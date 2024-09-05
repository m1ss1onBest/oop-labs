using System;
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
        private void ShouldCreateEmptyUint256()
        {
            UInt256 uint256 = new UInt256();
            Assert.Equal(uint256.Data, new uint[8]);
        }

        [Fact]
        private void ShouldParseCorrectly()
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

        [Fact]
        private void ShouldEqual()
        {
            var a = new UInt256("0000000000000000000000000000000100000000000000000000000000000000");
            var b = new UInt256("0000000000000000000000000000000100000000000000000000000000000000");
            Assert.True(a == b);
            Assert.Equal(a, b);
            Assert.True(a != new UInt256());
        }

        [Fact]
        private void ShouldAdd()
        {
            var a = new UInt256("0000000000000000000000000000000000000000000000000000000000000001");
            var b = new UInt256("00000000000000000000000000000000000000000000000000000000ffffffff");
            var c = a.Add(b);
            var d = a + b;
            
            _testOutputHelper.WriteLine($@"0x{a}");
            _testOutputHelper.WriteLine($@"0x{b}");
            _testOutputHelper.WriteLine($@"0x{c}");
            
            Assert.Equal(c, new UInt256("0000000000000000000000000000000000000000000000000000000100000000"));
            Assert.Equal(c, d);
        }

        [Fact]
        private void ShouldSubtract()
        {
            var a = new UInt256("0000000000000000000000000000000000000000000000000000000100000000");
            var b = new UInt256("0000000000000000000000000000000000000000000000000000000000000001");
            var c = a.Subtract(b);
            var d = a - b;
            
            _testOutputHelper.WriteLine($@"0x{a}");
            _testOutputHelper.WriteLine($@"0x{b}");
            _testOutputHelper.WriteLine($@"0x{c}");
            
            Assert.Equal(c, new UInt256("00000000000000000000000000000000000000000000000000000000ffffffff"));
            Assert.Equal(c, d);
        }

        [Fact]
        private void ShouldIncrement()
        {
            void Print(UInt256 value) => _testOutputHelper.WriteLine($@"0x{value}");
            
            var a = new UInt256("00000000000000000000000000000000000000000000000000000000ffffffff");
            Print(a);
            for (int i = 0; i < 10; i++) Print(++a);
            _testOutputHelper.WriteLine(@"Now another ops");
            Print(a++);
            Print(a);
        }

        [Fact]
        private void ShouldDecrement()
        {
            void Print(UInt256 value) => _testOutputHelper.WriteLine($@"0x{value}");

            var a = new UInt256("0000000000000000000000000000000000000000000000000000000100000000");
            Print(a);
            for (int i = 0; i < 10; i++) Print(--a);
            _testOutputHelper.WriteLine(@"Now another ops");
            Print(a--);
            Print(a);
            
        }
        
    }
}