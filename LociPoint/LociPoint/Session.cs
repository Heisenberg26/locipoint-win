using LociPoint.UC;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LociPoint
{
   public class Session
    {
       
        public static Panel panel;
        public static string MemorizeText { get; set; }

        //lists
        public static List<string> urls = new List<string>();
        public static List<string> memoList = new List<string>();
        public static List<string> recallList = new List<string>();

        public static List<TextBox> myTextboxList = new List<TextBox>();
    
        public static List<int> ImageList = new List<int>();
        public static List<int> ImageRecallList = new List<int>();




        public static async Task namesSessionAsync(int amount,SessionUC.Type type, bool memorize)
        {
            recallList.Clear();


            if (memorize)
            {
                await APIHelper.requestAsync(amount, NamesUC.nationality);

                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(APIHelper.response);
                Console.WriteLine(obj.results[0].name.first);
                int x = panel.Width / 2 - 70; int y = 10;
                for (int i = 0; i < amount; i++)
                {
                    string name = obj.results[i].name.first + " " + obj.results[i].name.last;
                    string labelName = "lblNames" + i;
                    if (type == SessionUC.Type.Names)
                    {


                        generateLabels(panel, name, labelName, x, y);
                        y += 25;

                    }
                    else
                    {
                        string url = obj.results[i].picture.large;
                        PictureBox pic = generatePictureBox(panel, url, x, y);
                        urls.Add(url);
                        y += pic.Height + 90;
                        generateLabels(panel, name, labelName, x, y);

                        y += 20;


                    }
                    memoList.Add(name);

                }


            }
            else
            {
                if (type == SessionUC.Type.Names)
                {
                    generateTbs(amount, panel, false, false);
                }
                else
                {
                    myTextboxList.Clear();
                    int x = panel.Width / 2 - 70;
                    int y = 20;
                    for (int i = 0; i < amount; i++)
                    {
                        PictureBox pic = generatePictureBox(panel, urls[i], x, y);
                        y += pic.Height + 90;

                        TextBox tbRecall = new TextBox();
                        Font font = new Font("Century Gothic", 16f);
                        tbRecall.Size = new Size(150, 600);
                        tbRecall.Name = "tbRecall" + i;
                        tbRecall.Font = font;
                        tbRecall.Location = new Point(panel.Width / 2 - 90, y);
                        panel.Controls.Add(tbRecall);
                        myTextboxList.Add(tbRecall);
                        y += 50;
                    }
                    myTextboxList = myTextboxList.OrderBy(z => z.Name).ToList();






                }

            }
        }
        public static void wordsSession(int amount, bool memorize, string file, bool words)
        {
            recallList.Clear();
            if (memorize)
            {
                

               
                if (File.Exists(file))
                {
                    string[] lines = File.ReadAllLines(file);
                    Console.WriteLine("File exists");
                    int x = 40; int y = 10;

                    Random rand = new Random();

                    for (int i = 0; i < amount; i++)
                    {
                        Label lblWords = new Label();
                        Font font = new Font("Century Gothic", 15f);
                        string line = lines[i];
                        if (words) {
                            line = lines[rand.Next(lines.Length)];
                        }
                        
                      
                        lblWords.Font = font;
                        lblWords.Text = line;
                        lblWords.Name = "lblWords" + i;
                        lblWords.AutoSize = true;

                        lblWords.Location = new Point(x, y);


                        y += 20;
                   

                        panel.Controls.Add(lblWords);
                        memoList.Add(lblWords.Text);
                    }
                }

                else
                {
                    Console.WriteLine("File doesn't exist");
                }
            }
            else
            {
                generateTbs(amount, panel, false,false);
              

            }
        }
        public static void numbersSession(int amount, string type, bool memorize) //Numbers Memorize
        {
            
            recallList.Clear();
            if (memorize)
            {
               
                Label lblNumbers = new Label();
                lblNumbers.AutoSize = true;
                lblNumbers.Text = Numbers.generateNumbers(amount, type);
                Font font = new Font("Century Gothic", 26f);
                lblNumbers.Location = new Point(250, 50);
                lblNumbers.Size = new Size(200, 90);
                lblNumbers.Font = font;
                panel.Controls.Add(lblNumbers);

                MemorizeText = Numbers.returnModifiedString(lblNumbers.Text);
                memoList = Input.stringToList(MemorizeText);
              /*  Console.WriteLine(string.Join(",", memoList.ToArray()));*/

            }
            else
            {
                generateTbs(amount / 2, panel, true, true);
               
            }

        }

        public static void imageSession(int amount, SessionUC.Type type, bool memorize)
        {

            recallList.Clear();
            if (memorize)
            {
                Image[] images;
                //generates random image array
                int[] randomImages = Numbers.shuffleImages(amount, Convert.ToString(type));
                
                if (type == SessionUC.Type.Cards)
                { 
                    images = generateResourceImages(amount, randomImages);
                    memoList = Input.intToList(randomImages);

                }
                else
                {
                    //convert image list to image array
                    images = Input.convertImageList(LearnUC.images);
                    //generate random images
                    images = generateResourceImages(randomImages, LearnUC.filenames);
                    memoList = Input.intToList(randomImages);

                }
                panel.Controls.Add(new ImageUC(images, amount));
                


            }
            else
            {
                //get string url for every card
                int[] imageArr;
                Image[] images;
                if (type == SessionUC.Type.Cards)
                {
                    amount = 52;
                    imageArr = new int[amount];
                    for (int i = 0; i < amount; i++)
                    {
                        imageArr[i] = i;
                    }
                    images = generateResourceImages(amount, imageArr);

                }
                else
                {
                    images = Input.convertImageList(LearnUC.images);
                   
                }
                panel.Controls.Add(new ImageRecallUC(images, amount));


            }


        }

        private static Image[] generateResourceImages(int[] randomImages, string[] filenames)
        {
            Image[] images = new Image[randomImages.Length];
            for (int i = 0; i < randomImages.Length; i++)
            {

 
                Image image = Image.FromFile(filenames[randomImages[i]]);
                images[i] = image;
                ImageList.Add(randomImages[i]);
            }
            return images;
        }

        public static Image[] generateResourceImages(int amount, int[] randomImages)
        {
            Image[] images = new Image[amount];
            for (int i = 0; i < amount; i++)
            {
                
                object rm = Properties.Resources.ResourceManager.GetObject("_" + randomImages[i].ToString());
                Bitmap myImage = (Bitmap)rm;
                Image image = myImage;
               
                images[i] = image;
                ImageList.Add(randomImages[i]);
            }
            return images;
        }

        public static PictureBox generatePictureBox(Panel panel, string url, int x, int y)
        {
            PictureBox pic = new PictureBox();
            pic.Location = new Point(x, y);
            pic.SizeMode = PictureBoxSizeMode.AutoSize;
            pic.ImageLocation = (url);
            panel.Controls.Add(pic);
            return pic;
        }
        public static void generateTbs(int amount, Panel panel, bool customizeTbs, bool order)
        {
            myTextboxList.Clear();
            int x = 200, y = 10;

            for (int i = 0; i < amount; i++)
            {
                TextBox tbRecall = new TextBox();
                Font font = new Font("Century Gothic", 16f);
                tbRecall.Size = new Size(100, 600);
                tbRecall.Name = "tbRecall" + i;
                tbRecall.Font = font;

                if (customizeTbs)
                {
                    tbRecall.MaxLength = 2;
                }

                if (i % 5 == 0 && i != 0) //new line, x and y change
                {
                    x = 10;
                    y += 40;
                    tbRecall.Location = new Point(x, y);
                }
                else //same line, x changes
                {
                    tbRecall.Location = new Point(x, y);
                }

                x = x + 120;

                panel.Controls.Add(tbRecall);
                myTextboxList.Add(tbRecall);

            }
            if (order)
            {
                myTextboxList = myTextboxList.OrderBy(z => z.Name).ToList(); //sorting textboxes by name
            }
          

        }

        public static void generateLabels(Panel panel, string str, string name, int x, int y)
        {
            Label label = new Label();
            Font font = new Font("Century Gothic", 15f);

            label.Font = font;
            label.Text = str;
            label.Name = name;
            label.AutoSize = true;
            label.Location = new Point(x, y);


            y += 20;
            panel.Controls.Add(label);
            
        }
    }
}
