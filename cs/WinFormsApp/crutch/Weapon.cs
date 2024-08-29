namespace WinFormsApp.crutch
{
    public class Weapon
    {
        public string Name { set; get; } = "no-name-specified";
        public string Caliber { set; get; } = "0x0mm";
        public int MagazineCapacity { set; get; } = 0;
        public float BarrelLength { set; get; } = 0;

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
            float barrelLength
        )
        {
            Name = name;
            Caliber = caliber;
            MagazineCapacity = magazineCapacity;
            BarrelLength = barrelLength;
        }
    }
}