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

namespace DbFirstFlightProject.Model
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        DbFlightEntities ent = new DbFlightEntities(); // ent nesnesi türettim Entitesleri çağırmak için
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = from x in ent.TblEmployee
                         select new
                         {
                            ID= x.EmployeeID,          //Employee ID yazdırmak yerine ID yazdırabilirim böyke yapınca
                            Personel_Adı= x.EmployeeName,
                            Personel_Departman= x.EmployeeDepartment,
                            Maaş=x.EmployeeSalary
                         };
            dataGridView1.DataSource = values.ToList();

        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentID";
            cmbDepartment.DataSource = ent.TblDepartment.ToList();
        }

        private void btnİnsert_Click(object sender, EventArgs e)
        {
            TblEmployee tblEmployee = new TblEmployee();
            tblEmployee.EmployeeName = txtPerName.Text;
            tblEmployee.EmployeeDepartment = int.Parse(cmbDepartment.SelectedValue.ToString());
            ent.TblEmployee.Add(tblEmployee);
            ent.SaveChanges();
            MessageBox.Show("Eklendi");
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            var totalEmployeeCount = ent.TblEmployee.Count();
            lblTotelEmployee.Text=totalEmployeeCount.ToString();    

            var totalSalary = ent.TblEmployee.Sum(x => x.EmployeeSalary);
            lblSumSalary.Text = totalSalary.ToString();

            var avgSalary = ent.TblEmployee.Average(x => x.EmployeeSalary);
            lblAvgSalary.Text = avgSalary.ToString();

            var maxSalary = ent.TblEmployee.Max(x => x.EmployeeSalary);
            lblMaxSalaryEmployee.Text = maxSalary.ToString();

            var maxHaveSalary = ent.TblEmployee.Max(x => x.EmployeeSalary);
            lblMaxSalaryEmployee.Text = ent.TblEmployee.Where(x => x.EmployeeSalary == maxHaveSalary).FirstOrDefault().EmployeeName; 
        }
    }
}
