using System;

namespace WinFormsApp.Data
{
    public class UInt256
    {
        private uint[] _data;

        public uint[] Data
        {
            set
            {
                if (value.Length != 8)
                    throw new ArgumentException("Invalid data size");
                _data = value;
            }
            get => _data;
        }

        public UInt256() => _data = new uint[8];
        public UInt256(string hex) => _data = FromHex(hex);
        public UInt256(uint[] data) => _data = data;

        public static uint[] FromHex(string hex)
        {
            if (hex.StartsWith("0x")) hex = hex.Substring(2);
            if (hex.Length != 64)
                throw new ArgumentException("Invalid hex string length. Must be 64 characters.");

            uint[] data = new uint[8];

            for (int i = 0, rev = 7; i < 8; i++, rev--)
            {
                data[rev] = uint.Parse(
                    hex.Substring(i * 8, 8),
                    System.Globalization.NumberStyles.HexNumber);
            }

            return data;
        }
        
        public static UInt256 operator +(UInt256 a, UInt256 b) => a.Add(b);
        public static UInt256 operator -(UInt256 a, UInt256 b) => a.Subtract(b);
        public static bool operator ==(UInt256 a, UInt256 b) => Equals(a, b);
        public static bool operator !=(UInt256 a, UInt256 b) => !Equals(a, b);
        public static UInt256 operator ++(UInt256 value) => value.Add(new UInt256(new uint[] { 1, 0, 0, 0, 0, 0, 0, 0}));
        public static UInt256 operator --(UInt256 value) => value.Subtract(new UInt256(new uint[] {1, 0, 0, 0, 0, 0, 0, 0}));

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            UInt256 other = (UInt256)obj;
            for (int i = 0; i < 8; i++)
                if (_data[i] != other._data[i])
                    return false;
            return true;
        }

        public UInt256 Add(UInt256 value)
        {
            uint[] result = new uint[8];
            ulong c = 0;
            
            for( int i = 0; i < 8; i++)
            {
                uint a = _data[i];
                uint b = value._data[i];

                ulong sum = (ulong)a + b + c;
                result[i] = (uint)(sum & 0xFFFFFFFF);
                c = sum >> 32;
            }
            return new UInt256(result);
        }

        public UInt256 Subtract(UInt256 value)
        {
            uint[] result = new uint[8];
            long borrow = 0;

            for (int i = 0; i < 8; i++)
            {
                long difference = (long)_data[i] - value._data[i] - borrow;
                if (difference < 0)
                {
                    difference += (1L << 32);
                    borrow = 1;
                }
                else
                {
                    borrow = 0;
                }
                result[i] = (uint)(difference & 0xFFFFFFFF);
            }
            return new UInt256(result);
        }

        
        public override string ToString()
        {
            string[] hexParts = new string[8];
            for (int i = 0; i < 8; i++) hexParts[i] = _data[7 - i].ToString("X8");
            return string.Concat(hexParts);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException("TODO!");
            // return (_data != null ? _data.GetHashCode() : 0);
        }
    }
}