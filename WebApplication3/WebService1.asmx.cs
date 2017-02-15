using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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

        [WebMethod]
        public string GetCustomer(string memberID)
        {
            string response = "<p>No customer selected</p>";
            string connect = "Server=myserver;Initial Catalog=mydatabase;uid=myuser;pwd=mypassword";
            string query = "SELECT * FROM [CRONUS Sverige AB$Employee], [CRONUS Sverige AB$Employee Absence], [CRONUS Sverige AB$Employee Portal Setup],[CRONUS Sverige AB$EmployeeQualification], [CRONUS Sverige AB$Employee Relative], [CRONUS Sverige AB$Employee Statistics Group], [CRONUS Sverige AB$Warehouse Employee]";

            return response;
        }
    }
}
