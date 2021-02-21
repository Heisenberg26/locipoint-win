using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LociPoint
{
    public class Score
    {
        public string value { get; set; }
        public string type { get; set; }
        public string date { get; set; }
        public int userId { get; set; }
        public int id { get; set; }
        public static string calculateScore(List<string> memoList, List<string> recallList)
        {
         
            int correct = 0;
          
            for (int i=0; i<recallList.Count; i++)
            {
                if (memoList[i] == recallList[i])
                {
                    correct++;
                }


            }
            
         
            return correct.ToString() + "/" + memoList.Count.ToString();
        }

        
    }
}
