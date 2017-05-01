using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class EditSettings
    {
        private int length;
        private bool capitals;
        private bool numbers;
        private bool specChar;
        private string specCharOptions;

        public EditSettings()
        {
            length = 5;
            capitals = true;
            numbers = true;
            specChar = true;
            specCharOptions = "$%^&*()";
        }
        public void setLength(string alength)// I know it should be a void but the only way I know how to do error messages
        {
            int length = 0;
            for (int i=0;i<alength.Length;i++)
            {
                if(alength[i]<48||alength[i]>57)
                {
                    errorMessage("length");
                    return;
                }
                else if(string.IsNullOrEmpty(alength))
                {
                    errorMessage("length");
                    return;
                }
                else if(alength.Length>=4)
                {
                    errorMessage("length");
                    return;
                }
                else if(Convert.ToInt16(alength)<1)
                {
                    errorMessage("length");
                    return;
                }
                else
                {
                    length = Convert.ToInt16(alength);
                    return;
                }

            }
        }

        public void setSettings(string lengthEntry, string aspecialCharOptions, bool acapitals, bool anumbers, bool aspecialChar)
        {
            setLength(lengthEntry);
            capitals = acapitals;
            numbers = anumbers;
            specChar = aspecialChar;
            if(specChar==true)
            {
                if(string.IsNullOrEmpty(specCharOptions))
                {
                    errorMessage("blankSpecial");
                }
                else
                {
                    specCharOptions = aspecialCharOptions;
                }
            }


            specCharOptions = aspecialCharOptions;

        }

        public string errorMessage(string errorType)
        {
            if (errorType == "length")
            {
                return "Please enter a valid number between 0 and 9999.";
            }
            else if (errorType == "None")
            {
                return "";
            }
            else if(errorType=="blankSpecial")
            {
                return "Please enter a list of special characters or uncheck Include Special Characters.";
            }
            else
            {
                return "Error";
            }
        }

        public int getLength()
        {
            return length;
        }
        public bool getCapitals()
        {
            return capitals;
        }
        public bool getNumber()
        {
            return numbers;
        }
        public bool getSpecialChar()
        {
            return specChar;
        }
        public string getSpecialCharOptions()
        {
            return specCharOptions;
        }
    }
}
