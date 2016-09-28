using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Compare2ColoumsInCSV
{
    class Program
    {
        private static int col1=-1;
        private static int col2=-1;
        private static Dictionary<string, string> Dictionary;
        private static List<string> List;
        private static string FiletoDoc1 = "";
        private static string FiletoDoc2 = "";
        private static string OutputFileLoc = "";
        public static bool checkReverse = true;

        private static List<string> Output = new List<string>();

        static void Main(string[] args)
        {
            ParseArgs(args);

            //Check 1st pass
            if (col1 != -1 && col2 != -1)
            {
                Dictionary = ReadInDocToCompareFrom(FiletoDoc2, col1);
                List = ReadInDocToCompareTo(FiletoDoc1, col2);
                for (int x = 0; x < List.Count; ++x)
                {
                    if (Dictionary.ContainsKey(List.ElementAt(x)) == false)
                    {
                        Output.Add(List.ElementAt(x));
                    }
                }
                if (checkReverse)
                {
                    //do REVERSE TEST
                    Dictionary.Clear();
                    List.Clear();
                    Dictionary = ReadInDocToCompareFrom(FiletoDoc1, col1);
                    List = ReadInDocToCompareTo(FiletoDoc2, col2);
                    for (int x = 0; x < List.Count; ++x)
                    {
                        if (Dictionary.ContainsKey(List.ElementAt(x)) == false)
                        {
                            Output.Add(List.ElementAt(x));
                        }
                    }
                    List<string> tmp;
                    tmp = Output.Distinct().ToList();
                    Output.Clear();
                    Output = tmp;
                }
                if (string.IsNullOrEmpty(OutputFileLoc)==false)
                {
                    PrintOuput(OutputFileLoc);
                }
            }
        }

        private static void PrintOuput(string Filename)
        {
            if (File.Exists(Filename))
            {
                File.Delete(Filename);
            }
            try
            {
                using (StreamWriter writer2 = File.AppendText(Filename))
                {
                    for (int x = 0; x < Output.Count; ++x)
                    {
                        writer2.WriteLine(Output.ElementAt(x));
                    }
                    writer2.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Cant write to output file" + e.Message.ToString());
            }
        }

        private static Dictionary<string, string> ReadInDocToCompareFrom(string FilePath, int col)
        {
            Dictionary<string, string> List = new Dictionary<string, string>();
            if (File.Exists(FilePath))
            {
                using (var reader = new StreamReader(FilePath, Encoding.ASCII))
                {
                    string ReadinLine = "";

                    while ((ReadinLine = reader.ReadLine()) != null)
                    {
                        ReadinLine = ReadinLine.ToLower().Split(',').ToList().ElementAt(col);
                        ReadinLine.ToLower();
                        if (String.IsNullOrEmpty(ReadinLine.ToLower()) == false)
                        {
                            try
                            {
                                List.Add(ReadinLine, "value");
                            }
                            catch
                            {
                                Console.WriteLine("Duplicate Value: " + ReadinLine);
                            }
                        }
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Input file not found");
            }
            return List;
        }

        private static List<string> ReadInDocToCompareTo(string FilePath, int col)
        {
            List<string> List = new List<string>();
            if (File.Exists(FilePath))
            {
                using (var reader = new StreamReader(FilePath, Encoding.ASCII))
                {
                    string ReadinLine = "";

                    while ((ReadinLine = reader.ReadLine()) != null)
                    {
                        ReadinLine = ReadinLine.ToLower().Split(',').ToList().ElementAt(col);
                        ReadinLine.ToLower();
                        if (String.IsNullOrEmpty(ReadinLine.ToLower()) == false)
                        {
                            List.Add(ReadinLine);
                        }
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Input file not found");
            }
            return List;
        }

        public static void ParseArgs(string[] Args)
        {
            for (int x = 0; x < Args.Length; ++x)
            {
                switch (Args[x].ToLower())
                {
                    case "file1":
                        {
                            FiletoDoc1 = Args[x + 1];
                            break;
                        }
                    case "col1":
                        {
                            col1 = Convert.ToInt32(Args[x + 1]);
                            break;
                        }
                    case "file2":
                        {
                            FiletoDoc2 = Args[x + 1];
                            break;
                        }
                    case "col2":
                        {
                            col2 = Convert.ToInt32(Args[x + 1]);
                            break;
                        }
                    case "noreverse":
                        {
                            checkReverse = false;
                            break;
                        }
                    case "output":
                        {
                            OutputFileLoc = Args[x + 1];
                            break;
                        }
                    case "help":
                        {
                            Console.WriteLine(@"HELP/COMMAND MENU:
                                                About:
                                                -App is used to compare 2 coloums in 2 CSV files. By default the app will compare both files coloums both ways.
                                       
                                                Args:
                                                File1: Is the path the file you want to compare
                                                    arg=C:\\...
                                                col1: Is the coloum for file1 to you want to compare
                                                    arg=col1 1
                                                File2: Is the path the file you want to compare
                                                    arg=C:\\...
                                                col2: Is the coloum for file2 to you want to compare
                                                    arg=col2 3
                                                Output: Is the path the file you want to output results to.
                                                    arg=Output C:\\...
                                                NoReverse: will not compare both file's col's to each other
                                                    arg=NoReverse {no arg}
                                              ");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
    }
}
