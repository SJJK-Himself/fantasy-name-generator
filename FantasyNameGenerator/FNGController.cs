using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FantasyNameGenerator
{
    class FNGController
    {
        /// <summary>
        /// Is the path and file name for the file where the names get saved.
        /// </summary>
        public static String pathAndFile;


        /// <summary>
        /// Creates an instance of Random class
        /// </summary>
        static Random rnd = new Random();


        /// <summary>
        /// Randomizes the index from which the name part is picked for the generator
        /// </summary>
        /// <param name="i">The allowed maximum value for the index</param>
        /// <returns>The index from which the name part is picked for the generator</returns>
        private static int Randomize(int i)
        {
            int index = rnd.Next(i);
            return index;
        }


        /// <summary>
        /// Takes two parts of a first name and returns the full first name
        /// </summary>
        /// <returns>The full first name</returns>
        public static String FirstNameGenerator()
        {
            String[] firstNamesHalf1 = { "Eleo", "Mar", "Dona", "Fe" };
            String firstN1 = firstNamesHalf1[Randomize(firstNamesHalf1.Length)];

            String[] firstNamesHalf2 = { "dric", "dal", "lar", "din" };
            String firstN2 = firstNamesHalf2[Randomize(firstNamesHalf2.Length)];

            String firstName = firstN1 + firstN2;
            return firstName;
        }


        /// <summary>
        /// Takes two parts of a last name and returns the full last name
        /// </summary>
        /// <returns>The full last name</returns>
        public static String LastNameGenerator()
        {
            String[] lastNamesHalf1 = { "Wolven", "Kors", "Lyra" };
            String lastN1 = lastNamesHalf1[Randomize(lastNamesHalf1.Length)];

            String[] lastNamesHalf2 = { "bane", "river", "wood" };
            String lastN2 = lastNamesHalf2[Randomize(lastNamesHalf2.Length)];

            String lastName = lastN1 + lastN2;
            return lastName;
        }


        /// <summary>
        /// Combines the path and file name into a String to be read during program initialization
        /// </summary>
        /// <returns></returns>
        public static void InitPath()
        {
            String winUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            String appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            String path = appDataDir + @"\FNGenerator\";
            String fileName = "FantasyNames.txt";
            pathAndFile = path + fileName;
        }


        /// <summary>
        /// Combines the first name and/or last name into a String and writes it to a .txt file in \AppData\FNGenerator\ below the previous name
        /// </summary>
        /// <param name="firstN">Chosen first name</param>
        /// <param name="lastN">Chosen last name</param>
        public static void SaveFinalName(String firstN, String lastN)
        {
            String finalName = firstN + " " + lastN;

            String winUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            String appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            String path = appDataDir + @"\FNGenerator\";
            String fileName = "FantasyNames.txt";
            String wholePath;
            pathAndFile = path + fileName;

            System.IO.Directory.CreateDirectory(path);
           wholePath = System.IO.Path.Combine(path, fileName);

            StreamWriter sw = new StreamWriter(wholePath, true);
            sw.WriteLine(finalName);
            sw.Close();
        }


         /// <summary>
         /// Reads the file of saved names and passes them as a list to usedNamesList in Form1
         /// </summary>
         /// <returns>The names on the file</returns>
         public static List<String> ReadNameFile()
         {
             List<String> lines = new List<String>();
             using (StreamReader r = new StreamReader(pathAndFile))
             {
                 String line;
                 while ((line = r.ReadLine()) != null)
                 {
                     lines.Add(line);
                 }
             }
             return lines;
         }
    }
}