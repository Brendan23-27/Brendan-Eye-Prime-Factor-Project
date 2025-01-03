namespace Unit_Test_For_Prime_Factor_Class
{
    using System;
    using System.Collections.Generic;
    using Prime_Factors_class;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int testNum = 10;

            List<int> expectedResult = new() { 2, 5 };

            List<int> actualResult = PrimeFactors.PrimeFactorCalculator(testNum);

            Assert.Equal(expectedResult, actualResult);

        }
    }
}