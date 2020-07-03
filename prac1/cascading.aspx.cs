using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace prac1
{
    public partial class cascading : System.Web.UI.Page
    {
        private SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\visual basics practical\prac1\prac1\App_Data\Database2.mdf;Integrated Security = True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindcountryList(conn);
            }
        }
        public void BindcountryList(SqlConnection conn)
        {
            string q = "select* from country";
            SqlDataAdapter da = new SqlDataAdapter(q, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);

            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "country_name";
            DropDownList1.DataValueField = "c_id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("--Select--", "0"));
            DropDownList2.Items.Insert(0, new ListItem("--Select--", "0"));
            DropDownList3.Items.Insert(0, new ListItem("--Select--", "0"));

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Countryid = Convert.ToInt32(DropDownList1.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter("select * from state where c_id=" + Countryid, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);

            DropDownList2.DataSource = dt;
            DropDownList2.DataTextField = "state_name";
            DropDownList2.DataValueField = "s_id";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem("--Select--", "0"));

        }
       
        protected void DropDownList2_SelectedIndexChanged1(object sender, EventArgs e)
        {
            int s_id = Convert.ToInt32(DropDownList2.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter("select * from city where s_id =" + s_id, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);

            DropDownList3.DataSource = ds;
            DropDownList3.DataTextField = "city_name";
            DropDownList3.DataValueField = "ci_id";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, new ListItem("--Select--", "0"));

        }

        protected void DropDownList3_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}