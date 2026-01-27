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
    // LoadingForm.cs
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            this.ControlBox = false; // Optional: removes close button
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Size = new Size(800, 450);
            this.Text = "Please wait...";
            this.BackColor = Color.LightGreen;
            //Label label = new Label()
            //{
            //    Text = "Loading QC Testing Application Please wait...",
            //    AutoSize = true,
            //    Font = new Font("Segoe UI", 15),
            //    BackColor = Color.White,
            //    TextAlign = ContentAlignment.MiddleCenter,
            //    Location = new Point(150, 60),
            //    Size = new Size(500, 80),
            //    Dock = DockStyle.Fill

            //};
            Label label = new Label()
            {
                Text = "Loading QC Testing Application. Please wait...",
                AutoSize = false, 
                Font = new Font("Poppins", 24, FontStyle.Regular), 
                BackColor = Color.Yellow,
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill 
            };

            this.Controls.Add(label);

            // 🟢 Force to front on load
            this.Load += (s, e) =>
            {
                this.Activate();                // Bring to foreground
                this.BringToFront();            // Move above other windows
                this.TopMost = true;            // Force stay on top
                this.Focus();                   // Focus it
            };
        }
    }

}
