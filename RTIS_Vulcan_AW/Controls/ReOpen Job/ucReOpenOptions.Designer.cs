namespace RTIS_Vulcan_AW.Controls.ReOpen_Job
{
    partial class ucReOpenOptions
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
            this.btnManual = new DevExpress.XtraEditors.SimpleButton();
            this.btnScanToOpen = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnManual
            // 
            this.btnManual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManual.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnManual.Appearance.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.btnManual.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnManual.Appearance.Options.UseBackColor = true;
            this.btnManual.Appearance.Options.UseFont = true;
            this.btnManual.Appearance.Options.UseForeColor = true;
            this.btnManual.Location = new System.Drawing.Point(211, 246);
            this.btnManual.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnManual.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnManual.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnManual.Margin = new System.Windows.Forms.Padding(4);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(783, 101);
            this.btnManual.TabIndex = 86;
            this.btnManual.Text = "Manual Open";
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnScanToOpen
            // 
            this.btnScanToOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScanToOpen.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnScanToOpen.Appearance.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.btnScanToOpen.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnScanToOpen.Appearance.Options.UseBackColor = true;
            this.btnScanToOpen.Appearance.Options.UseFont = true;
            this.btnScanToOpen.Appearance.Options.UseForeColor = true;
            this.btnScanToOpen.Location = new System.Drawing.Point(211, 137);
            this.btnScanToOpen.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnScanToOpen.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnScanToOpen.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnScanToOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnScanToOpen.Name = "btnScanToOpen";
            this.btnScanToOpen.Size = new System.Drawing.Size(783, 101);
            this.btnScanToOpen.TabIndex = 85;
            this.btnScanToOpen.Text = "Scan to Open";
            this.btnScanToOpen.Click += new System.EventHandler(this.btnScanToOpen_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Appearance.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.Location = new System.Drawing.Point(211, 599);
            this.btnBack.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnBack.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnBack.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(783, 101);
            this.btnBack.TabIndex = 84;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ucReOpenOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnScanToOpen);
            this.Controls.Add(this.btnBack);
            this.Name = "ucReOpenOptions";
            this.Size = new System.Drawing.Size(1225, 728);
            this.Load += new System.EventHandler(this.ucReOpenOptions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.SimpleButton btnManual;
        internal DevExpress.XtraEditors.SimpleButton btnScanToOpen;
        internal DevExpress.XtraEditors.SimpleButton btnBack;
    }
}
