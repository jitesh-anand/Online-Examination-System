using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Class1
/// </summary>
public class details
{
    public string fname { get; set; }
    public string lname { get; set; }
    public int age { get; set; }
    public string sex { get; set; }
    public DateTime dob { get; set; }
    public string qual { get; set; }
    public string email { get; set; }
    public string pass { get; set; }

    public static SqlConnection Open()
    { 
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source = JITESH; Initial Catalog = OTS ;Integrated Security=true";
        con.Open();
        return con;
    }
    public static int insert(details d)
    {
        SqlConnection con = Open();
        SqlCommand cmd = new SqlCommand("insert register values(@f,@l,@a,@s,@d,@q,@e,@p)",con);
        cmd.Parameters.AddWithValue("@f", d.fname);
        cmd.Parameters.AddWithValue("@l", d.lname);
        cmd.Parameters.AddWithValue("@a", d.age);
        cmd.Parameters.AddWithValue("@s", d.sex);
        cmd.Parameters.AddWithValue("@d", d.dob.ToShortDateString());
        cmd.Parameters.AddWithValue("@q", d.qual);
        cmd.Parameters.AddWithValue("@e", d.email);
        cmd.Parameters.AddWithValue("@p", d.pass);

        int res = cmd.ExecuteNonQuery();
        con.Close();
        return res;

    }
	public details()
	{
		
	}
    public static Boolean check(string email1, string pass1)
    {
        Boolean ab = false;
        details obj = new details();
        SqlConnection con = Open();
        SqlCommand cmd = new SqlCommand("select * from register where email=@e and pass=@p", con);
        cmd.Parameters.AddWithValue("@e",email1);
        cmd.Parameters.AddWithValue("@p", pass1);
        SqlDataReader sdr = cmd.ExecuteReader();
        if (sdr.HasRows)
        {
            ab = true;
        }
        sdr.Close();
        con.Close();
        return ab;
    }
}