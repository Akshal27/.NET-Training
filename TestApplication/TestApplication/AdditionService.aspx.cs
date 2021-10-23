using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestApplication
{
    public partial class AdditionService : System.Web.UI.Page
    {
        ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
        int a, b, result,age;
        string name,course;

        protected void Button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            result = sc.Mutiplication(a, b);
            TextBox3.Text = result.ToString();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            name = TextBox4.Text;
            course = TextBox6.Text;
            age = Convert.ToInt32(TextBox5.Text);
            Label1.Text = sc.DisplayName(name,age,course);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            result = sc.Division(a, b);
            TextBox3.Text = result.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            result = sc.Subtraction(a, b);
            TextBox3.Text = result.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            result = sc.Addition(a, b);
            TextBox3.Text = result.ToString();

        }
    }
}