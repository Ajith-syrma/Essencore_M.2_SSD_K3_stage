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
            lbl_sw_version = new Label();
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
            lbl_SN = new TextBox();
            label1 = new Label();
            txt_live_stat = new RichTextBox();
            lbl_result_Click = new Label();
            label3 = new Label();
            lbl_try = new Label();
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
            pictureBox1.Location = new Point(0, 2);
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
            app_name_lbl.Controls.Add(lbl_sw_version);
            app_name_lbl.Controls.Add(lbl_hdr_sw_version);
            app_name_lbl.Controls.Add(lbl_app_id);
            app_name_lbl.Controls.Add(lbl_hdr_app_id);
            app_name_lbl.Controls.Add(pictureBox3);
            app_name_lbl.Controls.Add(K1_STAGE);
            app_name_lbl.Controls.Add(pictureBox2);
            app_name_lbl.Location = new Point(0, 5);
            app_name_lbl.Name = "app_name_lbl";
            app_name_lbl.Size = new Size(961, 79);
            app_name_lbl.TabIndex = 19;
            // 
            // lbl_sw_version
            // 
            lbl_sw_version.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_sw_version.BackColor = Color.White;
            lbl_sw_version.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            lbl_sw_version.ForeColor = Color.Navy;
            lbl_sw_version.Location = new Point(683, 39);
            lbl_sw_version.Name = "lbl_sw_version";
            lbl_sw_version.Size = new Size(101, 39);
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
            lbl_hdr_sw_version.Location = new Point(683, 0);
            lbl_hdr_sw_version.Name = "lbl_hdr_sw_version";
            lbl_hdr_sw_version.Size = new Size(101, 39);
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
            lbl_app_id.Size = new Size(101, 39);
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
            lbl_hdr_app_id.Size = new Size(101, 39);
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
            //pictureBox2.Click += pictureBox2_Click;
            // 
            // lbl_qty
            // 
            lbl_qty.AutoSize = true;
            lbl_qty.BackColor = Color.Turquoise;
            lbl_qty.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_qty.ForeColor = Color.Navy;
            lbl_qty.Location = new Point(672, 96);
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
            label5.Location = new Point(628, 101);
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
            label2.Location = new Point(49, 150);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 27;
            label2.Text = "Work order";
            // 
            // lbl_SN
            // 
            lbl_SN.Location = new Point(190, 101);
            lbl_SN.Name = "lbl_SN";
            lbl_SN.Size = new Size(227, 31);
            lbl_SN.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(49, 101);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 25;
            label1.Text = "SCAN PCB";
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
            // lbl_result_Click
            // 
            lbl_result_Click.BackColor = SystemColors.ActiveCaption;
            lbl_result_Click.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_result_Click.Location = new Point(492, 176);
            lbl_result_Click.Name = "lbl_result_Click";
            lbl_result_Click.Size = new Size(456, 274);
            lbl_result_Click.TabIndex = 23;
            lbl_result_Click.Text = "TEST STATUS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.AppWorkspace;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(628, 136);
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
            lbl_try.Location = new Point(672, 136);
            lbl_try.Name = "lbl_try";
            lbl_try.Size = new Size(32, 28);
            lbl_try.TabIndex = 32;
            lbl_try.Text = "\"\"";
            // 
            // k_stage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(961, 462);
            Controls.Add(lbl_try);
            Controls.Add(label3);
            Controls.Add(lbl_qty);
            Controls.Add(label5);
            Controls.Add(lbl_wo);
            Controls.Add(label2);
            Controls.Add(lbl_SN);
            Controls.Add(label1);
            Controls.Add(txt_live_stat);
            Controls.Add(lbl_result_Click);
            Controls.Add(app_name_lbl);
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
        private Label lbl_sw_version;
        private Label lbl_hdr_sw_version;
        private Label lbl_qty;
        private Label label5;
        private Label lbl_wo;
        private Label label2;
        private TextBox lbl_SN;
        private Label label1;
        private RichTextBox txt_live_stat;
        private Label lbl_result_Click;
        private Label label3;
        private Label lbl_try;
    }
}
