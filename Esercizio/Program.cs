using System;
using System.Collections.Generic;
using System.IO;

namespace Esercizio
{
    public class Program
    {
        public List<string> search(string filename, int column, string key)
        {
            List<string> results = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(filename);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (fields.Length > column && fields[column].Equals(key))
                    {
                        results.Add(line);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return results;
        }

        public static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Errore nei parametri da linea di comando");
                return;
            }

            string filename = Path.GetFullPath(args[0]);
            int column = int.Parse(args[1]);
            string key = args[2];

            Program p = new Program();
            var ris = p.search(filename, column, key);
            if (ris.Count == 0)
            {
                Console.WriteLine("La chiave di ricerca non ha dato alcun riscontro");
            }
            else
            {
                foreach (var var in ris)
                {
                    Console.WriteLine(var);
                }
            }
        }
    }
}