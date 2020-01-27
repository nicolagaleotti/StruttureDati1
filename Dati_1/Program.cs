using System;
using System.Collections.Generic;
using System.IO;

namespace Dati_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "decimali.txt";
            List<double> votiList = new List<double>();
            if(File.Exists(file))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(file))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                            votiList.Add(double.Parse(line));
                    }
                }
                catch { }
            }
            string file2 = "decimali2.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(file2))
                {
                    for (int i = votiList.Count -1; i >= 0; i--)
                    {
                        writer.WriteLine(votiList[i]);
                    }
                }
            }
            catch { }
        }
    }
}
