namespace DbFirstFlightProject.Model
{
    partial class FrmEmployee
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnİnsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotelEmployee = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAvgSalary = new System.Windows.Forms.Label();
            this.lblSumSalary = new System.Windows.Forms.Label();
            this.lblMaxSalaryEmployee = new System.Windows.Forms.Label();
            this.btnStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(575, 213);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 48);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(421, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 48);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnİnsert
            // 
            this.btnİnsert.Location = new System.Drawing.Point(258, 213);
            this.btnİnsert.Name = "btnİnsert";
            this.btnİnsert.Size = new System.Drawing.Size(117, 48);
            this.btnİnsert.TabIndex = 21;
            this.btnİnsert.Text = "Ekle";
            this.btnİnsert.UseVisualStyleBackColor = true;
            this.btnİnsert.Click += new System.EventHandler(this.btnİnsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Departman:";
            // 
            // txtPerName
            // 
            this.txtPerName.Location = new System.Drawing.Point(169, 84);
            this.txtPerName.Name = "txtPerName";
            this.txtPerName.Size = new System.Drawing.Size(273, 26);
            this.txtPerName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Personel Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 238);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(99, 213);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(117, 48);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(169, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(273, 26);
            this.txtid.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Personel ID:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(169, 145);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(273, 28);
            this.cmbDepartment.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(688, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Toplam Kişi Sayısı:";
            // 
            // lblTotelEmployee
            // 
            this.lblTotelEmployee.AutoSize = true;
            this.lblTotelEmployee.Location = new System.Drawing.Point(844, 15);
            this.lblTotelEmployee.Name = "lblTotelEmployee";
            this.lblTotelEmployee.Size = new System.Drawing.Size(27, 20);
            this.lblTotelEmployee.TabIndex = 29;
            this.lblTotelEmployee.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Toplam Maaş:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(702, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ortalama Maaş:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(615, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "En Yüksek Maaşlı Personel:";
            // 
            // lblAvgSalary
            // 
            this.lblAvgSalary.AutoSize = true;
            this.lblAvgSalary.Location = new System.Drawing.Point(844, 99);
            this.lblAvgSalary.Name = "lblAvgSalary";
            this.lblAvgSalary.Size = new System.Drawing.Size(27, 20);
            this.lblAvgSalary.TabIndex = 33;
            this.lblAvgSalary.Text = "00";
            // 
            // lblSumSalary
            // 
            this.lblSumSalary.AutoSize = true;
            this.lblSumSalary.Location = new System.Drawing.Point(844, 58);
            this.lblSumSalary.Name = "lblSumSalary";
            this.lblSumSalary.Size = new System.Drawing.Size(27, 20);
            this.lblSumSalary.TabIndex = 34;
            this.lblSumSalary.Text = "00";
            // 
            // lblMaxSalaryEmployee
            // 
            this.lblMaxSalaryEmployee.AutoSize = true;
            this.lblMaxSalaryEmployee.Location = new System.Drawing.Point(844, 135);
            this.lblMaxSalaryEmployee.Name = "lblMaxSalaryEmployee";
            this.lblMaxSalaryEmployee.Size = new System.Drawing.Size(27, 20);
            this.lblMaxSalaryEmployee.TabIndex = 35;
            this.lblMaxSalaryEmployee.Text = "00";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(785, 183);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(117, 48);
            this.btnStatistics.TabIndex = 36;
            this.btnStatistics.Text = "İstatistikler";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 542);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.lblMaxSalaryEmployee);
            this.Controls.Add(this.lblSumSalary);
            this.Controls.Add(this.lblAvgSalary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotelEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnİnsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnİnsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotelEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAvgSalary;
        private System.Windows.Forms.Label lblSumSalary;
        private System.Windows.Forms.Label lblMaxSalaryEmployee;
        private System.Windows.Forms.Button btnStatistics;
    }
}