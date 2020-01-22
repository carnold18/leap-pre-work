using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EssentialTrainingApp
{
    class Program
    {
        public static List<string> Words;
        // need to make the Words list static type to match the Main method below
        static void Main(string[] args)
        {
            var Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CrazyMathProblem();
            ReadTextFile();
            Console.ReadLine();
        }

        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find the directory.");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Could not find the file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("NO RUNTIME ERRORS");
            }
        }

        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (var i = 10; i > 0; i--)
            {
                income = income = (income / i);
            }
            return income;
        }
    }
}
