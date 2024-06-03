# Hash Function Demonstration

This repository is created for educational purposes, showcasing experiments with hash functions in C#.

# Project Overview

The repository includes the following projects:

## Hashing
A simple implementation of Multiplication Hashing and Division Hashing.

## HashTable
A comprehensive implementation of a Hashtable using Division Hashing, including insert, delete, and search operations. Examples of Linear Probing, Quadratic Probing, and Double Hashing are provided. It also comes with dynamic resizing through rehashing.

## Cryptographic Hashing
This C# application demonstrates the functionality and performance of various cryptographic hash functions, such as MD5, SHA1, SHA256, SHA512. Additionally, I added a simple additive hash, that processes input data to produce fixed-size outputs. 


|           | MD5 | SHA1 | SHA256 | SHA512 | Simple Hash |
|-----------|-----|------|--------|--------|-------------|
| Bit Size  | 128 | 160  | 256    | 512    | 16          |



## Tests
Includes various tests for the hash functions and hash table implementations.



## Python Hashing

### Two Images One Hash
Here is one example of two different images, that have the same image. This shows how collisions can occur on completely different data.

### Hash Plot

This Python script plots the scattering of hash values using different hash functions. It utilizes the `matplotlib` library for visualization.


The script currently supports three hash functions:

1. `hashFunc(x, y)`: A simple hash function that returns the value of `x`.
2. `hashByDivision(key, tableSize)`: A hash function that uses the modulo operator to map the `key` to a value within the `tableSize`.
3. `hashByMultiplication(key, tableSize)`: A hash function that uses the multiplication method to map the `key` to a value within the `tableSize`.


Feel free to experiment with different values and hash functions to see how the scattering of hash values changes.

## Docs
A collection of [Drawio](https://draw.io) diagrams is stored here.
The project consists of the following examples:

## Usage
These projects demonstrate basic hashing concepts. They can be executed directly. It is recommended to modify `Program.cs` to test different examples and gain a deeper understanding.

## License

This project is released under the MIT License - see the [LICENSE](LICENSE.md) file for details.
