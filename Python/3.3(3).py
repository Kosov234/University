##prints all the vowels in the string in Uppercase

def function(text):
    vowels = 'aeiou'
    newtext=[]
    for char in text:
        if char.lower() in vowels:
            text = text.replace(char,char.upper())
    newtext.append(text)
    return newtext
def main():
    print(function(input("Please write the text: ")))
main()
