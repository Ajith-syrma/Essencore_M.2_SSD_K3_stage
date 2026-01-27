namespace K1_Stages
{
    partial class Barcodescan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcodescan));
            app_name_lbl = new Panel();
            lbl_sw_version = new Label();
            lbl_hdr_sw_version = new Label();
            lbl_app_id = new Label();
            lbl_hdr_app_id = new Label();
            pictureBox3 = new PictureBox();
            K1_STAGE = new Label();
            pictureBox2 = new PictureBox();
            app_name_lbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // app_name_lbl
            // 
            app_name_lbl.BackColor = Color.SteelBlue;
            app_name_lbl.Controls.Add(lbl_sw_version);
            app_name_lbl.Controls.Add(lbl_app_id);
            app_name_lbl.Controls.Add(lbl_hdr_sw_version);
            app_name_lbl.Controls.Add(lbl_hdr_app_id);
            app_name_lbl.Controls.Add(pictureBox3);
            app_name_lbl.Controls.Add(K1_STAGE);
            app_name_lbl.Controls.Add(pictureBox2);
            app_name_lbl.Location = new Point(2, 2);
            app_name_lbl.Margin = new Padding(2);
            app_name_lbl.Name = "app_name_lbl";
            app_name_lbl.Size = new Size(802, 69);
            app_name_lbl.TabIndex = 20;
            // 
            // lbl_sw_version
            // 
            lbl_sw_version.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_sw_version.BackColor = Color.White;
            lbl_sw_version.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lbl_sw_version.ForeColor = Color.Navy;
            lbl_sw_version.Location = new Point(603, 33);
            lbl_sw_version.Margin = new Padding(2, 0, 2, 0);
            lbl_sw_version.Name = "lbl_sw_version";
            lbl_sw_version.Size = new Size(59, 36);
            lbl_sw_version.TabIndex = 6;
            lbl_sw_version.Text = "abc";
            lbl_sw_version.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_hdr_sw_version
            // 
            lbl_hdr_sw_version.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_hdr_sw_version.BackColor = Color.Navy;
            lbl_hdr_sw_version.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lbl_hdr_sw_version.ForeColor = Color.White;
            lbl_hdr_sw_version.Location = new Point(603, 0);
            lbl_hdr_sw_version.Margin = new Padding(2, 0, 2, 0);
            lbl_hdr_sw_version.Name = "lbl_hdr_sw_version";
            lbl_hdr_sw_version.Size = new Size(59, 45);
            lbl_hdr_sw_version.TabIndex = 5;
            lbl_hdr_sw_version.Text = "Version";
            lbl_hdr_sw_version.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_app_id
            // 
            lbl_app_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_app_id.BackColor = Color.White;
            lbl_app_id.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lbl_app_id.ForeColor = Color.Navy;
            lbl_app_id.Location = new Point(113, 33);
            lbl_app_id.Margin = new Padding(2, 0, 2, 0);
            lbl_app_id.Name = "lbl_app_id";
            lbl_app_id.Size = new Size(61, 36);
            lbl_app_id.TabIndex = 4;
            lbl_app_id.Text = "abc";
            lbl_app_id.TextAlign = ContentAlignment.MiddleCenter;
            lbl_app_id.Click += lbl_app_id_Click;
            // 
            // lbl_hdr_app_id
            // 
            lbl_hdr_app_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_hdr_app_id.BackColor = Color.Navy;
            lbl_hdr_app_id.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lbl_hdr_app_id.ForeColor = Color.White;
            lbl_hdr_app_id.Location = new Point(113, 0);
            lbl_hdr_app_id.Margin = new Padding(2, 0, 2, 0);
            lbl_hdr_app_id.Name = "lbl_hdr_app_id";
            lbl_hdr_app_id.Size = new Size(61, 45);
            lbl_hdr_app_id.TabIndex = 3;
            lbl_hdr_app_id.Text = "App ID";
            lbl_hdr_app_id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(683, 0);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // K1_STAGE
            // 
            K1_STAGE.AutoSize = true;
            K1_STAGE.Font = new Font("Bahnschrift Condensed", 27.75F, FontStyle.Bold);
            K1_STAGE.ForeColor = Color.White;
            K1_STAGE.Location = new Point(307, 7);
            K1_STAGE.Margin = new Padding(2, 0, 2, 0);
            K1_STAGE.Name = "K1_STAGE";
            K1_STAGE.Size = new Size(131, 45);
            K1_STAGE.TabIndex = 1;
            K1_STAGE.Text = "K1_STAGE";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Barcodescan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(app_name_lbl);
            Name = "Barcodescan";
            Text = "K1-STAGE";
            app_name_lbl.ResumeLayout(false);
            app_name_lbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel app_name_lbl;
        private Label lbl_sw_version;
        private Label lbl_hdr_sw_version;
        private Label lbl_hdr_app_id;
        private PictureBox pictureBox3;
        private Label K1_STAGE;
        private PictureBox pictureBox2;
        private Label lbl_app_id;
    }
}