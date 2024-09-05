using System;
using System.Linq;
using WinFormsApp.Data;
using Xunit;
using Xunit.Abstractions;

namespace WinFormsApp.Tests
{
    public class Test
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Test(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ShouldCreateEmptyUint256()
        {
            UInt256 uint256 = new UInt256();
            Assert.Equal(uint256.Data, new uint[8]);
        }

        [Fact]
        public void ShouldParseCorrectly()
        {
            uint[] values =
                { 0x15ff3ab1, 0xaaf3945, 0xfabcd320, 0x16f24ec, 0x111ffa11, 0x44122222, 0x3333ffab, 0x2342f2cc };

            string value = String.Empty;

            for (int i = 0; i < 8; i++)
            {
                value += values[i].ToString("X8");
            }
            
            Assert.Equal(64, value.Length);
            _testOutputHelper.WriteLine($@"0x{value}");
        }
    }
}