namespace DAdotNet
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHuyDN = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radu = new System.Windows.Forms.RadioButton();
            this.radA = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(508, 149);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(309, 22);
            this.txtTK.TabIndex = 2;
            this.txtTK.Text = "thaocutepro";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(508, 219);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(309, 22);
            this.txtMK.TabIndex = 6;
            this.txtMK.Text = "123456";
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 262);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnHuyDN
            // 
            this.btnHuyDN.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyDN.Image")));
            this.btnHuyDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyDN.Location = new System.Drawing.Point(669, 314);
            this.btnHuyDN.Name = "btnHuyDN";
            this.btnHuyDN.Size = new System.Drawing.Size(148, 40);
            this.btnHuyDN.TabIndex = 5;
            this.btnHuyDN.Text = "Hủy";
            this.btnHuyDN.UseVisualStyleBackColor = true;
            // 
            // btnDN
            // 
            this.btnDN.Image = ((System.Drawing.Image)(resources.GetObject("btnDN.Image")));
            this.btnDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDN.Location = new System.Drawing.Point(422, 314);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(164, 40);
            this.btnDN.TabIndex = 4;
            this.btnDN.Text = "Nhập Đăng ";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 78);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(267, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đăng Nhập Hệ Thống";
            // 
            // radu
            // 
            this.radu.AutoSize = true;
            this.radu.Location = new System.Drawing.Point(433, 276);
            this.radu.Name = "radu";
            this.radu.Size = new System.Drawing.Size(59, 21);
            this.radu.TabIndex = 9;
            this.radu.TabStop = true;
            this.radu.Text = "User";
            this.radu.UseVisualStyleBackColor = true;
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Location = new System.Drawing.Point(669, 276);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(68, 21);
            this.radA.TabIndex = 10;
            this.radA.TabStop = true;
            this.radA.Text = "Admin";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 401);
            this.Controls.Add(this.radA);
            this.Controls.Add(this.radu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.btnHuyDN);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnHuyDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radu;
        private System.Windows.Forms.RadioButton radA;
    }
}