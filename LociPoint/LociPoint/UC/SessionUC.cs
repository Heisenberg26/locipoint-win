using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LociPoint.UC
{
    public partial class SessionUC : UserControl
    {
        public enum Type { Decimal, Binary, Images, Cards, Names,NamesFaces, Words, Text };
        public Time Time { get; set; }
        public Time Recall { get; set; }
        public Time ActiveTime { get; set; }
        public int Amount { get; set; }
        private Type _type;
        internal static bool split { get; set; }

        public SessionUC(Type type, int amount, Time time, Time recall)
        {
            InitializeComponent();
            _type = type;
            Amount = amount;
            Time = time;
            Recall = recall;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelSession.Show();
            lblMemo.Hide();
            if (Time.isTimeZero())
            {
                timer2.Start();
                initializeSession(false);
            }
            else
            {
                timer.Start();
            }
           
            btnStart.Hide();
            btnStop.Show();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (Time.isTimeZero())
            {
                timer2.Stop();
            }
            else
            {
                timer.Stop();
            }

            btnStart.Show();
            btnStop.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            timeTick(Time, timer, true);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeTick(Recall, timer2, false);
          
        }

        private void timeTick(Time time, Timer timer, bool showText)
        {
            if (time.isTimeZero())
            {
                timer.Stop();
                btnStart.Show();
                btnStop.Hide();
                if (showText)
                {
                    lblMemo.Text = "Press Start to begin recall phase";
                    lblMemo.Show();
                }
                else
                {
                    btnScore.Show();

                }
            }
            else
            {
                time.tickTime();
                time.formatTime(lblHrs, lblMins, lblSecs);

            }

        }



        private void panelSession_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void SessionUC_Load(object sender, EventArgs e)
        {
            initializeSession(true);
        }
        private void initializeSession(bool memorize)
        {
            panelSession.Controls.Clear();
            Time.formatTime(lblHrs, lblMins, lblSecs);
            Session.panel = panelSession;
            switch (_type)
            {
                case Type.Binary:
                case Type.Decimal:
                    Session.numbersSession(Amount, _type.ToString(), memorize);
                    break;
                case Type.Images:
                case Type.Cards:
                    Session.imageSession(Amount, _type, memorize);
                    break;
                case Type.Names:
                case Type.NamesFaces:
                    Session.namesSessionAsync(Amount, _type, memorize);
                    break;

                case Type.Words:
                    var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                    string words = Path.Combine(projectPath, "Resources/words.txt");
                    Session.wordsSession(Amount, memorize, words, true);
                    break;
                case Type.Text:
                    string file = LearnUC.filenames[0];
                    Session.wordsSession(Amount, memorize, file,false);
                    break;
         
            }
            

        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            switch (_type)
            {
                case Type.Binary:
                case Type.Decimal:
                    Session.recallList = Input.convertTb(Session.myTextboxList, true);
                    break;
                case Type.Images:
                case Type.Cards:
                    Session.recallList = ImageRecallUC.recallList;
                    
                    break;
                case Type.Names:
                case Type.NamesFaces:
                    Session.recallList = Input.convertTb(Session.myTextboxList, false);
                    break;
                case Type.Words:
                    Session.recallList = Input.convertTb(Session.myTextboxList, false);
                    break;
                case Type.Text:
                    Session.recallList = Input.convertTb(Session.myTextboxList, false);
                    break;
            }
            MenuForm.changeUserControl(new ScoreUC(Score.calculateScore(Session.memoList, Session.recallList), _type.ToString(), DateTime.UtcNow.ToString("dd/MM/yyyy")));
            Session.memoList.Clear();
            Session.urls.Clear();
        }
    }
}
