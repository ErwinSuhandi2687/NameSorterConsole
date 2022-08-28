using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterConsole
{
    public interface INameSorter
    {
        List<string> ReadUnsortedName();
        List<string> SortName(List<string> UnsortedNames);
        void WriteSortedName(List<string> SortedNames);
    }
}
