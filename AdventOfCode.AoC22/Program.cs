using AdventOfCode.AoC22.Day01;

namespace AdventOfCode.AoC22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // --- Day 1: Calorie Counting ---

            var maxElf = CalorieCounting.ElfWithMaxCalories();
            Console.WriteLine($"Elf number {maxElf.Item1} has {maxElf.Item2} cals.");

            var calsByTop3Elfs = CalorieCounting.MaxCaloriesByTopThreeElfs();
            Console.WriteLine($"Top three Elfs has {calsByTop3Elfs} cals.");

            // -------------------------------------------------- 


            Console.ReadLine();
        }   
    }
}