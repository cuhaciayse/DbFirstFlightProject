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
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }
        DbFlightEntities ent=new DbFlightEntities(); // Entities den nesne türettim
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ent.TblCity.ToList(); //nesneyi çağırttım tolist tüm verileri getirir
        }

        private void btnİnsert_Click(object sender, EventArgs e)
        {
            TblCity tblCity = new TblCity();
            tblCity.CityName = txtCityName.Text;
            tblCity.CityCountry = txtCountryName.Text;
            ent.TblCity.Add(tblCity);
            ent.SaveChanges();
            MessageBox.Show("Şehir başarılı bir şekilde kaydedildi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            var values = ent.TblCity.Where(x => x.CityID == id).FirstOrDefault(); //var bütün değişkenleri tutan global değişken firstordefault bu şartı sağlayan tek bir değeri getirmek için bu metotu kullanırız
            ent.TblCity.Remove(values);
        }

        private void btnSearchbyCity_Click(object sender, EventArgs e)
        {
            //var values = ent.TblCity.ToList();
            //dataGridView1.DataSource = values;   //şehire göre arattığımız tüm verileri listeler

            string cityName = txtCityName.Text;
            var values = ent.TblCity.Where(y => y.CityName == cityName).ToList();
            dataGridView1.DataSource = values;


            //var values = ent.TblCity.Where(y => y.CityName == txtCityName.Text).ToList();
            //dataGridView1.DataSource = values; 

            // illa yukarıdaki gibi değişken tanımlamamıza gerek yok bu şekilde de çalışır
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            var values = ent.TblCity.Where(x => x.CityID == id).FirstOrDefault();
            values.CityName = txtCityName.Text;
            values.CityCountry = txtCountryName.Text;
            ent.SaveChanges();
            MessageBox.Show("Bilgiler başarılı bir şekilde güncellendi");
        }
    }
}
