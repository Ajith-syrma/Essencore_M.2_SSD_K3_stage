namespace K1_Stages
{
    partial class k_stage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(k_stage));
            lbl_filepathvalue = new Label();
            lbl_startinfo = new Label();
            pictureBox1 = new PictureBox();
            pic_status = new PictureBox();
            app_name_lbl = new Panel();
            lblemp_id = new Label();
            lbl_date = new Label();
            lbldate = new Label();
            lbl_id = new Label();
            lblappver = new Label();
            lbl_hdr_sw_version = new Label();
            lbl_app_id = new Label();
            lbl_hdr_app_id = new Label();
            pictureBox3 = new PictureBox();
            K1_STAGE = new Label();
            pictureBox2 = new PictureBox();
            lbl_qty = new Label();
            label5 = new Label();
            lbl_wo = new Label();
            label2 = new Label();
            txt_SN = new TextBox();
            txt_live_stat = new RichTextBox();
            lbl_result = new Label();
            label3 = new Label();
            lbl_try = new Label();
            lbl_pcbserial = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_status).BeginInit();
            app_name_lbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_filepathvalue
            // 
            lbl_filepathvalue.AutoSize = true;
            lbl_filepathvalue.BackColor = Color.FromArgb(255, 128, 128);
            lbl_filepathvalue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_filepathvalue.ForeColor = SystemColors.ActiveCaptionText;
            lbl_filepathvalue.Location = new Point(190, 292);
            lbl_filepathvalue.Name = "lbl_filepathvalue";
            lbl_filepathvalue.Size = new Size(0, 25);
            lbl_filepathvalue.TabIndex = 4;
            // 
            // lbl_startinfo
            // 
            lbl_startinfo.AutoSize = true;
            lbl_startinfo.BackColor = Color.FromArgb(255, 128, 128);
            lbl_startinfo.ForeColor = SystemColors.ActiveCaptionText;
            lbl_startinfo.ImageAlign = ContentAlignment.BottomLeft;
            lbl_startinfo.Location = new Point(299, 348);
            lbl_startinfo.Name = "lbl_startinfo";
            lbl_startinfo.Size = new Size(0, 25);
            lbl_startinfo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Essencore;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(968, 481);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pic_status
            // 
            pic_status.BackColor = Color.Transparent;
            pic_status.Image = (Image)resources.GetObject("pic_status.Image");
            pic_status.Location = new Point(885, 89);
            pic_status.Margin = new Padding(4, 5, 4, 5);
            pic_status.Name = "pic_status";
            pic_status.Size = new Size(63, 67);
            pic_status.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_status.TabIndex = 18;
            pic_status.TabStop = false;
            pic_status.Click += pic_status_Click;
            // 
            // app_name_lbl
            // 
            app_name_lbl.BackColor = Color.SteelBlue;
            app_name_lbl.Controls.Add(lblemp_id);
            app_name_lbl.Controls.Add(lbl_date);
            app_name_lbl.Controls.Add(lbldate);
            app_name_lbl.Controls.Add(lbl_id);
            app_name_lbl.Controls.Add(lblappver);
            app_name_lbl.Controls.Add(lbl_hdr_sw_version);
            app_name_lbl.Controls.Add(lbl_app_id);
            app_name_lbl.Controls.Add(lbl_hdr_app_id);
            app_name_lbl.Controls.Add(pictureBox3);
            app_name_lbl.Controls.Add(K1_STAGE);
            app_name_lbl.Controls.Add(pictureBox2);
            app_name_lbl.Location = new Point(0, 0);
            app_name_lbl.Name = "app_name_lbl";
            app_name_lbl.Size = new Size(961, 84);
            app_name_lbl.TabIndex = 19;
            // 
            // lblemp_id
            // 
            lblemp_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblemp_id.BackColor = Color.White;
            lblemp_id.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lblemp_id.ForeColor = Color.Navy;
            lblemp_id.Location = new Point(591, 40);
            lblemp_id.Name = "lblemp_id";
            lblemp_id.Size = new Size(101, 44);
            lblemp_id.TabIndex = 11;
            lblemp_id.Text = "abc";
            lblemp_id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_date
            // 
            lbl_date.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_date.BackColor = Color.White;
            lbl_date.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lbl_date.ForeColor = Color.Navy;
            lbl_date.Location = new Point(698, 38);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(101, 44);
            lbl_date.TabIndex = 10;
            lbl_date.Text = "abc";
            lbl_date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbldate
            // 
            lbldate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbldate.BackColor = Color.Navy;
            lbldate.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lbldate.ForeColor = Color.White;
            lbldate.Location = new Point(698, -1);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(101, 44);
            lbldate.TabIndex = 9;
            lbldate.Text = "Date";
            lbldate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_id
            // 
            lbl_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_id.BackColor = Color.Navy;
            lbl_id.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lbl_id.ForeColor = Color.White;
            lbl_id.Location = new Point(588, -2);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(101, 44);
            lbl_id.TabIndex = 7;
            lbl_id.Text = "Emp ID";
            lbl_id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblappver
            // 
            lblappver.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblappver.BackColor = Color.White;
            lblappver.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lblappver.ForeColor = Color.Navy;
            lblappver.Location = new Point(287, 39);
            lblappver.Name = "lblappver";
            lblappver.Size = new Size(101, 44);
            lblappver.TabIndex = 6;
            lblappver.Text = "abc";
            lblappver.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_hdr_sw_version
            // 
            lbl_hdr_sw_version.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_hdr_sw_version.BackColor = Color.Navy;
            lbl_hdr_sw_version.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lbl_hdr_sw_version.ForeColor = Color.White;
            lbl_hdr_sw_version.Location = new Point(287, 0);
            lbl_hdr_sw_version.Name = "lbl_hdr_sw_version";
            lbl_hdr_sw_version.Size = new Size(101, 44);
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
            lbl_app_id.Location = new Point(177, 38);
            lbl_app_id.Name = "lbl_app_id";
            lbl_app_id.Size = new Size(101, 44);
            lbl_app_id.TabIndex = 4;
            lbl_app_id.Text = "abc";
            lbl_app_id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_hdr_app_id
            // 
            lbl_hdr_app_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_hdr_app_id.BackColor = Color.Navy;
            lbl_hdr_app_id.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lbl_hdr_app_id.ForeColor = Color.White;
            lbl_hdr_app_id.Location = new Point(177, -1);
            lbl_hdr_app_id.Name = "lbl_hdr_app_id";
            lbl_hdr_app_id.Size = new Size(101, 44);
            lbl_hdr_app_id.TabIndex = 3;
            lbl_hdr_app_id.Text = "App ID";
            lbl_hdr_app_id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(805, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(153, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // K1_STAGE
            // 
            K1_STAGE.AutoSize = true;
            K1_STAGE.Font = new Font("Bahnschrift Condensed", 27.75F, FontStyle.Bold);
            K1_STAGE.ForeColor = Color.White;
            K1_STAGE.Location = new Point(397, -1);
            K1_STAGE.Name = "K1_STAGE";
            K1_STAGE.Size = new Size(196, 68);
            K1_STAGE.TabIndex = 1;
            K1_STAGE.Text = "K1_STAGE";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // lbl_qty
            // 
            lbl_qty.AutoSize = true;
            lbl_qty.BackColor = Color.Turquoise;
            lbl_qty.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_qty.ForeColor = Color.Navy;
            lbl_qty.Location = new Point(805, 94);
            lbl_qty.Name = "lbl_qty";
            lbl_qty.Size = new Size(46, 28);
            lbl_qty.TabIndex = 30;
            lbl_qty.Text = "Qty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.AppWorkspace;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(746, 101);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 29;
            label5.Text = "Qty";
            // 
            // lbl_wo
            // 
            lbl_wo.AutoSize = true;
            lbl_wo.BackColor = Color.Turquoise;
            lbl_wo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_wo.ForeColor = Color.Navy;
            lbl_wo.Location = new Point(190, 145);
            lbl_wo.Name = "lbl_wo";
            lbl_wo.Size = new Size(119, 28);
            lbl_wo.TabIndex = 28;
            lbl_wo.Text = "Work order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 27;
            label2.Text = "Work order";
            // 
            // txt_SN
            // 
            txt_SN.Location = new Point(190, 101);
            txt_SN.Name = "txt_SN";
            txt_SN.Size = new Size(227, 31);
            txt_SN.TabIndex = 26;
            txt_SN.KeyDown += Txt_SN_KeyDown;
            // 
            // txt_live_stat
            // 
            txt_live_stat.BackColor = SystemColors.InfoText;
            txt_live_stat.ForeColor = SystemColors.Window;
            txt_live_stat.Location = new Point(3, 176);
            txt_live_stat.Name = "txt_live_stat";
            txt_live_stat.Size = new Size(483, 274);
            txt_live_stat.TabIndex = 24;
            txt_live_stat.Text = "";
            // 
            // lbl_result
            // 
            lbl_result.BackColor = SystemColors.ActiveCaption;
            lbl_result.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_result.Location = new Point(493, 179);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(456, 274);
            lbl_result.TabIndex = 23;
            lbl_result.Text = "TEST STATUS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.AppWorkspace;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(749, 143);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 31;
            label3.Text = "Try";
            // 
            // lbl_try
            // 
            lbl_try.AutoSize = true;
            lbl_try.BackColor = Color.Turquoise;
            lbl_try.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_try.ForeColor = Color.Navy;
            lbl_try.Location = new Point(819, 136);
            lbl_try.Name = "lbl_try";
            lbl_try.Size = new Size(32, 28);
            lbl_try.TabIndex = 32;
            lbl_try.Text = "\"\"";
            // 
            // lbl_pcbserial
            // 
            lbl_pcbserial.AutoSize = true;
            lbl_pcbserial.BackColor = SystemColors.AppWorkspace;
            lbl_pcbserial.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_pcbserial.ForeColor = Color.Navy;
            lbl_pcbserial.Location = new Point(12, 106);
            lbl_pcbserial.Name = "lbl_pcbserial";
            lbl_pcbserial.Size = new Size(146, 23);
            lbl_pcbserial.TabIndex = 33;
            lbl_pcbserial.Text = "SCAN Serial No";
            // 
            // k_stage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(961, 462);
            Controls.Add(app_name_lbl);
            Controls.Add(lbl_pcbserial);
            Controls.Add(lbl_try);
            Controls.Add(label3);
            Controls.Add(lbl_qty);
            Controls.Add(label5);
            Controls.Add(lbl_wo);
            Controls.Add(label2);
            Controls.Add(txt_SN);
            Controls.Add(txt_live_stat);
            Controls.Add(lbl_result);
            Controls.Add(pic_status);
            Controls.Add(lbl_startinfo);
            Controls.Add(lbl_filepathvalue);
            Controls.Add(pictureBox1);
            Name = "k_stage";
            Text = "K1 STAGE";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_status).EndInit();
            app_name_lbl.ResumeLayout(false);
            app_name_lbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        //private void Txt_SN_KeyDown(object sender, KeyEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label lbl_filepathvalue;
        private Label lbl_startinfo;
        private PictureBox pictureBox1;
        private PictureBox pic_status;
        private Panel app_name_lbl;
        private PictureBox pictureBox2;
        private Label K1_STAGE;
        private Label lbl_hdr_app_id;
        private PictureBox pictureBox3;
        private Label lbl_app_id;
        private Label lblappver;
        private Label lbl_hdr_sw_version;
        private Label lbl_qty;
        private Label label5;
        private Label lbl_wo;
        private Label label2;
        private TextBox txt_SN;
        private Label label1;
        private RichTextBox txt_live_stat;
        private Label lbl_result;
        private Label label3;
        private Label lbl_try;
        private Label lbl_pcbserial;
        private Label lblemp_id;
        private Label lbl_date;
        private Label lbldate;
        //private Label lblemp_id;
        private Label lbl_id;
        //private Label lblemp_id;
    }
}
