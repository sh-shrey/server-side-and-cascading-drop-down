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
    public partial class serverside : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["try_abc"].ConnectionString.ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                register(con);
            }

        }
        public void register(SqlConnection con)
        {
            string q = "select* from registration";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);

            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "user_name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("--Select--", "0"));
            
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int r_id = Convert.ToInt32(DropDownList1.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter("select * from registration where Id=" + r_id, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);

            TextBox2.Text = dt.Rows[0]["age"].ToString();
            
            TextBox3.Text = dt.Rows[0]["email"].ToString();
            
            TextBox4.Text = dt.Rows[0]["password"].ToString();

            
            RadioButton1.Text = dt.Rows[0]["gender"].ToString();
            TextBox6.Text = dt.Rows[0]["hobby"].ToString();
            Image1.ImageUrl = dt.Rows[0]["image"].ToString();
        }
    }
}