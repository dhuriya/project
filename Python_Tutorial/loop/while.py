count = 0;
while(count<3):
    count = count +1;
    print("Hello Deepu");
    
# While loop with countinue Statement

i =0;
a = 'geeksforgeeks';
while i<len(a):
    if a[i]=='e' or a[i]=='s':
        i +=1;
        continue;
    print(a[i]);
    i +=1;
    
# While loop with break statement
a = 'geeksforgeeks';
print("While loop with break statement");
while i<len(a):
    if a[i]=='e' or a[i]=='s':
        i +=1;
        break;
    print(a[i]);
    i +=1;
    
# While loop with pass statement

i = 0;
while i<len(a):
    i +=1;
    pass;
print('value of i :',i);

# While loop with else

i =0;
while i< 4:
    i +=1
    print(i)
else:
    print("No Break\n");
i = 0;
while i<4:
    i +=1;
    print(i);
    break;
else:
    print("No Break");
    
    