﻿using System;
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

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void DropDownMenu(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadTableButton(object sender, EventArgs e)
        {
            if (bunifuDropdown1.Items.Contains("1 MetaData for employees and relative tables"))
            {
                dataGridView1.DataSource = service.Get();
            }
            else if (bunifuDropdown1.Items.Contains("2 Employees and relatives"))
            {
                dataGridView1.DataSource = service.Get1();
            }
            else if (bunifuDropdown1.Items.Contains("3 Employees with most sickdays 2004"))
            {
                dataGridView1.DataSource = service.Get2();
            }
            else if (bunifuDropdown1.Items.Contains("4 Employee with most sickdays"))
                {
                dataGridView1.DataSource = service.Get3();
                }
            else if (bunifuDropdown1.Items.Contains("5 All Keys"))
            {
                dataGridView1.DataSource = service.Get4();
            }
            else if (bunifuDropdown1.Items.Contains("6 All indexes"))
            {
                dataGridView1.DataSource = service.Get5();
            }
            else if (bunifuDropdown1.Items.Contains("7 All table constraints"))
            {
                dataGridView1.DataSource = service.Get6();
            }
            else if (bunifuDropdown1.Items.Contains("8 All tables"))
            {
                dataGridView1.DataSource = service.Get7();
            }
            else if (bunifuDropdown1.Items.Contains("9 All columns from Employee"))
            {
                dataGridView1.DataSource = service.Get8();
            }
        }

        private void MinimizeButton(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectButton(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel1.Visible = true;
            panel1.Refresh();
        }

        private void AddButton(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point (96, 0);
        }

        private void UpdateButton(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel4.Visible = true;
            panel4.Location = new Point(96, 0);
        }

        private void deleteButton(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel5.Location = new Point(96, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddEmployeeButton(object sender, EventArgs e)
        {
            service.addemployee();
        }

        private void FindUpdateButton(object sender, EventArgs e)
        {

        }

        private void FindDeleteButton(object sender, EventArgs e)
        {
            dataGridView2.DataSource = service.FindEmpoyee();
        }

        private void UpdateUpdateButton(object sender, EventArgs e)
        {
            service.updateemployee();
        }

        private void DeleteDeleteButton(object sender, EventArgs e)
        {
            service.DeleteEmploye();
        }

        private void DeleteEmployeeDataGrid(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdatePanel(object sender, PaintEventArgs e)
        {

        }

        private void DeletePanel(object sender, PaintEventArgs e)
        {

        }

        private void No_Update(object sender, EventArgs e)
        {

        }

        public void No_Delete(object sender, EventArgs e)
        {
        }
    }
}
