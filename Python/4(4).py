##calculates an arithmetical mean of randomly selected numbers in the randomly selected list of random size

import random
def filling(L,n):
    for x in range(n):
        L.append(random.randrange(0,20))
    return L
def function (L,n):
    value = 0
    L.sort()
    for x in range(n):
        buffer = random.sample(L,n)
        value = buffer[x]+value
        print(value)
    value = value/n
    print (value)
def main():
    L = []
    number=random.randrange(2,10)
    filling(L,number)
    print(L)
    function(L,(random.randrange(1,number-1)))
main()
