namespace AdventOfCode.AoC22.Day01
{
    internal class CalorieCounting
    {
        public static (int, int) ElfWithMaxCalories()
        {
            var caloriesPerElf = GetCaloriesPerElf();

            return caloriesPerElf.MaxBy(kvp => kvp.Item2);
        }

        public static int MaxCaloriesByTopThreeElfs()
        {
            var caloriesPerElf = GetCaloriesPerElf();

            return caloriesPerElf.OrderByDescending(kvp => kvp.Item2).Take(3).Sum(e => e.Item2);
        }

        private static IEnumerable<(int, int)> GetCaloriesPerElf()
        {
            var data = File.ReadAllLines("Day01/input.txt");    
            var current = new List<int>();
            var i = 1;

            foreach (var line in data)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    current.Add(int.Parse(line));
                    continue;
                }

                yield return (i, current.Sum());
                current = new List<int>();
                i++;
            }
        }

    }
}
