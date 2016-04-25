using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomWebFormSQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void writeToDatabase(object sender, EventArgs e)
        {
            String first = tbFirst.Text;
            String last = tbLast.Text;
            String address = tbAddress.Text;
            String city = tbCity.Text;
            String state = tbState.Text;
            String zip = tbZip.Text;
            String cc = tbCreditCard.Text;
            String exp = tbExp.Text;
            String information = "INSERT INTO ClientInfo ([First Name], [Last Name], Address, City, State, Zip, [Credit Card Number], Expiration) VALUES ('" + first + "', '" + last + "', '" + address + "', '" + city + "', '" + state + "', '" + zip + "', '" + cc + "', '" + exp + "');";
            using (SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDatabase"].ToString()))
            {
                using (SqlCommand saveData = new SqlCommand(information, myConnection))
                {
                    myConnection.Open();
                    saveData.Connection = myConnection;
                    saveData.ExecuteNonQuery();
                    myConnection.Close();
                }
            }
        }
    }
}