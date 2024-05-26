
namespace BrewHouse.Stock_Report
{
    partial class StockReport
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
            this.components = new System.ComponentModel.Container();
            this.panel_report = new System.Windows.Forms.Panel();
            this.panelradiobuttons = new System.Windows.Forms.Panel();
            this.radio_brewsp = new System.Windows.Forms.RadioButton();
            this.radio_sandwich = new System.Windows.Forms.RadioButton();
            this.radio_sweets = new System.Windows.Forms.RadioButton();
            this.radio_coffee = new System.Windows.Forms.RadioButton();
            this.StockreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_load = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel_report.SuspendLayout();
            this.panelradiobuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_report
            // 
            this.panel_report.Controls.Add(this.panelradiobuttons);
            this.panel_report.Controls.Add(this.StockreportViewer);
            this.panel_report.Controls.Add(this.btn_load);
            this.panel_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_report.Location = new System.Drawing.Point(0, 0);
            this.panel_report.Name = "panel_report";
            this.panel_report.Size = new System.Drawing.Size(979, 661);
            this.panel_report.TabIndex = 3;
            // 
            // panelradiobuttons
            // 
            this.panelradiobuttons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelradiobuttons.Controls.Add(this.radio_brewsp);
            this.panelradiobuttons.Controls.Add(this.radio_sandwich);
            this.panelradiobuttons.Controls.Add(this.radio_sweets);
            this.panelradiobuttons.Controls.Add(this.radio_coffee);
            this.panelradiobuttons.Location = new System.Drawing.Point(207, 23);
            this.panelradiobuttons.Name = "panelradiobuttons";
            this.panelradiobuttons.Size = new System.Drawing.Size(357, 56);
            this.panelradiobuttons.TabIndex = 14;
            // 
            // radio_brewsp
            // 
            this.radio_brewsp.AutoSize = true;
            this.radio_brewsp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_brewsp.Location = new System.Drawing.Point(242, 19);
            this.radio_brewsp.Name = "radio_brewsp";
            this.radio_brewsp.Size = new System.Drawing.Size(87, 17);
            this.radio_brewsp.TabIndex = 16;
            this.radio_brewsp.TabStop = true;
            this.radio_brewsp.Text = "Brew Special";
            this.radio_brewsp.UseVisualStyleBackColor = true;
            this.radio_brewsp.CheckedChanged += new System.EventHandler(this.radio_brewsp_CheckedChanged_1);
            // 
            // radio_sandwich
            // 
            this.radio_sandwich.AutoSize = true;
            this.radio_sandwich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_sandwich.Location = new System.Drawing.Point(153, 19);
            this.radio_sandwich.Name = "radio_sandwich";
            this.radio_sandwich.Size = new System.Drawing.Size(83, 17);
            this.radio_sandwich.TabIndex = 15;
            this.radio_sandwich.TabStop = true;
            this.radio_sandwich.Text = "Sandwiches";
            this.radio_sandwich.UseVisualStyleBackColor = true;
            this.radio_sandwich.CheckedChanged += new System.EventHandler(this.radio_sandwich_CheckedChanged_1);
            // 
            // radio_sweets
            // 
            this.radio_sweets.AutoSize = true;
            this.radio_sweets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_sweets.Location = new System.Drawing.Point(87, 19);
            this.radio_sweets.Name = "radio_sweets";
            this.radio_sweets.Size = new System.Drawing.Size(60, 17);
            this.radio_sweets.TabIndex = 14;
            this.radio_sweets.TabStop = true;
            this.radio_sweets.Text = "Sweets";
            this.radio_sweets.UseVisualStyleBackColor = true;
            this.radio_sweets.CheckedChanged += new System.EventHandler(this.radio_sweets_CheckedChanged_1);
            // 
            // radio_coffee
            // 
            this.radio_coffee.AutoSize = true;
            this.radio_coffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_coffee.Location = new System.Drawing.Point(25, 19);
            this.radio_coffee.Name = "radio_coffee";
            this.radio_coffee.Size = new System.Drawing.Size(56, 17);
            this.radio_coffee.TabIndex = 13;
            this.radio_coffee.TabStop = true;
            this.radio_coffee.Text = "Coffee";
            this.radio_coffee.UseVisualStyleBackColor = true;
            this.radio_coffee.CheckedChanged += new System.EventHandler(this.radio_coffee_CheckedChanged_1);
            // 
            // StockreportViewer
            // 
            this.StockreportViewer.Location = new System.Drawing.Point(0, 105);
            this.StockreportViewer.Name = "StockreportViewer";
            this.StockreportViewer.ServerReport.BearerToken = null;
            this.StockreportViewer.Size = new System.Drawing.Size(979, 556);
            this.StockreportViewer.TabIndex = 13;
            // 
            // btn_load
            // 
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.Location = new System.Drawing.Point(669, 33);
            this.btn_load.Name = "btn_load";
            this.btn_load.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(54)))));
            this.btn_load.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_load.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(54)))));
            this.btn_load.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_load.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_load.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_load.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_load.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(54)))));
            this.btn_load.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.OverrideFocus.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_load.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(54)))));
            this.btn_load.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_load.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_load.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_load.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_load.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_load.Size = new System.Drawing.Size(95, 36);
            this.btn_load.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(54)))));
            this.btn_load.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(54)))));
            this.btn_load.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_load.StateCommon.Border.Rounding = 20;
            this.btn_load.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btn_load.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btn_load.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_load.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_load.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(54)))));
            this.btn_load.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(54)))));
            this.btn_load.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_load.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(54)))));
            this.btn_load.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(122)))), ((int)(((byte)(54)))));
            this.btn_load.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_load.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_load.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_load.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_load.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btn_load.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_load.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_load.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_load.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(82)))), ((int)(((byte)(43)))));
            this.btn_load.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_load.TabIndex = 7;
            this.btn_load.Values.Text = "Load";
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.SystemColors.ScrollBar;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 661);
            this.Controls.Add(this.panel_report);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StockReport";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StockReport_Load);
            this.panel_report.ResumeLayout(false);
            this.panelradiobuttons.ResumeLayout(false);
            this.panelradiobuttons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_report;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_load;
        private Microsoft.Reporting.WinForms.ReportViewer StockreportViewer;
        private System.Windows.Forms.Panel panelradiobuttons;
        private System.Windows.Forms.RadioButton radio_brewsp;
        private System.Windows.Forms.RadioButton radio_sandwich;
        private System.Windows.Forms.RadioButton radio_sweets;
        private System.Windows.Forms.RadioButton radio_coffee;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}