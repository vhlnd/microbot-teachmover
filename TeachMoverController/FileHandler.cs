using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ArmBot
{
    class FileHandler
    {
        public static void WriteProgramToFile(string programname,List<string> data)
        {
            StreamWriter sw = new StreamWriter(programname);
            foreach (var item in data)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }

        public static List<string>ReadProgramFromFile(string programname)
        {
            List<string> data = new List<string>();
            StreamReader sr = new StreamReader(programname);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                data.Add(line);
            }
            sr.Close();
            return data;
        }
    }
}
