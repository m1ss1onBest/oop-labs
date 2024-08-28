using System.Collections.Generic;

namespace WinFormsApp.types
{
    public class Magazine
    {
        private string Name { get; set; }
        private int MaxCapacity { get; set; } = 1;
        private Stack<BulletType> Bullets { get; set; } = new Stack<BulletType>();

        public Magazine(string name)
        {
            Name = name;
        }

        public Magazine(string name, int maxCapacity)
        {
            Name = name;
            MaxCapacity = maxCapacity;
            
        }

        public void Load(BulletType bullet)
        {
            if (Bullets.Count < MaxCapacity)
            { 
                Bullets.Push(bullet);
            }
        }

        public void LoadAll(BulletType bullet)
        {
            while (Bullets.Count < MaxCapacity)
            {
                Load(bullet);
            }
        }

        public BulletType Unload()
        {
            return Bullets.Pop();
        }

        public BulletType[] UnloadAll()
        {
            return Bullets.ToArray();
        }
    }
}