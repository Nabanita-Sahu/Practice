using NUnit.Framework;

public class ProgramTests
{
    [Test]
    public void TestStringSplitByPipe()
    {
        // Arrange
        string X = "1|2|3|";
        
        // Act
        string[] result = X.Split('|');
        
        // Assert
        Assert.AreEqual(4, result.Length, "The array should have 4 elements.");
        Assert.AreEqual("1", result[0], "The first element should be '1'.");
        Assert.AreEqual("2", result[1], "The second element should be '2'.");
        Assert.AreEqual("3", result[2], "The third element should be '3'.");
        Assert.AreEqual("", result[3], "The last element should be an empty string.");
    }
}
