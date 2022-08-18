namespace DbFirstFlightProject
{
    partial class FrmPassenger
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
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnList2 = new System.Windows.Forms.Button();
            this.btnWomenPassengerList = new System.Windows.Forms.Button();
            this.btnMenPassengerList = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMen = new System.Windows.Forms.Label();
            this.lblWomen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(547, 252);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 48);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(389, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 48);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnİnsert
            // 
            this.btnİnsert.Location = new System.Drawing.Point(226, 252);
            this.btnİnsert.Name = "btnİnsert";
            this.btnİnsert.Size = new System.Drawing.Size(117, 48);
            this.btnİnsert.TabIndex = 21;
            this.btnİnsert.Text = "Ekle";
            this.btnİnsert.UseVisualStyleBackColor = true;
            this.btnİnsert.Click += new System.EventHandler(this.btnİnsert_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(200, 111);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(273, 27);
            this.txtSurname.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Yolcu Soyadı:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 27);
            this.txtName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Yolcu Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(882, 238);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(67, 252);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(117, 48);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(200, 13);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(273, 27);
            this.txtid.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Yolcu ID:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(200, 159);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(273, 27);
            this.txtAge.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Yolcu Yaşı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cinsiyet:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(200, 201);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(273, 28);
            this.cmbGender.TabIndex = 27;
            // 
            // btnList2
            // 
            this.btnList2.Location = new System.Drawing.Point(723, 232);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(181, 48);
            this.btnList2.TabIndex = 28;
            this.btnList2.Text = "Ad Soyad Listele";
            this.btnList2.UseVisualStyleBackColor = true;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            // 
            // btnWomenPassengerList
            // 
            this.btnWomenPassengerList.Location = new System.Drawing.Point(723, 163);
            this.btnWomenPassengerList.Name = "btnWomenPassengerList";
            this.btnWomenPassengerList.Size = new System.Drawing.Size(181, 48);
            this.btnWomenPassengerList.TabIndex = 29;
            this.btnWomenPassengerList.Text = "Kadın Yolcular";
            this.btnWomenPassengerList.UseVisualStyleBackColor = true;
            this.btnWomenPassengerList.Click += new System.EventHandler(this.btnWomenPassengerList_Click);
            // 
            // btnMenPassengerList
            // 
            this.btnMenPassengerList.Location = new System.Drawing.Point(723, 91);
            this.btnMenPassengerList.Name = "btnMenPassengerList";
            this.btnMenPassengerList.Size = new System.Drawing.Size(181, 48);
            this.btnMenPassengerList.TabIndex = 30;
            this.btnMenPassengerList.Text = "Erkek Yolcular";
            this.btnMenPassengerList.UseVisualStyleBackColor = true;
            this.btnMenPassengerList.Click += new System.EventHandler(this.btnMenPassengerList_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(723, 25);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(181, 48);
            this.btnTotal.TabIndex = 31;
            this.btnTotal.Text = "Toplam Yolcular";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(951, 39);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 20);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "label 6";
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.Location = new System.Drawing.Point(951, 105);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(65, 20);
            this.lblMen.TabIndex = 33;
            this.lblMen.Text = "label 6";
            // 
            // lblWomen
            // 
            this.lblWomen.AutoSize = true;
            this.lblWomen.Location = new System.Drawing.Point(951, 177);
            this.lblWomen.Name = "lblWomen";
            this.lblWomen.Size = new System.Drawing.Size(65, 20);
            this.lblWomen.TabIndex = 34;
            this.lblWomen.Text = "label 6";
            // 
            // FrmPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 562);
            this.Controls.Add(this.lblWomen);
            this.Controls.Add(this.lblMen);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnMenPassengerList);
            this.Controls.Add(this.btnWomenPassengerList);
            this.Controls.Add(this.btnList2);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnİnsert);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPassenger";
            this.Text = "FrmPassenger";
            this.Load += new System.EventHandler(this.FrmPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnİnsert;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnList2;
        private System.Windows.Forms.Button btnWomenPassengerList;
        private System.Windows.Forms.Button btnMenPassengerList;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMen;
        private System.Windows.Forms.Label lblWomen;
    }
}