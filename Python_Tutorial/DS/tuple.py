tup=();
print(tup);
tup = ('Geeks','for');
print(tup);

li = [1,2,3,4];
print(tuple(li));

tup = tuple('Geeks');
print(tup);
# Creating a tuple with nested tuple
tup1 = (0,1,2,3,4);
tup2 = ('python','Java');
tup3 =(tup1,tup2);
print(tup3);

# Creating a Tuple with repetion
tup4 = ('Geeks',)*3;
print(tup4);

# Creating a Tuple with the use of loop
tup5 = ('Deepu');
n = 5;
for i in range(int(n)):
    tup5 = (tup5,)
    print(tup5);