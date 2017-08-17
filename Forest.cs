using System;

namespace IOPractice
{
    public class Forest
    {
        public string NumTrees { get; set; }
        public string TypeTrees { get; set; }

        public override string ToString()
        {
            return $"In this forest, there are {NumTrees} trees and they are all {TypeTrees}.";
        }

        public Forest(string[] data)
        {
            NumTrees = data[0];
            TypeTrees = data[1];
        }

        public Forest()
        {
            
        }
    }

}