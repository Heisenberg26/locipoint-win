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
    public partial class LearnUC : UserControl
    {

        private int amount = 0;
        private static LearnUC _instance;
        private SessionUC.Type type = SessionUC.Type.Text;
        public static List<Image> images = new List<Image>();
        public static List<string> lines = new List<string>();
        public static string[] words;
        public static string[] filenames;

        public static LearnUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LearnUC();
                return _instance;
            }
        }
        public LearnUC()
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
  
            string strType = cbType.Text;

            string[] inputs = { hoursText, minsText, secsText, recallHrsText, recallMinsText, recallSecsText};
            Time time = new Time(hoursText, minsText, secsText);
            Time recall = new Time(recallHrsText, recallMinsText, recallSecsText);
            Time[] times = { time, recall };
          
           
            if (Error.validateInputs(inputs) && Error.validateTimes(times))
            {
                if(filenames == null)
                {
                    Error.message = "Please select a file. \n";
                    Error.showErrorMessage();
                }
                else
                {
                    switch (strType)
                    {
                        case "Textfile":
                            type = SessionUC.Type.Text;

                            var lineCount = File.ReadLines(filenames[0]).Count();
                            amount = lineCount;
                            break;
                        case "Images":
                            type = SessionUC.Type.Images;
                            break;

                    }

                    MenuForm.changeUserControl(new SessionUC(type, amount, time, recall));
                }
                

            }
        }

        private void LearnUC_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
            /*MenuForm.setFontType(this, MenuForm.comforta, typeof(Button));
            MenuForm.setFontType(this, MenuForm.comforta, typeof(Label));
            label1.Font = MenuForm.comfortaL;
            label1.Font  = new Font(label1.Font, FontStyle.Bold);*/

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            panelFiles.Controls.Clear();
            images.Clear();

            OpenFileDialog theDialog = new OpenFileDialog();
            
            if(type == SessionUC.Type.Text)
            {
                theDialog.Title = "Open Text Files(s)";
                theDialog.Filter = "TXT files|*.txt";

            }
            else
            {
                theDialog.Title = "Open Image File(s)";
                theDialog.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
                theDialog.Multiselect = true;

            }
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                filenames = theDialog.FileNames;
                if (type == SessionUC.Type.Images)
                {
                    generateImages(filenames);
                    amount = filenames.Length;
                }
                else
                {
                    generateFile(filenames);
                    amount = lines.Count;
                }
               
                int x = 10; int y = 10;
                for (int i = 0; i < filenames.Length; i++)
                {
                    Label label = new Label();
                    Font font = new Font("Century Gothic", 15f);
                 
               
                    label.Font = font;
                    label.Text = filenames[i];  
                    label.Name = "lblFile" + i;
                    label.AutoSize = true;

                    label.Location = new Point(x, y);
                    y += 20;
                    panelFiles.Controls.Add(label);
                }
               
       
                

            }
           
        }

        private void generateFile(string[] filenames)
        {
            List<string> strings = new List<string>();
            string lineFromFile;
            int lineCount = 0;
            using (StreamReader reader = new StreamReader(filenames[0]))
            {
                while (!reader.EndOfStream)
                {
                    lineFromFile = reader.ReadLine();
                    strings.Add(lineFromFile);
                    Console.WriteLine(strings[lineCount]);
                    lineCount++;
                   
                    
                }
            }
            lines = strings;
            for(int i=0; i<strings.Count; i++)
            {
                Console.WriteLine(strings[i]);
            }
        }

        private void generateImages(string[]files)
        {
            for(int i=0; i<files.Length; i++)
            {
                Image loadedImage = Image.FromFile(files[i]);
                images.Add(loadedImage);
            }

            
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbType.Text)
            {
                case "Textfile":
                    type = SessionUC.Type.Text;
                   
                    break;
                case "Images":
                    type = SessionUC.Type.Images;
                   
                    break;

            }
        }
    }
}
