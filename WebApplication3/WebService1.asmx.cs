using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using QueryGenerator;
using Bunifu;
using System.Windows.Forms;

namespace WebApplication3
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    { 
        QueryGenerator.Form1 data = new QueryGenerator.Form1();
        [WebMethod]
        public DataTable Get()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [CRONUS Sverige AB$Employee], [CRONUS Sverige AB$Employee Absence],[CRONUS Sverige AB$Employee Portal Setup],[CRONUS Sverige AB$EmployeeQualification], [CRONUS Sverige AB$Employee Relative], [CRONUS Sverige AB$Employee Statistics Group], [CRONUS Sverige AB$Warehouse Employee]"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Uppgift 1";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        [WebMethod]
        public DataTable Get1()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [CRONUS Sverige AB$Employee], [CRONUS Sverige AB$Employee Relative] where [Employee No_] = No_"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Uppgift 2";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        [WebMethod]
        public DataTable Get2()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [CRONUS Sverige AB$Employee Absence], [CRONUS Sverige AB$Employee] where [Employee No_] = No_ and [From Date] like '%2004%'"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Uppgift 3";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        [WebMethod]
        public DataTable Get3()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT [First Name], count(*)  as 'Sickdays' FROM [CRONUS Sverige AB$Employee Absence], [CRONUS Sverige AB$Employee] where [Employee No_] = No_  group by [First Name] Order by COUNT(*) DESC"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Uppgift 4";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        [WebMethod]
        public DataTable Get4()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT OBJECT_NAME (OBJECT_ID) AS NameofConstraint, SCHEMA_NAME (schema_id) AS SchemaName,OBJECT_NAME (parent_object_id) AS TableName,type_desc AS ConstraintType FROM sys.objects WHERE type_desc IN ('FOREIGN_KEY_CONSTRAINT', 'PRIMARY_KEY_CONSTRAINT')GO"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Uppgift 5";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        [WebMethod]
        public DataTable Get5()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT so.name AS TableName, si.name AS IndexName, si.type_desc AS IndexType FROM sys.indexes si JOIN sys.objects so ON si.[object_id] = so.[object_id] WHERE so.type = 'U'--Only get indexes for User Created Tables AND si.name IS NOT NULL ORDER BY so.name, si.type"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Uppgift 6";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        [WebMethod]
        public DataTable Get6()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TableName = t.Name, ColumnName = c.Name, dc.Name, dc.definition FROM sys.tables t INNER JOIN sys.default_constraints dc ON t.object_id = dc.parent_object_id INNER JOIN sys.columns c ON dc.parent_object_id = c.object_id AND c.column_id = dc.parent_column_id ORDER BY t.Name"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Uppgift 7";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        [WebMethod]
        public DataTable Get7()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Uppgift 8";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        [WebMethod]
        public DataTable Get8()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [CRONUS Sverige AB$Employee]"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Uppgift 9";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        [WebMethod]
        public DataTable findupdateemployee()
        {
            string upnr = data.FindSSN.Text;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT first_name, last_name, job_title, adress FROM [CRONUS Sverige AB$Employee] WHERE No_ = " + upnr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Employee";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        [WebMethod]
        public void DeleteEmploye()
        {
            string delnr = data.FindSSN2.Text;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE * FROM[CRONUS Sverige AB$Employee] where No_ =" + delnr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                    }
                }
            }
        }

        [WebMethod]
        public void addemployee()
        {
            string sosnr = data.AddSSN.Text;
            string name = data.AddFirstName.Text;
            string adress = data.AddAdress.Text;
            string lastname = data.AddLasName.Text;
            string worktitle = data.AddWorkTitle.Text;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [CRONUS Sverige AB$Employee](No_, First_name, last_name, adress, work_title) VALUES (" + sosnr +"," + name + "," + lastname + "," +adress + "," + worktitle +")" ))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                    }
                }
            }
        }

        [WebMethod]
        public void updateemployee()
        {
            string sosnr = data.FindSSN.Text;
            string name = data.UpdateFirstName.Text;
            string adress = data.UpdateAdress.Text;
            string lastname = data.UpdateLastName.Text;
            string worktitle = data.UpdateWorkTitle.Text;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE [CRONUS Sverige AB$Employee] SET first_name = " + name + ", last_name =" + lastname +", adress =" + adress + ", work_title = " + worktitle +"WHERE No_ =" + sosnr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                    }
                }
            }
        }

        [WebMethod]
        public DataTable FindEmployee()
        {
            string sosnr = data.FindSSN2.Text;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM[CRONUS Sverige AB$Employee] where No_ =" + sosnr))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())

                        {

                            dt.TableName = "Employee";
                            sda.Fill(dt);
                            return dt;

                        }
                    }
                }
            }
        }
    }
}