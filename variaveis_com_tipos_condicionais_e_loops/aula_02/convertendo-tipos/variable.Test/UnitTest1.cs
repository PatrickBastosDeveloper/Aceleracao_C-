using Xunit;
using FluentAssertions;

namespace variable.Test;

public class UnitTest1
{
    [Theory(DisplayName="Deve converter string para inteiro")]
    [InlineData("1", 1)]
    [InlineData("100", 100)]
    [InlineData("-50", -50)]

    public void TestVariableConversion(string entry, int expected)
    {
        Class1 instance = new();

        instance.strEntry = entry;
        var strTypeCheck = instance.strEntry is string;
        strTypeCheck.Should().Be(true);

        instance.DoConversion();

        instance.intResponse.Should().Be(expected);
        var intTypeCheck = instance.intResponse is int;
        intTypeCheck.Should().Be(true);
    }
}