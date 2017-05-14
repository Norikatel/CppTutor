using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CppTutor
{
    public partial class CurriculumCreator : Form
    {
        Problem problem = new Problem();
        List<KeyValuePair<int, int>> curriculum = new List<KeyValuePair<int, int>>();

        public CurriculumCreator()
        {
            InitializeComponent();
            for (int i = 1; i <= problem.CountChapter(); i++)
                for (int j = 1; j <= problem.CountProblem(i); j++)
                    checkedListBox1.Items.Add(problem.LoadChapterInfo(i) + " " + problem.LoadProblemInfo(i, j));
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveNewCurriculum();
        }

        private void SaveNewCurriculum()
        {
            saveFileDialog1.FileName = "Curriculum";
            saveFileDialog1.Filter = "Файл сохранения|*.sav";
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName, NewCurriculum());
        }

        private string NewCurriculum()
        {
            StringBuilder sb = new StringBuilder();
            int k = 0;
            for (int i = 1; i <= problem.CountChapter(); i++)
                for (int j = 1; j <= problem.CountProblem(i); j++)
                {
                    if (checkedListBox1.GetItemChecked(k))
                        sb.Append(i + ":" + j + ",");
                    k++;
                }
            sb.Remove(sb.Length - 1, 1);
            sb.Append(";1");
            return sb.ToString();
        }
    }
}
