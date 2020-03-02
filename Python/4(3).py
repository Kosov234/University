##creates a matrix of random elements and specific range

import random
def function (m,n,k):
    Matrix = [[random.randrange(0,k) for x in range(m)]for y in range(n)]
    print (Matrix)
    return Matrix
def main():
    function (int(input("Write the first size of your matrix \n")),int(input("Write the second size of your matrix \n")),int(input("The range of numbers will be from 0 to  \n")))
main()
