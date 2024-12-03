# Prime Generation Library

This repository contains a C# implementation of a secure and efficient prime number generator using parallel processing and probabilistic primality testing. The library includes support for generating prime numbers of specified bit lengths and checking primality.

## Project Structure

### Files

- **PrimeExtension.cs**

  Contains extension methods for handling prime number generation and primality testing using `BigInteger`.
  
  **Features:**
  - Probabilistic primality testing using Miller-Rabin.
  - Naive and probabilistic prime generation.
  - Random `BigInteger` generation within a specified range.

- **SecureRandom.cs**

  Provides a secure random number generator using `RandomNumberGenerator` from the `System.Security.Cryptography` namespace.
  
  **Features:**
  - Ensures cryptographic security for random number generation.

- **Program.cs**

  Implements the main application logic for generating prime numbers.
  
  **Features:**
  - Command-line arguments for specifying the bit length and count of primes to generate.
  - Input validation with custom error messages using `InternalInputErrorException`.
  - Performance tracking using `Stopwatch`.

## Features

### Prime Generation and Testing

- **Naive Prime Generation:**  
  Preprocesses the first 10,000 primes for optimization.

- **Probabilistic Prime Generation:**  
  Uses parallel processing and the Miller-Rabin test to generate large primes efficiently.

- **Secure Random Number Generation:**  
  Generates cryptographically secure random numbers.

### Input Validation

- Custom error handling ensures robust input validation and detailed error reporting.

## Usage

### Namespace

Ensure you include the appropriate namespaces to access the library:

```csharp
using ExtensionMethod;
using SecureRandomNamespace;


# Command-Line Interface
The program accepts the following arguments:

- `<bits>`: Number of bits for the prime number (must be a multiple of 8 and at least 32).
- `[<count>]`: Optional. Number of primes to generate (default is 1).

## Example usage:

```bash
dotnet run 256 5
This command generates 5 primes of 256 bits each.

Code Snippets
Generating a Prime
Generate a 256-bit prime:

csharp
Copy code
BigInteger prime = PrimeExtension.GeneratePrime(256, k: 10);
Console.WriteLine($"Generated prime: {prime}");
Command-Line Arguments Example
bash
Copy code
dotnet run 128
Output:
yaml
Copy code
BitLength: 128 bits
1: 29387239872983728392
Time to Generate: 00:00:02.345
Testing
To validate the implementation:

Test small primes with known values.
Test large primes using the Miller-Rabin primality test.
Measure performance for different bit lengths and counts.
Requirements
.NET Framework or .NET Core
A compatible C# compiler
System.Numerics
System.Security.Cryptography
Author
Andrew Photinakis
Course: Concepts of Parallel Computing and Distributed Systems
Assignment: Project 2
Due Date: October 31, 2023
License
This project is licensed under the MIT License. See the LICENSE file for details.

vbnet
Copy code

This markdown version will display correctly when rendered in environm