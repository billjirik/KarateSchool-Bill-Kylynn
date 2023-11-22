using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KarateSchool
{
    public partial class Admin : System.Web.UI.Page
    {
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\w_m_j\\OneDrive\\Desktop\\KarateSchool\\App_Data\\KarateSchool.mdf;Integrated Security=True;Connect Timeout=30";
        KarateSchoolDataContext dbcon;


        protected void Page_Load(object sender, EventArgs e)
        {
            dbcon = new KarateSchoolDataContext(connString);

            //select Mem records
            var result = from item in dbcon.Members
                         orderby item.MemberLastName, item.MemberFirstName
                         select item;
            //show in gridview
            GridView1.DataSource = result;
            GridView1.DataBind();

            //select instr records
            var result2= from item in dbcon.Instructors
                         orderby item.InstructorLastName, item.InstructorFirstName
                         select item;
            // show in gridview2
            GridView2.DataSource = result2;
            GridView2.DataBind();
            






        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string lastname = txtBox1.Text;

            //select all records
            var result= from item in dbcon.Members
                        where item.MemberLastName.Contains(lastname)
                        select item;
            //show in gview
            GridView1.DataSource= result;
            GridView1.DataBind();
        }

        protected void Unnamed2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            string lastname=txtBox2.Text;

            //select records
            var result= from item in dbcon.Instructors
                        where item.InstructorLastName.Contains(lastname)
                        select item;
            //show
            GridView2.DataSource= result;
            GridView2.DataBind();
        }
    }
}