namespace WinFormsApp.types.weapons
{
    public class Gun : WeaponType
    {
        private Magazine Magazine { set; get; }

        public Gun(string name) : base(name)
        {
            
        }
    }
}