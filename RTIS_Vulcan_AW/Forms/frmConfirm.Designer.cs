namespace RTIS_Vulcan_AW.Forms
{
    partial class frmConfirm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConf = new DevExpress.XtraEditors.LabelControl();
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblConf);
            this.panel1.Controls.Add(this.btnYes);
            this.panel1.Controls.Add(this.btnNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 352);
            this.panel1.TabIndex = 0;
            // 
            // lblConf
            // 
            this.lblConf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConf.Appearance.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConf.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblConf.Appearance.Options.UseFont = true;
            this.lblConf.Appearance.Options.UseForeColor = true;
            this.lblConf.Appearance.Options.UseTextOptions = true;
            this.lblConf.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblConf.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblConf.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblConf.Location = new System.Drawing.Point(12, 12);
            this.lblConf.Margin = new System.Windows.Forms.Padding(4);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(576, 249);
            this.lblConf.TabIndex = 62;
            this.lblConf.Text = "[Insert Message Here]";
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYes.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnYes.Appearance.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnYes.Appearance.Options.UseBackColor = true;
            this.btnYes.Appearance.Options.UseFont = true;
            this.btnYes.Appearance.Options.UseForeColor = true;
            this.btnYes.Location = new System.Drawing.Point(410, 269);
            this.btnYes.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnYes.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnYes.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnYes.Margin = new System.Windows.Forms.Padding(4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(178, 69);
            this.btnYes.TabIndex = 42;
            this.btnYes.Text = "Yes";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNo.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnNo.Appearance.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNo.Appearance.Options.UseBackColor = true;
            this.btnNo.Appearance.Options.UseFont = true;
            this.btnNo.Appearance.Options.UseForeColor = true;
            this.btnNo.Location = new System.Drawing.Point(12, 269);
            this.btnNo.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnNo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnNo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(178, 69);
            this.btnNo.TabIndex = 41;
            this.btnNo.Text = "No";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // frmConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 352);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfirm";
            this.Load += new System.EventHandler(this.frmConfirm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraEditors.LabelControl lblConf;
    }
}