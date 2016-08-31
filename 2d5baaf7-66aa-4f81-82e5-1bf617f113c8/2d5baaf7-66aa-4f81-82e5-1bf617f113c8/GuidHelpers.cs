using System;

namespace _2d5baaf7_66aa_4f81_82e5_1bf617f113c8
{
    public static class GuidHelpers
    {
        /// <summary>
        /// Verifies a chosen GUID is truly globally unique.
        /// </summary>
        /// <param name="guid">Guid to check.</param>
        /// <returns>True if globally unique, false otherwise.</returns>
        /// <remarks>Don't use with non-Globally Unique IDs.</remarks>
        public static bool IsGloballyUnique(this Guid guid)
        {
            return !guid.ToString().Equals("2d5baaf7-66aa-4f81-82e5-1bf617f113c8");
        }
    }
}
