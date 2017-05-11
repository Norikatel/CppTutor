using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CppTutor
{
    class Problem
    {
        private static List<String> allSolv = new List<String>();

        private byte Checker(string inp, string outp)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "fOut.exe",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true
                }
            };
            process.Start();
            process.StandardInput.WriteLine(inp);
            if (!process.WaitForExit(3000))
            {
                process.Kill();
                return 2;
            }
            if (process.StandardOutput.ReadLine() == outp)
                return 1;
            return 3;
        }

        private void Compile()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c g++ fIn.cpp -o fOut.exe 2>logs.txt",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();
            process.WaitForExit();
        }

        private bool InFile(string text)
        {
            try
            {
                File.WriteAllText("fIn.cpp", text);
                return true;
            }
            catch { return false; }
        }

        private string OutLogs()
        {
            try
            {
                string data = File.ReadAllText("logs.txt"); ;
                return data;
            }
            catch { return "Error"; }
        }

        public string RunAndCheck(string code, List<KeyValuePair<string, string>> checkList)
        {
            foreach (string s in allSolv)
                if (String.Compare(code, s) == 0)
                    return "Это решение уже отправлялось!";
            allSolv.Add(code.Replace(" ", string.Empty));
            InFile(code);
            Compile();
            string outs = OutLogs();
            if (outs != "")
                return outs;
            else
                foreach (var c in checkList)
                {
                    switch (Checker(c.Key, c.Value))
                    {
                        case 1:
                            break;
                        case 2:
                            return "Time Limit";
                        case 3:
                            return "Wrong Answer";
                    }
                }
            return "Accepted";
        }

        public string LoadProblem(int currentChapter)
        {
            try
            {
                return File.ReadAllText("Chapter" + currentChapter + "/ProblemText", Encoding.GetEncoding(1251));
            }
            catch (DirectoryNotFoundException e)
            {
                return "Поздравляем, вы прошли курс!";
            }
        }

        public List<KeyValuePair<string, string>> LoadTests(int currentChapter)
        {
            List<KeyValuePair<string, string>> checkList = new List<KeyValuePair<string, string>>();
            int numTest = 1;
            try
            {
                while (true)
                {
                    checkList.Add(new KeyValuePair<string, string>(
                        File.ReadAllText("Chapter" + currentChapter + "/ITest" + numTest),
                        File.ReadAllText("Chapter" + currentChapter + "/OTest" + numTest)));
                    numTest++;
                }
            }
            catch(Exception e) { return checkList; }
        }
    }
}
