using System;
using System.Collections.Generic;
using System.Linq;

namespace Edabit.Expert.MultipleChoiceTest
{
    #region #interfaces
    public interface ITestpaper
    {
        string Subject { get; }
        string[] MarkScheme { get; }
        string PassMark { get; }
    }

    public interface IStudent
    {
        List<string> TestsTaken { get; }
        void TakeTest(ITestpaper paper, string[] testAnswers);
    }
    #endregion

    public class MultipleChoiceTest
    {
        //https://edabit.com/challenge/thXMEAWNWyk9cCZcM
        public static void RunTheCode()
        {
            var paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
            var paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
            var paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");
            var paper4 = new Testpaper("Physics", new string[] { "1A", "2B", "3A", "4C", "5A", "6C", "7A", "8C", "9D", "10A", "11A" }, "90%");

            var student1 = new Student(); 
            var student2 = new Student();
            var student3 = new Student();

            student1.TakeTest(paper1, new[] {"1A", "2D", "3D", "4A", "5A"});

            student2.TakeTest(paper2, new[] { "1C", "2D", "3A", "4C" });
            student2.TakeTest(paper3, new[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });

            student3.TakeTest(paper1, new[] { "1C", "2D", "3A", "4C", "5A" });
            student3.TakeTest(paper3, new[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
            student3.TakeTest(paper4, new[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B", "8C", "9D", "10A", "11A" });


            Console.WriteLine("Student 1:");
            student1.WriteTestsTaken();
            Console.WriteLine("\nStudent 2:");
            student2.WriteTestsTaken();
            Console.WriteLine("\nStudent 3:");
            student3.WriteTestsTaken();
        }
    }
    public class Testpaper : ITestpaper
    {
        public string Subject { get; }
        public string[] MarkScheme { get; }
        public string PassMark { get; }

        public Testpaper(string subject, string[] markScheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark;
        }
    }

    public class Student : IStudent
    {
        public List<string> TestsTaken { get; }

        public Student()
        {
            TestsTaken = new List<string>() {"No tests taken"};
        }
        public void TakeTest(ITestpaper paper, string[] testAnswers)
        {
            double correctAnswersCount = testAnswers.Where((t, i) => t == paper.MarkScheme[i]).Count();
            var percentageCorrect = Math.Round(correctAnswersCount * 100 / testAnswers.Length);
            var percentageToPass = Convert.ToInt32(paper.PassMark.Remove(paper.PassMark.Length - 1));

            var isPassString = percentageCorrect >= percentageToPass ? "Passed!" : "Failed!";
            var resultString = $"{paper.Subject}: {isPassString} ({percentageCorrect}%)";

            if (TestsTaken[0] == "No tests taken") TestsTaken.Clear();
            TestsTaken.Add(resultString);
            TestsTaken.Sort();
        }

        public void WriteTestsTaken()
        {
            foreach (var test in TestsTaken)
            {
                Console.WriteLine(test);
            }
        }
    }
}
