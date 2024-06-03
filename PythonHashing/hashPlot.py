# Plot a hash func with x, y to show the scattering of the hash values.

import matplotlib.pyplot as plt
import numpy as np
import math

def hashPlot(hashFunc, x, y):
    hashValues = np.array([hashFunc(x[i], y) for i in range(len(x))])
    plt.plot(x, hashValues, 'ro')
    plt.show()
    
    
def hashFunc(x, y):
    return x 

def hashByDivision(key, tableSize):
    return key % tableSize
  
def hashByMultiplication(key, tableSize):
    A = (math.sqrt(5) - 1) / 2
    return math.floor(tableSize * ((key * A) % 1))


# Random values
x = np.random.randint(1, 1000, 10000)
# Hashtable size 
y = 100

# Plot the 3 hash functions 
hashPlot(hashFunc, x, y)
hashPlot(hashByDivision, x, y)
hashPlot(hashByMultiplication, x, y)    