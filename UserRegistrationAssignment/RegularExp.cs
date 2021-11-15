using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationAssignment
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
        public string MailValidation(string Email)
        {
            string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$"; // RegEx Expression for gmail 
            Regex regex = new Regex(emailPattern);

            if (regex.IsMatch(Email))
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

        public string MobileNo(string number)
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

        // UC5 Password RegEx smallest letter password max size 8
        public string Validpassword1(string pass)
        {
            string Password = "^[a-z]{8}$";    // Regex exp for smallest 8 letter  password 
            Regex regex = new Regex(Password);        //creating a regex named obj with regular pwd.
            if (regex.IsMatch(pass))
            {
                //Console.WriteLine(pass + "-- > Valid");
                return "Valid";
            }
            else
                // Console.WriteLine(pass + "-- > InValid");
                return "InValid";
        }

        // UC6 Password RegEx should have at least one Alphabet char in the password
        public string Validpassword2(string pass)
        {
            string Password = "^(?=.*[A-Z])[a-zA-Z]{8}$";    // Regex exp for  8 letter in should have at least one Uppercase  password 
            Regex regex = new Regex(Password);        //creating a regex named obj with regular pwd.
            if (regex.IsMatch(pass))
            {
                //Console.WriteLine(pass + "-- > Valid");
                return "Valid";
            }
            else
                // Console.WriteLine(pass + "-- > InValid");
                return "InValid";
        }

        // UC7 Password RegEx should have at least one numaric number in the password
        public string Validpassword3(string pass)
        {
            // Add at least one numaric number
            string Password = "^(?=.*[0-9])(?=.*[A-Z])[a-zA-Z0-9]{8}$";   // Regex exp for  8 letter in should have at least one Uppercase  password 
            Regex regex = new Regex(Password);        //creating a regex named obj with regular pwd.
            if (regex.IsMatch(pass))
            {
                //Console.WriteLine(pass + "-- > Valid");
                return "Valid";
            }
            else
                // Console.WriteLine(pass + "-- > InValid");
                return "InValid";
        }

        // UC8 compleate Password RegEx should have at least one numaric number & Capital Alphabet& Speciaal char in the password
        public string Validpassword4(string pass)
        {
            // Add at least one numaric number
            string Password = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8}$";  // Regex exp  should have at least one Uppercase,number,special char password 
            Regex regex = new Regex(Password);        //creating a regex named obj with regular pwd.
            if (regex.IsMatch(pass))
            {
                //Console.WriteLine(pass + "-- > Valid");
                return "Valid";
            }
            else
                // Console.WriteLine(pass + "-- > InValid");
                return "InValid";
        }

        ////uc9 Regex Pattern for maill format
        

        public static string CompleteMailFormat(string patternmail1)
        {
           
            string GEmail = "^[a-zA-Z0-9]+[+-._]{0,1}[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]*[@][a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}([.]?[a-zA-Z]{2,3}){0,1}$";  // Regex exp  should have at least one Uppercase,number,special char password 
            Regex regex = new Regex(GEmail);      
            if (regex.IsMatch(patternmail1))
            {
                //Console.WriteLine(pass + "-- > Valid");
                return "Valid";
            }
            else
                // Console.WriteLine(pass + "-- > InValid");
                return "InValid";
        }
    }
}
