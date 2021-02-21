using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LociPoint.UC
{
    public partial class NamesUC : UserControl
    {
        public static string nationality = "";
        private static NamesUC _instance;
        public static NamesUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NamesUC();
                return _instance;
            }
        }
        public NamesUC()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string hoursText = tbHrs.Text;
            string minsText = tbMins.Text;
            string secsText = tbSecs.Text;
            string recallHrsText = tbRecallHrs.Text;
            string recallMinsText = tbRecallMins.Text;
            string recallSecsText = tbRecallSecs.Text;
            string amountText = numericAmount.Text;
            string type = cbType.Text;
            string[] inputs = { hoursText, minsText, secsText, recallHrsText, recallMinsText, recallSecsText, amountText };
            Time time = new Time(hoursText, minsText, secsText);
            Time recall = new Time(recallHrsText, recallMinsText, recallSecsText);
            Time[] times = { time, recall };
            int amount = Int32.Parse(amountText) ;

            if (Error.validateInputs(inputs) && Error.validateTimes(times)) {
                if (type.Equals("Names")){
                    nationality = "gb";
                    MenuForm.changeUserControl(new SessionUC(SessionUC.Type.Names, amount, time, recall));
                }
                else
                {
                    nationality = "gb";
                    MenuForm.changeUserControl(new SessionUC(SessionUC.Type.NamesFaces, amount, time, recall));
                }
                
            }
        }

        private void NamesUC_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
            cbCountry.SelectedIndex = 0;

        }
    }
}
