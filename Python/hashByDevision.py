def hashByDivision(key, tableSize):
    return key % tableSize
  
while True:
    key = int(input("Enter a key: "))
    tableSize = 7#int(input("Enter a table size: "))
    print("Hash value: ", hashByDivision(key, tableSize))
    if input("Do you want to continue? (yes/no): ") == "no":
        break