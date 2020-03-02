##checks if the lists have the same size and the same elements (but the order of elements can be different)

def equals(a,b):
    if (set(a)!=set(b)):
        print("The lists are not equal")
        return 0;
    else:
        print("The lists are equal")
        return 1;
def main():
    list1 = [1,2,3,'s']
    list2 = [1,3,2,'s']
    equals(list1,list2)
main()
