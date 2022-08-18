using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFirstFlightProject.Model;


namespace DbFirstFlightProject
{
    public partial class FrmPassenger : Form
    {
        public FrmPassenger()
        {
            InitializeComponent();
        }
        DbFlightEntities ent = new DbFlightEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = ent.TblPassenger.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = (from x in ent.TblPassenger
                          select new
                          {
                              x.PassengerName,
                              x.PassengerSurname
                          }).ToList();
            dataGridView1.DataSource = values;  //x üzerinden values e veri atıyorum 
        }

        private void btnMenPassengerList_Click(object sender, EventArgs e)
        {
            var values = ent.TblPassenger.Where(x => x.PassengerGender == "Erkek").ToList();
            dataGridView1.DataSource = values;
        }

        private void btnWomenPassengerList_Click(object sender, EventArgs e)
        {
            var values = ent.TblPassenger.Where(x => x.PassengerGender == "Kadın");
            dataGridView1.DataSource = values.ToList();
        }

        private void FrmPassenger_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Add("Kadın");
            cmbGender.Items.Add("Erkek");
            cmbGender.DropDownStyle=ComboBoxStyle.DropDownList; //comboboxa duşarıdan veri girmek yerine kodlar girdirdim

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            var totalCountPassengers = ent.TblPassenger.Count(); //toplam yolcu sayısı
            lblTotal.Text="Toplam Yolcu Sayısı:"+ totalCountPassengers.ToString();

            var totalWomenPassenger = ent.TblPassenger.Where(x =>x.PassengerGender=="Kadın").Count();
            lblWomen.Text = "Toplam Kadın Yolcu Sayısı:" + totalWomenPassenger.ToString();

            var totalMenPassenger = ent.TblPassenger.Where(y => y.PassengerGender == "Erkek").Count();
            lblMen.Text = "Toplam Erkek Yolcu Sayısı:" + totalMenPassenger; 
            // yukarıda ToString yapmadık eğer bir satırda ToString varsa yani kadın sayısını çağırırken yapmıştık bir daha yapmamıza gerek kalmıyor ama yapadabiliriz


        }

        private void btnİnsert_Click(object sender, EventArgs e)
        {
            TblPassenger tblPassenger = new TblPassenger();   //TblPassenger bir sınıf 
            tblPassenger.PassengerName = txtName.Text;
            tblPassenger.PassengerSurname = txtSurname.Text;
            tblPassenger.PassengerAge=txtAge.Text;
            tblPassenger.PassengerGender = cmbGender.Text;
            ent.TblPassenger.Add(tblPassenger); //ent bütün Entityleri tutuyor
            ent.SaveChanges();
            MessageBox.Show("Yolcu eklendi");
        }
    }
}
