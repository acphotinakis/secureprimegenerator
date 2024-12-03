# Prime Generation Library

This repository contains a C# implementation of a secure and efficient prime number generator using parallel processing and probabilistic primality testing. The library includes support for generating prime numbers of specified bit lengths and checking primality.

# Project Overview


# Use Cases for Network Security

The **Prime Generation Library** can be leveraged in various network security applications where prime numbers play a crucial role. Below are some key use cases:

- **1. RSA Encryption Key Generation**
  - RSA encryption relies on the generation of large prime numbers for creating public and private keys.
  - A typical RSA key size ranges from 2048 to 4096 bits, and the **Prime Generation Library** can be used to efficiently generate the required primes for secure communication.

    **Example:**
    ```bash
    dotnet run 2048 1
    ```
    This command generates a 2048-bit prime number, which can be used in the generation of an RSA key.

- **2. Elliptic Curve Cryptography (ECC)**
  - In ECC, large prime numbers are used to define the curve's finite field.
  - By using the Prime Generation Library, cryptographically secure primes can be generated for use in ECC key pair creation.

    **Example:**
    ```bash
    dotnet run 512 1
    ```
    This will generate a 512-bit prime, suitable for elliptic curve parameters.

- **3. Diffie-Hellman Key Exchange**
  - Diffie-Hellman key exchange protocols use large primes to create a shared secret over an insecure channel.
  - The Prime Generation Library can generate primes for this purpose, ensuring secure key exchange between parties.

    **Example:**
    ```bash
    dotnet run 1024 1
    ```
    This command generates a 1024-bit prime suitable for Diffie-Hellman key exchange.

- **4. Digital Signatures**
  - Digital signature algorithms, such as DSA (Digital Signature Algorithm), rely on the use of primes to generate secure signature pairs.
  - By using the Prime Generation Library, prime numbers can be generated for signing and verifying messages, ensuring data integrity and authentication.

    **Example:**
    ```bash
    dotnet run 1024 5
    ```
    This generates 5 prime numbers of 1024 bits, which can be used in DSA for signing multiple messages.

- **5. Secure Hashing and Message Authentication Codes (HMAC)**
  - In secure hashing, primes are sometimes used as part of the algorithm to ensure randomness and prevent certain types of attacks.
  - The library can be integrated into HMAC systems to enhance security by providing strong, random primes.

    **Example:**
    ```bash
    dotnet run 512 1
    ```
    This will generate a 512-bit prime number that could be incorporated into HMAC-based protocols.

- **6. Random Number Generation for Security Tokens**
  - The library provides a cryptographically secure random number generator that can be used to create random tokens, which are essential in generating session keys or cryptographic nonces used in network security protocols.

    **Example:**
    ```bash
    dotnet run 256 1
    ```
    This generates a secure 256-bit random prime suitable for creating a security token.

- **7. Blockchain and Cryptocurrency**
  - In blockchain systems, prime numbers are often used in the creation of secure addresses and cryptographic algorithms.
  - The Prime Generation Library can be used to generate secure primes for blockchain-related operations such as generating keys and signing transactions.

    **Example:**
    ```bash
    dotnet run 2048 10
    ```
    This generates 10 prime numbers of 2048 bits, which can be used for secure blockchain applications.

## Utilization Features
By utilizing this Prime Generation Library, developers can ensure that their cryptographic systems are built on secure, efficiently generated prime numbers, which are a fundamental component in protecting data and communications in modern network security applications.

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
```

# Command-Line Interface
The program accepts the following arguments:

- `<bits>`: Number of bits for the prime number (must be a multiple of 8 and at least 32).
- `[<count>]`: Optional. Number of primes to generate (default is 1).


## Unacceptable Arguments

- Fewer than 1 argument or more than 2 arguments will result in an error.
- Invalid `<bits>` (not an integer, not a multiple of 8, or less than 32).
- Invalid `<count>` (not a positive integer or less than 1).

### Error Messages:

- **Too few arguments**: If you don't provide any arguments or provide just one invalid argument, the program will prompt for correct usage.
    - Example: `Usage: PrimeGen <bits> [<count=1>]`
  
- **Too many arguments**: If you provide more than 2 arguments, the program will report an error.
    - Example: `Too many arguments. Usage: PrimeGen <bits> [<count=1>]`
  
- **Invalid `<bits>`**: If the `<bits>` argument is not a positive integer, not a multiple of 8, or less than 32, the program will show an error.
    - Example: `Invalid bits. It must be an integer, a multiple of 8, and at least 32 bits.`
  
- **Invalid `<count>`**: If the `<count>` argument is not a positive integer or less than 1, the program will show an error.
    - Example: `Invalid count. It must be a positive integer and at least 1`


# Example usage:

## Command-Line Arguments Example
```bash
dotnet run 256 10
```

This command generates 10 primes of 256 bits each.

## Code Snippets
```csharp
BigInteger prime = PrimeExtension.GeneratePrime(256, k: 10);
Console.WriteLine($"Generated prime: {prime}");
```

```scss
Output:

BitLength: 256 bits
1: 56286178874160225877270396766798824950107447976566511842577628922373451581127

2: 23437464717690545131602483531650459217845425887589361284419514873102066919659

3: 37708056443178967314073291439953379298072638648119221625980487041007261724239

4: 41713257470660737412042170643563333165004770503340617190839070066483432403047

5: 13226172819100084528766919151972475706240529215479998703500327864285235025847

6: 23469191115338735188992644789692191256346320488320776889824095764481866758891

7: 19960431338165247743554201497945672861759002573454229951851847828230229881683

8: 14936226496283527293309567553982842974695157320921397694864783857666803993051

9: 56515072535467960290214267111776177251424143139075684941983277489192716229603

10: 38915507061896704385867732279141395143839118410126725247893825205631638405411
Time to Generate: 0:00:00.1015518
```

## Testing
To validate the implementation:

- Test small primes with known values.
- Test large primes using the Miller-Rabin primality test.
- Measure performance for different bit lengths and counts.

## Requirements
- .NET Framework or .NET Core
- .NET 7.0
- A compatible C# compiler
- System.Numerics
- System.Security.Cryptography

