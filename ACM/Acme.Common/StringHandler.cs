using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpacesInWords (this string source)
        {
            string result = string.Empty;

            if(!String.IsNullOrWhiteSpace(source)) //if there is no whitespace in the string called source..
            {
                foreach(var letter in source) //cycle through the combined words "ex SonicHammer"
                {
                    if(char.IsUpper(letter))
                    {
                        result = result.Trim(); //trims any whitespace that already exists "Hot Dog" is
                        //now "HotDog"
                        result += " ";//add whitespace at the end of word & beginning 
                        //of new word that starts
                        //with capital letter
                    }
                    result += letter;//then add the letter of the following word "Sonic Hammer"
                }
            }
            result = result.Trim(); //trims white space that precedes first capital letter of word
            //" Sonic Hammer" NOW it's "Sonic Hammer"
            return result;
        }

    }
}
