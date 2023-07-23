using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace cbmprocessor
{
    public class cbmprocessor
    {
        public DateTime getindate, getoutdate, setindate, setoutdate;
        public DateTime checkouttime,checkintime;
        public TimeSpan dif;
        public string outstring;
        public int days = 0;
        public void daycounter(DateTime get_indate,DateTime get_outdate)
        {
            getindate = Convert.ToDateTime(get_indate.ToString("yyyy/MM/dd HH:mm:ss.fff")); // load user input date of checkin
            getoutdate = Convert.ToDateTime(get_outdate.ToString("yyyy/MM/dd HH:mm:ss.fff")); // load user input date of checkout

            string timein = getindate.ToString("HH:mm:ss.fff"); // Crop Time from indatetime
            string datein = getindate.ToString("yyyy/MM/dd "); // Crop Date from indatetime

            string timeout = getoutdate.ToString("HH:mm:ss.fff"); // Crop Time from outdatetime
            string dateout = getoutdate.ToString("yyyy/MM/dd "); // Crop Date from outdatetime

            string midindatein = datein + "02:59:59.000"; // mid point
            string checkouttime = dateout + "13:59:59.000"; // checkout time

            if (getindate > Convert.ToDateTime(midindatein) && getoutdate < Convert.ToDateTime(checkouttime) && datein == dateout) // First 1 Day/unit clause
            {
                var datediff = (Convert.ToDateTime(dateout)).Subtract(Convert.ToDateTime(datein).AddDays(-1));
                days = datediff.Days;
            }
            else if (getindate > Convert.ToDateTime(midindatein) && getoutdate > Convert.ToDateTime(checkouttime) && datein == dateout) // First 1 day/unit clause with in same date
            {
                var datediff = (Convert.ToDateTime(dateout)).Subtract(Convert.ToDateTime(datein).AddDays(-1));
                days = datediff.Days;
                //days += 1;
            }
            else if (getindate < Convert.ToDateTime(midindatein) && getoutdate > Convert.ToDateTime(checkouttime) && datein == dateout) // Second 2 day/unit clause with in same date
            {
                var datediff = (Convert.ToDateTime(dateout)).Subtract(Convert.ToDateTime(datein).AddDays(-1));
                days = datediff.Days;
                days += 1;
            }
            else if (getindate > Convert.ToDateTime(midindatein) && getoutdate > Convert.ToDateTime(checkouttime) && Convert.ToDateTime(datein) < Convert.ToDateTime(dateout)) // after first midnight day/unit meter counter
            {
                var datediff = (Convert.ToDateTime(dateout)).Subtract(Convert.ToDateTime(datein));
                days = datediff.Days;
                days += 1;
            }
            else if (getindate > Convert.ToDateTime(midindatein) && getoutdate < Convert.ToDateTime(checkouttime))
            {
                var datediff = (Convert.ToDateTime(dateout)).Subtract(Convert.ToDateTime(datein));
                days = datediff.Days;
            }
            else if (getindate < Convert.ToDateTime(midindatein) && getoutdate > Convert.ToDateTime(checkouttime))
            {
                var datediff = (Convert.ToDateTime(dateout)).Subtract(Convert.ToDateTime(datein).AddDays(-1));
                days = datediff.Days;
                days += 1;
            }
            else
            {
                var datediff = (Convert.ToDateTime(dateout)).Subtract(Convert.ToDateTime(datein).AddDays(-1));
                days = datediff.Days;
            }
            


            //if (getindate < Convert.ToDateTime(midindatein)) // disadvantage
            //{
            //    if (getoutdate < Convert.ToDateTime(checkouttime))
            //    {
            //        days += 1;
            //    }
            //    else
            //    {
            //        days += 2;
            //    }
            //}
            //else if (getindate > Convert.ToDateTime(midindatein)) // advantage
            //{
            //    if (getoutdate < Convert.ToDateTime(checkouttime))
            //    {
            //        if (days == 0)
            //        {
            //            days = 1;
            //        }
            //    }
            //    else
            //    {
            //        if (Convert.ToDateTime(getindate.ToString("yyyy/MM/dd")) == Convert.ToDateTime(getoutdate.ToString("yyyy/MM/dd")))
            //        {
            //            days += 1;
            //        }
            //        else if (Convert.ToDateTime(getindate.ToString("yyyy/MM/dd")) < Convert.ToDateTime(getoutdate.ToString("yyyy/MM/dd")) && Convert.ToDateTime(getoutdate.ToString("HH:mm:ss.fff")) > Convert.ToDateTime(checkouttime))
            //        {
            //            days += 2;
            //        }
            //        days += 1;
            //    }
            //}
        }

    }
}
