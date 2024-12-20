using Modern_Pharmacy_Managment_System.Database;
using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Modern_Pharmacy_Managment_System.Classes
{
    class Customer
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            
            if (phoneNumber.Length != 11 || !phoneNumber.StartsWith("01"))
            {
                MessageBox.Show("Please enter a valid phone number starting with '01' and having exactly 11 digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            char thirdDigit = phoneNumber[2];
            if (!(thirdDigit == '5' || thirdDigit == '3' || thirdDigit == '7' || thirdDigit == '9' || thirdDigit == '8' || thirdDigit == '6'))
            {
                MessageBox.Show("Please enter a valid phone number with a supported SIM company (third digit can be 5, 3, 7, 9, 8, or 6).", "Invalid SIM Company", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate all digits
            foreach (char digit in phoneNumber.Substring(2))
            {
                if (!char.IsDigit(digit))
                {
                    MessageBox.Show("Please enter a valid phone number containing only digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        public static bool CheckPhoneNumberExists(string phoneNumber)
        {
            using (var con = DatabaseConnection.databaseConnect())
            {
                try
                {
                    con.Open();

                    // Prepare the SELECT query
                    string selectQuery = "SELECT COUNT(*) FROM tbCustomer WHERE cphone = @cphone";

                    // Create SqlCommand object and add parameters
                    SqlCommand cmd = new SqlCommand(selectQuery, con);

                    cmd.Parameters.AddWithValue("@cphone", phoneNumber);

                    // Execute the query and get the count
                    int count = (int)cmd.ExecuteScalar();

                    // If count is greater than 0, phone number already exists
                    if(count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
         
    }

    
}
