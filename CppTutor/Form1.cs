using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CppTutor
{
    public partial class Form1 : Form
    {
        int currentChapter = 1;
        Problem problem = new Problem();


        public Form1()
        {
            InitializeComponent();
            ProblemText.Text = problem.LoadProblem(currentChapter);
        }

        private void button1_Click(object sender, EventArgs e)
        {                    
            AnswerText.Text=problem.RunAndCheck(CodeText.Text, problem.LoadTests(currentChapter));
            CheckChapterComplite();
        }

        private void CheckChapterComplite() {
            if (AnswerText.Text == "Accepted")
            {
                currentChapter++;
                ProblemText.Text = problem.LoadProblem(currentChapter);
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Save";
            openFileDialog1.Filter = "Файл сохранения|*.sav";
            openFileDialog1.ShowDialog();
            currentChapter = Convert.ToInt32(File.ReadAllText(openFileDialog1.FileName));
            ProblemText.Text = problem.LoadProblem(currentChapter);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Save";
            saveFileDialog1.Filter = "Файл сохранения|*.sav";
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName, currentChapter.ToString());
        }
    }
}
