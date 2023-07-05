using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormSample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double result = 0;

            if(DropDownList1.SelectedValue == "+")
                result = double.Parse(TextBox1.Text) + double.Parse(TextBox2.Text);
            if (DropDownList1.SelectedValue == "-")
                result = double.Parse(TextBox1.Text) - double.Parse(TextBox2.Text);
            if (DropDownList1.SelectedValue == "*")
                result = double.Parse(TextBox1.Text) * double.Parse(TextBox2.Text);
            if (DropDownList1.SelectedValue == "/")
                result = double.Parse(TextBox1.Text) / double.Parse(TextBox2.Text);
            if (DropDownList1.SelectedValue == "%")
                result = double.Parse(TextBox1.Text) % double.Parse(TextBox2.Text);

            TextBox3.Text = result.ToString();
        }
    }
}