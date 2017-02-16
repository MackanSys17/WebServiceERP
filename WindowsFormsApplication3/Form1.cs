using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QueryGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WindowsFormsApplication3.localhost.WebService1 service = new WindowsFormsApplication3.localhost.WebService1();

        private void DropDownMenu(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (bunifuDropdown1.Items.Contains("1 MetaData for employees and relative tables"))
            {
                dataGridView1.DataSource = service.Get();
            }
            else if (bunifuDropdown1.Items.Contains("2 Employees and relatives"))
            {
                dataGridView1.DataSource = service.Get1();
            }
        }
    }
    }
