using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;


public partial class Controls_ContactForm : System.Web.UI.UserControl
    
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\csdl.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    //{
    //    if (!string.IsNullOrEmpty(PhoneHome.Text) || !string.IsNullOrEmpty(TopicQuestions.Text))
    //    {
    //        args.IsValid = true;
    //    }
    //    else
    //    {
    //        args.IsValid = false;
    //    }
    //}
    protected void SendButton_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("INSERT INTO Phim VALUES ('" + Name.Text + "','" + EmailAddress.Text + "','" + PhoneHome.Text + "','" + TopicQuestions.Text + "','" + Comments.Text + "')", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        if (Page.IsValid)
        {
            Response.Write("<script>alert('Gửi thành công')</script>");
        }
        else
        {
            Response.Write("<script>alert('Gửi thất bại')</script>");
        }

        System.Threading.Thread.Sleep(1000);
    }
}