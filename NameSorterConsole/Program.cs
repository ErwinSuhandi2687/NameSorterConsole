using Microsoft.Extensions.DependencyInjection;
using NameSorterConsole;


//setup our Dependency Injection
var serviceProvider = new ServiceCollection()
    .AddSingleton<INameSorter, NameSorterService>()
    .BuildServiceProvider();

//do the actual work here
var _nameSorterService = serviceProvider.GetService<INameSorter>();

while (true)
{
    utility.Welcome();
    utility.PressEnterToReadFile();

    if (_nameSorterService != null)
    {
        var listUnsortedName = utility.ListOfUnsortedName(_nameSorterService);

        //Logic Sorting Name
        utility.PressEnterToWriteFile();
        var listSortedName = utility.ListOfSortedName(_nameSorterService, listUnsortedName);
        utility.WriteToFile(_nameSorterService, listUnsortedName);
    }

    utility.Welcome();
}


