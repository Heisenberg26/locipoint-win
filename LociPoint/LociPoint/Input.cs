using Dapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LociPoint
{
    public class Input
    {
        public static string[] stringListToArr(List<string> list)
        {
            string[] arr = new string[list.Count];
            for(int i=0; i<list.Count; i++)
            {
                arr[i] = list[i];
            }
            return arr;
        }
        public static List<string> stringToList(string str)
        {
            str = String.Join(",", str.ToArray());
            List<string> list = str.Split(',').ToList();
           
    
            return list;

        }
        public static List<string> intToList(int[] images)
        {
            List<string> list = new List<string>();
            for(int i=0; i<images.Length; i++)
            {
                list.Add(images[i].ToString());
            }
            
            return list;
        }
        public static DynamicParameters generateDictionary(string[] str, object[] objs)
        {
            var dictionary = new Dictionary<string, object> { };
            for(int i=0; i<str.Length; i++)
            {
                dictionary.Add(str[i], objs[i]);
            }
            DynamicParameters parameters = new DynamicParameters(dictionary);
            return parameters;
        }

        internal static string[] generateArr(string str, char delimiter)
        { 
            
            return str.Split(delimiter);
        }

        public static List<string> convertTb(List<TextBox> myTextboxList, bool split)
        {
            List<string> list = new List<string>();
            foreach(var tb in myTextboxList)
            {
                string str = tb.Text.ToString();
                if (split)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        char c = str[i];

                        list.Add(c.ToString());
                    }
                }
                else
                {
                    list.Add(str);
                }
              
               
            }
          
            return list;
        }

        public static string generateArrIds(int rangeInt, bool nullify)
        {
            string str = "";
            for(int i=0; i<rangeInt; i++)
            {
                if (nullify)
                {
                    str+= i.ToString();
                }
                else
                {
                    str += "";
                }
                if (i != rangeInt - 1)
                {
                    str += ",";
                }
                
            }
            Console.WriteLine(str);
            return str;
        }

       

        internal static string generateStr(List<TextBox> tbs)
        {
            string str = "";
            for(int i=0; i<tbs.Count; i++)
            {
                str += tbs[i].Text;
                if (i != tbs.Count)
                {
                    str += ",";
                }
            }
            return str;
        }

        public static TextBox createTb(Panel panel, int x, int y, string str, int width, int height)
        {
            TextBox tb = new TextBox();
            Font font = new Font("Century Gothic", 26f);
            tb.Location = new Point(x, y);
            tb.Size = new Size(width, height);
            tb.Font = font;
            tb.Text = str;

            panel.Controls.Add(tb);
            return tb;
        }

        public static void createLabel(Panel panel, string str, Label lbl, int y)
        {
            Label label = new Label();
            Font font = new Font("Century Gothic", 26f);
            label.Location = new Point(lbl.Location.X, y);
            label.Size = new Size(200, 90);
            label.Font = font;
            label.Text = str;

            panel.Controls.Add(label);
        }
        public static void createLabel(Panel panel, string str, int x, int y)
        {
            Label label = new Label();
            Font font = new Font("Century Gothic", 26f);
            label.Location = new Point(x, y);
            label.Size = new Size(200, 90);
            label.Font = font;
            label.Text = str;

            panel.Controls.Add(label);
        }
        public static void createLabel(Panel panel, string str, int x, int y, int width, int height)
        {
            Label label = new Label();
            Font font = new Font("Century Gothic", 26f);
            label.Location = new Point(x, y);
            label.Size = new Size(width, height);
            label.Font = font;
            label.Text = str;

            panel.Controls.Add(label);
        }
        public static int getId(Button btn, List<Button> btns)
        {
            int count = 0;


            for (int i = 0; i < btns.Count; i++)
            {
                if (btn == btns[i])
                {
                    count = i;
                }
            }
            return count;
        }
        public static Button createButton(Panel panel, string str, int x, int y)
        {
            Button btn = new Button();

            Font font = new Font("Century Gothic", 26f);
            btn.Location = new Point(x, y);
            btn.Size = new Size(155, 50);
            btn.Font = font;
            btn.Text = str;

            panel.Controls.Add(btn);
            return btn;
          
            
           
        }
        

        internal static Image[] convertImageList(List<Image> images)
        {
            Image[] imgs = new Image[images.Count];
            for(int i=0; i<images.Count; i++)
            {
                imgs[i] = images[i];

            }
            return imgs;
           
        }
    }
}
