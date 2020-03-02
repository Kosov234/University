##the program that guesses the number user is thinking about

import random
i=input("Please guess a number between 1 and 10 (Press ENTER to continue)")
i=0
while(i==0):
    print("Write 0 for NO and 1 for YES\nIs this your number?",random.randint(1,10))
    i=int(input())
print("That was your number!")    
