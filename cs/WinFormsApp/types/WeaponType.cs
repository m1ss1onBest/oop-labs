// ReSharper disable once IdentifierTypo
using System;

namespace WinFormsApp.types
{
    public class WeaponType
    {
        private string Name { set; get; }
        private BulletType Caliber { set; get; }
        private int Barrel { set; get; }
        private float Accuracy { set; get; }

        public WeaponType(string name)
        {
            Name = name;
        }

        public WeaponType(
            string name,
            BulletType caliber,
            int barrel,
            float accuracy
        )
        {
            Name = name;
            Caliber = caliber;
            Barrel = barrel;
            Accuracy = accuracy;
        }
    }
}