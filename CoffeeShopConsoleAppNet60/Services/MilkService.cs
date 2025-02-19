using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60.Services
{
    public abstract class MilkService
    {
        public static int ExtractMilk(int milkCapacityBefore, int milkInMilliliterToBeExtracted)
        {
            if (milkCapacityBefore <= 0)
            {
                throw new ArgumentException($"Milk is empty\nCapacity: {milkCapacityBefore}");
            }

            int milkCapacityAfterExtract = milkCapacityBefore - milkInMilliliterToBeExtracted;

            if (milkCapacityAfterExtract <= -1)
            {
                throw new ArgumentException($"Not enough milk\nBefore brew: {milkCapacityBefore}\nAfter brew {milkCapacityAfterExtract}");
            }

            return milkCapacityAfterExtract;
        }

        public static int InsertMilk(int milkCapacityBefore, int milkInMilliliter)
        {
            if (milkCapacityBefore >= 3000)
            {
                throw new ArgumentException($"Milk Capacity is full\nCapacity: {milkCapacityBefore}");
            }

            int milkCapacityAfterInsert = milkCapacityBefore + milkInMilliliter;

            if (milkCapacityAfterInsert >= 3001)
            {
                throw new ArgumentException($"Too much milk, not enough capacity\nCapacity: {milkCapacityBefore}\nExpected Capacity {milkCapacityAfterInsert}");
            }

            return milkCapacityAfterInsert;
        }
    }
}
