namespace Exercises.Matrix
{
    public static class RichestCustomerWealth
    {
        public static int Solution(int[][] accounts)
        {
            var richestWealth = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                var currentWealth = 0;

                for (int j = 0; j < accounts[i].Length; j++)
                {
                    currentWealth += accounts[i][j];
                }

                if (currentWealth > richestWealth)
                {
                    richestWealth = currentWealth;
                }
            }

            return richestWealth;
        }
    }
}
