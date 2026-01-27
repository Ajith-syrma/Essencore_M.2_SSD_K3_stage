using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K1_Stages
{
    public partial class K1_load : Form
    {
        // SSDMP.txt monitoring
        DbConnection dbConnection = new DbConnection();
        private readonly string ssdmpFilePathG3 = ConfigurationManager.AppSettings["File_Path1"];
        private readonly string ssdmpFilePathG4 = ConfigurationManager.AppSettings["File_Path2"];
        private readonly string Logsbkppath = ConfigurationManager.AppSettings["BackupfilePath"];
        public string G3appPath = ConfigurationManager.AppSettings["Executable_Path1"];
        public string G4appPath = ConfigurationManager.AppSettings["Executable_Path2"];

        public string fileNameg4 = DateTime.Now.ToString("yyyyMMdd");


        public string ssdmpFilePath = string.Empty;
        public string ssdmpG3 = string.Empty;
        public string ssdmpG4 = string.Empty;
        private DateTime lastSsdmpReadTime = DateTime.MinValue;
        private DateTime _lastFileWriteTime = DateTime.MinValue;

        private string lastHash;
        public string emp_id = "";
        public string emp_name = "";
        public string Gentype = "";
        private string Filename;
        public string filepath = string.Empty;

        private bool isHandlingChange = false;
        bool suppressCapacityEvent = false;



        public K1_load()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            lbl_filepathvalue.Enabled = false;
            lbl_startinfo.Enabled = false;
            cmb_stage.Text = "K1";
            cmb_stage.Visible = false;
            this.Shown += K1_load_Shown; // Attach Shown event

            Filevalidation();
            fg_load();

        }

        private void K1_load_Shown(object sender, EventArgs e)
        {
            this.Shown -= K1_load_Shown;
            bool valid = Filevalidation();
            if (!valid)
            {
                // Exit the application safely
                Application.Exit();
                return; // stop further execution
            }

            fg_load(); // only run if validation passed
        }

        private bool Filevalidation()
        {
            try
            {
                ssdmpG3 = ($"Gen3X3_{System.DateTime.Now.ToString("dd-MM-yyyy_HH_mm_ss")}.log");
                ssdmpG4 = Path.Combine(ssdmpFilePathG4, ($"{fileNameg4}.txt"));

                if (!Directory.Exists(Logsbkppath))
                {
                    System.IO.Directory.CreateDirectory(Logsbkppath);
                }

                if (!File.Exists(G3appPath) || !File.Exists(G4appPath))
                {
                    MessageBox.Show("Please check the Gen3X3 OR Gen4X4 Application path", "Application File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // signal failure
                }

                if (File.Exists(ssdmpFilePathG3))
                {
                    File.Copy(ssdmpFilePathG3, Logsbkppath + "\\" + ssdmpG3);
                    Thread.Sleep(1000);
                    File.WriteAllText(ssdmpFilePathG3, string.Empty);
                }
                if (File.Exists(ssdmpG4))
                {
                    File.Copy(ssdmpG4, Logsbkppath + "\\" + "Gen4X4_" + System.DateTime.Now.ToString("dd-MM-yyyy_HH_mm_ss") + ".txt");
                    Thread.Sleep(1000);
                    File.WriteAllText(ssdmpG4, string.Empty);
                }
                return true; // validation passed


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // validation passed
            }

        }

        private void fg_load()
        {
            cmb_stage.Enabled = false;
            try
            {

                string stageval = "K1";
                var listNos = dbConnection.getcapacity(stageval);
                suppressCapacityEvent = true;
                if (listNos != null && listNos.Count > 0)
                {

                    cmb_capacity.DataSource = listNos;

                }
                else
                {
                    cmb_capacity.DataSource = null;
                }
                suppressCapacityEvent = false;



            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString()); }

        }

        private void cmbcapacity_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (suppressCapacityEvent) return;
            cmb_capacity.Enabled = false;
            string stage = cmb_stage.Text;
            string capacity = cmb_capacity.Text;
            filepath = dbConnection.GetFilePathdetail(cmb_stage.Text, cmb_capacity.Text);
            if (!string.IsNullOrEmpty(filepath) || filepath != "1")
            {

                lbl_filepathvalue.Enabled = false;
                lbl_filepathvalue.Visible = true;
                lbl_filepathvalue.Text = $"File Name :{filepath}";
                
                lbl_startinfo.Enabled = false;
                lbl_startinfo.Visible = true;
                lbl_startinfo.Text = "Please validate and Press the start Button ";
            }
            else
            {
                MessageBox.Show($"Filepath not available for {capacity} at {stage}");
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string stage = "K1";
            string fg = cmb_capacity.Text;
            string emp_id = txt_empid.Text;
            string emp_name = txt_emp_name.Text;
            

            if (stage != "select stage" && !string.IsNullOrEmpty(fg) && (!string.IsNullOrEmpty(emp_id)) && !string.IsNullOrEmpty(emp_name))
            {

                k_stage k1form = new k_stage(stage, fg, emp_id, emp_name, filepath);
                k1form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please provide all the inputs");
                cmb_capacity.Enabled = true;
                cmb_stage.Enabled = true;
            }
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
