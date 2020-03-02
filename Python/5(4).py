##functions that reads one file, capitalize the vowels and writes the changed text in another file
##easyfunction uses .upper(), while complicatedfunction uses ASCII code

def easyfunction(inpu,outpu):
    st = open(inpu,'r')
    fin = open(outpu,'w+')
    text = st.read()
    vowels = 'a','e','i','o','u'
    buffer =''
    for x in text:
        if x in vowels:
            x=x.upper()
        buffer+=x
    fin.write(buffer)
    st.close()
    fin.close()
    fin = open(outpu,'r')
    text = fin.read()
    print(text)
    fin.close()
    return text
def complicatedfunction(inpu,outpu):
    st = open(inpu,'r')
    fin = open(outpu,'w+')
    text = st.read()
    vowels = 'a','e','i','o','u'
    buffer=''
    for x in text:
        if x in vowels:
            x=(chr(ord(x)-32))
        buffer+=x
    fin.write(buffer)
    st.close()
    fin.close()
    fin = open(outpu,'r')
    text = fin.read()
    print(text)
    fin.close()
    return text
def main():
    inpu = 'data.txt'
    outpu = 'final.txt'
    complicatedfunction(inpu,outpu)
    easyfunction(inpu,outpu)
main()
