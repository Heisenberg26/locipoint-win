using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LociPoint
{
    public partial class ErrorForm : Form
    {
        private string title;
        private string message;
        public ErrorForm(string message, string title)
        {
            this.title = title;
            this.message = message;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            label1.Text = message;
            this.Text = title;
            this.Width = label1.Width +300;
            this.Height = label1.Height + button1.Height + 200;
            label1.Location = new Point(this.Width/2 - label1.Width/2 , this.Height / 2 -button1.Height);
            button1.Location = new Point(this.Width / 2 - button1.Width / 2, label1.Bottom +20 ) ;
            
          
        }
    }
}
