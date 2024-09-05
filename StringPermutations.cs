using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public class StringPermutations
    {
        public static IEnumerable<string> GetAllSequences(IEnumerable<char> chars)
        {
            if (!chars.Any())
            {
                yield return string.Empty;
            }
            else
            {
                for (int i = 0; i < chars.Count(); i++)
                {
                    var currentChar = chars.ElementAt(i);
                    var remainingChars = chars.Where((c, index) => index != i);

                    foreach (var subSequence in GetAllSequences(remainingChars))
                    {
                        yield return currentChar + subSequence;
                    }
                }
            }
        }
    }
}
