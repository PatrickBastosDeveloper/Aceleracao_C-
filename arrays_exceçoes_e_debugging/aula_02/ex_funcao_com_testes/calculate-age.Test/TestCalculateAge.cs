using Xunit;
using System.IO;
using System;
using Agenamespace;
using FluentAssertions;

namespace TestCalculateAge.Test;

public class TestCalculateAge
{
  [Theory(DisplayName = "Validação de maioridade a partir do ano de nascimento")]
  [InlineData(2013, false)]
  [InlineData(1980, true)]
  [InlineData(2000, true)]
  public void TestIsOfLegalAge(int yearOfBirth, bool resultExpected)
  {
    var age = AgeCalculator.CalculateAgeByYear(yearOfBirth);
    var isOfLegalAge = AgeCalculator.ValidateComingOfAge(age);

    isOfLegalAge.Should().Be(resultExpected);
  }
}