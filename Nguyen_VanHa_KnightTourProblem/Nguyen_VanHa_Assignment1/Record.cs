using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nguyen_VanHa_Assignment1
{
    class Record
    {
        private static string name = "NguyenVanHa";
        private static string methodName = "";
        private static string location = @System.IO.Directory.GetCurrentDirectory() + @"\..\..\";

        public Record(string choice)
        {
            methodName = choice + "Method";
        }

        private string GetFileLocation()
        {
            return location + name + methodName + ".txt";
        }

        public void AddtoOutputFile(string input)
        {
            string fileLocation = GetFileLocation();

            //Create a file if it doesn't exist
            //Otherwise, just open and append.
            StreamWriter sw = new StreamWriter(fileLocation, true);
            sw.WriteLine(input);
            sw.Dispose();
        }
    }
}
