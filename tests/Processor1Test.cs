namespace tests;

[TestClass]
public class Processor1Test : code.Processor1
{

  [TestMethod]
  public void StrengthTest1()
  {
    string input = @"32T3K";

    int expected = 2;
    int actual = code.Processor1.GetStrengthLevel(input);
    Assert.AreEqual(expected, actual);
  }
    [TestMethod]
  public void StrengthTest2()
  {
    string input = @"T55J5";

    int expected = 4;
    int actual = code.Processor1.GetStrengthLevel(input);
    Assert.AreEqual(expected, actual);
  }
      [TestMethod]
  public void StrengthTest3()
  {
    string input = @"KK677";

    int expected = 3;
    int actual = code.Processor1.GetStrengthLevel(input);
    Assert.AreEqual(expected, actual);
  }
        [TestMethod]
  public void StrengthTest4()
  {
    string input = @"KTJJT";

    int expected = 3;
    int actual = code.Processor1.GetStrengthLevel(input);
    Assert.AreEqual(expected, actual);
  }
          [TestMethod]
  public void StrengthTest5()
  {
    string input = @"QQQJA";

    int expected = 4;
    int actual = code.Processor1.GetStrengthLevel(input);
    Assert.AreEqual(expected, actual);
  }
    [TestMethod]
  public void ExampleTest()
  {
    string input = @"32T3K 765
T55J5 684
KK677 28
KTJJT 220
QQQJA 483";

    long expected = 6440;
    long actual = code.Processor1.Process(code.InputHandler.ReadInputLines(input));
    Assert.AreEqual(expected, actual);
  }
      [TestMethod]
  public void GetQ1AnswerTest()
  {
    string input = @"";

    long expected = 0;
    long actual = code.Processor1.Process(code.InputHandler.ReadInputLines(input));
    Assert.AreEqual(expected, actual);
  }
}
