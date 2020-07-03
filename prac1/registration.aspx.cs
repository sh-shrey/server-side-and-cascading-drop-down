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
    public partial class registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["try_abc"].ConnectionString.ToString());
        
      

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            using (con)
            {
                SqlCommand cmd = new SqlCommand("studententry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                
                cmd.Parameters.AddWithValue("@username", TextBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@age", TextBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@email", TextBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@password", TextBox4.Text.ToString());
                string gender;
                if (RadioButton1.Checked)
                    gender = RadioButton1.Text;
                else
                    gender = RadioButton2.Text;

                cmd.Parameters.AddWithValue("@gender", gender);
                string hobby = string.Empty;

                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                        hobby += CheckBoxList1.Items[i].Value + ",";
                }

                cmd.Parameters.AddWithValue("@hobby", hobby);
                if (!FileUpload1.HasFile)
                {
                    Label2.Text = "pls insert image";
                }
                else
                {

                 string propic  = FileUpload1.PostedFile.FileName;
                    //Image2.ImageUrl= "~/images/1.JPG";

                    //Set the Image File Path.
                    string filePath = "~/images/" + propic;

                    //Save the Image File in Folder.
                    FileUpload1.PostedFile.SaveAs(Server.MapPath(filePath));

                    cmd.Parameters.AddWithValue("@image",filePath); 
                    Label2.Text = "file uploaded";
                    con.Open();

                    int c = cmd.ExecuteNonQuery();
                    con.Close();
                    if (c == 1)
                    {
                        Label1.Text = "";
                        Label1.ForeColor = System.Drawing.Color.Green;
                        Label1.Text = "succesfully inserted";
                    }


                }

            }


        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select* from registration where user_name='"+TextBox1.Text+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            TextBox1.Text = dt.Rows[0]["user_name"].ToString();
            TextBox2.Text = dt.Rows[0]["age"].ToString();
            TextBox3.Text = dt.Rows[0]["email"].ToString();
            TextBox4.Text = dt.Rows[0]["password"].ToString();
            TextBox5.Text = dt.Rows[0]["password"].ToString();
            RadioButton1.Text = dt.Rows[0]["gender"].ToString();
            CheckBoxList1.Text = dt.Rows[0]["hobby"].ToString();
            

            
            
             

        }

        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {
             
                

        }
    }
}