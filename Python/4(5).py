##calculates a median of randomly selected numbers in the randomly selected list of random size

import random
def filling(L,n):
    for x in range(n):
        L.append(random.randrange(0,20))
    return L
def function (L,n):
    L.sort()
    print(L)
    for x in range(n):
        buffer = random.sample(L,n)
    buffer.sort()
    print(buffer)
    if n%2==1:
        value =buffer[int(n/2)]
    else:
        value = (buffer[int(n/2-1)]+buffer[int(n/2)])/2
    print (value)
def main():
    L = []
    number=random.randrange(2,10)
    filling(L,number)
    print(L)
    function(L,(random.randrange(1,number-1)))
main()
