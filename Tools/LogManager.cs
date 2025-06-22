using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tools
{
    public static class LogManager
    {
        private static string path = "Log";
        public static string getCurrentDir()
        {
            return path +"/"+ DateTime.Now.Month.ToString()+"_"+DateTime.Now.Year.ToString();
        }
        public static string getCurrentFile()
        {
            return getCurrentDir()+"/"+DateTime.Now.Day.ToString()+".txt";
        }

        public static void WriteIntoLog(string projectName, string funcName, string message)
        {
            if (!Directory.Exists(getCurrentDir()))
            {
                Directory.CreateDirectory(getCurrentDir());
            }

            if (!File.Exists(getCurrentFile()))
            {
                File.Create(getCurrentFile()).Close(); 
            }

            using (StreamWriter writeText = new StreamWriter(getCurrentFile(), true))
            {
                writeText.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}\t{projectName}.{funcName}:\t{message}");
            }
        }

        public static void DeleteLog()
        {
            string[]subDirectoriesOnLog = Directory.GetDirectories(path);
            for(int i=0; i< subDirectoriesOnLog.Length; i++)
            {
                string[] parts = Path.GetFileName(subDirectoriesOnLog[i]).Split('_');
                string dirMonth = parts[0];
                string dirYear = parts[1];
                if (!((DateTime.Now.Year.ToString().Equals(dirYear)&&
                    ((DateTime.Now.Month-2).ToString().Equals(dirMonth) || (DateTime.Now.Month - 1).ToString().Equals(dirMonth)||(DateTime.Now.Month).ToString().Equals(dirMonth)))||
                    ((dirMonth.Equals("01")||dirMonth.Equals("02"))&&dirYear.Equals((DateTime.Now.Year-1).ToString()))))
                {
                    Directory.Delete(subDirectoriesOnLog[i],true);
                }

            }
        }
    }
}
    