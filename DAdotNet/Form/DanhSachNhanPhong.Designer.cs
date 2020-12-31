namespace DAdotNet
{
    partial class DanhSachNhanPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachNhanPhong));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLamMoi = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tìmTheoMãNhậnPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmTheoMãĐặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmTheoMãKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxTK = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMD,
            this.MADAT,
            this.cbMKH});
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 398);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtMD
            // 
            this.txtMD.DataPropertyName = "MANHANPHONG";
            this.txtMD.HeaderText = "Mã Nhận Phòng";
            this.txtMD.Name = "txtMD";
            this.txtMD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MADAT
            // 
            this.MADAT.DataPropertyName = "MADAT";
            this.MADAT.HeaderText = "Mã Đặt Phòng";
            this.MADAT.Name = "MADAT";
            // 
            // cbMKH
            // 
            this.cbMKH.DataPropertyName = "MAKHACH";
            this.cbMKH.HeaderText = "Mã Khách Hàng";
            this.cbMKH.Name = "cbMKH";
            this.cbMKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonThem,
            this.toolStripButtonSua,
            this.toolStripButtonXoa,
            this.toolStripButtonThoat,
            this.toolStripButtonLuu,
            this.toolStripButtonLamMoi,
            this.toolStripDropDownButton1,
            this.toolStripTextBoxTK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(975, 32);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonThem
            // 
            this.toolStripButtonThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonThem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonThem.Image")));
            this.toolStripButtonThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonThem.Name = "toolStripButtonThem";
            this.toolStripButtonThem.Size = new System.Drawing.Size(80, 29);
            this.toolStripButtonThem.Text = "Thêm";
            this.toolStripButtonThem.Click += new System.EventHandler(this.toolStripButtonThem_Click);
            // 
            // toolStripButtonSua
            // 
            this.toolStripButtonSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSua.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSua.Image")));
            this.toolStripButtonSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSua.Name = "toolStripButtonSua";
            this.toolStripButtonSua.Size = new System.Drawing.Size(64, 29);
            this.toolStripButtonSua.Text = "Sửa";
            // 
            // toolStripButtonXoa
            // 
            this.toolStripButtonXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonXoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonXoa.Image")));
            this.toolStripButtonXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonXoa.Name = "toolStripButtonXoa";
            this.toolStripButtonXoa.Size = new System.Drawing.Size(65, 29);
            this.toolStripButtonXoa.Text = "Xóa";
            // 
            // toolStripButtonThoat
            // 
            this.toolStripButtonThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonThoat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonThoat.Image")));
            this.toolStripButtonThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonThoat.Name = "toolStripButtonThoat";
            this.toolStripButtonThoat.Size = new System.Drawing.Size(81, 29);
            this.toolStripButtonThoat.Text = "Thoát";
            // 
            // toolStripButtonLuu
            // 
            this.toolStripButtonLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLuu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLuu.Image")));
            this.toolStripButtonLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLuu.Name = "toolStripButtonLuu";
            this.toolStripButtonLuu.Size = new System.Drawing.Size(64, 29);
            this.toolStripButtonLuu.Text = "Lưu";
            // 
            // toolStripButtonLamMoi
            // 
            this.toolStripButtonLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLamMoi.Image")));
            this.toolStripButtonLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLamMoi.Name = "toolStripButtonLamMoi";
            this.toolStripButtonLamMoi.Size = new System.Drawing.Size(108, 29);
            this.toolStripButtonLamMoi.Text = "Làm Mới";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmTheoMãNhậnPhòngToolStripMenuItem,
            this.tìmTheoMãĐặtPhòngToolStripMenuItem,
            this.tìmTheoMãKháchHàngToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(122, 29);
            this.toolStripDropDownButton1.Text = "Tìm Kiếm";
            // 
            // tìmTheoMãNhậnPhòngToolStripMenuItem
            // 
            this.tìmTheoMãNhậnPhòngToolStripMenuItem.Name = "tìmTheoMãNhậnPhòngToolStripMenuItem";
            this.tìmTheoMãNhậnPhòngToolStripMenuItem.Size = new System.Drawing.Size(308, 30);
            this.tìmTheoMãNhậnPhòngToolStripMenuItem.Text = "Tìm Theo Mã Nhận Phòng";
            this.tìmTheoMãNhậnPhòngToolStripMenuItem.Click += new System.EventHandler(this.tìmTheoMãNhậnPhòngToolStripMenuItem_Click);
            // 
            // tìmTheoMãĐặtPhòngToolStripMenuItem
            // 
            this.tìmTheoMãĐặtPhòngToolStripMenuItem.Name = "tìmTheoMãĐặtPhòngToolStripMenuItem";
            this.tìmTheoMãĐặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(308, 30);
            this.tìmTheoMãĐặtPhòngToolStripMenuItem.Text = "Tìm Theo Mã Đặt Phòng";
            this.tìmTheoMãĐặtPhòngToolStripMenuItem.Click += new System.EventHandler(this.tìmTheoMãĐặtPhòngToolStripMenuItem_Click);
            // 
            // tìmTheoMãKháchHàngToolStripMenuItem
            // 
            this.tìmTheoMãKháchHàngToolStripMenuItem.Name = "tìmTheoMãKháchHàngToolStripMenuItem";
            this.tìmTheoMãKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(308, 30);
            this.tìmTheoMãKháchHàngToolStripMenuItem.Text = "Tìm Theo Mã Khách Hàng";
            this.tìmTheoMãKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.tìmTheoMãKháchHàngToolStripMenuItem_Click);
            // 
            // toolStripTextBoxTK
            // 
            this.toolStripTextBoxTK.Name = "toolStripTextBoxTK";
            this.toolStripTextBoxTK.Size = new System.Drawing.Size(200, 32);
            this.toolStripTextBoxTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxTK_KeyPress);
            this.toolStripTextBoxTK.Click += new System.EventHandler(this.toolStripTextBoxTK_Click);
            // 
            // DanhSachNhanPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DanhSachNhanPhong";
            this.Text = "DanhSachNhanPhong";
            this.Load += new System.EventHandler(this.DanhSachNhanPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbMKH;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonThem;
        private System.Windows.Forms.ToolStripButton toolStripButtonSua;
        private System.Windows.Forms.ToolStripButton toolStripButtonXoa;
        private System.Windows.Forms.ToolStripButton toolStripButtonThoat;
        private System.Windows.Forms.ToolStripButton toolStripButtonLuu;
        private System.Windows.Forms.ToolStripButton toolStripButtonLamMoi;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxTK;
        private System.Windows.Forms.ToolStripMenuItem tìmTheoMãNhậnPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmTheoMãĐặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmTheoMãKháchHàngToolStripMenuItem;
    }
}