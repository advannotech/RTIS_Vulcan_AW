namespace RTIS_Vulcan_AW.Forms
{
    partial class frmMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMsg));
            this.xtcMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtpError = new DevExpress.XtraTab.XtraTabPage();
            this.meError = new DevExpress.XtraEditors.MemoEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.lblError = new DevExpress.XtraEditors.LabelControl();
            this.xtpSuccess = new DevExpress.XtraTab.XtraTabPage();
            this.btnSucOk = new DevExpress.XtraEditors.SimpleButton();
            this.lblSuc = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.xtpQuestion = new DevExpress.XtraTab.XtraTabPage();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.lblQuest = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.xtpVir = new DevExpress.XtraTab.XtraTabPage();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.btnVirOk = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtpInfo = new DevExpress.XtraTab.XtraTabPage();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.lblInfoHeader = new DevExpress.XtraEditors.LabelControl();
            this.btnInfoOK = new DevExpress.XtraEditors.SimpleButton();
            this.lblInfoMsg = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtcMain)).BeginInit();
            this.xtcMain.SuspendLayout();
            this.xtpError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meError.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.xtpSuccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.xtpQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.xtpVir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            this.xtpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtcMain
            // 
            this.xtcMain.Appearance.BackColor = System.Drawing.Color.White;
            this.xtcMain.Appearance.Options.UseBackColor = true;
            this.xtcMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtcMain.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcMain.Location = new System.Drawing.Point(0, 0);
            this.xtcMain.Margin = new System.Windows.Forms.Padding(4);
            this.xtcMain.Name = "xtcMain";
            this.xtcMain.PaintStyleName = "Standard";
            this.xtcMain.SelectedTabPage = this.xtpError;
            this.xtcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtcMain.Size = new System.Drawing.Size(513, 289);
            this.xtcMain.TabIndex = 0;
            this.xtcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpError,
            this.xtpSuccess,
            this.xtpQuestion,
            this.xtpVir,
            this.xtpInfo});
            // 
            // xtpError
            // 
            this.xtpError.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtpError.Appearance.PageClient.Options.UseBackColor = true;
            this.xtpError.Controls.Add(this.meError);
            this.xtpError.Controls.Add(this.pictureEdit1);
            this.xtpError.Controls.Add(this.btnOk);
            this.xtpError.Controls.Add(this.lblError);
            this.xtpError.Margin = new System.Windows.Forms.Padding(4);
            this.xtpError.Name = "xtpError";
            this.xtpError.Size = new System.Drawing.Size(513, 266);
            this.xtpError.Text = "xtpError";
            // 
            // meError
            // 
            this.meError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meError.Location = new System.Drawing.Point(36, 58);
            this.meError.Margin = new System.Windows.Forms.Padding(4);
            this.meError.Name = "meError";
            this.meError.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meError.Properties.Appearance.Options.UseFont = true;
            this.meError.Size = new System.Drawing.Size(440, 135);
            this.meError.TabIndex = 39;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::RTIS_Vulcan_AW.Properties.Resources.redX;
            this.pictureEdit1.Location = new System.Drawing.Point(36, 4);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(51, 47);
            this.pictureEdit1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnOk.Appearance.Options.UseBackColor = true;
            this.btnOk.Location = new System.Drawing.Point(308, 201);
            this.btnOk.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnOk.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(168, 49);
            this.btnOk.TabIndex = 38;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblError.Appearance.Options.UseFont = true;
            this.lblError.Appearance.Options.UseForeColor = true;
            this.lblError.Appearance.Options.UseTextOptions = true;
            this.lblError.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblError.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblError.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblError.Location = new System.Drawing.Point(96, 4);
            this.lblError.Margin = new System.Windows.Forms.Padding(4);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(380, 47);
            this.lblError.TabIndex = 37;
            this.lblError.Text = "fsdvdsdvsdvsdvvsdsvsvdsdvsdvsdvsdvsdvsd";
            // 
            // xtpSuccess
            // 
            this.xtpSuccess.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtpSuccess.Appearance.PageClient.Options.UseBackColor = true;
            this.xtpSuccess.Controls.Add(this.btnSucOk);
            this.xtpSuccess.Controls.Add(this.lblSuc);
            this.xtpSuccess.Controls.Add(this.pictureEdit2);
            this.xtpSuccess.Margin = new System.Windows.Forms.Padding(4);
            this.xtpSuccess.Name = "xtpSuccess";
            this.xtpSuccess.Size = new System.Drawing.Size(513, 266);
            this.xtpSuccess.Text = "xtraTabPage2";
            // 
            // btnSucOk
            // 
            this.btnSucOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSucOk.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnSucOk.Appearance.Options.UseBackColor = true;
            this.btnSucOk.Location = new System.Drawing.Point(168, 169);
            this.btnSucOk.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnSucOk.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSucOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnSucOk.Name = "btnSucOk";
            this.btnSucOk.Size = new System.Drawing.Size(168, 49);
            this.btnSucOk.TabIndex = 41;
            this.btnSucOk.Text = "OK";
            this.btnSucOk.Click += new System.EventHandler(this.btnSucOk_Click);
            // 
            // lblSuc
            // 
            this.lblSuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuc.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuc.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSuc.Appearance.Options.UseFont = true;
            this.lblSuc.Appearance.Options.UseForeColor = true;
            this.lblSuc.Appearance.Options.UseTextOptions = true;
            this.lblSuc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSuc.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblSuc.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblSuc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSuc.Location = new System.Drawing.Point(4, 80);
            this.lblSuc.Margin = new System.Windows.Forms.Padding(4);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(505, 81);
            this.lblSuc.TabIndex = 40;
            this.lblSuc.Text = "The following error has occured:";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = global::RTIS_Vulcan_AW.Properties.Resources.found;
            this.pictureEdit2.Location = new System.Drawing.Point(209, 10);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit2.Size = new System.Drawing.Size(68, 63);
            this.pictureEdit2.TabIndex = 39;
            // 
            // xtpQuestion
            // 
            this.xtpQuestion.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtpQuestion.Appearance.PageClient.Options.UseBackColor = true;
            this.xtpQuestion.Controls.Add(this.btnNo);
            this.xtpQuestion.Controls.Add(this.btnYes);
            this.xtpQuestion.Controls.Add(this.lblQuest);
            this.xtpQuestion.Controls.Add(this.pictureEdit3);
            this.xtpQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.xtpQuestion.Name = "xtpQuestion";
            this.xtpQuestion.Size = new System.Drawing.Size(513, 266);
            this.xtpQuestion.Text = "xtraTabPage1";
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNo.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnNo.Appearance.Options.UseBackColor = true;
            this.btnNo.Location = new System.Drawing.Point(329, 208);
            this.btnNo.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnNo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(168, 49);
            this.btnNo.TabIndex = 44;
            this.btnNo.Text = "No";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnYes.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnYes.Appearance.Options.UseBackColor = true;
            this.btnYes.Location = new System.Drawing.Point(16, 208);
            this.btnYes.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnYes.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnYes.Margin = new System.Windows.Forms.Padding(4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(168, 49);
            this.btnYes.TabIndex = 43;
            this.btnYes.Text = "Yes";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblQuest
            // 
            this.lblQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuest.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuest.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblQuest.Appearance.Options.UseFont = true;
            this.lblQuest.Appearance.Options.UseForeColor = true;
            this.lblQuest.Appearance.Options.UseTextOptions = true;
            this.lblQuest.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblQuest.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblQuest.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblQuest.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblQuest.Location = new System.Drawing.Point(4, 75);
            this.lblQuest.Margin = new System.Windows.Forms.Padding(4);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(505, 126);
            this.lblQuest.TabIndex = 42;
            this.lblQuest.Text = "The following error has occured:";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureEdit3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(229, 16);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit3.Size = new System.Drawing.Size(68, 63);
            this.pictureEdit3.TabIndex = 0;
            // 
            // xtpVir
            // 
            this.xtpVir.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtpVir.Appearance.PageClient.Options.UseBackColor = true;
            this.xtpVir.Controls.Add(this.pictureEdit4);
            this.xtpVir.Controls.Add(this.btnVirOk);
            this.xtpVir.Controls.Add(this.labelControl1);
            this.xtpVir.Margin = new System.Windows.Forms.Padding(4);
            this.xtpVir.Name = "xtpVir";
            this.xtpVir.Size = new System.Drawing.Size(513, 266);
            this.xtpVir.Text = "xtraTabPage1";
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureEdit4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(229, 16);
            this.pictureEdit4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit4.Size = new System.Drawing.Size(68, 63);
            this.pictureEdit4.TabIndex = 40;
            // 
            // btnVirOk
            // 
            this.btnVirOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVirOk.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnVirOk.Appearance.Options.UseBackColor = true;
            this.btnVirOk.Location = new System.Drawing.Point(171, 201);
            this.btnVirOk.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnVirOk.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnVirOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnVirOk.Name = "btnVirOk";
            this.btnVirOk.Size = new System.Drawing.Size(168, 49);
            this.btnVirOk.TabIndex = 39;
            this.btnVirOk.Text = "OK";
            this.btnVirOk.Click += new System.EventHandler(this.btnVirOk_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(69, 97);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(380, 84);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "Initial use detected\r\n\r\nYou will be logged in as a Service User";
            // 
            // xtpInfo
            // 
            this.xtpInfo.Appearance.PageClient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xtpInfo.Appearance.PageClient.Options.UseBackColor = true;
            this.xtpInfo.Controls.Add(this.pictureEdit5);
            this.xtpInfo.Controls.Add(this.lblInfoHeader);
            this.xtpInfo.Controls.Add(this.btnInfoOK);
            this.xtpInfo.Controls.Add(this.lblInfoMsg);
            this.xtpInfo.Margin = new System.Windows.Forms.Padding(4);
            this.xtpInfo.Name = "xtpInfo";
            this.xtpInfo.Size = new System.Drawing.Size(513, 266);
            this.xtpInfo.Text = "Info";
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureEdit5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(229, 16);
            this.pictureEdit5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit5.Size = new System.Drawing.Size(68, 63);
            this.pictureEdit5.TabIndex = 45;
            // 
            // lblInfoHeader
            // 
            this.lblInfoHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoHeader.Appearance.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoHeader.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblInfoHeader.Appearance.Options.UseFont = true;
            this.lblInfoHeader.Appearance.Options.UseForeColor = true;
            this.lblInfoHeader.Appearance.Options.UseTextOptions = true;
            this.lblInfoHeader.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblInfoHeader.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblInfoHeader.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblInfoHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblInfoHeader.Location = new System.Drawing.Point(67, 91);
            this.lblInfoHeader.Margin = new System.Windows.Forms.Padding(4);
            this.lblInfoHeader.Name = "lblInfoHeader";
            this.lblInfoHeader.Size = new System.Drawing.Size(380, 25);
            this.lblInfoHeader.TabIndex = 44;
            this.lblInfoHeader.Text = "info header";
            // 
            // btnInfoOK
            // 
            this.btnInfoOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInfoOK.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnInfoOK.Appearance.Options.UseBackColor = true;
            this.btnInfoOK.Location = new System.Drawing.Point(168, 194);
            this.btnInfoOK.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnInfoOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnInfoOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfoOK.Name = "btnInfoOK";
            this.btnInfoOK.Size = new System.Drawing.Size(168, 49);
            this.btnInfoOK.TabIndex = 42;
            this.btnInfoOK.Text = "OK";
            this.btnInfoOK.Click += new System.EventHandler(this.btnInfoOK_Click);
            // 
            // lblInfoMsg
            // 
            this.lblInfoMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoMsg.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMsg.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblInfoMsg.Appearance.Options.UseFont = true;
            this.lblInfoMsg.Appearance.Options.UseForeColor = true;
            this.lblInfoMsg.Appearance.Options.UseTextOptions = true;
            this.lblInfoMsg.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblInfoMsg.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblInfoMsg.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblInfoMsg.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblInfoMsg.Location = new System.Drawing.Point(67, 123);
            this.lblInfoMsg.Margin = new System.Windows.Forms.Padding(4);
            this.lblInfoMsg.Name = "lblInfoMsg";
            this.lblInfoMsg.Size = new System.Drawing.Size(380, 64);
            this.lblInfoMsg.TabIndex = 41;
            this.lblInfoMsg.Text = "info message";
            // 
            // frmMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 289);
            this.Controls.Add(this.xtcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMsg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RTIS Vulcan - Notification";
            this.Load += new System.EventHandler(this.frmMsg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtcMain)).EndInit();
            this.xtcMain.ResumeLayout(false);
            this.xtpError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meError.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.xtpSuccess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.xtpQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.xtpVir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            this.xtpInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtcMain;
        private DevExpress.XtraTab.XtraTabPage xtpError;
        private DevExpress.XtraTab.XtraTabPage xtpSuccess;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblError;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnSucOk;
        private DevExpress.XtraEditors.LabelControl lblSuc;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraTab.XtraTabPage xtpQuestion;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.LabelControl lblQuest;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraEditors.MemoEdit meError;
        private DevExpress.XtraTab.XtraTabPage xtpVir;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.SimpleButton btnVirOk;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtpInfo;
        private DevExpress.XtraEditors.SimpleButton btnInfoOK;
        private DevExpress.XtraEditors.LabelControl lblInfoMsg;
        private DevExpress.XtraEditors.LabelControl lblInfoHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
    }
}