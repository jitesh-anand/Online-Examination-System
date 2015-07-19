using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class student_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int marks;
        Label3.Text = Request.QueryString["r"].ToString();
        Label5.Text = Request.QueryString["w"].ToString();
        Label7.Text = Request.QueryString["a"].ToString();
        Label9.Text = Request.QueryString["n"].ToString();
        marks = (int.Parse(Label3.Text)) * 10;
        Label11.Text = marks.ToString() + "%";
    }
}