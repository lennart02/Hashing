import hashlib
import os

dir = os.getcwd()
print("Working directory: ", dir)

# get binary of image one
imageOne = open(dir +"/PythonHashing/plane.jpg", "rb").read()

# get image two
imageTwo = open(dir +"/PythonHashing/ship.jpg", "rb").read()

# print both md5 hashes
print("Image one: ", hashlib.md5(imageOne).hexdigest())
print("Image two: ", hashlib.md5(imageTwo).hexdigest())
