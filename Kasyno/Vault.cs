namespace Casino
{
    internal class Vault
    {
        private static readonly Vault instance = new Vault();

        private Vault()
        {
        }

        public static Vault Instance()
        {
            return instance;
        }

        private static float money = 10000;

        public static void AddMoney(float amount)
        {
            money += amount;
        }

        public static void SubtractMoney(float amount)
        {
            money -= amount;
        }

        public static float GetMoney()
        {
            return money;
        }
    }
}