namespace BTH2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttentacgia = new System.Windows.Forms.TextBox();
            this.txtmatacpham = new System.Windows.Forms.TextBox();
            this.txttentacpham = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxuatexxel = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimtentacpham = new System.Windows.Forms.Button();
            this.btnlamoi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.cbbloaitacpham = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã tác phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên tác phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại tác phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 39);
            this.label7.TabIndex = 6;
            this.label7.Text = "Danh mục hàng hóa";
            // 
            // txttentacgia
            // 
            this.txttentacgia.Location = new System.Drawing.Point(108, 63);
            this.txttentacgia.Name = "txttentacgia";
            this.txttentacgia.Size = new System.Drawing.Size(243, 22);
            this.txttentacgia.TabIndex = 7;
            // 
            // txtmatacpham
            // 
            this.txtmatacpham.Location = new System.Drawing.Point(108, 113);
            this.txtmatacpham.Name = "txtmatacpham";
            this.txtmatacpham.Size = new System.Drawing.Size(243, 22);
            this.txtmatacpham.TabIndex = 8;
            // 
            // txttentacpham
            // 
            this.txttentacpham.Location = new System.Drawing.Point(108, 172);
            this.txttentacpham.Name = "txttentacpham";
            this.txttentacpham.Size = new System.Drawing.Size(243, 22);
            this.txttentacpham.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 225);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(852, 40);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(82, 45);
            this.btnthem.TabIndex = 18;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxuatexxel
            // 
            this.btnxuatexxel.Location = new System.Drawing.Point(852, 291);
            this.btnxuatexxel.Name = "btnxuatexxel";
            this.btnxuatexxel.Size = new System.Drawing.Size(82, 45);
            this.btnxuatexxel.TabIndex = 19;
            this.btnxuatexxel.Text = "Xuất excel";
            this.btnxuatexxel.UseVisualStyleBackColor = true;
            this.btnxuatexxel.Click += new System.EventHandler(this.btnxuatexxel_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(852, 116);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(82, 45);
            this.btnsua.TabIndex = 20;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntimtentacpham
            // 
            this.btntimtentacpham.Location = new System.Drawing.Point(852, 442);
            this.btntimtentacpham.Name = "btntimtentacpham";
            this.btntimtentacpham.Size = new System.Drawing.Size(82, 45);
            this.btntimtentacpham.TabIndex = 21;
            this.btntimtentacpham.Text = "Tìm tên tác phẩm";
            this.btntimtentacpham.UseVisualStyleBackColor = true;
            this.btntimtentacpham.Click += new System.EventHandler(this.btntimtentacpham_Click);
            // 
            // btnlamoi
            // 
            this.btnlamoi.Location = new System.Drawing.Point(852, 363);
            this.btnlamoi.Name = "btnlamoi";
            this.btnlamoi.Size = new System.Drawing.Size(82, 45);
            this.btnlamoi.TabIndex = 22;
            this.btnlamoi.Text = "Làm mới";
            this.btnlamoi.UseVisualStyleBackColor = true;
            this.btnlamoi.Click += new System.EventHandler(this.btnlamoi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(852, 211);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(82, 45);
            this.btnxoa.TabIndex = 23;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // cbbloaitacpham
            // 
            this.cbbloaitacpham.FormattingEnabled = true;
            this.cbbloaitacpham.Location = new System.Drawing.Point(108, 222);
            this.cbbloaitacpham.Name = "cbbloaitacpham";
            this.cbbloaitacpham.Size = new System.Drawing.Size(243, 24);
            this.cbbloaitacpham.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 566);
            this.Controls.Add(this.cbbloaitacpham);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnlamoi);
            this.Controls.Add(this.btntimtentacpham);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxuatexxel);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttentacpham);
            this.Controls.Add(this.txtmatacpham);
            this.Controls.Add(this.txttentacgia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttentacgia;
        private System.Windows.Forms.TextBox txtmatacpham;
        private System.Windows.Forms.TextBox txttentacpham;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxuatexxel;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimtentacpham;
        private System.Windows.Forms.Button btnlamoi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ComboBox cbbloaitacpham;
    }
}

