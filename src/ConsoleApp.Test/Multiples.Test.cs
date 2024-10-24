namespace ConsoleApp.Test;

public class MultiplesTest
{

    /// <summary>
    /// Let's check whether tests work at all :P
    /// </summary>
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }

    // https://andrewlock.net/creating-parameterised-tests-in-xunit-with-inlinedata-classdata-and-memberdata/
    [Theory]
    [InlineData(15, new int[] { 3, 5 })]
    [InlineData(3, new int[] { 3 })]
    public void isMultipleOfWithDividers(int input, int[] dividers)
    {
        Assert.True(Multiples.IsMultipleOf(input, dividers));
    }
}