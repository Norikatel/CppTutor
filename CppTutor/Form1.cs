using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CppTutor
{
    public partial class Form1 : Form
    {

        private int CurrentChapter
        {
            get { return curriculum[currentStep].Key; }
        }
        private int CurrentProblem
        {
            get { return curriculum[currentStep].Value; }
        }
        int currentStep = 0;
        bool isProblemText = false;
        Problem problem = new Problem();
        List<KeyValuePair<int, int>> curriculum = new List<KeyValuePair<int, int>>();

        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= problem.CountChapter(); i++)
                curriculum.Add(new KeyValuePair<int, int>(i, new Random().Next(problem.CountProblem(i)) + 1));
            ProblemText.Text = problem.LoadChapter(CurrentChapter);
        }

        private void Check_Click(object sender, EventArgs e)
        {
            AnswerText.Text = problem.RunAndCheck(CodeText.Text, problem.LoadTests(CurrentChapter, CurrentProblem));
            CheckChapterComplite();
        }

        private void ProblemLoad_Click_1(object sender, EventArgs e)
        {
            if (!isProblemText)
            {
                ProblemText.Text = problem.LoadProblem(CurrentChapter, CurrentProblem);
                isProblemText = true;
            }
            else
            {
                ProblemText.Text = problem.LoadChapter(CurrentChapter);
                isProblemText = false;
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void CheckChapterComplite()
        {
            if (AnswerText.Text == "Accepted")
                if (currentStep < curriculum.Count - 1)
                {
                    currentStep++;
                    ProblemText.Text = problem.LoadChapter(CurrentChapter);
                    isProblemText = false;
                }
                else
                {
                    ProblemText.Text = "Поздравляем, вы прошли курс!";
                    currentStep = 0;
                }
        }
        private void LoadFile()
        {
            openFileDialog1.FileName = "Save";
            openFileDialog1.Filter = "Файл сохранения|*.sav";
            openFileDialog1.ShowDialog();
            LoadCurriculum(File.ReadAllText(openFileDialog1.FileName));
            ProblemText.Text = problem.LoadChapter(CurrentChapter);
            isProblemText = false;
        }

        private void SaveFile()
        {
            saveFileDialog1.FileName = "Save";
            saveFileDialog1.Filter = "Файл сохранения|*.sav";
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName, SaveCurriculum());
        }

        private void LoadCurriculum(string input)
        {
            curriculum.RemoveAll(i => i is KeyValuePair<int, int>);
            string[] splitString = input.Split(';');
            currentStep = Convert.ToInt32(splitString[1]) - 1;
            splitString = splitString[0].Split(',');
            for (int i = 0; i < splitString.Length; i++)
                curriculum.Add(new KeyValuePair<int, int>(Convert.ToInt32(splitString[i].Split(':')[0]),
                    Convert.ToInt32(splitString[i].Split(':')[1])));
        }

        private string SaveCurriculum()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var p in curriculum)
                sb.Append(p.Key + ":" + p.Value + ",");
            sb.Remove(sb.Length - 1, 1);
            sb.Append(";" + (currentStep + 1));
            return sb.ToString();
        }

        private void CreateCurriculumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CurriculumCreator().ShowDialog();
        }
    }
}
