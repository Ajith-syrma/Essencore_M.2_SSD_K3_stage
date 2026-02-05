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
        //    private readonly string ssdmpFilePathG3 = ConfigurationManager.AppSettings["File_Path1"];
        //    private readonly string ssdmpFilePathG4 = ConfigurationManager.AppSettings["File_Path2"];
        private string ssdmpFilePathG3;
        private string ssdmpFilePathG4;
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
        private string App_Name;
        private string App_Path;
        private string App_LogPath;
        public string filepath = string.Empty;

        private bool isHandlingChange = false;
        bool suppressCapacityEvent = false;



        public K1_load()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            lbl_filepathvalue.Enabled = false;
            lbl_startinfo.Enabled = false;
            //cmb_stage.Text = "K3";
            cmb_stage.Visible = false;

            //this.Shown += K1_load_Shown; // Attach Shown event

            //Filevalidation();
            //fg_load();

        }

        //private void K1_load_Shown(object sender, EventArgs e)
        //{
        //    this.Shown -= K1_load_Shown;
        //    bool valid = Filevalidation();
        //    if (!valid)
        //    {
        //        // Exit the application safely
        //        Application.Exit();
        //        return; // stop further execution
        //    }

        //     // only run if validation passed
        //}

        private bool Filevalidation()
        {
            string fg_name = cmb_capacity.Text;
            string stage_name = lbl_stage_load.Text;


            var lstfgappdetails = dbConnection.get_app_Name(fg_name, stage_name); // Load file details from DB

            if (lstfgappdetails != null)
            {
                if (lstfgappdetails.Count > 0)
                {
                    foreach (var appfg in lstfgappdetails)
                    {
                        App_Name = appfg.app_name;
                        App_Path = appfg.app_path;
                        App_LogPath = appfg.app_logpath;
                        Gentype = appfg.fg_model;

                    }
                }

                try
                {
                    if (App_Name == "SSDMP.exe")
                    {
                        ssdmpFilePathG3 = App_LogPath;

                        ssdmpG3 = ($"Gen3X3_{System.DateTime.Now.ToString("dd-MM-yyyy_HH_mm_ss")}.log");
                        if (!Directory.Exists(Logsbkppath))
                        {
                            System.IO.Directory.CreateDirectory(Logsbkppath);
                        }

                        if (File.Exists(ssdmpFilePathG3))
                        {
                            File.Copy(ssdmpFilePathG3, Logsbkppath + "\\" + ssdmpG3);
                            Thread.Sleep(1000);
                            File.WriteAllText(ssdmpFilePathG3, string.Empty);
                        }

                        if (!File.Exists(App_Path))
                        {
                            MessageBox.Show("Please check the Gen3X3  Application path", "Application File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false; // signal failure
                        }

                        return true; // validation passed
                    }
                    else if (App_Name == "SM2268XT2_MPTool.exe" || App_Name == "MPTools.exe")
                    {
                        ssdmpFilePathG4 = App_LogPath;
                        ssdmpG4 = Path.Combine(ssdmpFilePathG4, ($"{fileNameg4}.txt"));
                        if (!Directory.Exists(Logsbkppath))
                        {
                            System.IO.Directory.CreateDirectory(Logsbkppath);
                        }
                        if (File.Exists(ssdmpG4))
                        {
                            File.Copy(ssdmpG4, Logsbkppath + "\\" + "Gen4X4_" + System.DateTime.Now.ToString("dd-MM-yyyy_HH_mm_ss") + ".txt");
                            Thread.Sleep(1000);
                            File.WriteAllText(ssdmpG4, string.Empty);
                        }
                        if (!File.Exists(App_Path))
                        {
                            MessageBox.Show("Please check the Gen4X4 Application path", "Application File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false; // signal failure
                        }

                        return true; // validation passed
                    }
                    else
                    {
                        MessageBox.Show("Please check the Gen Type for the Selected FG", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // signal failure
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // validation passed
                }
            }
            else
            {
                MessageBox.Show("No Application Name available for the Selected FG", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // signal failure 

            }
        }

        //private void fg_load()
        //{
        //    cmb_stage.Enabled = false;
        //    try
        //    {

        //        string stageval = "K1";
        //        var listNos = dbConnection.getcapacity(stageval);
        //        suppressCapacityEvent = true;
        //        if (listNos != null && listNos.Count > 0)
        //        {

        //            cmb_capacity.DataSource = listNos;

        //        }
        //        else
        //        {
        //            cmb_capacity.DataSource = null;
        //        }
        //        suppressCapacityEvent = false;



        //    }
        //    catch (Exception ex)
        //    { MessageBox.Show(ex.Message.ToString()); }

        //}

        private void cmb_prdctModel_SelectedValueChanged(object sender, EventArgs e)
        {

            cmb_prdctModel.Enabled = false;
            try
            {

                string stageval = lbl_stage_load.Text;
                var listNos = dbConnection.getcapacity(stageval, cmb_prdctModel.Text);
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
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cmbcapacity_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (suppressCapacityEvent) return;
            cmb_capacity.Enabled = false;
            string stage = cmb_stage.Text;
            string capacity = cmb_capacity.Text;
            filepath = dbConnection.GetFilePathdetail(lbl_stage_load.Text, cmb_capacity.Text);
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

            string stage = lbl_stage_load.Text;
            string Prduct_model = cmb_prdctModel.Text;
            string fg = cmb_capacity.Text;
            string emp_id = txt_empid.Text;
            string emp_name = txt_emp_name.Text;


            if (stage != "select stage" && Prduct_model != "Select model" && !string.IsNullOrEmpty(fg) && (!string.IsNullOrEmpty(emp_id)) && !string.IsNullOrEmpty(emp_name))
            {
                bool valid = Filevalidation();
                if (valid)
                {

                    k_stage k1form = new k_stage(stage, Prduct_model, App_Name, App_Path, fg, emp_id, emp_name, filepath, App_LogPath);
                    k1form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("File Validation Failed. Please check the file paths and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
