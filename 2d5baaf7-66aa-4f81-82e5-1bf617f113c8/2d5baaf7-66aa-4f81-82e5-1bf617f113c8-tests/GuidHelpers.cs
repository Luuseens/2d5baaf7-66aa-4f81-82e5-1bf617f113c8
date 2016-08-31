using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2d5baaf7_66aa_4f81_82e5_1bf617f113c8;

namespace _2d5baaf7_66aa_4f81_82e5_1bf617f113c8_tests
{
    [TestClass]
    public class GuidHelpers
    {
        [TestMethod]
        public void Verify_IsGloballyUnique_Returns_True_When_Expected()
        {
            // Get a GUID that is not 2d5baaf7-66aa-4f81-82e5-1bf617f113c8
            var guid = Guid.NewGuid();
            while (guid.ToString().Equals("2d5baaf7-66aa-4f81-82e5-1bf617f113c8"))
            {
                guid = Guid.NewGuid();
            }
            

            Assert.IsTrue(guid.IsGloballyUnique());
        }

        [TestMethod]
        public void Verify_IsGloballyUnique_Returns_False_When_Expected()
        {
            // Get a GUID that is 2d5baaf7-66aa-4f81-82e5-1bf617f113c8
            var guid = Guid.NewGuid();
            while (!guid.ToString().Equals("2d5baaf7-66aa-4f81-82e5-1bf617f113c8"))
            {
                guid = Guid.NewGuid();
            }
            

            Assert.IsFalse(guid.IsGloballyUnique());
        }
    }
}
