using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseLibraryNet.DataTransactions
{
    public class txtWriter
    {      
        private static string fileInfo = "E:\\Shares\\SAPdata\\SAPdataService_Log\\InfoTrack.txt";
        private static string fileLog = "E:\\Shares\\SAPdata\\SAPdataService_Log\\Log.txt";
        /// <summary>
        /// convert SAP date code from yyyymmdd to DateTime
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns>date</returns>
        public static DateTime convDate(string strDate)
        {
            //default date
            DateTime date = DateTime.Parse("3999/01/01");
            // insert forward slashes so the string can be recognized as a date
            try
            {
                string str = strDate.Insert(6, "/");
                strDate = str.Insert(4, "/");
                date = DateTime.Parse(strDate);
                return date;
            }
            catch (Exception)
            {
                //on error, return default date
                string.IsNullOrEmpty(strDate);
                return date;
                throw;
            }
        }
        public static void writeInfo(string info)
        {
            FileStream streamLog = new FileStream(fileInfo, FileMode.Append);
            using (StreamWriter w = new StreamWriter(streamLog))
            {
                string buildHeader = "\t\t\t\t" + DateTime.Now.ToString() + "\n" + info;
                //Log(buildHeader, errors, w);
                w.WriteLine(buildHeader + "\n");
            }
        }
        /// <summary Romoves whites spaces and other symbols trim character function for all symbols></summary>
        /// <param name="toClean"></param>
        /// <returns string></returns>
        public static string CleanString(string toClean)
        {
            string s1 = toClean.Trim(new Char[] { ' ', '*', '.' });
            return s1;
        }

        public static void Log(string message, string source)
        {            FileStream streamLog = new FileStream(fileLog, FileMode.Append, FileAccess.Write);
            using (StreamWriter w = new StreamWriter(streamLog))
            {
                string buildHeader = $"{source}\n\t{DateTime.Now}\n";
                //Log(buildHeader, errors, w);
                w.WriteLine(buildHeader + "\n");

                //MessageBox.Show(line);
                w.WriteLine(message + "\n");

                w.WriteLine("_________________________\n\n");
            }
        }

        /// <summary function will write one line item to log file based on parameters
        /// Reset class parameters></summary>
        /// <param name="logMessage"></param>
        /// <param name="source"></param>

        /// <summary> function will write one line item to log file based on parameters
        /// Reset class parameters</summary>
        /// <param name="logMessage"></param>
        /// <param name="source"></param>
        public static void Log(string message, string source, int errorCount, int newLineCount)
        {
            FileStream streamLog = new FileStream(fileLog, FileMode.Append, FileAccess.Write);
            using (StreamWriter w = new StreamWriter(streamLog))
            {
                string buildHeader = $"{source}\n\t{DateTime.Now}\n\t{newLineCount}\tnew orders added. {errorCount} error(s):";
                //Log(buildHeader, errors, w);
                w.WriteLine(buildHeader + "\n");

                //MessageBox.Show(line);
                w.WriteLine(message + "\n");

                w.WriteLine("_________________________\n\n");
            }
        }

        /// <summary> function to write all error to log file list</summary>
        /// <param> name="logMessage"</param>
        /// <param> name="source"</param>
        public static void Log(List<string> logMessage, string source, int errorCount, int newLineCount)
        {
            FileStream streamLog = new FileStream(fileLog, FileMode.Append);
            using (StreamWriter w = new StreamWriter(streamLog))
            {
                if (newLineCount > 0 || errorCount > 0)
                {
                    string buildHeader = $"{source}\n\t{DateTime.Now}\t{newLineCount}\tnew orders added. {errorCount} error(s):";
                    //Log(buildHeader, errors, w);
                    w.WriteLine(buildHeader + "\n");
                    foreach (string line in logMessage)
                    {
                        //MessageBox.Show(line);
                        w.WriteLine(line + "\n");
                    }
                    w.WriteLine("_________________________\n\n");
                }
            }
        }
       
    }
}
