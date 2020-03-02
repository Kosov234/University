##calculates the factorial of inputed number

def factorial(num):
    finalnum=1
    for x in range(num):
        finalnum = (x+1)*finalnum
    return finalnum
def main():
    print (factorial(int(input("Please write the number:"))))
main()  
