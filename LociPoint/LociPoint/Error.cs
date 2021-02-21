using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LociPoint
{
    public class Error
    {
        public static string message = "";
        public static string title = "Input Error";
        public static bool validateInputs(string[] inputs) {

            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == "")
                {
                    Error.message = "All input fields must be filled. \n";
                    showErrorMessage();
                    return false;
                }

            }

            return true;
        
        
        }
        public static bool validateTimes(Time[] times)
        {

            for (int i = 0; i < times.Length; i++)
            {
                if (times[i].Hours > 24 || times[i].Hours < 0 || times[i].Mins > 59 || times[i].Mins < 0 || times[i].Secs > 59 || times[i].Secs < 0)
                {
                    Error.message = "Hours field accepts values higher than 0 and less than 25 \n" +
                        "Minutes field accepts values higher than 0 and less than 59 \n" +
                        "Seconds field accepts values higher than 0 and less than 59 \n";
                    showErrorMessage();
                    return false;
                }
            }

            return true;

        }
        public static bool validateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                Error.message = "Invalid email address";
                showErrorMessage();
                return false;
            }
           
        }
        public static void showErrorMessage()
        {
            MessageBox.Show(Error.message, Error.title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
