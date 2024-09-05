using System;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp.Data
{
    public class UInt256
    {
        private uint[] _data;
        public uint[] Data
        {
            set => _data = value;
            get => _data;
        }

        public UInt256() => _data = new uint[8];
        public UInt256(string hex) => _data = FromHex(hex);
        public UInt256(UInt256 num) => _data = num._data;

        public static uint[] FromHex(string hex)
        {
            if (hex.StartsWith("0x")) hex = hex.Substring(2);
            if (hex.Length != 64)
                throw new ArgumentException("Invalid hex string length. Must be 64 characters.");

            uint[] data = new uint[8];

            for (var i = 0; i < 8; i++)
            {
                data[i] = uint.Parse(
                    hex.Substring(i * 8, 8),
                    System.Globalization.NumberStyles.HexNumber);
            }

            return data;
        }

        public int Bits() => 256;
    }

}