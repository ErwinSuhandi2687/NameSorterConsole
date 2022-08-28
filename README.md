# Name-Sorter

[![GitHub](https://img.shields.io/github/license/defartsa23/shuffle-dice-sicbo)](https://opensource.org/licenses/MIT)

## Setup Project
1. Clone or download this code.
2. Open NameSorterConsole.sln.
3. if there are missing package, then enable package restore in visual studio and install or update all package dependencies.
    ```
      dotnet restore 
    ```
4. Copy folder : NameSorterConsole\Files.
5. Open folder : NameSorterConsole\bin\Debug\net6.0, and paste folder : NameSorterConsole\Files.
6. Open folder : NameSorterConsoleTest\bin\Debug\net6.0, and paste folder : NameSorterConsole\Files.


## Run Project
1. run console project
    ```
      - Press enter to view list name unsorted. File will be read from file "unsorted-names-list.txt" 
        in folder : NameSorterConsole\bin\Debug\net6.0\Files
      - Press enter to view list name that has been sorted and create file "sorted-names-list.txt" 
        in folder : NameSorterConsole\bin\Debug\net6.0\Files. 
    ```
2. Check file "sorted-names-list.txt" in folder : NameSorterConsole\bin\Debug\net6.0\Files. 
   this file already contains sorted data
   
## Run Unit Test
there are 3 Scenario of Unit test.
1. unit test when file doesnt exist when that file will be read ("unsorted-names-list.txt").
2. unit test when there are file will be read ("unsorted-names-list.txt").
3. unit test when the names will be sorted.


## Stay in touch

- Author - [Erwin Suhandi]

