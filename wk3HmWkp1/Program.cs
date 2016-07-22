using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk3HmWkp1
{
    class Program
    {
        //Method for Problem Four
        static void ProblemFour (string getZeroOut)
        {
            int o = getZeroOut.LastIndexOf('0');
            if (o == -1)
            {
                Console.WriteLine("This String is okay!");
            }
            else
            {
                getZeroOut = getZeroOut.Remove(o, 1);
                Console.WriteLine(getZeroOut);
            }
        }
        //Method for Problem Three
        static string ProblemThree(string fName, string lName)
        {
            
            char one = fName[0];
            fName=fName.Remove(0, 1);
            string oneUp = one.ToString().ToUpper();

            char two = lName[0];
            lName=lName.Remove(0, 1);
            string twoUp = two.ToString().ToUpper();
            string output = oneUp + fName + " " + twoUp + lName;
            return output;
        }
        //Method for Problem Two
        static void ProblemTwo (string name, string month)
        {
            string aAn = "a";
            if (month.ToLower() == "october" || month.ToLower() == "august"|| month.ToLower() == "april")
            {
                aAn = "an";
            }
            Console.WriteLine($"{name} is {aAn} {month} baby!");
        }
        //Method for Problem One
        static void ProblemOne(string input)
        {
            string[] reverseString = input.Split();
            for (int i = reverseString.Length-1; i>=0; i--)
            {
                Console.Write(reverseString[i]+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Call/Input for Problem One
            ProblemOne("my heart will go on");
            //Gather input for Problem Two
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What month were you born?");
            string month = Console.ReadLine();
            //Call for Problem Two
            ProblemTwo(name, month);
            //Gather Input for Problem Three
            Console.WriteLine("What is your first name?");
            string fName = Console.ReadLine().ToLower();
            Console.WriteLine("What is your last name?");
            string lName = Console.ReadLine().ToLower();
            //Call for Problem Three
            string output = ProblemThree(fName, lName);
            //Output for Problem Three
            Console.WriteLine(output);
            //Test String for Problem Four
            string getZeroOut = "It's fri0day!";
            //Call for Problem Four
            ProblemFour(getZeroOut);

        }
    }
}
