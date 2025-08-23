#name = input("Enter your name");
#print("Hello, ",name,"! Welcome!");

# single varibale
#s = "Deepu";
#print(s);

#Multiple variable
#s = "Apple";
#age =24;
#city ="Delhi";
#print(s,age,city);


# taking two inputs at a time
#x, y = input("Enter two values : ").split();
#y = input("Enter two values : ")
#print("Number of boys: ",x);
#print("number of grils: ",y);


#Find DataType of input 
a = "Hello word";
b = 10;
c = 11.22;
d = ("Deepu","Kumar","Dhuriya");
e = ["Deepu","Kumar","Dhuriya"];
f = {"Name":"Deepu","age":26};

print(type(a));
print(type(b));
print(type(c));
print(type(d));
print(type(e));
print(type(f));


# Using sep and end parameter
# end Parameter with '@'
print("Deepu", end='@');
print("Dhuriya");

# Seprating with comma
print('G','F','S',sep='');

#for formatting a data
print('23','08','2025', sep='-');

print('pratik','geekforgeek',sep='@'); 

# Using f-string
name ='Deepu';
age = 26;
print(f"Hello, My name is {name} and I'm {age} years old.");

