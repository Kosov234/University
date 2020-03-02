##creates a list of random elements and specific range

import random
def function (n,k):
    L = []
    for x in range(n):
        L.append(random.randrange(0,k))
    return L
def main():
    L=function(int(input("How many numbers do you want?\n")),int(input("The range will be from 0 to ")))
    print(L)
main()
