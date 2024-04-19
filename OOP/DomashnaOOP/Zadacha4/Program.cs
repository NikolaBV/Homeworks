using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string language = "bulgarian";
            string theme = "dark";
            string font = "Arial";

            Console.WriteLine("What do you want to edit?");
            Console.WriteLine($"1. Language: {language}, 2. theme: {theme}, 3. font: {font}");
            Console.Write(" Type a number from 1 to 3: ");
            int input = int.Parse( Console.ReadLine() );
            switch ( input )
            {
                case 1:
                    EditProperty(ref language);
                    break;
                    case 2:
                    EditProperty(ref theme);
                    break;
                case 3:
                    EditProperty(ref font);
                    break;
                default:
                    break;
            }
            Console.WriteLine($"1. Language: {language}, 2. theme: {theme}, 3. font: {font}");
        }
        public static string EditProperty(ref string property)
        {
            Console.Write("Enter the new value: ");
            string newValue = Console.ReadLine();
            property = newValue;
            return property;

        }
    }
}
