namespace KiemTra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddNhom = new System.Windows.Forms.ToolStripButton();
            this.btnDelNhom = new System.Windows.Forms.ToolStripButton();
            this.btnAddLL = new System.Windows.Forms.ToolStripButton();
            this.btnDelLL = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtgvNhom = new System.Windows.Forms.DataGridView();
            this.dtgvSinhVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.sinhVienViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ColTenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNhom,
            this.btnDelNhom,
            this.btnAddLL,
            this.btnDelLL});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(831, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddNhom
            // 
            this.btnAddNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNhom.Image")));
            this.btnAddNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNhom.Name = "btnAddNhom";
            this.btnAddNhom.Size = new System.Drawing.Size(112, 24);
            this.btnAddNhom.Text = "Thêm nhóm";
            this.btnAddNhom.Click += new System.EventHandler(this.btnAddNhom_Click);
            // 
            // btnDelNhom
            // 
            this.btnDelNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnDelNhom.Image")));
            this.btnDelNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelNhom.Name = "btnDelNhom";
            this.btnDelNhom.Size = new System.Drawing.Size(101, 24);
            this.btnDelNhom.Text = "Xóa nhóm";
            this.btnDelNhom.Click += new System.EventHandler(this.btnDelNhom_Click);
            // 
            // btnAddLL
            // 
            this.btnAddLL.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLL.Image")));
            this.btnAddLL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddLL.Name = "btnAddLL";
            this.btnAddLL.Size = new System.Drawing.Size(121, 24);
            this.btnAddLL.Text = "Thêm liên lạc";
            this.btnAddLL.Click += new System.EventHandler(this.btnAddLL_Click);
            // 
            // btnDelLL
            // 
            this.btnDelLL.Image = ((System.Drawing.Image)(resources.GetObject("btnDelLL.Image")));
            this.btnDelLL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelLL.Name = "btnDelLL";
            this.btnDelLL.Size = new System.Drawing.Size(110, 24);
            this.btnDelLL.Text = "Xóa liên lạc";
            this.btnDelLL.Click += new System.EventHandler(this.btnDelLL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập từ cần tìm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 3;
            // 
            // dtgvNhom
            // 
            this.dtgvNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTenNhom});
            this.dtgvNhom.Location = new System.Drawing.Point(0, 30);
            this.dtgvNhom.Name = "dtgvNhom";
            this.dtgvNhom.RowHeadersWidth = 51;
            this.dtgvNhom.RowTemplate.Height = 24;
            this.dtgvNhom.Size = new System.Drawing.Size(291, 423);
            this.dtgvNhom.TabIndex = 4;
            // 
            // dtgvSinhVien
            // 
            this.dtgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTenGoi,
            this.ColEmail,
            this.ColSDT});
            this.dtgvSinhVien.Location = new System.Drawing.Point(297, 30);
            this.dtgvSinhVien.Name = "dtgvSinhVien";
            this.dtgvSinhVien.RowHeadersWidth = 51;
            this.dtgvSinhVien.RowTemplate.Height = 24;
            this.dtgvSinhVien.Size = new System.Drawing.Size(503, 221);
            this.dtgvSinhVien.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Gọi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(421, 306);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(311, 22);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(421, 344);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(421, 384);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(311, 22);
            this.txtSDT.TabIndex = 12;
            // 
            // nhomViewModelBindingSource
            // 
            this.nhomViewModelBindingSource.DataSource = this.sinhVienViewModelBindingSource;
            // 
            // ColTenNhom
            // 
            this.ColTenNhom.HeaderText = "Tên Nhóm";
            this.ColTenNhom.MinimumWidth = 6;
            this.ColTenNhom.Name = "ColTenNhom";
            this.ColTenNhom.Width = 125;
            // 
            // ColTenGoi
            // 
            this.ColTenGoi.HeaderText = "Tên gọi";
            this.ColTenGoi.MinimumWidth = 6;
            this.ColTenGoi.Name = "ColTenGoi";
            this.ColTenGoi.Width = 125;
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.MinimumWidth = 6;
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Width = 125;
            // 
            // ColSDT
            // 
            this.ColSDT.HeaderText = "Số điện thoại";
            this.ColSDT.MinimumWidth = 6;
            this.ColSDT.Name = "ColSDT";
            this.ColSDT.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvSinhVien);
            this.Controls.Add(this.dtgvNhom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDelLL;
        private System.Windows.Forms.ToolStripButton btnAddNhom;
        private System.Windows.Forms.ToolStripButton btnDelNhom;
        private System.Windows.Forms.ToolStripButton btnAddLL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dtgvNhom;
        private System.Windows.Forms.DataGridView dtgvSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.BindingSource sinhVienViewModelBindingSource;
        private System.Windows.Forms.BindingSource nhomViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSDT;
    }
}

