using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            string sexd = RadioButton1.Checked ? "Male" : "Female";
            details d = new details { fname = TextBox1.Text, lname = TextBox2.Text, age = int.Parse(TextBox3.Text), sex = sexd, dob = Calendar1.SelectedDate, qual = DropDownList1.SelectedValue, email = TextBox4.Text, pass = TextBox6.Text };
            int res = details.insert(d);
            if (res > 0)
            {
                Response.Write("<script>alert('Registered Successfully')</script>");
            }
            else
            {
                Response.Write("<script>alert('ERROR!!! Try Again')</script>");
            }
        }
        else {
            Response.Write("<script>alert('Must abide all the rules')</script>");
        }
    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox7.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Calendar1.Visible == true)
        {
            TextBox7.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }
        else
        {
            Calendar1.Visible = true;
        }
    }
} 