# def fun():
#     print("Hello");

# fun();

# #def evenOdd(x:int):
# def evenOdd(x):
#     if(x%2==0):
#         return "even";
#     else:
#         return "Odd";

# print(evenOdd(16));
# print(evenOdd(7));

# # Default Argument
# def myFun(x,y=59):
#     print("X :",x);
#     print("Y :",y);
# myFun(10);

# # Keyword Argument
# def student(fname,lname):
#     print(fname,lname);

# student(fname="Deepu",lname="Dhuriya");

# def nameAge(name,age):
#     print("Hi I am ",name);
#     print("My age is ",age);
    
# nameAge("Deepu",26);
# nameAge(26,"Deepu");


# # Arbitrary keyword Arguments
# def myFun(*argv):
#     for arg in argv:
#         print(arg);

# myFun("Deepu","Dhuriya","From Delhi");

# def myFun2(**kwargs):
#     for key, value in kwargs.items():
#         print("%s = %s"% (key,value));

# myFun2(Name='Deepu',Lname='Dhuriya');

# # Anonymous Functions
# def cube(x):return x*x*x ;
# cube_l=lambda x : x*x*x;

# print(cube(7));
# print(cube_l(4));

# # Return Statement 
# def square_value(num):
#     return num**2;

# print(square_value(2));

# # Pass by Reference and pass by value
# def my_fun3(x):
#     x[0]=20;

# lst = [10,11,12,13,14];
# my_fun3(lst);
# print(lst);

# def swap(x,y):
#     temp = x
#     x = y
#     y = temp;
# x =2;
# y=3;
# swap(x,y);
# print(x);
# print(y);

# # Recursive function
# def factorial(n):
#     if n==0:
#         return 1;
#     else:
#         return n* factorial(n-1);
# print(factorial(4));



#---------------------------------------------------
#---------------------------------------------------
#---------------------------------------------------

# Python Pass Statement

def fun():
    pass
fun();

# Using pass in Conditional Statements
x = 10;
if x>5:
    pass
else:
    print("x is 5 or less");
    
# Using pass in Loop
for i in range(5):
    if i ==3:
        pass
    else:
        print(i);
        

# Using pass in class
class EmptyClass:
    pass
class Person:
    def __init__(self,name,age):
        self.name = name
        self.age = age
    def greet(self):
        pass
p = Person("Deepu",26);
print(p);