a = ["Geeks","For","Geeks"];

for i, name in enumerate(a):
    print(f"Index {i}: {name}");
    
print(list(enumerate(a)));

# Using custom start index
for index,x in enumerate(a,start=1):
    print(index,x);
print();

# Using Enumarate object in loops

for ele in enumerate(a):
    print(ele);
print();

# Accessing the Next Element 
b = enumerate(a);
next_val = next(b);
print(next_val);


