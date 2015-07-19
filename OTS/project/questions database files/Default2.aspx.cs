using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        level2 obj = new level2 { qno = int.Parse(TextBox1.Text), que = TextBox2.Text, opA = TextBox3.Text, opB = TextBox4.Text, opC = TextBox5.Text, opD = TextBox6.Text, correct = TextBox7.Text };
        int res = level2.insert(obj);
        if (res > 0)
        {
            Response.Write("<script>alert(' question is inserted successfully ')</script>");
        }
        else
        {
            Response.Write("<script>alert(' question insertion is unsuccessfull ')</script>");
        }
    }
}