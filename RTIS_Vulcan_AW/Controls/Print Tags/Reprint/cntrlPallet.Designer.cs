namespace RTIS_Vulcan_AW.Controls
{
    partial class cntrlPallet
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblItemCode = new DevExpress.XtraEditors.LabelControl();
            this.lblPalletNo = new DevExpress.XtraEditors.LabelControl();
            this.lblQty = new DevExpress.XtraEditors.LabelControl();
            this.lblLot = new DevExpress.XtraEditors.LabelControl();
            this.pnlBack.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.Controls.Add(this.tlpMain);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1082, 105);
            this.pnlBack.TabIndex = 0;
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Controls.Add(this.lblLot, 0, 0);
            this.tlpMain.Controls.Add(this.lblQty, 0, 0);
            this.tlpMain.Controls.Add(this.lblPalletNo, 0, 0);
            this.tlpMain.Controls.Add(this.lblItemCode, 0, 0);
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1082, 105);
            this.tlpMain.TabIndex = 0;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCode.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblItemCode.Appearance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemCode.Appearance.Options.UseBackColor = true;
            this.lblItemCode.Appearance.Options.UseFont = true;
            this.lblItemCode.Appearance.Options.UseForeColor = true;
            this.lblItemCode.Appearance.Options.UseTextOptions = true;
            this.lblItemCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblItemCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblItemCode.Location = new System.Drawing.Point(275, 5);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(261, 95);
            this.lblItemCode.TabIndex = 85;
            this.lblItemCode.Text = "[Code]";
            this.lblItemCode.Click += new System.EventHandler(this.lblItemCode_Click);
            // 
            // lblPalletNo
            // 
            this.lblPalletNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPalletNo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPalletNo.Appearance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletNo.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPalletNo.Appearance.Options.UseBackColor = true;
            this.lblPalletNo.Appearance.Options.UseFont = true;
            this.lblPalletNo.Appearance.Options.UseForeColor = true;
            this.lblPalletNo.Appearance.Options.UseTextOptions = true;
            this.lblPalletNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblPalletNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPalletNo.Location = new System.Drawing.Point(5, 5);
            this.lblPalletNo.Margin = new System.Windows.Forms.Padding(4);
            this.lblPalletNo.Name = "lblPalletNo";
            this.lblPalletNo.Size = new System.Drawing.Size(261, 95);
            this.lblPalletNo.TabIndex = 86;
            this.lblPalletNo.Text = "[Pallet]";
            this.lblPalletNo.Click += new System.EventHandler(this.lblPalletNo_Click);
            // 
            // lblQty
            // 
            this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQty.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Appearance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQty.Appearance.Options.UseBackColor = true;
            this.lblQty.Appearance.Options.UseFont = true;
            this.lblQty.Appearance.Options.UseForeColor = true;
            this.lblQty.Appearance.Options.UseTextOptions = true;
            this.lblQty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblQty.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblQty.Location = new System.Drawing.Point(815, 5);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(262, 95);
            this.lblQty.TabIndex = 87;
            this.lblQty.Text = "[Qty]";
            this.lblQty.Click += new System.EventHandler(this.lblQty_Click);
            // 
            // lblLot
            // 
            this.lblLot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLot.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLot.Appearance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLot.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLot.Appearance.Options.UseBackColor = true;
            this.lblLot.Appearance.Options.UseFont = true;
            this.lblLot.Appearance.Options.UseForeColor = true;
            this.lblLot.Appearance.Options.UseTextOptions = true;
            this.lblLot.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLot.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLot.Location = new System.Drawing.Point(545, 5);
            this.lblLot.Margin = new System.Windows.Forms.Padding(4);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(261, 95);
            this.lblLot.TabIndex = 88;
            this.lblLot.Text = "[Lot]";
            this.lblLot.Click += new System.EventHandler(this.lblLot_Click);
            // 
            // cntrlPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBack);
            this.Name = "cntrlPallet";
            this.Size = new System.Drawing.Size(1082, 105);
            this.Load += new System.EventHandler(this.cntrlPallet_Load);
            this.pnlBack.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        public DevExpress.XtraEditors.LabelControl lblLot;
        public DevExpress.XtraEditors.LabelControl lblQty;
        public DevExpress.XtraEditors.LabelControl lblPalletNo;
        public DevExpress.XtraEditors.LabelControl lblItemCode;
    }
}
