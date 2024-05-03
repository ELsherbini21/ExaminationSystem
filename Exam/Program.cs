using System.Diagnostics;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject cSharp = new Subject(1, "C#");

            cSharp.CreateExam();

            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine($"Do you want to start exam sir ?    1.Yes     2.No");
            } while (!(int.TryParse(Console.ReadLine(), out choice) && (choice == 1 || choice == 2)));

            if (choice == 1)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                cSharp.SubjectExam.ShowExam();
                Console.WriteLine($"Time = {stopwatch.Elapsed}");
            }
            else
                Console.WriteLine("Thank you ");
        }
    }
}