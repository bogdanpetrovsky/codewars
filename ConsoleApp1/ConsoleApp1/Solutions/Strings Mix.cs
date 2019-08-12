using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Strings_Mix
    {
        public static string Mix(string s1, string s2)
        {

            var first = s1.Where(c => char.IsLower(c) && char.IsLetter(c)).GroupBy(a => a, b => b).Select(a => new { letter = a.Key, count = a.Count() });

            var second = s2.Where(c => char.IsLower(c) && char.IsLetter(c)).GroupBy(a => a, b => b).Select(a => new { letter = a.Key, count = a.Count() });

            var common = first.Concat(second).GroupBy(a => a.letter, b => b);

            var sGrouped = common.Select(a => new {
                count = a.OrderByDescending((p => p.count)).First().count,
                letter = a.Key,
                winner = s1.Count(i => i == a.Key) > s2.Count(i => i == a.Key) ? "1" : s1.Count(i => i == a.Key) < s2.Count(i => i == a.Key) ? "2" : "="
            });

            return string.Join("/", sGrouped.Where(o => o.count > 1)
                .OrderByDescending(o => o.count)
                .ThenBy(o => int.Parse(o.winner == "=" ? "3" : o.winner))
                .ThenBy(o => o.letter).Select(gz => gz.winner + ":" + new string(gz.letter, gz.count)));
        }
    }
}
