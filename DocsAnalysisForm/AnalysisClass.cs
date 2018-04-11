using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using YandexMystem.Wrapper;
using System.Threading.Tasks;

namespace DocsAnalysisForm
{
    static class AnalysisClass
    {
        public static Dictionary<string, int> GetWordsFreq(this List<string> src)
        {
            return src.SelectMany(s => s.Split(' '))
                      .GroupBy(w => w)
                      .ToDictionary(g => g.Key, g => g.Count());
        }
        public static List<string> GetWordsFromAllFiles(this List<Dictionary<string, int>> dicts)
        {
            var result = dicts.SelectMany(dict => dict)
                         .ToLookup(pair => pair.Key, pair => pair.Value)
                         .Select(group => group.Key)
                         .ToList();
            return result.OrderBy(x => x).ToList();
        }
        public static List<Dictionary<string, int>> FinalWordsFreq(List<string> words, List<Dictionary<string, int>> dicts)
        {
            var finalResult = new List<Dictionary<string, int>>();
            foreach (var dict in dicts)
            {
                var result = new Dictionary<string, int>();
                int? freq;
                foreach (string word in words)
                {
                    freq = dict.Where(x => x.Key.Contains(word)).Select(x => x.Value).Sum();
                    result.Add(word, (int)freq);
                }
                finalResult.Add(result);
            }
            return finalResult;
        }
        public static List<string> StemSrcText(string path)
        {
            var result = new List<string>();
            Mysteam mst = new Mysteam();
            var fileText = File.ReadAllLines(path);
            var text = string.Join("", fileText);
            foreach (var word in mst.GetWords(text).Where(x => x.SourceWord.Text.Length > 2))
            {
                try { result.Add(word.Lexems[0].SourceLex.Lex.ToLower()); }
                catch { result.Add(word.SourceWord.Text.ToLower()); }
            }
            return result;
        }
        public static double CosMeasure(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            List<int> firstFreq = dict1.Select(x => x.Value).ToList();
            List<int> secondFreq = dict2.Select(x => x.Value).ToList();
            double upper = 0.0;
            for(int i = 0; i < firstFreq.Count; i++)
                upper += (firstFreq[i] * secondFreq[i]);
            double lower = Math.Sqrt(firstFreq.Select(x => x * x).Sum()) * Math.Sqrt(secondFreq.Select(x => x * x).Sum());
            return upper / lower;
        }
        public static double JaccardMeasure(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            List<int> firstFreq = dict1.Select(x => x.Value).ToList();
            List<int> secondFreq = dict2.Select(x => x.Value).ToList();
            double upper = 0.0, lower = 0.0;
            for (int i = 0; i < firstFreq.Count; i++)
            {
                upper += Math.Min(firstFreq[i], secondFreq[i]);
                lower += Math.Max(firstFreq[i], secondFreq[i]);
            }
            return upper / lower;
        }
    }
}
