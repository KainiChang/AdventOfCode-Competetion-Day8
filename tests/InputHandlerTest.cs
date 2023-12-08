// namespace tests;

// [TestClass]
// public class InputHandlerTest : code.InputHandler
// {
//     [TestMethod]
//     public void ReadInputInstructionsTest()
//     {
//         string input = @"RL

// AAA = (BBB, CCC)
// BBB = (DDD, EEE)
// CCC = (ZZZ, GGG)
// DDD = (DDD, DDD)
// EEE = (EEE, EEE)
// GGG = (GGG, GGG)
// ZZZ = (ZZZ, ZZZ)";
//          List<char> expected = ['R', 'L'];
//         List<char>  actual = code.InputHandler.ReadInputInstruction(input);
//         CollectionAssert.AreEqual(expected, actual);

//     }
//         [TestMethod]
//     public void ReadInputMapTest()
//     {
//         string input = @"RL

// AAA = (BBB, CCC)
// BBB = (DDD, EEE)
// CCC = (ZZZ, GGG)
// DDD = (DDD, DDD)
// EEE = (EEE, EEE)
// GGG = (GGG, GGG)
// ZZZ = (ZZZ, ZZZ)";
//         List<(string,string, string)> expected = [("AAA","BBB","CCC"),("BBB","DDD","EEE"),("CCC","ZZZ","GGG"),("DDD","DDD","DDD"),("EEE","EEE","EEE"),("GGG","GGG","GGG"),("ZZZ","ZZZ","ZZZ")];
//         List<(string,string, string)>  actual = code.InputHandler.ReadInputMap(input);
//         CollectionAssert.AreEqual(expected, actual);

//     }
// }
