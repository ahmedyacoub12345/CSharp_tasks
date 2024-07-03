using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Task1
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Get the input values
            string name = TextBox1.Text;
            string email = TextBox2.Text;
            string id = TextBox3.Text;
            string gender = RadioButtonList1.SelectedValue;

            // Get the selected courses
            StringBuilder courses = new StringBuilder();
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    if (courses.Length > 0)
                    {
                        courses.Append(", ");
                    }
                    courses.Append(item.Text);
                }
            }

            // Get the description
            string description = Request.Form["S1"];

            // Display the values in the labels
            NameLabel.Text = name;
            EmailLabel.Text = email;
            IDLabel.Text = id;
            GenderLabel.Text = gender;
            CourseLabel.Text = courses.ToString();
            DescriptionLabel.Text = description;
        }
    }
}