namespace DbFirstFlightProject
{
    partial class FrmCity
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnİnsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearchbyCity = new System.Windows.Forms.Button();
            this.btnSearchbyCountry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(171, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(273, 27);
            this.txtid.TabIndex = 1;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(120, 213);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(117, 48);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(882, 238);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(171, 84);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(273, 27);
            this.txtCityName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şehir Adı:";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(171, 145);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(273, 27);
            this.txtCountryName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ülke Adı:";
            // 
            // btnİnsert
            // 
            this.btnİnsert.Location = new System.Drawing.Point(279, 213);
            this.btnİnsert.Name = "btnİnsert";
            this.btnİnsert.Size = new System.Drawing.Size(117, 48);
            this.btnİnsert.TabIndex = 8;
            this.btnİnsert.Text = "Ekle";
            this.btnİnsert.UseVisualStyleBackColor = true;
            this.btnİnsert.Click += new System.EventHandler(this.btnİnsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(442, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 48);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(596, 213);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 48);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearchbyCity
            // 
            this.btnSearchbyCity.Location = new System.Drawing.Point(751, 145);
            this.btnSearchbyCity.Name = "btnSearchbyCity";
            this.btnSearchbyCity.Size = new System.Drawing.Size(193, 48);
            this.btnSearchbyCity.TabIndex = 11;
            this.btnSearchbyCity.Text = "Şehire göre ara";
            this.btnSearchbyCity.UseVisualStyleBackColor = true;
            this.btnSearchbyCity.Click += new System.EventHandler(this.btnSearchbyCity_Click);
            // 
            // btnSearchbyCountry
            // 
            this.btnSearchbyCountry.Location = new System.Drawing.Point(751, 73);
            this.btnSearchbyCountry.Name = "btnSearchbyCountry";
            this.btnSearchbyCountry.Size = new System.Drawing.Size(193, 48);
            this.btnSearchbyCountry.TabIndex = 12;
            this.btnSearchbyCountry.Text = "Ülkeye göre ara";
            this.btnSearchbyCountry.UseVisualStyleBackColor = true;
            // 
            // FrmCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.btnSearchbyCountry);
            this.Controls.Add(this.btnSearchbyCity);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnİnsert);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCity";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnİnsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearchbyCity;
        private System.Windows.Forms.Button btnSearchbyCountry;
    }
}

