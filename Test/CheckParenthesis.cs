using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class CheckParenthesis
    {
        bool Basic(string input)
        {
            char[,] balancedPairs = new char[,] { { '(', ')' },
                                                  { '{', '}' },
                                                  { '[', ']' } };

            int maxRows = balancedPairs.GetLength(0);

            Stack<char> matches = new();

            foreach (char c in input)
            {
                for (int currentRow = 0; currentRow < maxRows; currentRow++)
                {
                    if (c == balancedPairs[currentRow, 1])
                    {
                        if ((matches.Count == 0) || (matches.Pop() != balancedPairs[currentRow, 0])) return false;
                        break;
                    }
                    if (c == balancedPairs[currentRow, 0])
                    {
                        matches.Push(c);
                        break;
                    }
                }
            }

            if (matches.Count != 0) return false;

            return true;
        }

        //bool Dict(string input)
        //{
        //    var balancedPairs = new Dictionary<char, char>
        //            {
        //                { ')', '(' },
        //                { '}', '{' },
        //                { ']', '[' }
        //            };

        //    var inputCharacterMatches = new Stack<char>();

        //    foreach (char inputCharacter in input)
        //    {
        //        if ((balancedPairs.ContainsKey(inputCharacter)) &&
        //            (inputCharacterMatches.Count == 0 || inputCharacterMatches.Pop() != balancedPairs.GetValueOrDefault(inputCharacter))) return false;
        //        if (balancedPairs.ContainsValue(inputCharacter)) inputCharacterMatches.Push(inputCharacter);
        //    }

        //    if (inputCharacterMatches.Count != 0) return false;

        //    return true;
        //}
    }
}
