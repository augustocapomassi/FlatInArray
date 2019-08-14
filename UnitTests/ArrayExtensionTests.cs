using FlatArray;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class ArrayExtensionTest
    {
        [TestMethod]
        public void ToFlattenArrayShouldGetAFlattenArrayOfInt()
        {
            var NeestedArray = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4 } };

            var result = NeestedArray.ToFlattenIntArray();

            result[0].Should().Be(1);
            result[1].Should().Be(2);
            result[2].Should().Be(3);
            result[3].Should().Be(4);
        }
    }
}
