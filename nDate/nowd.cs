using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nDate
{
    public class nowd
    {
        public DateTime nowdatevar;
        public DateTime dateout;
        public void nowdate()
        {
            nowdatevar = DateTime.Now;

            string midtime = "02:59:59.000";
            string outtime = "13:59:59.000";
            string dtpoint = "23:59:59.000";

            string trimdate = nowdatevar.ToString("yyyy/MM/dd ");
            string trimtime = nowdatevar.ToString("HH:mm:ss.fff");

            if (nowdatevar > Convert.ToDateTime(trimdate + midtime) && nowdatevar < Convert.ToDateTime(trimdate+dtpoint))
            {
                string dateoutstring = Convert.ToString(trimdate+ outtime);
                dateout = Convert.ToDateTime(dateoutstring).AddDays(+1);
                return;
            }
            else
            {
                string dateoutstring = Convert.ToString(trimdate + outtime);
                dateout = Convert.ToDateTime(dateoutstring);
                return;
            }
        }

        public void seldate(DateTime dt)
        {
            nowdatevar = dt;

            string midtime = "02:59:59.000";
            string outtime = "13:59:59.000";
            string dtpoint = "23:59:59.000";

            string trimdate = nowdatevar.ToString("yyyy/MM/dd ");
            string trimtime = nowdatevar.ToString("HH:mm:ss.fff");

            if (nowdatevar > Convert.ToDateTime(trimdate + midtime) && nowdatevar < Convert.ToDateTime(trimdate + dtpoint))
            {
                string dateoutstring = Convert.ToString(trimdate + outtime);
                dateout = Convert.ToDateTime(dateoutstring).AddDays(+1);
                return;
            }
            else
            {
                string dateoutstring = Convert.ToString(trimdate + outtime);
                dateout = Convert.ToDateTime(dateoutstring);
                return;
            }
        }
    }
}
