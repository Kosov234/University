##function that reads the first n lines of the file

def ReadLines(fileName,n):
    count=0
    file = open(fileName)
    for line in file:
        print(line.strip())
        count+=1
        if(count>=n):
            break
    file.close()
def main():
    file = ('data.txt')
    number = 3
    ReadLines(file,number)
main()
