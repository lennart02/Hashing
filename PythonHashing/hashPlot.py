# Plot a hash func with x, y to show the scattering of the hash values.

import matplotlib.pyplot as plt
import numpy as np
import math


def hashPlot(hashFunc, x, y):
    hashValues = np.array([hashFunc(x[i], y) for i in range(len(x))])
    plt.plot(x, hashValues, "ro")
    plt.xlabel("Key")
    plt.ylabel("Hash Value")
    plt.title(hashFunc.__name__)
    plt.show()


def hashFunc(x, y):
    return x


def hashByDivision(key, tableSize):
    return key % tableSize


def hashByMultiplication(key, tableSize):
    A = (math.sqrt(5) - 1) / 2
    return math.floor(tableSize * ((key * A) % 1))


# 1000 Random values von 1 to 1000
x = np.random.randint(1, 1000, 1000)
# Hashtable size
y = 100
# x axis is the key values, y axis is the hash values
# Plot the 3 hash functions
hashPlot(hashFunc, x, y)
hashPlot(hashByDivision, x, y)
hashPlot(hashByMultiplication, x, y)
