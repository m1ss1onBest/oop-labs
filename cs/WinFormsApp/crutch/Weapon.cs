namespace WinFormsApp.crutch
{
    public class Weapon
    {
        private string Name { set; get; }
        private string Caliber { set; get; } = "0x0mm";
        private int MagazineCapacity { set; get; } = 0;
        private int BarrelLength { set; get; } = 0;

        public Weapon()
        {

        }

        public Weapon(string name)
        {
            Name = name;
        }

        public Weapon(
            string name,
            string caliber,
            int magazineCapacity,
            int barrelLength
        )
        {
            Name = name;
            Caliber = caliber;
            MagazineCapacity = magazineCapacity;
            BarrelLength = barrelLength;
        }
    }
}