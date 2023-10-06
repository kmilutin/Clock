using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Clock
{
    public class SetTime
    {

        public static Model GetTime()
        {

            System.DateTime moment = DateTime.Now;

            double hourAngles = (360 / 12) * moment.Hour;
            double minuteAngles = (360 / 60) * moment.Minute;
            double secondAngles = (360 / 60) * moment.Second;

            Model setTime = new Model() 
            { 
                SecondAngles = secondAngles, 
                MinuteAngles = minuteAngles, 
                HourAngles = hourAngles,
            };

            return setTime; 
              
        }
    }
}
