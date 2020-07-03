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
    public partial class gridview : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["try_abc"].ConnectionString.ToString());

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void checked_changes(object sender, EventArgs e)
        {
            Label1.Text = "<br/>";
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkrow = (row.Cells[0].FindControl("CheckBox1") as CheckBox);
                    if (chkrow.Checked == true)
                    {
                        Label1.Text += "<br/> id -" + row.Cells[1].Text;
                        Label1.Text += "<br/> name -" + row.Cells[2].Text;
                        Label1.Text += "<br/> age -" + row.Cells[3].Text;
                        Label1.Text += "<br/> emailid -" + row.Cells[4].Text;
                        Label1.Text += "<br/> password -" + row.Cells[5].Text;
                        Label1.Text += "<br/> gender -" + row.Cells[6].Text;
                        Label1.Text += "<br/> hobby -" + row.Cells[7].Text;



                    }

                }
            }


        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "<br/>";
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkrow = (row.Cells[0].FindControl("CheckBox1") as CheckBox);
                    if (chkrow.Checked == true)
                    {
                        Label1.Text += "<br/> id -" + row.Cells[1].Text;
                        Label1.Text += "<br/> name -" + row.Cells[2].Text;
                        Label1.Text += "<br/> age -" + row.Cells[3].Text;
                        Label1.Text += "<br/> emailid -" + row.Cells[4].Text;
                        Label1.Text += "<br/> password -" + row.Cells[5].Text;
                        Label1.Text += "<br/> gender -" + row.Cells[6].Text;
                        Label1.Text += "<br/> hobby -" + row.Cells[7].Text;
                        Image img = (row.Cells[8].FindControl("Image1") as Image);
                        Image2.ImageUrl = img.ImageUrl.ToString();




                    }
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkrow = (row.Cells[0].FindControl("CheckBox1") as CheckBox);
                    if (chkrow.Checked == true)
                    {
                        TextBox7.Text = row.Cells[1].Text;
                        TextBox8.Text = row.Cells[2].Text;
                        TextBox9.Text = row.Cells[3].Text;
                        TextBox10.Text = row.Cells[4].Text;
                        TextBox11.Text = row.Cells[5].Text;
                        TextBox12.Text = row.Cells[6].Text;
                        TextBox13.Text = row.Cells[7].Text;

                        Image img = (row.Cells[8].FindControl("Image1") as Image);
                        Image2.ImageUrl = img.ImageUrl.ToString();


                    }




                }
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("studententry", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            
                        cmd.Parameters.AddWithValue("@Id", TextBox7.Text.ToString());
                        cmd.Parameters.AddWithValue("@username", TextBox8.Text.ToString());
                        cmd.Parameters.AddWithValue("@age", TextBox9.Text.ToString());
                        cmd.Parameters.AddWithValue("@email", TextBox10.Text.ToString());
                        cmd.Parameters.AddWithValue("@password", TextBox11.Text.ToString());
                        cmd.Parameters.AddWithValue("@gender", TextBox12.Text.ToString());
                        cmd.Parameters.AddWithValue("@hobby", TextBox13.Text.ToString());
                        string propic = FileUpload1.PostedFile.FileName;
                        //Image2.ImageUrl= "~/images/1.JPG";

                        //Set the Image File Path.
                        string filePath = "~/images/" + propic;

                        //Save the Image File in Folder.
                        FileUpload1.PostedFile.SaveAs(Server.MapPath(filePath));

                        cmd.Parameters.AddWithValue("@propic", filePath);

                        con.Open();

                        int c = cmd.ExecuteNonQuery();
                        con.Close();
                        if (c == 1)
                        {
                            Label2.Text = "";
                            Label2.ForeColor = System.Drawing.Color.Green;
                            Label2.Text = "succesfully updated";
                        }



                    }


                }
            }
       
    
