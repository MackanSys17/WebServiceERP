using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication3.ServiceReference1;

namespace QueryGenerator
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        WebService2SoapClient service = new WebService2SoapClient();

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
            service.AddEmployee(ssn, firstname, adress, lastname, worktitle);
        }

        private void FindUpdateButton(object sender, EventArgs e)
        {
            string upnr = FindSSN.Text;
            dataGridView3.DataSource = service.FindEmployee(upnr);
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
            service.UpdateEmployee(ssn, ufirstname, uadress, ulastname, uworktitle);
        }

        private void DeleteDeleteButton(object sender, EventArgs e)
        {
            string load = FindSSN2.Text;
            service.DeleteEmploye(load);
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

        private void TaskButton1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get();
        }

        private void TaskButton2(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get1();
        }

        private void TaskButton3(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get2();
        }

        private void TaskButton4(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get3();
        }

        private void TaskButton5(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get4();
        }

        private void TaskButton6(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get5();
        }

        private void TaskButton7(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get6();
        }

        private void TaskButton8(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get7();
        }

        private void TaskButton9(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.Get8();
        }
    }
}
