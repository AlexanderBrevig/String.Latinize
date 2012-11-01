using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latinize
{
    public static class StringLatinizeExtension
    {
        /// <summary>
        /// Make any unicode string conform to [a..zA..Z], keep whitespace and symbols/numbers
        /// </summary>
        /// <param name="text">The text to be latinized</param>
        /// <returns>The latinized text</returns>
        public static string Latinize(this String text)
        {
            foreach (KeyValuePair<string,string> kvp in map){
                foreach (var chr in kvp.Key.ToCharArray()) {
                    text = text.Replace(""+chr, kvp.Value);
                }
            }
            return text;
        }

        private static Dictionary<string, string> map = new Dictionary<string, string>() {
            {"äæåâáàã", "a"},
            {"ÄÆÅÂÁÀÃ", "A"},

            {"ç", "c"},
            {"Ç", "C"},
            
            {"éèêëĕ", "e"},
            {"ÉÈÊËĔ", "E"},

            {"øö", "o"},
            {"ØÖ", "O"}
        };
    }
}
