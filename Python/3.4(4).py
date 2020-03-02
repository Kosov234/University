##calculates the amount of negative numbers in list

def function (numbers):
    count = 0;
    for x in numbers:
        if x<0:
            count+=1
    return count;
def main():
    list1 = [-1,2,3,-4,5,6,7,-8,9,-10]
    print("The amount of negative numbers in this list is: ", function(list1))
main()
