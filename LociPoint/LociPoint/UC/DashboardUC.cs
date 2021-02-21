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
    public partial class DashboardUC : UserControl
    {
     
        
        public DashboardUC()
        {
            InitializeComponent();
        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome Back, " + SignInUC.user.UserName + "!";

            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
           
            MenuForm.changeUserControl(CardsUC.Instance);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            MenuForm.changeUserControl(NumbersUC.Instance);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MenuForm.changeUserControl(WordsUC.Instance);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MenuForm.changeUserControl(NamesUC.Instance);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
