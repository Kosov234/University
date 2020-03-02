##Converts Fahrenheit to Celsius and vice versa until the user writes 0

i=1
while i!=0:
    i = int(input("\nWhat conversion will you do?\nCelsius to Fahrenheit-1\nFahrenheit to Celsius-2\nif you want to exit press 0\n"))
    if(i==1):
        temp = int(input("Please write the Celsius temperature\n"))
        print("The temperature in Fahrenheit is : ",temp*1.8+32)
    if(i==2):
        temp = int(input("Please write the Fahrenheit temperature\n"))
        print("The temperature in Celsius is : ",(temp-32)/1.8)
