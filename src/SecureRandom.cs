// ########################################################################
// ### Author: Andrew Photinakis                                        ###
// ### File: SecureRandom.cs                                            ###
// ### Description: Provides a secure random number generator using     ###
// ### cryptographic APIs to generate secure random bytes.              ###
// ########################################################################

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