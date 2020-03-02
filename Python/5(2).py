##function that counts the amount of lines in a file

def CountLines(fileName):
    i=0
    file = open(fileName)
    for line in file:
        i+=1
    file.close()
    return i
def main():
    file = ('data.txt')
    print(CountLines(file))
main()
