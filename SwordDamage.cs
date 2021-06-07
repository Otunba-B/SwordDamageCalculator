namespace SwordDamageCalculator
{
    class SwordDamage
    {
        public const int Base_Damage = 3;
        public const int Flame_Damage = 3;

        public int Roll;
        public decimal MagicMultiplier = 1M;
        public int FlamingDamage = 0;
        public int Damage;

        public void CalculateDamage()
        {
            Damage = (int)(Roll * MagicMultiplier) + Base_Damage + FlamingDamage;
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if(isFlaming)
            {
                Damage += Flame_Damage;
            }
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75M;
            }
            else
            {
                MagicMultiplier = 1M;
            }
            CalculateDamage();
        }
    }
}
