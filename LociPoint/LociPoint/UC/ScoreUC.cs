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
    public partial class ScoreUC : UserControl
    {
        private string Score { get; set; }
        private string Type { get; set; }
        private string Date { get; set; }
        public ScoreUC(string score, string type, string date)
        {
            
            InitializeComponent();
            Type = type;
            Score = score;
            Date = date;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignInUC.saveScore = true;
            SignInUC.score = new Score();
            SignInUC.score.value = Score;
            SignInUC.score.type = Type;
            SignInUC.score.date = Date;
            MenuForm.changeUserControl(new SignInUC());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Score);
            string[] keys = { "@value", "@type" , "@userId", "@date" };
            object[] vals = { Score , Type, SignInUC.userId, Date };

           
            
            string createScore = "INSERT INTO Scores( value, type, userId, date)  VALUES ( @value, @type, @userId, @date)";
            Database.executeQuery(createScore, Input.generateDictionary(keys, vals));
           

            MenuForm.instance.changeMenu(new ScoresUC());

        }

        private void ScoreUC_Load(object sender, EventArgs e)
        {
            lblScoreNumber.Text = Score;
            lblDateVal.Text = Date;
            lblStatistics.Text = "";
            //if signed in
            if (SignInUC.SignedIn)
            {
                btnSignUp.Hide();
                lblSignUp.Hide();
                btnSave.Show();
            }
            else
            {
                btnSignUp.Show();
                lblSignUp.Show();
                btnSave.Hide();
            }
            

        }
    }
}
