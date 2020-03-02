##function that reads the file line by line, sorts them by size and writes them to another file

def function(inpu,outpu):
    buffer = []
    read = open(inpu,'r')
    write = open(outpu,'w+')
    for line in read:
        buffer.append(line)
    print(buffer)
    i=0
    indent = 1
    while(i<len(buffer)-1):
        while(indent<len(buffer)-i):
            if (len(buffer[i])>=len(buffer[i+indent])):
                #print (buffer[i]+buffer[i+indent]+'\n')
                buffer[i],buffer[i+indent]=buffer[i+indent],buffer[i]
                #print (buffer[i]+buffer[i+indent]+'\n')
            indent+=1
        i+=1
        indent=1
    print(buffer)
    for element in buffer:
        write.write(element)
    read.close()
    write.close()
def main():
    inpu = 'data.txt'
    outpu= 'final.txt'
    function(inpu,outpu)
main()

