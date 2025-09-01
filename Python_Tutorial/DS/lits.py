# Creating a python list with diffrent datatypes

a = [10,29,"GFG",40,True];
print(a);

# using Square Brackets
a = [1,2,3,4,5];

# using list() Constructor
a = list((12,34,'a','m',True));

print(a);

# Creatig list repeated elements
a = [2]*5;
print(a);

# Adding Elements list
b = [];
# Adding 10 to end of list
b.append(10);
print("After append(10): ",b);

# inserting 5 at index 0 
b.insert(0,5);
print("After insert(0,5): ",b);

# Adding multiple elements [15,20,25] at the end
b.extend([15,20,25]);
print("After extend([15,20,25]): ",b);

# Removing Elements of list
c = [10,20,30,40,50];
c.remove(30);
print(c);
c.pop(1);
print(c);
del c[2];
print(c);

# List Comprehension in Python
squares = [x**2 for x in range(1,6)];
print(squares);