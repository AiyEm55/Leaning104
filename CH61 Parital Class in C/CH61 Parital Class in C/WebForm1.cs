using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CH61_Parital_Class_in_C
{
    public partial class WebForm1 : System.Web.IU.Page
    {
        protected void Page_Laod(object sender, EventArgs e)
        {
            Customer C1 = new Customer();
            C1.FirstName = "Program";
            C1.LastName = "Techonology";
            string FullName1 = C1.GetFullName();
            Response.Write("Full Name = " + FullName1 + "<br/>");

            PartialCustomer C2 = new PartialCustomer();
            C2.FirstName = "Program";
            C2.LastName = "Tech";
            string FullName1 = C2.GetFullName();
            Response.Write((FullName2 + "<br/>");
    }
    }
}
