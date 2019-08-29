using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroToMethods _ITM = new IntroToMethods();
            string reverseName;
            string fullName;
            fullName = _ITM.ConcatFNameAndLName("First Name", "Last Name", out reverseName);
            Console.WriteLine(reverseName);

            Console.WriteLine(_ITM.ConcatFNameAndLNameWithDefault("asd"));
        }
    }

    class IntroToMethods
    {
        public string ConcatFNameAndLName(string fname, string lname, out string reverseName)
        {
            reverseName = lname + " " + fname;
            return fname + " " + lname;
        }

        public string ConcatFNameAndLNameWithDefault(string fname = "Legally" , string lname = "Blonde")
        {
            return fname + " " + lname;
        }
    }
}
