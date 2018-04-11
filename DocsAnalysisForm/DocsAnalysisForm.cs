using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocsAnalysisForm
{
    public partial class DocsAnalysisForm : Form
    {
        public DocsAnalysisForm()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            WordsTableDGV.DataSource = null;
            var dicts = new List<Dictionary<string, int>>();
            for (int i = 1; i <= 5; i++)
            {
                var stemWords = AnalysisClass.StemSrcText(Application.StartupPath + string.Format("/AllText/text{0}.txt", i));
                var dict = stemWords.GetWordsFreq().OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                dicts.Add(dict);
            }
            var allWords = AnalysisClass.GetWordsFromAllFiles(dicts).Where(x => x.Length > 2).OrderBy(x => x).ToList();
            var result = AnalysisClass.FinalWordsFreq(allWords, dicts);

            string[,] table = new string[allWords.Count, result.Count + 1];
            WordsTableDGV.Columns.Add("Word", "Слово");
            for (int t = 1; t < table.GetLength(1); t++)
                WordsTableDGV.Columns.Add("Text" + t.ToString(), "Текст " + t.ToString());

            for (int i = 0; i < table.GetLength(0); i++)
            {
                table[i, 0] = allWords[i];
                for (int j = 1; j < table.GetLength(1); j++)
                    table[i, j] = result[j-1].Where(x => x.Key == allWords[i]).Select(x => x.Value).First().ToString();
            }

            int height = table.GetLength(0);
            int width = table.GetLength(1);

            WordsTableDGV.ColumnCount = width;
            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(WordsTableDGV);

                for (int c = 0; c < width; c++)
                    row.Cells[c].Value = table[r, c];

                WordsTableDGV.Rows.Add(row);
            }

            string resultText = "";
            for (int i = 0; i < result.Count; i++)
                for (int j = i + 1; j < result.Count; j++)
                    resultText += string.Format("Sim-cos(Текст {0}, Текст {1}) = {2}\r\n" +
                                                "Sim-Jaccard(Текст {0}, Текст {1}) = {3}\r\n\r\n",
                                                i + 1, j + 1, AnalysisClass.CosMeasure(result[i], result[j]), 
                                                AnalysisClass.JaccardMeasure(result[i], result[j]));
            ResultTB.Text = resultText;
        }
    }
}
