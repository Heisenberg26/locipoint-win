using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LociPoint
{
    public class Numbers
    {
        public static string generateNumbers(int amount, string type)
        {
            var random = new Random();
            string s = "";
            for (int i = 0; i < amount; i++)
            {
                s = String.Concat(s, random.Next(returnRange(type)).ToString());
             
                if (i % 50 == 0 && i != 0)
                {
                    s = String.Concat(s, "\n");
                }

            }

            return s;
        }
        public static int returnRange(string type)
        {
            if (type == "Decimal")
            {
                return 10;
            }
            else
            {
                return 2;
            }
        }
        public static string returnModifiedString(string s)
        {
            string replacement = Regex.Replace(s, @"\t|\n|\r", "");
            return replacement;
        }
        public static void populateImages(int[] images, string type, int amount)
        {
            if (type == "Images")
            {
                for (int i = 0; i < images.Length; i++)
                {
                    images[i] = i;
                }
            }
            else
            {
                int imageIndex = 0;

                for (int i = 0; i < amount; i++)
                {
                    if (imageIndex % 52 == 0)
                    {
                        imageIndex = 0;
                    }

                    images[i] = imageIndex;
                    imageIndex++;

                }

            }

        }
        public static int[] shuffleImages(int amount, string type)
        {
            //Knuth shuffle algorithm
            var random = new Random();
            int[] images = new int[amount];
            populateImages(images, type, amount);
            for (int i = 0; i < images.Length; i++)
            {
                int tmp = images[i];
                int j = random.Next(i, images.Length);
                images[i] = images[j];
                images[j] = tmp;

            }
            return images;
        }

        internal static Image[] shuffleImages(Image[] images)
        {
            var random = new Random();
            for (int i = 0; i < images.Length; i++)
            {
                Image tmp = images[i];
                int j = random.Next(i, images.Length);
                images[i] = images[j];
                images[j] = tmp;

            }
            return images;
         
        }
    }
}
