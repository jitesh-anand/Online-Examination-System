using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Web.Security;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string user = WebConfigurationManager.AppSettings["user"];
        string pass = WebConfigurationManager.AppSettings["pass"];
        if (user == Login1.UserName && pass == Login1.Password)
        {
            FormsAuthentication.RedirectFromLoginPage(user, Login1.RememberMeSet);
            Response.Redirect("admin/admin1.aspx");
        }
        else
        {
            Boolean ab = details.check(Login1.UserName,Login1.Password);
            if (ab)
            {
                FormsAuthentication.RedirectFromLoginPage(user, Login1.RememberMeSet);
                Response.Redirect("student/student1.aspx");
            }
        }
    }
}