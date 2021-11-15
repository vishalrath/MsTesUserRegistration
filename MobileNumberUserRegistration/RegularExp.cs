using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MobileNumberUserRegistration
{
    public class RegularExp
    {
        //public string Name;  // instance veriable 

        ////// intialize parameterise constructer and store the user inpute name
        //public RegularExp(string Name)
        //{
        //    this.Name = Name;

        //}
        //We are using this method to match pattern of first name
        public string validFirstName(string Name)
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
        public string MailValidation(string mail)
        {
            string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$"; // RegEx Expression for gmail 
            Regex regex = new Regex(emailPattern);

            if (regex.IsMatch(mail))
            {
                //Console.WriteLine(mail + "-- > Valid");
                return "Valid";
            }
            else
            {
                //Console.WriteLine(mail + "-- > InValid");
                return "Invalid";
            }
        }

        public  string MobileNo(string number)
        {
            string Mobnumber = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";  //Expression for Validating mobileFormating
            Regex regex = new Regex(Mobnumber);

            if (regex.IsMatch(number))
            {
                //Console.WriteLine(number + "-- > Valid");
                return "Valid";
            }
            else
            {
                //Console.WriteLine(number + "-- > InValid");
                return "Invalid";
            }

        }
    }
}
