using System;
using System.Linq;

namespace FlatArray
{
    public static class ArrayExtension
    {
        public static int[] ToFlattenIntArray(this int[][] arrayValue) {

           return arrayValue.SelectMany(x => x).ToArray();

        }
    }
}
