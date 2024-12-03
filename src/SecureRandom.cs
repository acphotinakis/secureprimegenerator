// ######################################################################
// ### Author: Andrew Photinakis                                      ###
// ### Course: Concepts of Parallel Computing and Distributed Systems ###

// ### Due Date: October 31, 2023                                     ###
// ######################################################################
using System.Security.Cryptography;

namespace SecureRandomNamespace
{
    /// <summary>
    /// Provides a secure random number generator.
    /// </summary>
    public class SecureRandom
    {
        private RandomNumberGenerator rng = RandomNumberGenerator.Create();

        /// <summary>
        /// Fills the provided byte array with cryptographically secure random bytes.
        /// </summary>
        /// <param name="bytes">The byte array to fill with random bytes.</param>
        public void NextBytes(byte[] bytes)
        {
            rng.GetBytes(bytes);
        }
    }
}