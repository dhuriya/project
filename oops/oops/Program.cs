using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using oops.Encapsulation;
using oops.Constructorcls;
using oops.DSA;
using oops.Abstraction;
using oops.Inheritance;
using oops.Interface;
using oops.Polymorphism;
using oops.AnonymousMethods;
using oops.Generic_Constraints;

namespace oops
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("-----------------------------------------------------------------");
            //Console.WriteLine("----------------------Welcome Your Account-----------------------");
            //Console.WriteLine("-----------------------------------------------------------------");
            
            //BankAccount myAccount = new BankAccount(600);
            //myAccount.Deposit(200);
            //Console.WriteLine(myAccount.Balance);
            //myAccount.Withdraw(700);
            //Console.WriteLine(myAccount.Balance);

            //Console.WriteLine("-----------------------------------------------------------------");
            //Console.WriteLine("----------------------Welcome Your Coffee Era--------------------");
            //Console.WriteLine("-----------------------------------------------------------------");

            //CoffeeMachine cm = new CoffeeMachine(1000, 100);
            //cm.MakeLatte();

            //Console.WriteLine("Beans left : "+cm.BeansLeft()+" grams");

            //Console.WriteLine("-----------------------------------------------------------------");
            //Console.WriteLine("-------------------------- Your Car Speed -----------------------");
            //Console.WriteLine("-----------------------------------------------------------------");
            //CarSpeed car = new CarSpeed();
            //car.Drive();
            //car.Drive();
            //car.Drive();

            //Console.WriteLine("-----------------------------------------------------------------");
            //Console.WriteLine("----------------------- About Your Account -----------------------");
            //Console.WriteLine("-----------------------------------------------------------------");

            //DigitalWallet mywallet = new DigitalWallet("Deepu@123");
            //mywallet.Deposit(300m);
            //Console.WriteLine(mywallet.Withdrow(50m, "Deepu@123"));
            //Console.WriteLine(mywallet.CheckBalance("Deepu@123"));
            //mywallet.GetTransactionLog("Deepu@123");

            //Console.WriteLine("----------------Constructor-------------------");
            //Constructor con = new Constructor();
            //con.Display();
            //Constructor consper = new Constructor(1);
            //ClsArray ar = new ClsArray();
            //int[] arr = { 12, 34, 10, 6, 40 };
            //ar.GetTwoSumOfArray();

            // 1 Array Traversal :
            //ar.ArrayTraversal();
            // 2 Inserton in Array.
            //ar.ArrayInsertion();
            //ar.ArrayDeletion();
            //ar.ReverseArray1();
            //ar.ReverseArray2();
            //ar.ReverseArray3();
            //ar.ReverseArray4();
            //ar.ReverseArray5();
            //ar.RotateArray1();
            //ar.RotateArray3();
            //ar.RotateArray4();
            //ar.RightRotate();
            //ar.RightRotate2();
            //ar.RightRotate3();
            //ar.SearchingInUnsortedArray();
            //ar.InsertEnd();
            //ar.DisplayInsertElements();
            //ar.DisplayArrayAfterDeletion();
            //ar.DisplayBinarySearch();   \
            //-------------------------------
            // Sorting
            //--------------------------
            //clsSorting clssort = new clsSorting();
            //clssort.PrintBubbleSort();

            //int[] arr = { 1, 2, 3 } ;

            //------------------------
            // Implicitly Constructor
            //------------------------
            //ImplicitlyConstructor Ic = new ImplicitlyConstructor();
            //Console.WriteLine(Ic.i);
            //Console.WriteLine(Ic.b);
            //if (Ic.s == null)
            //{
            //    Console.WriteLine("null");
            //}

            //-----------------------------
            // Explicit Constructor
            //-----------------------------
            //ExplicitConstructor Ec = new ExplicitConstructor();

            //----------------------------
            // User-Defined Default Constructor
            //------------------------------
            //UserDefineDefault udd = new UserDefineDefault();
            //udd.Display();

            //----------------------------
            // Parameterized Constructor
            //------------------------------
            //ParameterizedConstructor pc = new ParameterizedConstructor("Deepu");

            //----------------------------
            // Copy Constructor
            //------------------------------
            //CopyConstructor cpC = new CopyConstructor(10);
            //cpC.Display();
            //CopyConstructor cpC2 = new CopyConstructor(cpC);
            //cpC2.Display();

            //----------------------------
            // Static Constructor
            //------------------------------
            //Console.WriteLine("This is a main method...");
            //StaticConstsructor sc = new StaticConstsructor();
            //StaticConstsructor sc1 = new StaticConstsructor();

            //----------------------------
            // Private Constructor
            //------------------------------
            //PrivateConstructor pc = new PrivateConstructor(12);

            //----------------------------
            // Singleton
            //------------------------------
            //Singleton fromPlace1 = Singleton.GetSingletonInstance();
            //fromPlace1.SomeMethod("From place 1");
            //Singleton fromPlace2 = Singleton.GetSingletonInstance();
            //fromPlace2.SomeMethod("From Place 2");

            //----------------------------
            // Encapsulation
            //------------------------------
            //EncapsulationBank EnBank = new EncapsulationBank();
            //EnBank.SetBalance(600);
            //Console.WriteLine(EnBank.GetBalance());

            //----------------------------
            // Abstraction
            //------------------------------
            //Console.WriteLine("Transaction doing SBI Bank");
            //SBI sbi = new SBI(); // without abstraction
            //sbi.VallidateCard(); // without abstraction
            //sbi.WithdrawMoney();  // without abstraction
            //sbi.CheckBalance(); // without abstraction
            //sbi.BankTransfer(); // without abstraction
            //sbi.MiniStatement(); // without abstraction
            //IBank sbi = BankFactory.GetBankObject("SBI");
            //sbi.ValidateCard();
            //sbi.WithdrawMoney();
            //sbi.CheckBalanace();
            //sbi.BankTransfer();
            //sbi.MiniStatement();
            //Console.WriteLine("Transaction doing AXIX Bank"); // without abstraction
            //AXIX axix = new AXIX();// without abstraction
            //axix.VallidateCard(); // without abstraction
            //axix.WithdrawMoney(); // without abstraction
            //axix.CheckBalance(); // without abstraction
            //axix.BankTransfer();// without abstraction
            //axix.MiniStatement();// without abstraction

            //Abstract sbi = BankFactory.GetBankObject("SBI");// abstraction
            //sbi.ValidateCard();
            //sbi.WithdrawMoney();
            //sbi.CheckBalanace();
            //sbi.BankTransfer();
            //sbi.MiniStatement();

            //IBank axix = BankFactory.GetBankObject("AXIX");
            //axix.ValidateCard();
            //axix.WithdrawMoney();
            //axix.CheckBalanace();
            //axix.BankTransfer();
            //axix.MiniStatement();

            //Abstract axix = BankFactory.GetBankObject("AXIX");//abstraction
            //axix.ValidateCard();
            //axix.WithdrawMoney();
            //axix.CheckBalanace();
            //axix.BankTransfer();
            //axix.MiniStatement();

            //---------------------------
            // Single Inheritace
            //--------------------------
            //Cuboid cub = new Cuboid(2, 4, 6);
            //Console.WriteLine("Volume is : "+cub.Volume()+"");
            //Console.WriteLine("Area is : "+cub.Area()+"");
            //Console.WriteLine("Perimeter is : "+cub.Perimeter()+"");

            //---------------------------
            // Multiple Inheritace it is not support in dot net c#
            //--------------------------
            //SmartPhone obj = new SmartPhone();
            //obj.GetPhoneModel();

            //-------------------------
            // Interface
            //-------------------------
            //ImplementationClass1 obj1 = new ImplementationClass1();
            //obj1.Add(10, 20);
            ////obj1.Sub(100, 20);//we can not call this
            //ImplementaionClass obj3 = new ImplementaionClass();
            ////We need to typecast obj1 to ITestInterface1 to call the Sub
            ////method because Sub method is implemented using Interface name
            //((ITestInterface1)obj3).Sub(100, 20); //Explicit Interface
            //ImplementationClass2 obj2 = new ImplementationClass2();
            //obj2.Add(10, 20);
            //obj2.Sub(100, 20);
            //-------------------------------
            // Interface Real world Example
            //-------------------------------
            //Console.WriteLine("Saving Account :");
            //IBankAccount savingAccount = new SavingAccount();
            //savingAccount.DepositAmount(2000);
            //savingAccount.DepositAmount(1000);
            //savingAccount.WithdrawaAmount(1500);
            //savingAccount.WithdrawaAmount(5000);
            //Console.WriteLine("Saving Account Balance : "+savingAccount.CheckBalance()+"");

            //Console.WriteLine("\nCurrent Account : ");
            //IBankAccount currentAccount = new CurrentAccount();
            //currentAccount.DepositAmount(500);
            //currentAccount.DepositAmount(1500);
            //currentAccount.WithdrawaAmount(2600);
            //currentAccount.WithdrawaAmount(1000);
            //Console.WriteLine("Current Account Balance : "+currentAccount.CheckBalance()+"");

            //MultipleInheritanceTest obj = new MultipleInheritanceTest();
            //obj.Test();
            // you cannot call the show method using obj
            //obj.Show();

            //using Interface referance call the show method
            //Interface1 i1 = obj;
            //i1.Show();
            //Typecase the object to interface type and call the show method
            //((Interface2)obj).Show();

            //--------------------------------
            // Compile Time Polymorphism
            //---------------------------------
            //CompileTimePolymorphism ctp = new CompileTimePolymorphism();
            //ctp.Add(4, 5);
            //ctp.Add(14.5f, 15.5f);
            //ctp.Add("Deepu", "Dhuriya");

            //--------------------------------
            // Dynamic(Run Time) Polymorphism
            //---------------------------------
            //DynamicPolymorphism dp = new DynamicPolymorphism2();
            //dp.Show();// Resolve at Runtime

            //--------------------------------
            // Method overriding
            //---------------------------------
            //MethodOverridingCls overr1 = new MethodOverridingCls2();
            //overr1.Show();
            //MethodOverridingCls2 overr2 = new MethodOverridingCls2();
            //overr2.Show();

            //--------------------------------
            // Method overriding real example
            //---------------------------------
            //OverridingExampleReal.Employee emp1 = new OverridingExampleReal.Employee()
            //{
            //    Id = 1001,
            //    Name = "Deepu",
            //    Salary = 500000,
            //    Designation = "Developer"
            //};
            //double bonus = emp1.CalculateBonus(emp1.Salary);
            //Console.WriteLine("Name: "+emp1.Name+", Designation: "+emp1.Designation+", Salary: "+emp1.Salary+", Bonus: "+bonus+"");

            //OverridingExampleReal.Employee emp2 = new OverridingExampleReal.Employee()
            //{
            //    Id = 1002,
            //    Name = "Sachin",
            //    Salary = 800000,
            //    Designation = "Manager"
            //};
            //bonus = emp2.CalculateBonus(emp1.Salary);
            //Console.WriteLine("Name: " + emp2.Name + ", Designation: " + emp2.Designation + ", Salary: " + emp2.Salary + ", Bonus: " + bonus + "");

            //OverridingExampleReal.Employee emp3 = new OverridingExampleReal.Employee()
            //{
            //    Id = 1003,
            //    Name = "Rajib",
            //    Salary = 300000,
            //    Designation = "Admin"
            //};
            //bonus = emp3.CalculateBonus(emp1.Salary);
            //Console.WriteLine("Name: " + emp3.Name + ", Designation: " + emp3.Designation + ", Salary: " + emp3.Salary + ", Bonus: " + bonus + "");

            //OverridingExampleReal.Employee emp4 = new OverridingExampleReal.Employee()
            //{
            //    Id = 1004,
            //    Name = "Priyanka",
            //    Salary = 200000,
            //    Designation = "Developer"
            //};
            //bonus = emp4.CalculateBonus(emp1.Salary);
            //Console.WriteLine("Name: " + emp4.Name + ", Designation: " + emp4.Designation + ", Salary: " + emp4.Salary + ", Bonus: " + bonus + "");

            // -----------------------
            // Anonymous Method
            //------------------------
            //oops.AnonymousMethods.Anonymous.GreetingsDelegate gd = new oops.AnonymousMethods.Anonymous.GreetingsDelegate(Anonymous.Greetings);
            //string GreetingsMessage=gd.Invoke("Deepu");
            //Console.WriteLine(GreetingsMessage);

            //oops.AnonymousMethods.Anonymous.GreetingsDelegate gd = delegate(string name)
            //{
            //    return "Hello " + name + " Welcome to Donet Tutorials";
            //};

            //string Greet = gd.Invoke("Rahul");
            //Console.WriteLine(Greet);
            
            //---------------------
            // Generic Collection
            //---------------------
            //MyGenricClass<int> integerGenericClass = new MyGenricClass<int>(10);
            //Console.WriteLine(integerGenericClass.GenericMethod(200));
            //MyGenricClass<string> stringGenericClass = new MyGenricClass<string>("Hello Generic World");
            //stringGenericClass.GenericProperty = "This is a generic property example";
            //Console.WriteLine(stringGenericClass.GenericMethod("Generic Parameter"));
            //GenericClass<string> myGenericClass = new GenericClass<string>
            //{
            //    Message = "Welcome to Dot Net Developers"
            //};
            //myGenericClass.GenericMethod("Deepu", "Delhi");

            //Console.WriteLine("Generic Method");
            //myGenericClass.GenericMethod<int, int>(10, 20);
            //myGenericClass.GenericMethod<string, string>("10.5", "20");
            //myGenericClass.GenericMethod<double, string>(10.5, "Deepu");

            //--------------------------------
            // Generic Constraints
            //---------------------------------
            // Instantiate Generic class with constraint
            //GenericClass<string> stringClass = new GenericClass<string>();
            //stringClass.Message = "Welcome to DotNetTutorials";
            //stringClass.GenericMethod("Deepu", "Delhi");
            //GenericClass<Employee> Emp = new GenericClass<Employee>();
            //Employee emp1 = new Employee()
            //{
            //    Name = "Deepu",Location ="Kanpur"
            //};
            //Employee emp2 = new Employee()
            //{
            //    Name = "rohan",
            //    Location = "Delhi"
            //};
            //Employee emp3 = new Employee()
            //{
            //    Name = "Ankit",
            //    Location = "Bihar"
            //};
            //Emp.Message = emp1;
            //Emp.GenericMethod(emp2, emp3);

            // The follwing statement will giveCompile time error as int is a value type not reference type
            // GenericClass<int> intClass = new GenericClass<int>();

            // Instantiate Generic Class With Constraint
            //GenericClass<int> inclass = new GenericClass<int>();
            //inclass.Message = 39;
            //inclass.GenericMethod(10, 20);
            //Compile Time Error as string is not a value type it is 
            // a reference type
            //GenericClass<string> stringClass = new GenericClass<string>();
            //Compile time error as Employee is not a type type it is
            // reference type 
            //GenericClass<Employee> Emp = new GenericClass<Employee>();

            //No Error , as employee class has parameterless constructor
            //GenericClass<Employee> employee = new GenericClass<Employee>();
            //Employee emp1 = new Employee()
            //{
            //    Name = "Rohit", Location = "Agra"
            //};
            //Employee emp2 = new Employee()
            //{
            //    Name = "Karan",
            //    Location = "Mumbai"
            //};
            //Employee emp3 = new Employee()
            //{
            //    Name = "Vinod",
            //    Location = "Fulera"
            //};
            //employee.Message = emp1;
            //employee.GenericMethod(emp2, emp3);
            ////compiletime error, as customer class has parameterized 
            //// constructor
            //GenericClass<Customer> customer = new GenericClass<Customer>();

            //ClsCollection clscol = new ClsCollection();
            //clscol.ComparisonDelegateDemo();
            //clscol.GenericDictionaryDemo();
            //clscol.ListVsDictionary();
            //clscol.GenericStackCollection();
            //clscol.GenericQueueCollection();
            //clscol.GenericHashSetDemo();
            //clscol.HashSet_Operations();
            //clscol.IEquatable_Interface();
            //clscol.GenericSortedListDemo();

            //Question.Fibonacci();
            //Question.Fibonacci_Recusrion();

            // FileHandlilng
            //Filehandling fl = new Filehandling();
            //fl.FileCreationUsingFileSteam();
            //fl.FileOpenAndWrite();
            //fl.FileRead();

            //BitManupulation.BinaryRepresentation();
            //BitManupulation.Countsetbits();
            BitManupulation.AddTwoBinary();





            Console.ReadLine();
        }
    }
}
