namespace WinFormsApp.types
{
    public class BulletType
    {
        private string Name { set; get; } = "no-name-specified";
        private int Damage { set; get; } = 1;
        private int ArmorPiercing { set; get; } = 0;
        private int Speed { set; get; } = 1;
        private bool Tracer { set; get; } = false;

        public BulletType() 
        {
            
        }

        public BulletType(string name, int damage, int armorPiercing, int speed, bool tracer)
        {
            Name = name;
            Damage = damage;
            ArmorPiercing = armorPiercing;
            Speed = speed;
            Tracer = tracer;
        }

        public BulletType(BulletType bulletType)
        {
            Name = bulletType.Name;
            Damage = bulletType.Damage;
            ArmorPiercing = bulletType.ArmorPiercing;
            Speed = bulletType.Speed;
            Tracer = bulletType.Tracer;
        }
    }
}