for i in range(6):
    print(i,end=" ");
print();

# python range(start,stop)
for i in range(5,20):
    print(i,end=" ");
print();
# python range(start,stop,step)
for i in range(0,30,4):
    print(i,end=" ");
print();

# incrementing the Range using a positive step

for i in range(0,20,5):
    print(i,end=" ");
print();

# range() using with  Negative step

for i in range(20,2,-2):
    print(i,end=" ");
print();

# range() with Float values  not support 
# for i in range(3.3):
#     print(i);
# print();


# Concatenation of two range() function using itertools chain() method

from itertools import chain
# Using chain method
print("Concatenation the result")
res = chain(range(5),range(10,20,2));
for i in res:
    print(i,end=" ");
print();

# Accessing range() with an index value

ele = range(10)[0];
print("First element: ",ele);

ele = range(10)[-1];
print("\nLast element: ",ele);

ele = range(10)[4];
print("\nFifth element: ",ele);

# range() with list
fruits = ["apples","Banana","orange"];
for i in fruits:
    print(i,end=" ");
print();