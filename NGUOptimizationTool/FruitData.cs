using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGUOptimizationTool
{
    public class FruitData
    {
        public FruitData(string name, int baseCost)
        {
            Name = name;
            BaseCost = baseCost;
        }

        public string Name { get; set; }
        public long BaseCost { get; set; }
        public long SeedsSpent(long level)
        {
            return BaseCost * level * (level + 1) * (2 * level + 1) / 6;
        }
    }
}
