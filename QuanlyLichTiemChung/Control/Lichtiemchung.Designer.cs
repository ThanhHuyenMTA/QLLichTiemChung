namespace QuanlyLichTiemChung
{
    partial class Lichtiemchung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataThLich = new System.Windows.Forms.DataGridView();
            this.TENLICHCHUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENVACXIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.combDT = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnloadlich = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataThLich)).BeginInit();
            this.SuspendLayout();
            // 
            // dataThLich
            // 
            this.dataThLich.BackgroundColor = System.Drawing.Color.Silver;
            this.dataThLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENLICHCHUNG,
            this.TENVACXIN,
            this.MOTA});
            this.dataThLich.Location = new System.Drawing.Point(142, 89);
            this.dataThLich.Name = "dataThLich";
            this.dataThLich.Size = new System.Drawing.Size(943, 442);
            this.dataThLich.TabIndex = 0;
            // 
            // TENLICHCHUNG
            // 
            this.TENLICHCHUNG.DataPropertyName = "TENLICHCHUNG";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TENLICHCHUNG.DefaultCellStyle = dataGridViewCellStyle1;
            this.TENLICHCHUNG.HeaderText = "Tên lịch chung";
            this.TENLICHCHUNG.Name = "TENLICHCHUNG";
            this.TENLICHCHUNG.Width = 200;
            // 
            // TENVACXIN
            // 
            this.TENVACXIN.DataPropertyName = "TENVACXIN";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.TENVACXIN.DefaultCellStyle = dataGridViewCellStyle2;
            this.TENVACXIN.HeaderText = "Tên vắc xin";
            this.TENVACXIN.Name = "TENVACXIN";
            this.TENVACXIN.Width = 300;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.Name = "MOTA";
            this.MOTA.Width = 400;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(476, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "LỊCH TIÊM CHỦNG CHUNG";
            // 
            // combDT
            // 
            this.combDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combDT.ForeColor = System.Drawing.Color.Blue;
            this.combDT.FormattingEnabled = true;
            this.combDT.Items.AddRange(new object[] {
            "Trẻ em",
            "Phụ nữ mang thai",
            "Người lớn"});
            this.combDT.Location = new System.Drawing.Point(142, 32);
            this.combDT.Name = "combDT";
            this.combDT.Size = new System.Drawing.Size(99, 24);
            this.combDT.TabIndex = 24;
            this.combDT.Text = "Trẻ em";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tên đối tượng";
            // 
            // btnloadlich
            // 
            this.btnloadlich.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnloadlich.Location = new System.Drawing.Point(291, 3);
            this.btnloadlich.Name = "btnloadlich";
            this.btnloadlich.Size = new System.Drawing.Size(62, 70);
            this.btnloadlich.TabIndex = 25;
            this.btnloadlich.Text = "Hiển thị";
            this.btnloadlich.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnloadlich.UseVisualStyleBackColor = true;
            this.btnloadlich.Click += new System.EventHandler(this.btnloadlich_Click);
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(380, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 70);
            this.button3.TabIndex = 26;
            this.button3.Text = "Thoát";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Lichtiemchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnloadlich);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combDT);
            this.Controls.Add(this.dataThLich);
            this.Controls.Add(this.label9);
            this.Name = "Lichtiemchung";
            this.Size = new System.Drawing.Size(1531, 927);
            this.Load += new System.EventHandler(this.Lichtiemchung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataThLich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataThLich;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnloadlich;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLICHCHUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENVACXIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.Button button3;
    }
}
