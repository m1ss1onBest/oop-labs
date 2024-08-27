// ReSharper disable once IdentifierTypo
using System;

namespace WinFormsApp.types
{
    public class WeaponType
    {
        private string Name { set; get; } = "no-name-specified";
        private string Caliber { set; get; } = "no-caliber-specified";
        private int MagCapacity { set; get; } = 8;
        private int Damage { set; get; } = 1;
        private int BarrelLength { set; get; } = 161;
        

        public WeaponType()
        {
            
        }

    }
}