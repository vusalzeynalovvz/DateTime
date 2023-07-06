using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string dateFormat = "dd_MM_yyyy";

            Console.WriteLine("Tarixi daxil edin (dd_MM_yyyy):");
            string userInput = Console.ReadLine();

            try
            {
                //CultureInfo culture = new CultureInfo("az-Latn-AZ");
                DateTime userDate = DateTime.ParseExact(userInput, dateFormat, new CultureInfo("az-Latn-AZ"));
                Console.WriteLine("Tarix: " + userDate.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xeta: " + ex.Message);
            }
        }

    }
}

//User - dan tarixi "dd _ MM _ yyyy" formatinda qebul eden ve onu DateTime strukturuna cheviren bir kodu yazin. DateTime.ParseExact()
//metodun - dan istifade edin.Atila bilen exception-larin qarshisini try/catch vasitesi ile alin.Error olan halda atilan
//    exception-un.Message property-sini console-da gorsedin.