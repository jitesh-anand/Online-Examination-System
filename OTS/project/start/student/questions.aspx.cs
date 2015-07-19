using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

public partial class student_Default : System.Web.UI.Page
{

    DataTable dt;
    int i { get; set; }
    SqlDataAdapter sda;
    SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            i = -1;
            if (!IsPostBack)
            {
                Session["ind"] = i;
                dt = new DataTable();
                DataColumn userans = new DataColumn("UserAns");
                userans.DefaultValue = "";
                dt.Columns.Add(userans);
                //string ch = Request.QueryString["examname"];
               // ViewState["ch"] = ch;
                con = new SqlConnection();
                con.ConnectionString = "Data Source = JITESH; Initial Catalog = OTS ;Integrated Security=true";
                //con.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                con.Open();
                //choose(ch);
                sda = new SqlDataAdapter("select * from qtabel1", con);
                sda.Fill(dt);
                Session["ds"] = dt;
                con.Close();
                FetchQANext();
            }
        }
        catch (Exception e1)
        {
            Console.WriteLine(e1.Message);
        }
    }


    /*private void choose(string s)
    {
        switch (s)
        {
            case "Cpp":
                {
                    sda = new SqlDataAdapter("SELECT * FROM  Cpp", con);
                }
                break;

            case "DS":
                {
                    sda = new SqlDataAdapter("SELECT * FROM  DS", con);
                }
                break;

            case "Java":
                {
                    sda = new SqlDataAdapter("SELECT * FROM  JAVA", con);
                }
                break;

            case "DotNet":
                {
                    sda = new SqlDataAdapter("SELECT * FROM  DotNET", con);
                }
                break;

            case "DBMS":
                {
                    sda = new SqlDataAdapter("SELECT * FROM  DBMS", con);
                }
                break;
        }

    }*/


    private void FetchQANext()
    {

        i = (int)Session["ind"];
        if (i <= 28)
        {
            i = i + 1;
            dt = (DataTable)Session["ds"];
            DataRow dr = dt.Rows[i];
            userans(dt, i);
            Qno.Text = dr["qno"].ToString();
            QD.Text = dr["que"].ToString();
            A.Text = dr["opA"].ToString();
            B.Text = dr["opB"].ToString();
            C.Text = dr["opC"].ToString();
            D.Text = dr["opD"].ToString();

            Session["ind"] = i;
        }

    }

    private void FetchQAPrevious()
    {


        i = (int)Session["ind"];
        if (i >= 1)
        {
            i = i - 1;

            dt = (DataTable)Session["ds"];
            userans(dt, i);
            DataRow dr = dt.Rows[i];
            Qno.Text = dr["qno"].ToString();
            QD.Text = dr["que"].ToString();
            A.Text = dr["opA"].ToString();
            B.Text = dr["opB"].ToString();
            C.Text = dr["opC"].ToString();
            D.Text = dr["opD"].ToString();

            Session["ind"] = i;
        }

    }

    private void FetchQAFirst()
    {
        i = 0;

        dt = (DataTable)Session["ds"];
        DataRow dr = dt.Rows[i];
        Qno.Text = dr["qno"].ToString();
        QD.Text = dr["que"].ToString();
        A.Text = dr["opA"].ToString();
        B.Text = dr["opB"].ToString();
        C.Text = dr["opC"].ToString();
        D.Text = dr["opD"].ToString();

        Session["ind"] = i;

    }
    private void FetchQALast()
    {
        i = 29;
        dt = (DataTable)Session["ds"];
        DataRow dr = dt.Rows[i];
        Qno.Text = dr["qno"].ToString();
        QD.Text = dr["que"].ToString();
        A.Text = dr["opA"].ToString();
        B.Text = dr["opB"].ToString();
        C.Text = dr["opC"].ToString();
        D.Text = dr["opD"].ToString();

        Session["ind"] = i;

    }

    private void clearRadio()
    {
        A.Checked = false;
        C.Checked = false;
        B.Checked = false;
        D.Checked = false;
        // CheckBox1.Checked = false;
    }

    private void chk_Change(DataTable dt, int i, string op)
    {
        DataRow dr = dt.Rows[i];
        dr["UserAns"] = op;
    }

    private void userans(DataTable dt, int i)
    {
        clearRadio();


        // i = (int)ViewState["ind"];
        // if (i <= 9)
        //{
        DataRow dr = dt.Rows[i];

        if (dr["UserAns"] == "")
        {
        }
        else
        {
            if (dr["UserAns"].ToString() == "A")
            {
                A.Checked = true;
            }

            if (dr["UserAns"].ToString() == "B")
            {
                B.Checked = true;
            }

            if (dr["UserAns"].ToString() == "C")
            {
                C.Checked = true;
            }

            if (dr["UserAns"].ToString() == "D")
            {
                D.Checked = true;
            }
        }
        // Qno.Text = dr["Ques_Id"].ToString();
        // QD.Text = dr["Question"].ToString();
        // A.Text = dr["option_A"].ToString();
        // B.Text = dr["option_B"].ToString();
        // C.Text = dr["option_C"].ToString();
        // D.Text = dr["option_D"].ToString();
        // i = i + 1;
        //Label3.Text = i.ToString();
        // }

        //if (A.Checked == true)
        //{ }

        //if (B.Checked == true)
        //{ }

        //if (C.Checked == true)
        //{ }

        //if (D.Checked == true)
        //{ }



    }


    protected void Button6_Click(object sender, EventArgs e)
    {


        FetchQANext();

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        FetchQAPrevious();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        FetchQAFirst();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {

        FetchQALast();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        clearRadio();
        int x;
        Button b = (Button)sender;

        x = int.Parse(b.Text);
        i = x - 1;
        dt = (DataTable)Session["ds"];
        DataRow dr = dt.Rows[i];
        Qno.Text = dr["qno"].ToString();
        QD.Text = dr["que"].ToString();
        A.Text = dr["opA"].ToString();
        B.Text = dr["opB"].ToString();
        C.Text = dr["opC"].ToString();
        D.Text = dr["opD"].ToString();

        // Session["ind"] = i;
        userans(dt, i);

        Session["ind"] = i;


    }

    private Button findbutton(int i)
    {
        Button b = null;
        if (i == 0)
        {
            b = Button1;
        }

        if (i == 1)
        {
            b = Button2;
        }

        if (i == 2)
        {
            b = Button9;
        }

        if (i == 3)
        {
            b = Button8;
        }

        if (i == 4)
        {
            b = Button10;
        }

        if (i == 5)
        {
            b = Button11;
        }

        if (i == 6)
        {
            b = Button12;
        }

        if (i == 7)
        {
            b = Button13;
        }

        if (i == 8)
        {
            b = Button14;
        }

        if (i == 9)
        {
            b = Button15;
        }
        if (i == 10)
        {
            b = Button16;
        }
        if (i == 11)
        {
            b = Button17;
        }
        if (i == 12)
        {
            b = Button18;
        }
        if (i == 13)
        {
            b = Button19;
        }
        if (i == 14)
        {
            b = Button20;
        }
        if (i == 15)
        {
            b = Button21;
        }
        if (i == 16)
        {
            b = Button22;
        }
        if (i == 17)
        {
            b = Button23;
        }
        if (i == 18)
        {
            b = Button24;
        }
        if (i == 19)
        {
            b = Button25;
        }
        if (i == 20)
        {
            b = Button26;
        }
        if (i == 21)
        {
            b = Button27;
        }
        if (i == 22)
        {
            b = Button28;
        }
        if (i == 23)
        {
            b = Button29;
        }
        if (i == 24)
        {
            b = Button30;
        }
        if (i == 25)
        {
            b = Button31;
        }
        if (i == 26)
        {
            b = Button32;
        }
        if (i == 27)
        {
            b = Button33;
        }
        if (i == 28)
        {
            b = Button34;
        }
        if (i == 29)
        {
            b = Button35;
        }

        return b;
    }

    protected void EndExamResult()
    {
        int rightcount = 0;
        int wrongCount = 0;
        int attempt = 0;
        int notattempt = 0;
        dt = (DataTable)Session["ds"];
        foreach (DataRow dr in dt.Rows)
        {
            if (dr["UserAns"] != "")
            {
                attempt = attempt + 1;

                if (dr["UserAns"].ToString().ToUpper() == dr["correct"].ToString().ToUpper())
                {
                    rightcount = rightcount + 1;
                }
                else
                {
                    wrongCount = wrongCount + 1;
                }
            }
            else
            {
                notattempt = notattempt + 1;
            }
        }

        //  ViewState["rightcount"] = rightcount;
        // ViewState["wrongcount"] = wrongCount;
        // ViewState["attempt"] = attempt;
        // ViewState["notattempt"] = notattempt;
        string rd = "Result.aspx?r=" + rightcount + "&w=" + wrongCount + "&a=" + attempt + "&n=" + notattempt;//check again
        Server.Transfer(rd);
    }

    protected void A_CheckedChanged(object sender, EventArgs e)
    {
        i = (int)Session["ind"];
        dt = (DataTable)Session["ds"];
        chk_Change(dt, i, "A");

        Button btnObj = findbutton(i);

        btnObj.BackColor = System.Drawing.Color.Yellow;

    }
    protected void B_CheckedChanged(object sender, EventArgs e)
    {
        i = (int)Session["ind"];
        dt = (DataTable)Session["ds"];
        chk_Change(dt, i, "B");

        Button btnObj = findbutton(i);

        btnObj.BackColor = System.Drawing.Color.Yellow;
    }
    protected void C_CheckedChanged(object sender, EventArgs e)
    {
        i = (int)Session["ind"];
        dt = (DataTable)Session["ds"];
        chk_Change(dt, i, "C");

        Button btnObj = findbutton(i);

        btnObj.BackColor = System.Drawing.Color.Yellow;
    }
    protected void D_CheckedChanged(object sender, EventArgs e)
    {
        i = (int)Session["ind"];
        dt = (DataTable)Session["ds"];
        chk_Change(dt, i, "D");

        Button btnObj = findbutton(i);
        btnObj.BackColor = System.Drawing.Color.Yellow;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        EndExamResult();
    }
    /*  protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
      {
          if (CheckBox1.Checked == true)
          {
              i = (int)ViewState["ind"];
              Button btnObj = findbutton(i);
              btnObj.BackColor = System.Drawing.Color.Green;
          }
          else
          {
              i = (int)ViewState["ind"];
              Button btnObj = findbutton(i);
              btnObj.BackColor = System.Drawing.Color.White;

          }
      }*/
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        Label3.Text = TimeEvent.time_count();

        if (Label3.Text == "1:0")
        {
            Timer1.Enabled = false;
            Response.Write("<script>alert('You have only 1 Minute Left')</script>");
            Timer1.Enabled = true;
        }

        if (Label3.Text == "0:0")
        {
            EndExamResult();
        }
    }
}