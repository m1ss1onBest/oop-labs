// ReSharper disable once IdentifierTypo

using System;

namespace WinFormsApp.types
{
    public class WeaponType
    {
        private string Name { set; get; } = "no-name-specified";
        private BulletType Bullet { set; get; }
        private int BarrelLength { set; get; } = 1;

        public WeaponType()
        {
            
        }

        public WeaponType(string name, int barrelLength, BulletType bullet)
        {
            Name = name;
            BarrelLength = barrelLength;
            Bullet = bullet;
        }
        
        public WeaponType(WeaponType weaponType)
        {
            Name = weaponType.Name;
            BarrelLength = weaponType.BarrelLength;
            Bullet = weaponType.Bullet;
        }
    }
}