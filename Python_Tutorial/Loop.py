s= ["Geek","For","Geeks"];
# Using for loop
for i in s:
    print(i);
    
# Using range() with For loop
for i in range(0, 10, 2):
    print(i);
    
for i in 'geeksforgeeks':
    if i=='e' or i=='s':
        continue
        print(i);