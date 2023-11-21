using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KarateSchool
{
    public partial class _Default : Page
    {
        //Connect to the database
        KarateSchoolDataContext dbcon;
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\w_m_j\\OneDrive\\Desktop\\KarateSchool\\App_Data\\KarateSchool.mdf;Integrated Security=True;Connect Timeout=30";

        protected void Page_Load(object sender, EventArgs e)
        {
            //Initialize connection string 
            dbcon = new KarateSchoolDataContext(conn);


        }
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string UserName = Login1.UserName;
            string Password = Login1.Password;


            HttpContext.Current.Session["UserName"] = UserName;
            HttpContext.Current.Session["Password"] = Password;



            // Search for the current User, validate UserName and Password
            NetUser myUser = (from x in dbcon.NetUsers
                              where x.UserName == HttpContext.Current.Session["UserName"].ToString()
                              && x.UserPassword == HttpContext.Current.Session["Password"].ToString()
                              select x).First();

            if (myUser != null)
            {
                //Add UserID and User type to the Session
                HttpContext.Current.Session["userID"] = myUser.UserID;
                HttpContext.Current.Session["userType"] = myUser.UserType;

            }
            if (myUser != null && HttpContext.Current.Session["userType"].ToString().Trim() == "Member")
            {

                FormsAuthentication.RedirectFromLoginPage(HttpContext.Current.Session["UserName"].ToString(), true);

                Response.Redirect("Member.aspx");
            }
            else if (myUser != null && HttpContext.Current.Session["userType"].ToString().Trim() == "Instructor")
            {

                FormsAuthentication.RedirectFromLoginPage(HttpContext.Current.Session["UserName"].ToString(), true);

                Response.Redirect("Instructor.aspx");
            }
            else
                Response.Redirect("Default.aspx", true);

        }
    }
}