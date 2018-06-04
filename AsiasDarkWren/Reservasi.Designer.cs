namespace AsiasDarkWren
{
    partial class Reservasi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservasi));
            this.listReservasi = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnBuang = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLanjut = new System.Windows.Forms.Button();
            this.cariPasien1 = new AsiasDarkWren.CariPasien();
            this.reservasiBerhasil1 = new AsiasDarkWren.ReservasiBerhasil();
            this.pilihJadwal1 = new AsiasDarkWren.PilihJadwal();
            this.listReservasi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listReservasi
            // 
            this.listReservasi.Controls.Add(this.tabPage1);
            this.listReservasi.Controls.Add(this.tabPage2);
            this.listReservasi.Location = new System.Drawing.Point(17, 15);
            this.listReservasi.Margin = new System.Windows.Forms.Padding(4);
            this.listReservasi.Name = "listReservasi";
            this.listReservasi.SelectedIndex = 0;
            this.listReservasi.Size = new System.Drawing.Size(929, 592);
            this.listReservasi.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnCari);
            this.tabPage1.Controls.Add(this.btnBuang);
            this.tabPage1.Controls.Add(this.btnPrint);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(921, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List Reservasi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(36, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(853, 339);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 25.38071F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 26;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 118.6548F;
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Width = 35;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 118.6548F;
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.Width = 145;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 118.6548F;
            this.Column4.HeaderText = "Phone Number";
            this.Column4.Name = "Column4";
            this.Column4.Width = 180;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 118.6548F;
            this.Column5.HeaderText = "Gender";
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Age";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Birth Date";
            this.Column7.Name = "Column7";
            this.Column7.Width = 104;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Origin";
            this.Column8.Name = "Column8";
            this.Column8.Width = 170;
            // 
            // btnCari
            // 
            this.btnCari.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnCari.Location = new System.Drawing.Point(556, 106);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(95, 32);
            this.btnCari.TabIndex = 9;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // btnBuang
            // 
            this.btnBuang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuang.FlatAppearance.BorderSize = 0;
            this.btnBuang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuang.Image = ((System.Drawing.Image)(resources.GetObject("btnBuang.Image")));
            this.btnBuang.Location = new System.Drawing.Point(795, 106);
            this.btnBuang.Name = "btnBuang";
            this.btnBuang.Size = new System.Drawing.Size(45, 49);
            this.btnBuang.TabIndex = 8;
            this.btnBuang.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(744, 106);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(45, 49);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(369, 32);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Poliklinik Gigi",
            "Onkologi"});
            this.comboBox1.Location = new System.Drawing.Point(162, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 31);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poliklinik";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLanjut);
            this.tabPage2.Controls.Add(this.cariPasien1);
            this.tabPage2.Controls.Add(this.reservasiBerhasil1);
            this.tabPage2.Controls.Add(this.pilihJadwal1);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(921, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservasi Baru";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLanjut
            // 
            this.btnLanjut.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLanjut.FlatAppearance.BorderSize = 0;
            this.btnLanjut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanjut.ForeColor = System.Drawing.Color.White;
            this.btnLanjut.Location = new System.Drawing.Point(570, 507);
            this.btnLanjut.Name = "btnLanjut";
            this.btnLanjut.Size = new System.Drawing.Size(310, 32);
            this.btnLanjut.TabIndex = 3;
            this.btnLanjut.Text = "Lanjut";
            this.btnLanjut.UseVisualStyleBackColor = false;
            this.btnLanjut.Click += new System.EventHandler(this.btnLanjut_Click);
            // 
            // cariPasien1
            // 
            this.cariPasien1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariPasien1.Location = new System.Drawing.Point(0, 0);
            this.cariPasien1.Margin = new System.Windows.Forms.Padding(4);
            this.cariPasien1.Name = "cariPasien1";
            this.cariPasien1.Size = new System.Drawing.Size(921, 552);
            this.cariPasien1.TabIndex = 0;
            // 
            // reservasiBerhasil1
            // 
            this.reservasiBerhasil1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservasiBerhasil1.Location = new System.Drawing.Point(0, 0);
            this.reservasiBerhasil1.Margin = new System.Windows.Forms.Padding(4);
            this.reservasiBerhasil1.Name = "reservasiBerhasil1";
            this.reservasiBerhasil1.Size = new System.Drawing.Size(925, 560);
            this.reservasiBerhasil1.TabIndex = 2;
            // 
            // pilihJadwal1
            // 
            this.pilihJadwal1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilihJadwal1.Location = new System.Drawing.Point(0, 0);
            this.pilihJadwal1.Margin = new System.Windows.Forms.Padding(4);
            this.pilihJadwal1.Name = "pilihJadwal1";
            this.pilihJadwal1.Size = new System.Drawing.Size(921, 548);
            this.pilihJadwal1.TabIndex = 1;
            // 
            // Reservasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listReservasi);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reservasi";
            this.Size = new System.Drawing.Size(960, 651);
            this.Load += new System.EventHandler(this.Reservasi_Load);
            this.listReservasi.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl listReservasi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBuang;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private CariPasien cariPasien1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private PilihJadwal pilihJadwal1;
        private ReservasiBerhasil reservasiBerhasil1;
        private System.Windows.Forms.Button btnLanjut;
    }
}
