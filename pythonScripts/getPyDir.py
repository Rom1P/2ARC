import sys

with open('..\\..\\pythonScripts\\localPathPython.txt', 'w') as fileConverted:
    fileConverted.write(sys.exec_prefix)