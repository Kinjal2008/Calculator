using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace CalcWebApplication
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            CalcServiceReference.CalcWebServiceSoapClient calcRef = new CalcServiceReference.CalcWebServiceSoapClient();
            
            string selectedOperator = ddlOperator.SelectedValue;
            int answer = 0;
            string res = "";
            try
            {
                if (calcRef.InnerChannel.State != System.ServiceModel.CommunicationState.Faulted)
                {
                    switch (selectedOperator)
                    {
                        case "Add":
                            answer = calcRef.Add(int.Parse(txtNumber1.Text), int.Parse(txtNumber2.Text));
                            res = "Addition of two numbers are ";
                            break;
                        case "Sub":
                            answer = calcRef.Subtract(int.Parse(txtNumber1.Text), int.Parse(txtNumber2.Text));
                            res = "Subtratcion of two numbers are ";
                            break;
                        case "Div":
                            answer = calcRef.Divide(int.Parse(txtNumber1.Text), int.Parse(txtNumber2.Text));
                            res = "Division of two numbers are ";
                            break;
                        case "Mul":
                            answer = calcRef.Multiply(int.Parse(txtNumber1.Text), int.Parse(txtNumber2.Text));
                            res = "Multiplication of two numbers are ";
                            break;
                        default:
                            break;

                    }

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CalcConnectionString"].ConnectionString);
                    conn.Open();
                    string query = "insert into DiagnosticsDetails values(@num1, @num2, @res, @operator)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@num1", txtNumber1.Text);
                    cmd.Parameters.AddWithValue("@num2", txtNumber2.Text);
                    cmd.Parameters.AddWithValue("@res", answer.ToString());
                    cmd.Parameters.AddWithValue("@operator", selectedOperator);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    lblResult.Text = res + answer.ToString() + " added in database.";
                }
            }
            catch (Exception)
            {
                // TO DO: Divide by Zero error can be handled in a better way by using specific exception.
                lblResult.Text = "Can not divide by zero..!";
                //throw;
            }
            

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            lblResult.Text = "";
        }
    }
}