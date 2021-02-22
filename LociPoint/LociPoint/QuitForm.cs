using LociPoint.UC;
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
    public partial class QuitForm : Form
    {
       
        private string Message = "";
        private string Title = "";
        public QuitForm(string message, string title)
        {
            
            Message = message;
            Title = title;
            InitializeComponent();
        }

        private void QuitForm_Load(object sender, EventArgs e)
        {
            label.Text = Message;
            this.Text = Title;
            this.Width = label.Width + 300;
            this.Height = label.Height + btnYes.Height + 200;
            label.Location = new Point(this.Width / 2 - label.Width / 2, this.Height / 2 - btnYes.Height);
            btnYes.Location = new Point(label.Left-10, label.Bottom + 20);
            btnNo.Location = new Point(btnYes.Right+30, label.Bottom + 20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
           
        }
    }
}
