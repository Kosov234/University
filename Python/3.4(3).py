##returns arithmetical and geometrical value of the list

import math
def function (numbers):
    total = 0
    for x in numbers:
        total = total + numbers[x-1]
    ar = total/len(numbers)
    total = 1
    for x in numbers:
        total = total * numbers[x-1]
    geom = math.sqrt(total)
    return ar,geom
def main():
    list1 = [1,2,3,4,5,6,7,8,9,10]
    print(list1)
    ar,geom = function(list1)
    print (f'The arithmetical value of this list is {ar} and geometrical value is {geom}')
main()
