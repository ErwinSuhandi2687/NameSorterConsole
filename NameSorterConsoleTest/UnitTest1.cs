namespace NameSorterConsoleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_readFile_WhenFileDoesntExist_throws()
        {
            NameSorterService readTest = new();
            //assert
            Assert.ThrowsException<FileNotFoundException>(() => readTest.ReadUnsortedName());
        }


        [TestMethod]
        public void Test_readFile()
        {
            NameSorterService readTest = new();
            var names = new List<string> {"Orson Milka Iddins",
                                            "Erna Dorey Battelle",
                                            "Flori Chaunce Franzel",
                                            "Odetta Sue Kaspar",
                                            "Roy Ketti Kopfen",
                                            "Madel Bordie Mapplebeck",
                                            "Selle Bellison",
                                            "Leonerd Adda Mitchell Monaghan",
                                            "Debra Micheli",
                                            "Hailey Avie Annakin"
                                            };

            //act
            var actResult = readTest.ReadUnsortedName();

            //assert
            CollectionAssert.AreEquivalent(names, actResult);
        }

        [TestMethod]
        public void Test_SortName()
        {
            NameSorterService sortNameTest = new();
            var names = new List<string> {"Hailey Avie Annakin",
                                           "Erna Dorey Battelle",
                                           "Selle Bellison",
                                            "Flori Chaunce Franzel",
                                            "Orson Milka Iddins",
                                            "Odetta Sue Kaspar",
                                            "Roy Ketti Kopfen",
                                            "Madel Bordie Mapplebeck",
                                            "Debra Micheli",
                                            "Leonerd Adda Mitchell Monaghan"
                                            };

            var actResult = sortNameTest.ReadUnsortedName();

            //act
            var actSortNameResult = sortNameTest.SortName(actResult);

            //assert
            CollectionAssert.AreEquivalent(names, actSortNameResult);
        }
    }
}