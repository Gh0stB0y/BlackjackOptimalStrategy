using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlackjackStrategy.Methods.Commands
{
    public static class WriteData
    {
        public static void WriteDataToFile(string[] strings, string path)
        {

            if (!File.Exists(path))
            {
                // If the file doesn't exist, create it and write the new data as the first line
                string dataLine = string.Join("\t", strings);
                File.WriteAllText(path, dataLine + Environment.NewLine);

                Console.WriteLine("File created and data has been written to " + path);
            }
            else
            {
                // If the file exists, append the new data
                string dataLine = string.Join("\t", strings);
                File.AppendAllText(path, dataLine + Environment.NewLine);

                //Console.WriteLine("Data has been appended to " + path);
            }
        }

        public static string GeneratePath(string generationNumber)
        {
            int id = 0;
            string[] pathParts = { "Generation" + generationNumber, "Iter", id.ToString(), ".csv" };
            string path = string.Concat(pathParts);
            while (File.Exists(path))
            {
                id++;
                pathParts[2] = id.ToString();
                path = string.Concat(pathParts);
            }
            return path;
        }

        public static void WriteDataFromIteration(string generationNumber,string specimenNumber, string[] parameters)
        {
            //ramka: wins loses pushes winratio profit 
            string[] pathParts = { "Generation" + generationNumber + "Specimen" + specimenNumber, "results", ".csv" };
            string path = string.Concat(pathParts);
            if (!File.Exists(path))
            {
                string dataLine = string.Join("\t", parameters);
                File.WriteAllText(path, dataLine + Environment.NewLine);
            }
            else
            {
                string dataLine = string.Join("\t", parameters);
                File.AppendAllText(path, dataLine + Environment.NewLine);
            }

        }
    }
}
