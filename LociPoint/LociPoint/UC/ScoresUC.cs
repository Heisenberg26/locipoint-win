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
    public partial class ScoresUC : UserControl
    {
     
      
        public ScoresUC()
        {
            InitializeComponent();
        }

        private void ScoresUC_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Scores WHERE userId = @userId ORDER BY type";
            var dictionary = new Dictionary<string, object> {
                    { "@userId", SignInUC.userId }

              };
            var parameters = new DynamicParameters(dictionary);
            List<Score> scores = Database.selectionQuery<Score>(query, parameters);
            int y = lblScore.Location.Y -110;
            for(int i=0; i< scores.Count; i++)
            {
                y += 50;
                Console.WriteLine(scores[i].value);
                Input.createLabel(panel, scores[i].value, lblScore, y);

                if (scores[i].type.Equals("NamesFaces"))
                {
                    scores[i].type = "Names and Faces";
                }
                Input.createLabel(panel,scores[i].type, lblType, y);

                Input.createLabel(panel,scores[i].date, lblDate, y);
                y += 50;

            }
         

        }
        
      
    }
}
