using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LociPoint
{
   public class Time
    {
        public int Hours { get; set; }
        public int Mins { get; set; }
        public int Secs { get; set; }
        public Time(int hours, int mins, int secs)
        {
            Hours = hours;
            Mins = mins;
            Secs = secs;
        }
        public Time(String hours, String mins, String secs) {
            int hrs = Hours;
            int min = Mins;
            int sec = Secs;
            bool isParsable = Int32.TryParse(hours, out hrs) && Int32.TryParse(mins, out min) && Int32.TryParse(secs, out sec);
            if (isParsable)
            {

                Hours = hrs;
                Mins = min;
                Secs = sec;
            }
            else {

                Hours = 0;
                Mins = 0;
                Secs = 0;
            }
        }
     
        public void tickTime()
        {
            Secs--;
            if (Secs < 0)
            {
                if (Mins < 0)
                {
                    if (Hours > 0)
                    {
                        Secs = 59;
                        Mins = 59;
                        Hours--;
                    }

                }
                else
                {
                    Secs = 59;
                    Mins--;
                }

            }
            if (Mins < 0)
            {
                if (Hours > 0)
                {
                    Mins = 59;
                    Hours--;
                }
                else
                {
                    Mins = 0;
                }


            }
            if (Hours < 0)
            {
                Hours = 0;
            }
        }

        public bool isTimeZero() {

            if (Hours == 0 && Mins == 0 && Secs == 0)
            {
                return true;
            }
            else {

                return false;
            }
        
        }

       

        public void formatTime(Label labelHrs, Label labelMins, Label labelSecs)
        {
            //formats indicated time of labels according to timer

            if (Hours < 10)
            {
                labelHrs.Text = "0" + Hours.ToString();
            }
            else
            {

                labelHrs.Text = Hours.ToString();
            }
            if (Mins < 10)
            {
                labelMins.Text = "0" + Mins;
            }
            else
            {

                labelMins.Text = Mins.ToString();
            }

            if (Secs < 10)
            {
                labelSecs.Text = "0" + Secs.ToString();
            }
            else
            {

                labelSecs.Text = Secs.ToString();
            }

        }
    }
}

