using Dapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LociPoint.UC
{
    public partial class SignInUC : UserControl
    {
        public static User user;
        public static int userId;
        public static event EventHandler SignInClicked;
        public static bool _signedIn;
        internal static bool saveScore = false;
        public static Score score;

        public static bool SignedIn
        {
            get
            {
                return _signedIn;
            }
            set
            {
                if (value == true)
                {
                    _signedIn = true;
                    Console.WriteLine("Signed in");

                }
                else
                {
                    _signedIn = false;
                    Console.WriteLine("Signed out");
                }
            }

        }
        public static Font comforta { get; set; }
       
        public SignInUC()
        {
            InitializeComponent();

  
            
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

            if (SignUpUC.SignedUp)
            {
                
                lblSignUp.Show();
            }
            else
            {
                lblSignUp.Hide();
            }

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
            string[] keys = {"@username", "@password"};
            object[] obj = { username, password };
       
            
            List<User> users = Database.selectionQuery<User>(query, Input.generateDictionary(keys, obj));
            if (users.Count == 1)
            {
                SignedIn = true;
                labelError.Hide();
                userId = users[0].Id;
                SignUpUC.SignedUp = false;
                user = users[0];
                if (SignInUC.saveScore)
                {
                    keys = new string[]{ "@value", "@type", "@userId", "@date" };
                    object[] vals = { score.value, score.type, SignInUC.userId, score.date };



                    string createScore = "INSERT INTO Scores( value, type, userId, date)  VALUES ( @value, @type, @userId, @date)";
                    Database.executeQuery(createScore, Input.generateDictionary(keys, vals));
                    MenuForm.changeUserControl(new ScoresUC());
                    saveScore = false;

                }
                Console.WriteLine(user.FirstName);
                //user is signed in
            }
            else {
                SignedIn = false;
                labelError.Show();
                //incorrect username or password

            }
            
            SignInClicked?.Invoke(this, e);

        }
    }
}
