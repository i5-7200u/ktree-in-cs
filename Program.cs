using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the to be listed subdirectorys and subfiles directory");
            List<string> qwe = kcstree(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Listed subdirectorys and subfiles");
            foreach (string gff in qwe)
            {
                Console.WriteLine(gff);
            }
            int ah = 5;
            for (int i = 0; i < 1; i = i +1)
            {
                Console.WriteLine("\n");
            }
            Console.WriteLine("Press E to Exit apllication");
            while (ah < 6)
            {
                ConsoleKeyInfo aw = Console.ReadKey();
                if (aw.Key == ConsoleKey.E)
                {
                    ah = 8;
                }
            }
        }
        public static List<string> kcstree(string path)
        {
            List<string> folder_file = new List<string> { path };
            if (System.IO.Directory.Exists(path) == true)
            {
                int fflength = 0;
                while (fflength <= folder_file.Count - 1)
                {
                    string targetfolder = folder_file[fflength];
                    try
                    {
                        if (System.IO.Directory.Exists(targetfolder) == true)
                        {
                            foreach (string gfolder in System.IO.Directory.GetDirectories(targetfolder))
                            {
                                folder_file.Add(gfolder);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        folder_file.Add("Created a Error! Directory = " + targetfolder + " Error = " + ex.Message + ex.Source);
                    }
                    fflength = fflength + 1;
                }
                int fflengthtwo = 0;
                int savedfflength = folder_file.Count - 1;
                while (fflengthtwo <= savedfflength)
                {
                    string targettfolder = folder_file[fflengthtwo];
                    try
                    {
                        if (System.IO.Directory.Exists(targettfolder) == true)
                        {
                            foreach (string gfile in System.IO.Directory.GetFiles(targettfolder))
                            {
                                folder_file.Add(gfile);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        folder_file.Add("Created a Error! Directory = " + targettfolder + " Error = " + ex.Message + ex.Source);

                    }
                    fflengthtwo = fflengthtwo + 1;
                }
            }
            else
            {
                folder_file.Add("Path is not exists.");
            }
            return folder_file;
        }
    }
}
