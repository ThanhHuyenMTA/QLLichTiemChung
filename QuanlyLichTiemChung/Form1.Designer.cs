namespace QuanlyLichTiemChung
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qLKHACHHANGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lICHTIEMCHUNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLKHACHHANGToolStripMenuItem,
            this.lICHTIEMCHUNGToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1304, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qLKHACHHANGToolStripMenuItem
            // 
            this.qLKHACHHANGToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.qLKHACHHANGToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("qLKHACHHANGToolStripMenuItem.Image")));
            this.qLKHACHHANGToolStripMenuItem.Name = "qLKHACHHANGToolStripMenuItem";
            this.qLKHACHHANGToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.qLKHACHHANGToolStripMenuItem.Text = "QL KHACHHANG";
            this.qLKHACHHANGToolStripMenuItem.Click += new System.EventHandler(this.qLKHACHHANGToolStripMenuItem_Click);
            // 
            // lICHTIEMCHUNGToolStripMenuItem
            // 
            this.lICHTIEMCHUNGToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lICHTIEMCHUNGToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.lICHTIEMCHUNGToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lICHTIEMCHUNGToolStripMenuItem.Image")));
            this.lICHTIEMCHUNGToolStripMenuItem.Name = "lICHTIEMCHUNGToolStripMenuItem";
            this.lICHTIEMCHUNGToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.lICHTIEMCHUNGToolStripMenuItem.Text = "QL.LICHTIEMCHUNG";
            this.lICHTIEMCHUNGToolStripMenuItem.Click += new System.EventHandler(this.lICHTIEMCHUNGToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 689);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "QUẢN LÝ LỊCH TIÊM CHỦNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lICHTIEMCHUNGToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem qLKHACHHANGToolStripMenuItem;
    }
}

