namespace EmailsManagement
{
    partial class Menu
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
            this.btnSoanThuMoi = new System.Windows.Forms.Button();
            this.btnHopThu = new System.Windows.Forms.Button();
            this.listBoxHopThu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSoanThuMoi
            // 
            this.btnSoanThuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoanThuMoi.Location = new System.Drawing.Point(12, 22);
            this.btnSoanThuMoi.Name = "btnSoanThuMoi";
            this.btnSoanThuMoi.Size = new System.Drawing.Size(206, 56);
            this.btnSoanThuMoi.TabIndex = 1;
            this.btnSoanThuMoi.Text = "Soạn Thư Mới";
            this.btnSoanThuMoi.UseVisualStyleBackColor = true;
            this.btnSoanThuMoi.Click += new System.EventHandler(this.btnSoanThuMoi_Click);
            // 
            // btnHopThu
            // 
            this.btnHopThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopThu.Location = new System.Drawing.Point(12, 106);
            this.btnHopThu.Name = "btnHopThu";
            this.btnHopThu.Size = new System.Drawing.Size(206, 47);
            this.btnHopThu.TabIndex = 2;
            this.btnHopThu.Text = "Hộp Thư Đến";
            this.btnHopThu.UseVisualStyleBackColor = true;
            this.btnHopThu.Click += new System.EventHandler(this.btnHopThu_Click);
            // 
            // listBoxHopThu
            // 
            this.listBoxHopThu.FormattingEnabled = true;
            this.listBoxHopThu.ItemHeight = 16;
            this.listBoxHopThu.Location = new System.Drawing.Point(250, 22);
            this.listBoxHopThu.Name = "listBoxHopThu";
            this.listBoxHopThu.Size = new System.Drawing.Size(687, 532);
            this.listBoxHopThu.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 588);
            this.Controls.Add(this.listBoxHopThu);
            this.Controls.Add(this.btnHopThu);
            this.Controls.Add(this.btnSoanThuMoi);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSoanThuMoi;
        private System.Windows.Forms.Button btnHopThu;
        private System.Windows.Forms.ListBox listBoxHopThu;
    }
}