using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgo
{
    public class RemoveDuplicateCharacter
    {
        public static string RemoveDuplicateChars(string key)
        {
            // Normalize string
            key = key.ToLower();
            // --- Removes duplicate chars using string concats. ---
            // Store encountered letters in this string.
            string result = string.Empty;

            // Loop over each character.
            foreach (char value in key)
            {
                // See if character is in the table.
                if (!result.Contains(value))
                {
                    // Append to the result.

                    result += value;
                }
            }
            //return result;
            return result;
        }
    }
}
