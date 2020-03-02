##Calculates the geometrical mean of two numbers

import math
def function(num1,num2):
    num = math.sqrt(int(num1)*int(num2))
    return num
def main():
    print(function(input("Please write the first number: "),input("Please write the second number: ")))
main()
