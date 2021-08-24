using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Indexers
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //double[,] measurments = new double[2, 28];

            //for (int i = 0; i < measurments.GetLength(1); i++)
            //{
            //    measurments[0, i] = i + 1;
            //}

            //for (int j = 0; j < measurments.GetLength(1); j++)
            //{
            //    Random rnd = new Random();
            //    int sumNum = rnd.Next(23, 40);
            //    double theDoublePart = rnd.NextDouble();
            //    measurments[1, j] = sumNum + theDoublePart;
            //}

            
        }

        //public double GetTempByDay(double[,] tempTwoDimArr, int dayInMonth)
        //{
        //    if(dayInMonth < 0 || dayInMonth > tempTwoDimArr.GetLength(1))
        //    {
        //        throw new IndexOutOfRangeException();
        //    }
        //    return tempTwoDimArr[1, dayInMonth - 1];
        //}
    }
}
