using BITool16550.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITool16550
{
    public partial class Form1 : Form
    {
        private StudenService _studenService;
        public Form1()
        {
            InitializeComponent();
            _studenService = new StudenService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegStudButton_Click(object sender, EventArgs e)
        {
            if (ForenameTxtBox.TextLength > 0 && SurnameTxtBox.TextLength > 0 && MobileTxtBox.TextLength >0)
            {
                AddEmployee();
            }
            else
            {
                MessageBox.Show("Please enter correct details");
            }

        }

        private void AddEmployee()
        {
            Student student = new Student();
            student.Forename = ForenameTxtBox.Text;
            student.Surname = SurnameTxtBox.Text;
            student.Mobile = MobileTxtBox.Text;
            student.DOB = dateTimePicker1.Value;
            if (CampusChkBox.Checked)
            {
                student.Campus = true;
            }
            if (VaccChckBox.Checked)
            {
                student.Vaccination = true;
            }
            _studenService.Save(student);
            MessageBox.Show($"You enter a new Student {student.Forename} {student.Surname}");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
