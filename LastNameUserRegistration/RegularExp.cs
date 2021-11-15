using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LastNameUserRegistration
{
    public class RegularExp
    {
        public string Name;  // instance veriable 

        // intialize parameterise constructer and store the user inpute name
        public RegularExp(string Name)
        {
            this.Name = Name;

        }
        //We are using this method to match pattern of first name
        public string validFirstName()
        {
            string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";  //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(firstname);

            if (regex.IsMatch(Name))
            {
                //Console.WriteLine(Name + "-->Valid");
                return "Valid";
            }
            else
            {
                // Console.WriteLine(Name + "--->Invalid");
                return "Invalid";
            }
        }
        public string LastName(string Lname)
        {
            string lastname = "^[A-Z]{1}[a-zA-Z]{2}$";      //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(lastname);

            if (regex.IsMatch(Lname))
            {
                //Console.WriteLine(name + "-->Valid");
                return "Valid";
            }
            else
            {
                // Console.WriteLine(name + "--->Invalid");
                return "Invalid";
            }
        }
    }
}
