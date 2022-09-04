using Xunit;
using FluentAssertions;
using WorkTools;

namespace WorkTools.Test;

public class TestNumbersTools
{
    [Theory(DisplayName = "Deve realizar a contagem do valor passado como parâmetro.")]
    [InlineData(new int[]{1, 1, 1}, 1, 3)]
    [InlineData(new int[]{1, 2, 1}, 1, 2)]
    [InlineData(new int[]{1, 2, 3}, 1, 1)]
    public void TestCountOf(int[] entnumbers, int value, int countExpected)
    {        
        var count = Main.CountOf(entnumbers, value);
        count.Should().Be(countExpected);
    }
}