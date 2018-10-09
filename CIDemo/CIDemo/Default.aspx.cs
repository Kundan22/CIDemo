using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Arithmatic;

namespace CIDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            string Oprator = ddlOperation.SelectedValue;
            decimal _Result = 0;
            Int32 Num1 = Convert.ToInt32(txtNum1.Text.Trim());
            Int32 Num2 = Convert.ToInt32(txtNum2.Text.Trim());

            switch(Oprator)
            {
                case "Add":
                    _Result = Arithmatic.Arithmatic.Add(Num1, Num2);
                    break;
                case "Subtract":
                    _Result = Arithmatic.Arithmatic.Subtract(Num1, Num2);
                    break;
                case "Multiply":
                    _Result = Arithmatic.Arithmatic.Multiply(Num1, Num2);
                    break;
                case "Devide":
                    _Result = Arithmatic.Arithmatic.Devide(Num1, Num2);
                    break;
            }

            lblResult.Text = "Result:-" + _Result.ToString();
        }
    }
}
