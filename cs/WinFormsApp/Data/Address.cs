
namespace WinFormsApp.Data
{
    public class Address : UInt256
    {
        public Address() : base() {}
        public Address(UInt256 value) : base(value.Data) {}
        public Address(string hex) : base(hex) {}

        public static string Zero() => "0x0000000000000000000000000000000000000000000000000000000000000000";
    }
}