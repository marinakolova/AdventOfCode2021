﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Day06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Task01();
            Task02();
        }

        private static void Task02()
        {
            var fishes = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var days = 256;

            var fishesByTimer = new long[9];
            for (int i = 0; i < fishes.Count; i++)
            {
                var timer = fishes[i];
                fishesByTimer[timer]++;
            }

            for (var day = 0; day < days; day++)
            {
                fishesByTimer[(day + 7) % 9] += fishesByTimer[day % 9];
            }

            Console.WriteLine($"Number of fishes after {days} days: {fishesByTimer.Sum()}");
        }

        private static void Task01()
        {
            var fishes = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var days = 80;

            for (int i = 0; i < days; i++)
            {
                var newFishes = new List<int>();
                for (int j = 0; j < fishes.Count; j++)
                {                    
                    if (fishes[j] == 0)
                    {
                        fishes[j] = 6;
                        newFishes.Add(8);
                    }
                    else
                    {
                        fishes[j] -= 1;
                    }
                }
                fishes.AddRange(newFishes);
            }

            Console.WriteLine($"Number of fishes after {days} days: {fishes.Count}");
        }
    }
}
