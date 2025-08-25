age = 19;
# if age>=18:
#     print("Eligible to vote");

#short hand
if age>=18: print("Eligible to vate");

# if age <= 12:
#     print("Travel for free");
# else:
#     print("pay for ticket");

#Short hand
marks = 45;
res = "pass" if marks>=40 else "Fail";
print(f"Result : {res}");

age = 25;
if age <=12:
    print("Chile");
elif age <=19:
    print("Teenager.");
elif age<=35:
    print("young Adult");
else:
    print("Adult");
    

age = 70;
is_member = True;
if age>=60:
    if is_member:
        print("30% senior discount!");
    else:
        print("20% senior discount!");
else:
    print("Not eligible for a senior discount.");
    
# Ternary Conditon
age = 20;
s = "Adult" if age>=18 else "minor";
print(s);


# Match-case statement in python
number = 2;
match number:
    case 1:
        print("One");
    case 2 |3:
        print("Two or Three");
    case _:
        print("Other number");
            
