namespace RTIS_Vulcan_AW.Controls.Open_Job
{
    partial class cntrlPGMItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLotNumber = new DevExpress.XtraEditors.LabelControl();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.lblItem = new DevExpress.XtraEditors.LabelControl();
            this.pnlBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLotNumber.Appearance.BackColor = System.Drawing.Color.White;
            this.lblLotNumber.Appearance.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotNumber.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLotNumber.Appearance.Options.UseBackColor = true;
            this.lblLotNumber.Appearance.Options.UseFont = true;
            this.lblLotNumber.Appearance.Options.UseForeColor = true;
            this.lblLotNumber.Appearance.Options.UseTextOptions = true;
            this.lblLotNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLotNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLotNumber.Location = new System.Drawing.Point(624, 13);
            this.lblLotNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(452, 80);
            this.lblLotNumber.TabIndex = 85;
            this.lblLotNumber.Text = "[Code]";
            this.lblLotNumber.Click += new System.EventHandler(this.lblLotNumber_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.White;
            this.pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBack.Controls.Add(this.lblItem);
            this.pnlBack.Controls.Add(this.lblLotNumber);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1082, 109);
            this.pnlBack.TabIndex = 86;
            this.pnlBack.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // lblItem
            // 
            this.lblItem.Appearance.BackColor = System.Drawing.Color.White;
            this.lblItem.Appearance.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItem.Appearance.Options.UseBackColor = true;
            this.lblItem.Appearance.Options.UseFont = true;
            this.lblItem.Appearance.Options.UseForeColor = true;
            this.lblItem.Appearance.Options.UseTextOptions = true;
            this.lblItem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblItem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblItem.Location = new System.Drawing.Point(4, 13);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(452, 80);
            this.lblItem.TabIndex = 86;
            this.lblItem.Text = "[Code]";
            this.lblItem.Click += new System.EventHandler(this.lblItem_Click);
            // 
            // cntrlPGMItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBack);
            this.Name = "cntrlPGMItem";
            this.Size = new System.Drawing.Size(1082, 109);
            this.Load += new System.EventHandler(this.cntrlPGMItem_Load);
            this.pnlBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lblLotNumber;
        private System.Windows.Forms.Panel pnlBack;
        public DevExpress.XtraEditors.LabelControl lblItem;
    }
}
