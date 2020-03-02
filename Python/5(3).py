##writes the text inputed by user into the file
##prints the content of the file after the user writes 'exit'

f = open('data.txt','w')
text = 'something'
while (text!='exit'):
    text = input("What do you want to add to the file? (to exit write 'exit')\n")
    if(text!='exit'):
        f.write(text+'\n')
f = open('data.txt','r')
text = f.read()
print(text)
f.close()

