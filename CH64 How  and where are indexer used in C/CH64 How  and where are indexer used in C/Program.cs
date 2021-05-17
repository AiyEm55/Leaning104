using System;
using System.Data.sqlClient;
using System.Configuration;
namespace CH64_How__and_where_are_indexer_used_in_C
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(Object sender, EventArgs e)
        {
            String CS = ConfigurationManager.ConnectionString["DBCS"].ConnectionString;
            using (SqlConnnection con = new SqlConnnection(CS())
            {
                SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
            con.oped();
            SqlDataReader rdr = cmd.ExecueReader();
            while (rdr.Read())
            {
                Response.Write("Id = " + rdr[0].ToString() + " ");
                Response.Write("Name = " + rdr["Name"].ToString());
                Response.Write("<br/>");
            }
            
        }
    }
}
