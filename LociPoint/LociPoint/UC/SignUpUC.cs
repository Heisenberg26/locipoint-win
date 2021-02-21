using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace LociPoint.UC
{
    public partial class SignUpUC : UserControl
    {
       
        private static SignUpUC _instance;
        public static bool SignedUp = false;
        public static SignUpUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SignUpUC();
                return _instance;
            }
        }
        public SignUpUC()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string email = tbEmail.Text;
            string fName = tbFName.Text;
            string lName = tbLName.Text;
            string[] inputs = { username, password, email, fName, lName };

            string[] keys = { "@username", "@email" };
            object[] vals = { username, email };

            if (Error.validateInputs(inputs) && Error.validateEmail(email) )
            {
                string checkIfExists = "SELECT * FROM Users WHERE Username = @username OR Email = @email";
                List<User> users = Database.selectionQuery<User>(checkIfExists, Input.generateDictionary(keys, vals));

                if (users.Count > 0)
                {
                    //show error message
                    lblError.Show();

                }
                else
                {
                    //create user query
                    lblError.Hide();
                    keys = new string[] { "@fName", "@lName", "@email", "@username", "@password" };
                    vals = new object[] { fName, lName, email, username, password };

                    string createUser = "INSERT INTO Users( FirstName, LastName, Email, Username, Password)  VALUES ( @fName, @lName, @email,@username, @password)";
                    Database.executeQuery(createUser, Input.generateDictionary(keys, vals));

                    SignedUp = true;
                    MenuForm.changeUserControl(new SignInUC());


                }
            }
           
        }
    }
}
