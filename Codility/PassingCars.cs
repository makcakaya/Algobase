namespace Codility
{
    public sealed class PassingCars
    {
        public static int Solution(int[] cars)
        {
            const int max = 1000000000;
            var countZeros = 0;
            var countPassed = 0;
            var totalPassed = 0L;
            for (var i = 0; i < cars.Length; i++)
            {
                var car = cars[i];
                if (car == 0)
                {
                    totalPassed += countPassed * countZeros++;
                    if (totalPassed > max || totalPassed < 0)
                    {
                        return -1;
                    }
                    countPassed = 0;
                }
                else
                {
                    countPassed++;
                }
            }

            totalPassed += countPassed * countZeros;
            if (totalPassed > max || totalPassed < 0)
            {
                return -1;
            }
            return (int)totalPassed;
        }
    }
}