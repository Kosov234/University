##Returns the number of vowels from the provided input

def function(text):
    vowels = 'aeiouAEIOU'
    number = 0
    for char in text:
        if char.lower() in vowels:
            number += 1
    return number
def main():
    print(function(input("Please write the text: ")))
main()
