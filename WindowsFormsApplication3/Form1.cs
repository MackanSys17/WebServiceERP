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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel1.Visible = true;
            panel1.Refresh();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point (96, 0);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel4.Visible = true;
            panel4.Location = new Point(96, 0);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
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
    }
    }
