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
        }

        private void MinimizeButton1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton1(object sender, EventArgs e)
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
            string ssn = AddSSN.Text;
            string firstname = AddFirstName.Text;
            string adress = AddAdress.Text;
            string lastname = AddLasName.Text;
            string worktitle = AddWorkTitle.Text;
            service.addemployee(ssn, firstname, adress, lastname, worktitle);
        }

        private void FindUpdateButton(object sender, EventArgs e)
        {
            string upnr = FindSSN.Text;
            dataGridView3.DataSource = service.findupdateemployee(upnr);
        }

        private void FindDeleteButton(object sender, EventArgs e)
        {
            string load = FindSSN2.Text;
            dataGridView2.DataSource = service.FindEmployee(load);
        }

        private void UpdateUpdateButton(object sender, EventArgs e)
        {
            string ssn = FindSSN.Text;
            string ufirstname = UpdateFirstName.Text;
            string uadress = UpdateAdress.Text;
            string ulastname = UpdateLastName.Text;
            string uworktitle = UpdateWorkTitle.Text;
            service.updateemployee(ssn, ufirstname, uadress, ulastname, uworktitle);
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

        private void MinimizeButton2(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton2(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Close();

        }

        private void MinimizeButton3(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton3(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Close();
        }

        private void MinimizeButton4(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton4(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get1();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get1();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get2();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get3();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get4();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get5();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get6();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get7();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get8();
        }
    }
}
