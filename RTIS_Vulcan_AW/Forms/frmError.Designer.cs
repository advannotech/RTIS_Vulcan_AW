namespace RTIS_Vulcan_AW.Forms
{
    partial class frmError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmError));
            this.tcError = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.meMsg = new DevExpress.XtraEditors.MemoEdit();
            this.lblTitel = new DevExpress.XtraEditors.LabelControl();
            this.lblMessage = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.meInfo = new DevExpress.XtraEditors.MemoEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.tcError.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meMsg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meInfo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tcError
            // 
            this.tcError.Controls.Add(this.tabPage1);
            this.tcError.Controls.Add(this.tabPage2);
            this.tcError.Location = new System.Drawing.Point(13, 13);
            this.tcError.Name = "tcError";
            this.tcError.SelectedIndex = 0;
            this.tcError.Size = new System.Drawing.Size(383, 236);
            this.tcError.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.meMsg);
            this.tabPage1.Controls.Add(this.lblTitel);
            this.tabPage1.Controls.Add(this.lblMessage);
            this.tabPage1.Controls.Add(this.pictureEdit1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(375, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Message";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // meMsg
            // 
            this.meMsg.Location = new System.Drawing.Point(5, 72);
            this.meMsg.Name = "meMsg";
            this.meMsg.Size = new System.Drawing.Size(365, 132);
            this.meMsg.TabIndex = 37;
            // 
            // lblTitel
            // 
            this.lblTitel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitel.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Appearance.Options.UseFont = true;
            this.lblTitel.Appearance.Options.UseForeColor = true;
            this.lblTitel.Appearance.Options.UseTextOptions = true;
            this.lblTitel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTitel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTitel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitel.Location = new System.Drawing.Point(74, 6);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(295, 60);
            this.lblTitel.TabIndex = 36;
            this.lblTitel.Text = "The following error has occured:";
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMessage.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Appearance.Options.UseFont = true;
            this.lblMessage.Appearance.Options.UseForeColor = true;
            this.lblMessage.Appearance.Options.UseTextOptions = true;
            this.lblMessage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblMessage.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblMessage.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMessage.Location = new System.Drawing.Point(6, 72);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(18, 12);
            this.lblMessage.TabIndex = 35;
            this.lblMessage.Text = "You will be logged in as a service user";
            this.lblMessage.Visible = false;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.Location = new System.Drawing.Point(6, 6);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(62, 60);
            this.pictureEdit1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.meInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(375, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // meInfo
            // 
            this.meInfo.Location = new System.Drawing.Point(4, 6);
            this.meInfo.Name = "meInfo";
            this.meInfo.Size = new System.Drawing.Size(365, 198);
            this.meInfo.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnOk.Appearance.Options.UseBackColor = true;
            this.btnOk.Location = new System.Drawing.Point(270, 256);
            this.btnOk.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnOk.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(126, 40);
            this.btnOk.TabIndex = 33;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 308);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tcError);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.Load += new System.EventHandler(this.frmError_Load);
            this.tcError.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meMsg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meInfo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcError;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraEditors.LabelControl lblTitel;
        private DevExpress.XtraEditors.LabelControl lblMessage;
        private DevExpress.XtraEditors.MemoEdit meInfo;
        private DevExpress.XtraEditors.MemoEdit meMsg;
        private DevExpress.XtraEditors.SimpleButton btnOk;
    }
}