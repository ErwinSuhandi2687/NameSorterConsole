using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterConsole
{
    public static class utility
    {
        public static void Welcome()
        {
            Console.Clear();
            Console.Title = "Name Sorter";
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\n-----------------Welcome to NameSorter App-----------------\n");
            Console.WriteLine("Note: The list of unsorted names is in the file: unsorted - names - list");
        }

        public static void PressEnterToReadFile()
        {
            Console.WriteLine("\n\nPress Enter To Read File from unsorted-names-list.txt...\n");
            Console.ReadLine();
        }

        public static void PressEnterToWriteFile()
        {
            Console.WriteLine("\n\nPress Enter To Write File to sorted-names-list.txt....\n");
            Console.ReadLine();
        }

        public static List<String> ListOfUnsortedName(INameSorter _nameSorterService)
        {
            Console.WriteLine("List Of UnsortedName :");
            var listUnsortedName = _nameSorterService.ReadUnsortedName();

            for (int i = 0; i < listUnsortedName.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + listUnsortedName[i]);
            }

            return listUnsortedName;
        }

        public static List<String> ListOfSortedName(INameSorter _nameSorterService, List<string> listUnsortedName)
        {
            Console.WriteLine("List Of SortedName :");
            var listSortedName = _nameSorterService.SortName(listUnsortedName);

            for (int i = 0; i < listSortedName.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + listSortedName[i]);
            }

            return listUnsortedName;
        }

        public static void WriteToFile(INameSorter _nameSorterService, List<string> listSortedName)
        {
            Console.WriteLine("\nThe list Of SortedName will be written in sorted-names-list.txt");
            _nameSorterService.WriteSortedName(listSortedName);
            PrintDotAnimation();
            Console.WriteLine("The list of Sortedname has been written.  Please Check File sorted-names-list.txt.. \n\n");
            Console.ReadLine();
        }

        public static void PrintDotAnimation(int timer = 5)
        {
            for (int i = 0; i < timer; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.Clear();
        }
    }
}
