namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        var value = 279.98m;
        var cents = value.ToCents();

        Assert.AreEqual(27_998, cents);
    }
}