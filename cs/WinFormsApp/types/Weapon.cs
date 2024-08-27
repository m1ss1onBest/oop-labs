// ReSharper disable once IdentifierTypo
namespace WinFormsApp.types
{
    public class Weapon
    {
        private string Name { set; get; } = "no-name-specified";
        private string Caliber { set; get; } = "no-caliber-specified";
        private int BarrelLength { set; get; }

        public Weapon()
        {
            BarrelLength = 0;
        }

        public Weapon(string name, string caliber, int barrelLength)
        {
            Name = name;
            Caliber = caliber;
            BarrelLength = barrelLength;
        }
        
        public Weapon(Weapon weapon)
        {
            Name = weapon.Name;
            Caliber = weapon.Caliber;
            BarrelLength = weapon.BarrelLength;
        }

        public string[] Format() =>
            new[] { Name, Caliber, BarrelLength.ToString()};

    }
}