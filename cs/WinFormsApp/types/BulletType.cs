namespace WinFormsApp.types
{
    public class BulletType
    {
        // bullet name
        private string Name { set; get; }
        // start speed in m/s
        private int Speed { set; get; }
        // accuracy multiplier
        private float Accuracy { set; get; } = 1;
        // armor piercing points
        private int ArmorPiercing { set; get; } = 0;
        // is bullet tracer
        private bool IsTracer { set; get; }

        public BulletType()
        {
            
        }
        
        public BulletType(
            string name,
            int speed,
            int armorPiercing,
            bool isTracer
        ) {
            Name = name;
            Speed = speed;
            ArmorPiercing = armorPiercing;
            IsTracer = isTracer;
        }
    }
}