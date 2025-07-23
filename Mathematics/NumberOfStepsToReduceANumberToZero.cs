namespace Exercises.Mathematics
{
    public static class NumberOfStepsToReduceANumberToZero
    {
        public static int Solution(int num)
        {
            var numberOfSteps = 0;

            while (true)
            {
                if (num == 0)
                {
                    break;
                }

                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }

                numberOfSteps++;
            }

            return numberOfSteps;
        }
    }
}
