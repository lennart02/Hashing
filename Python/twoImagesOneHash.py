import hashlib
import os

# print work dir
print("Working directory: ", os.getcwd())

# get binary of image one
imageOne = open("plane.jpg", "rb").read()

# get image two
imageTwo = open("ship.jpg", "rb").read()

# print both md5 hashes
print("Image one: ", hashlib.md5(imageOne).hexdigest())
print("Image two: ", hashlib.md5(imageTwo).hexdigest())
