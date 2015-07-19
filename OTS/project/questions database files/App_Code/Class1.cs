using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Class1
/// </summary>
public class level1
{

    public int qno { get; set; }
    public string que { get; set; }
    public string opA { get; set; }
    public string opB { get; set; }
    public string opC { get; set; }
    public string opD { get; set; }
    public string correct { get; set; }

	public level1()
    {

		
	}
  
     public static SqlConnection Open()
     {
              SqlConnection con = new SqlConnection();
              con.ConnectionString="Data Source = JITESH-PC\\SQLEXPRESS; Initial Catalog=questions ;Integrated Security=true";
              con.Open();
             return con;
     }

    public static int insert(level1 e)
    {
        SqlConnection con = Open();
        SqlCommand cmd=new SqlCommand(" insert qtabel1 values(@q,@ques,@a,@b,@c,@d,@corr)",con);
        cmd.Parameters.AddWithValue("@q",e.qno);
        cmd.Parameters.AddWithValue("@ques",e.que);
        cmd.Parameters.AddWithValue("@a",e.opA);
        cmd.Parameters.AddWithValue("@b",e.opB);
        cmd.Parameters.AddWithValue("@c",e.opC);
        cmd.Parameters.AddWithValue("@d",e.opD);
        cmd.Parameters.AddWithValue("@corr",e.correct);
        int res=cmd.ExecuteNonQuery();
        con.Close();
        return res;
    }

    

}