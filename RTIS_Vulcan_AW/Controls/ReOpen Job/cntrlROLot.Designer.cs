namespace RTIS_Vulcan_AW.Controls.ReOpen_Job
{
    partial class cntrlROLot
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
            this.pnlBack = new System.Windows.Forms.Panel();
            this.lblLot = new DevExpress.XtraEditors.LabelControl();
            this.pnlBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.White;
            this.pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBack.Controls.Add(this.lblLot);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1082, 150);
            this.pnlBack.TabIndex = 91;
            this.pnlBack.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // lblLot
            // 
            this.lblLot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLot.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLot.Appearance.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLot.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLot.Appearance.Options.UseBackColor = true;
            this.lblLot.Appearance.Options.UseFont = true;
            this.lblLot.Appearance.Options.UseForeColor = true;
            this.lblLot.Appearance.Options.UseTextOptions = true;
            this.lblLot.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLot.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLot.Location = new System.Drawing.Point(28, 24);
            this.lblLot.Margin = new System.Windows.Forms.Padding(4);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(1024, 100);
            this.lblLot.TabIndex = 84;
            this.lblLot.Text = "[Lot]";
            this.lblLot.Click += new System.EventHandler(this.lblLot_Click);
            // 
            // cntrlROLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBack);
            this.Name = "cntrlROLot";
            this.Size = new System.Drawing.Size(1082, 150);
            this.Load += new System.EventHandler(this.cntrlROLot_Load);
            this.pnlBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlBack;
        public DevExpress.XtraEditors.LabelControl lblLot;
    }
}
