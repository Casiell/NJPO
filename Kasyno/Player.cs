namespace Casino
{
    internal static class Player
    {
        private static float money = 1000;

        public static void SubstractMoney(float amount)
        {
            money -= amount;
        }

        public static void AddMoney(float amount)
        {
            money += amount;
        }

        public static float GetMoney()
        {
            return money;
        }
    }
}