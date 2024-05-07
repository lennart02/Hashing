import matplotlib.pyplot as plt
import numpy as np
import math
import random


def hashByMultiplication(key, tableSize):
    A = (math.sqrt(5) - 1) / 2
    return math.floor(tableSize * ((key * A) % 1))


def hashByDivision(key, tableSize):
    return key % tableSize


def getRandomValues(n, tableSize):
    keys = [random.randint(1, n)*8 for i in range(n)]
    hashValues = []
    for key in keys:
        hashValues.append(hashByDivision(key, tableSize))
    
    return hashValues

#get bytes of ../Docs/hashFunk.png
def getBytes():
    with open("../Docs/hashFunk.png", "rb") as file:
        return file.read()

# main: zeige grafisch die Verteilung der Hashwerte bei verschieden tableSize nur für hashBy Division
def main():
    maxTableSize = 16
    variants = []
    for tableSize in range(1, maxTableSize):
        hashValues = getRandomValues(10_000, tableSize)
        variants.append(np.std(hashValues))

    table64 = getRandomValues(1_000_000, 32)
    # show variants on y and index on x
    plt.plot(range(1, maxTableSize), variants)
    #plt.hist(table64, bins=max(table64), color='red')
    plt.show()

    # print standard deviation
    print(np.std(variants))


if __name__ == "__main__":
    main()
