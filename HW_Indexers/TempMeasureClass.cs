using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Indexers
{
    public class Measurments
    {
        public string City { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public double TempInCelcius { get; set; }
    }

    public class MeasurmentManagement
    {
        Measurments[] measurment = new Measurments[31];
        int counter = 0;

        public void Add(Measurments myMeasure)
        {
            if(myMeasure == null)
            {
                throw new ArgumentNullException();
            }
            measurment[counter] = myMeasure;
            counter++;
        }

        public double this [int dayInMonth]
        {
            get
            {
                if(dayInMonth < 0 || dayInMonth > measurment.Length + 1)
                {
                    throw new IndexOutOfRangeException();
                }

                foreach (var measure in measurment)
                {
                    if(measure.Day == dayInMonth)
                    {
                        return measure.TempInCelcius;
                    }
                }
                return 0;

                
            }
        }

        /*
         * The next indexer will not be available because it gets the 
         * same type of argument as the previous.
        */


        //public Measurments this[int dayInMonth]
        //{
        //    get
        //    {
        //        if (dayInMonth < 0 || dayInMonth > measurment.Length + 1)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }

        //        return measurment[dayInMonth];
        //    }
        //}

        public double this [string city]
        {
            get
            {
                for (int i = 0; i < measurment.Length; i++)
                {
                    if(measurment[i].City == city)
                    {
                        return measurment[i].TempInCelcius;
                    }
                }
                return 0;
            }
        }

        public bool this[string city, int day, int month]
        {
            get
            {
                foreach (var measure in measurment)
                {
                    if(measure == null)
                    {
                        return false;
                    }
                    if(measure.City == city && measure.Day == day && measure.Month == month)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
