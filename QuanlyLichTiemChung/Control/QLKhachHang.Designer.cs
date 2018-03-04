namespace QuanlyLichTiemChung
{
    partial class QLKhachHang
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
            this.panelkh = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelkh
            // 
            this.panelkh.Location = new System.Drawing.Point(31, 114);
            this.panelkh.Name = "panelkh";
            this.panelkh.Size = new System.Drawing.Size(1372, 731);
            this.panelkh.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(408, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 87);
            this.button4.TabIndex = 3;
            this.button4.Text = "Nhắc lịch";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(52, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 87);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thông tin khách hàng";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(293, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 87);
            this.button2.TabIndex = 0;
            this.button2.Text = "Lịch sử tiêm";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(178, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lịch tiêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panelkh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "QLKhachHang";
            this.Size = new System.Drawing.Size(1415, 845);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelkh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
