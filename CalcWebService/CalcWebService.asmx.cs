using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcWebService
{
    /// <summary>
    /// Summary description for CalcWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public int Add(int start, int amount)
        {
            return start + amount;
        }

        [WebMethod]
        public int Divide(int start, int by)
        {
            if (by == 0)
            {
                throw new ArgumentException("Cannot divide by zero!");
            }
            return start / by;
        }

        [WebMethod]
        public int Multiply(int start, int by)
        {
            return start * by;
        }

        [WebMethod]
        public int Subtract(int start, int amount)
        {
            return start - amount;
        }
    }
}
