using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PasswordGenorator
    {
        private string password;
        //sorry I stole this from you
        private readonly Random rand = new Random(System.DateTime.Now.Millisecond);
        public PasswordGenorator()
        { 
            password = "";
        }

        public string generatePassword(int alength, bool capitals, bool numbers, bool specialChars, string specialCharOptions)
        //this will generate a string of random chars then call to the check function to ensure that all char fall within the ranges they are supposed to
        {
            for (int i = 0; i < alength+5; i++)
            {
                char temp;
                temp = this.generateChar(capitals, numbers, specialChars, specialCharOptions);
                password = password + temp;
            }
            return password;
        }
        



        private char generateChar(bool capitals, bool numbers, bool specialChars, string specialCharOptions)
        {
            //generate random number 0-94 and set a random char
     
            char tchar;
            int temp = rand.Next(33, 126);
            if (temp > 96 && temp < 123)
            {
                tchar = Convert.ToChar(temp);
                return tchar;
            }
            else if (capitals==true && temp > 64 && temp < 91)
            {
                tchar = Convert.ToChar(temp);
                return tchar;
            }
            else if (temp > 47 && temp < 58 && numbers == true)
            {
                tchar = Convert.ToChar(temp);
                return tchar;
            }
            else if (specialChars == true)
            {
                //it would be easier if it is trying to generate a special char to just pull it from the list rather than try to force a random generation. It would make it more likely that a special char would be included.
                temp = rand.Next(0,specialCharOptions.Length-1);
                tchar = specialCharOptions[temp];
                return tchar;
            }
            else
            {
                temp = '.';
                temp = generateChar(capitals, numbers, specialChars, specialCharOptions);
                tchar = Convert.ToChar(temp);
                return tchar;
            }
        }
    };
}
