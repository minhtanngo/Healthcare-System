using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;


namespace WebApplication1
{
    public partial class Healthcare_Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Khai bao ket noi toi MS SQL Server
            SqlConnection con = new SqlConnection("server=DESKTOP-SG1DHTO\\SQLEXPRESS;database=HeathcareProject;Integrated security = true;");

            //Thuc thi cau query
            SqlDataAdapter da = new SqlDataAdapter("select * from BENHNHAN", con);

            //Tao mot bảng ảo
            DataTable tb = new DataTable();
            da.Fill(tb);

            //Ném data vào gridview
            GridView1.DataSource = tb;
            GridView1.DataBind();
        }
    }
}