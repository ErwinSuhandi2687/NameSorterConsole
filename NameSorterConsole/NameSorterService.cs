using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NameSorterConsole
{
    public class NameSorterService : INameSorter
    {
        public List<string> ReadUnsortedName()
        {
            var startupPath = Directory.GetCurrentDirectory();
            var readPathName = $@"{startupPath}\Files\unsorted-names-list.txt";

            if (!File.Exists(readPathName))
            {
                throw new FileNotFoundException(readPathName);
            }

            var listUnsortedName = File.ReadAllLines(readPathName).ToList();
            return listUnsortedName;
        }

        public List<string> SortName(List<string> UnsortedNames)
        {
            UnsortedNames.Sort((n1, n2) => n1.Split(" ")[n1.Split(" ").Length - 1]
                                                        .CompareTo(n2.Split(" ")[n2.Split(" ").Length - 1]));
            return UnsortedNames;
        }

        public void WriteSortedName(List<string> SortedNames)
        {
            var startupPath = Directory.GetCurrentDirectory();
            var writePathName = $@"{startupPath}\Files\sorted-names-list.txt";

            File.WriteAllLines(writePathName, SortedNames);
        }
    }
}
