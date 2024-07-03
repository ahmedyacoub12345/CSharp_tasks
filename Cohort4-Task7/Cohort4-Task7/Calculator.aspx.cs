using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cohort4_Task7
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Number1.Text);
            int number2 = Convert.ToInt32(Number2.Text);

            ResultLabel.Text = $"{number1 + number2}";
        }

        protected void SubtractButton_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Number1.Text);
            int number2 = Convert.ToInt32(Number2.Text);

            ResultLabel.Text = $"{number1 - number2}";
        }

        protected void MultiplyButton_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(Number1.Text);
            int number2 = Convert.ToInt32(Number2.Text);

            ResultLabel.Text = $"{number1 * number2}";
        }
    }
}