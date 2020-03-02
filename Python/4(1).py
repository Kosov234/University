## a quessing game where user must guess a number

import random
def function(n):
    k=0
    i=1
    rand = random.randrange(1,n)
    while (i!=0):
        num = (int(input("What is the number?\n")))
        if num > rand:
            print("No, it's Less")
            k+=1
        elif num<rand:
            print("No, it's More")
            k+=1
        else:
            k+=1
            print("Congratulations! The number is " + str(rand) + ", and you solved it in " + str(k) + " tries")
            return rand
def main():
    function (int(input ("The program will gues a number from 1 to ")))
main()
