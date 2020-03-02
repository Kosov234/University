##calculates a mode of randomly selected numbers in the randomly selected list of random size

def filling(L,n):
    for x in range(n):
        L.append(random.randrange(0,20))
    return L
def function(L,n):
    value = 0
    L.sort()
    print(L)
    counter1 = 1
    counter2 = 0
    for x in range(n):
        buffer = random.sample(L,n)
    buffer.sort()
    print(buffer)
    for x in range(n):
        if ((buffer[x-1]==buffer[x])&(x!=0)):
            counter1 +=1
        else :
            if (counter1>=counter2):
                value = buffer[x-1]
            counter2=counter1
            counter1 = 0
    print(value)
    return value##usually just returns the random number of buffer,
                ##(if there were no repetitions in original List)
def main():
    L = []
    number=random.randrange(2,10)
    filling(L,number)
    print(L)
    function(L,(random.randrange(1,number-1)))
main()
