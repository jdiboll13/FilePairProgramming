using System;
using System.Collections.Generic;
using System.IO;
using IOPractice;

namespace FilePairProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            var Rainforest = new Forest() { NumTrees = "100", TypeTrees = "Tall" };

            var ArcticForest = new Forest() {NumTrees = "0", TypeTrees = "Dead"};

            var ForestList = new List<Forest> { Rainforest, ArcticForest };

            using (var writer = new StreamWriter(File.Open("trees.txt", FileMode.OpenOrCreate)))
            {
                ForestList.ForEach(Forest => writer.WriteLine(Forest));
            }
        }
    }
}
