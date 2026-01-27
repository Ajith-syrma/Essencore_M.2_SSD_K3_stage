using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K1_Stages
{

    public partial class Barcode_scan : Form
    {
        // Variables
        int[] valuesfromdb = { 0, 0, 0, 0, 0 }; // Len, Date, Year, sno, manfdata
        bool[] reverseorder = { false, false }; // Sno, ManfData
        string[] infosfromprint = { "", "", "" }; // FG, Sno, WO
        string[] infosfromboard = { "", "" }; // WO, RW
        string yearinfofromprint = "";
        string serialnotowrite = "";
        bool boardfail = false;
        string errordesc = "";
        int decimalvalueforpass = 80; // Hex { 50 }
        string[] filenamesofspd = { "", "" }; // Input , Output
        string[] nextidinfo = { "", "" }; // Next Stage ID, Name
        string[] reworkidinfo = { "24", "Rework" }; // Rework ID , Name

        bool boardonline = true;
        bool testaborted = false;
        int boardfailcount = 0;
        public Barcode_scan(string stage,string fg)
        {
            InitializeComponent();
            //lbl_result_Click
        }

        private void app_name_lbl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fill_Response_Data(string datarep)
        {
            txt_live_stat.AppendText(
                DateTime.Now.ToString("HH:mm:ss.fff") + " : " + datarep + Environment.NewLine
            );

            txt_live_stat.SelectionStart = txt_live_stat.TextLength;
            txt_live_stat.ScrollToCaret();
            base.Update();
            Application.DoEvents();
        }

    }
}
