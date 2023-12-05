
namespace CNPM
{
    partial class FormDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BTN_DANGNHAP = new System.Windows.Forms.Button();
            this.BTN_DONG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "MẬT KHẨU";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 34);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 34);
            this.textBox2.TabIndex = 3;
            // 
            // BTN_DANGNHAP
            // 
            this.BTN_DANGNHAP.Location = new System.Drawing.Point(250, 180);
            this.BTN_DANGNHAP.Name = "BTN_DANGNHAP";
            this.BTN_DANGNHAP.Size = new System.Drawing.Size(162, 52);
            this.BTN_DANGNHAP.TabIndex = 4;
            this.BTN_DANGNHAP.Text = "ĐĂNG NHẬP";
            this.BTN_DANGNHAP.UseVisualStyleBackColor = true;
            this.BTN_DANGNHAP.Click += new System.EventHandler(this.BTN_DANGNHAP_Click);
            // 
            // BTN_DONG
            // 
            this.BTN_DONG.Location = new System.Drawing.Point(430, 180);
            this.BTN_DONG.Name = "BTN_DONG";
            this.BTN_DONG.Size = new System.Drawing.Size(162, 52);
            this.BTN_DONG.TabIndex = 5;
            this.BTN_DONG.Text = "ĐÓNG";
            this.BTN_DONG.UseVisualStyleBackColor = true;
            this.BTN_DONG.Click += new System.EventHandler(this.BTN_DONG_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 307);
            this.Controls.Add(this.BTN_DONG);
            this.Controls.Add(this.BTN_DANGNHAP);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BTN_DANGNHAP;
        private System.Windows.Forms.Button BTN_DONG;
    }
}