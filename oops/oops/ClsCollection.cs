using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace oops
{
    class ClsCollection
    {
        public void ArrayList_1()
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101);
            arrayList1.Add("Deepu");

            ArrayList arrayList2 = new ArrayList()
            {
                12,"deepu","smith",true
            };
            //How to Insert an Element into a Specified Position in an ArrayList Collection in C#?
            arrayList1.Insert(0, "First");
            //How to Remove Elements from ArrayList in C#?
            arrayList1.Remove("Deepu");
            arrayList1.RemoveAt(0);
            arrayList1.RemoveRange(0,1);
            //How to Remove all the elements from the ArrayList in C#?
            arrayList1.Clear();
            //How do we Check whether an Element exists in ArrayList or not in C#?
            arrayList1.Contains(101);
            //How to Clone the Non-Generic ArrayList Collection in C#?
            ArrayList clone = (ArrayList)arrayList1.Clone();
            //How to copy an ArrayList to an existing array in C#?
            //How to Sort the Elements of an ArrayList Collection in C#?
            arrayList1.Sort();
        }

        public void Hash_Table_1()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("EID",1001);
            hashtable.Add("Name", "Deepu");
            hashtable.Add("Salary", 50000);
            hashtable.Add("Loaction", "Delhi");

            foreach (object item in hashtable)
            {
                Console.WriteLine(item + " : "+ hashtable[item]);
            }
            //or
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine(de.Key + " : "+ de.Value);
            }
            Console.WriteLine("Location :" + hashtable["Loaction"]);
            //Example to Add Elements to a Hashtable using Collection Initializer in C#:

            Hashtable citiesHashtable = new Hashtable()
            {
               {"UK","London,Manchester,Birmingham"},
               {"USA","Chicago,New York,Washinton"},
               {"India","Mumbai,New Delhi,Pune"}
            };

            Console.WriteLine("Creating a Hashtable using Collection-Initializer");
            foreach (DictionaryEntry city in citiesHashtable)
            {
                Console.WriteLine("Key : "+city.Key +","+"Value : "+city.Value);
            }

            //How to Check the Availability of a key/value Pair in a Hashtable in C#?
            citiesHashtable.Contains("UK");
            citiesHashtable.ContainsKey("India");
            citiesHashtable.ContainsValue("Delhi");
            //How to Remove Elements from a Non-Generic Hashtable Collection in C#?
            citiesHashtable.Remove("UK");
            citiesHashtable.Clear();

            //How to Assign Values to a Hashtable with Indexer in C#?
            citiesHashtable["UK"] = "America";
            // creating hashtable collection with defaut constructor
            Hashtable hashtb = new Hashtable();
            hashtb.Add("Eid", 1001);
            hashtb.Add("Name", "Deepu");
            hashtb.Add("Location", "Delhi");

            //Printing all queuq elements using for each loop
            foreach (DictionaryEntry item in hashtb)
            {
                Console.WriteLine(item.Key +", "+item.Value);
            }
            // copying the hashtable to an object Array
            DictionaryEntry[] myArray = new DictionaryEntry[hashtb.Count];
            hashtb.CopyTo(myArray, 0);
            Console.WriteLine("\nHashtable Copy Array Elements :");
            foreach (DictionaryEntry item in myArray)
            {
                Console.WriteLine(item.Key+" ,"+item.Value);
            }
            Object[] myObjArrayKey = new Object[hashtb.Count];
            Object[] myObjArrayValue = new Object[hashtb.Count];
            Console.WriteLine("\nCoptTo Method to copy keys:");
            hashtb.Keys.CopyTo(myObjArrayKey, 0);
            foreach (var item in myObjArrayKey)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nCopyTo Method to copy Values:");
            hashtb.Values.CopyTo(myObjArrayValue, 0);
            foreach (var item in myObjArrayValue)
            {
                Console.WriteLine(item);
            }
        }

        public void Stack_1()
        {
            //Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');
            // Printing the stack items using foreach loop
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
            //How to Remove Elements from a Non-Generic Stack Collection in C#?
            stack.Pop();
            //Fetch the topmost element from stack using peek method
            Console.WriteLine(stack.Peek());
        }
        public void Queue_1()
        {
            Queue queue = new Queue();
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            queue.Enqueue('A');
            //Printing the queue items using foreach loop
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            //Remoing and Returing an item from the queue using the Deque method
            Console.WriteLine(queue.Dequeue());
            queue.Clear();
            //Fetch the topmost element from queue using peek method
            Console.WriteLine(queue.Peek());
        }
        public void SortedList_1()
        {
            //Creating sortedList collection
            SortedList sortedlist = new SortedList();
            sortedlist.Add(1, "One");
            sortedlist.Add(5, "Five");
            sortedlist.Add(4, "Four");
            sortedlist.Add(2, "Two");
            sortedlist.Add(3, "Three");
            //Duplicate key not allowed
            //sortedlist.Add(4, "Fout");
            //NUll value is allowed
            sortedlist.Add(6, null);
            //Duplicated values is allowed
            //sortedlist.Add(7, "Five");
            //In this case string key is not valid throw exception
            //sortedlist.Add("Ten", "Ten");
            //Accessing sortedList using for loop
            Console.WriteLine("Accessing SortedList using for loop");
            for (int i = 0; i < sortedlist.Count; i++)
            {
                Console.WriteLine(sortedlist.GetKey(i)+","+sortedlist.GetByIndex(i));
            }
            Console.WriteLine("\nAccessing SortedList using for each loop");
            foreach (DictionaryEntry item in sortedlist)
            {
                Console.WriteLine(item.Key +","+item.Value);
            }
            Console.WriteLine("\nAccessing SortedList using Keys");
            Console.WriteLine(sortedlist[1]);
            Console.WriteLine("\nAccessing SortedList Usin Indes");
            Console.WriteLine(sortedlist.GetByIndex(0));
            //creating sortedList using Object Initializer
            SortedList sortedList = new SortedList
            {
                {"Ind","India"},
                {"USA","United State of America"},
                {"SA","South Africa"},
                {"PAK","Pakistan"}
            };
            //Remove value having key PAK using Remove() Method
            sortedList.Remove("PAK");
            //Remove element at index 1 using RemoveAt() Method
            sortedList.RemoveAt(1);
            //Remove all key/value pairs using clear method
            sortedList.Clear();
        }
        public void Disadvantage_Of_NonGeneric_1()
        {
            ArrayList numbers = new ArrayList(3);
            //Boxing happens - Converting value type (100,200) to reference type
            // Means Interger to object type
            numbers.Add(100);
            numbers.Add(200);
            numbers.Add(300);
            //it is also possible to store string values
            numbers.Add("Hi");

            // Unboxing happens - 100 and 200,300 stored as object type
            // now converted to Integer type
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        public void ComparisonDelegateDemo()
        {
            // creating a List of type Employee
            List<Employee> listEmployee = new List<Employee>
            {
                new Employee(){ID = 101, Name = "Pranaya",Gender = "Male",Salary = 5000},
                new Employee(){ID = 102, Name ="Priyanka",Gender = "Female",Salary = 7000},
                new Employee(){ID = 103,Name = "Anurag",Gender ="Male",Salary = 5500},
                new Employee(){ID = 104,Name ="Sambit",Gender = "Male",Salary = 6500},
                new Employee(){ID = 105,Name = "Hina",Gender = "Female",Salary = 6500}
            };
            Console.WriteLine("Employees Before Sorting");
            foreach (Employee employees in listEmployee)
            {
                Console.WriteLine("ID : "+employees.ID+" Name : "+employees.Name+"  Gender : "+employees.Gender+" Salary : "+employees.Salary+"");
            }
            //create an instance of the Comparison Delegate
            Comparison<Employee> employeeComarer = new Comparison<Employee>(CompareEmployees);
            // passing Comparison Delegate as an argument to the sort method
            //listEmployee.Sort(employeeComarer);

            // Using Comparison Delegate with Anonymous Method
            //listEmployee.Sort(delegate(Employee e1, Employee e2)
            //{
            //    // sorting the employees based on name
            //    return e1.Name.CompareTo(e2.Name);
            //});
            
            //Using Lambda Expression 
            listEmployee.Sort((e1, e2) => { return e1.Name.CompareTo(e2.Name); });
            Console.WriteLine("\nEmployees After Sorting");
            foreach (Employee employees in listEmployee)
            {
                Console.WriteLine("ID : " + employees.ID + " Name : " + employees.Name + "  Gender : " + employees.Gender + " Salary : " + employees.Salary + "");
            }
        }
        private int CompareEmployees(Employee e1, Employee e2)
        {
            return e1.Name.CompareTo(e2.Name);
        }

        public void GenericDictionaryDemo()
        {
            // Creating a Dictionary with key and value both are string type
            //Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>();
            //adding Elements to the Dictionary using add methos of dictionary class
            //dictionaryCountries.Add("UK", "London,Manchester,Birmingham");
            //dictionaryCountries.Add("USA", "Chicago,New York,Washington");
            //dictionaryCountries.Add("IND", "Mumbai,Delhi,Bhubaneswar");

            //Creating a Dictionary with key and value both are string type using collection Initializer
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>
            {
                {"UK","London,Manchester,Birmingham"},
                {"USA","Chicago,New York,Washington"},
                {"IND","Mumbai,Delhi,Bhubaneswar"}
            };


            //Accessing Dictionary Elements Using For Each Loop
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string,string> KVP in dictionaryCountries)
            {
                Console.WriteLine("Key : "+KVP.Key+" Value : "+KVP.Value+"");
            }
            //Accessing Dictionary Elements usig for loop
            Console.WriteLine("\nAccessing Dictionary Elements using For loop");
            for (int i = 0; i < dictionaryCountries.Count; i++)
            {
                string key = dictionaryCountries.Keys.ElementAt(i);
                string value = dictionaryCountries[key];
                Console.WriteLine("Key : " + key + " Value : " + value + "");
            }
            //Accessing Dictionary Elements using Keys
            Console.WriteLine("\nAccessing Dictionary Elements using Keys");
            Console.WriteLine("Key : UK, Value : "+dictionaryCountries["UK"]+"");
            Console.WriteLine("Key : USA, Value : " + dictionaryCountries["USA"] + "");
            Console.WriteLine("Key : IND, Value : " + dictionaryCountries["IND"] + "");

            //Checking the key using the ContainsKey method
            Console.WriteLine("\nIs USA Key Exists : "+dictionaryCountries.ContainsKey("USA")+"");
            Console.WriteLine("\nIs PAK Key Exists : " + dictionaryCountries.ContainsKey("PAK") + "");
            //Checking the value using the ContainsValue Method
            Console.WriteLine("\nIs India Value Exists : "+dictionaryCountries.ContainsValue("India")+"");
            Console.WriteLine("\nIs Srilanka Value Exists : " + dictionaryCountries.ContainsValue("Srilanka") + "");

            //Console.WriteLine("Dictionary Elements Count Before Removing : "+dictionaryCountries.Count+"");
            //if (dictionaryCountries.ContainsKey("USA"))
            //{
            //    dictionaryCountries.Remove("USA");
            //}
            //Console.WriteLine("Dictionary Elements Count After Removing USA: " + dictionaryCountries.Count + "");

            Console.WriteLine("\nIterating Dictionary Using AsParallel().ForAll Method");
            dictionaryCountries.AsParallel().ForAll(entry =>Console.WriteLine(entry.Key +":"+entry.Value));

            Console.WriteLine("\nGeneric Dictionary Collection with Complex Type in C#:");
            Dictionary<int, Student> dictionaryStudents = new Dictionary<int, Student>
            {
                {101, new Student(){ID = 101,Name="Anurag",Branch="CSE"}},
                {102, new Student(){ID = 102,Name ="Mohanty",Branch = "CSE"}},
                {103, new Student(){ID = 103,Name = "Sambit",Branch = "ETC"}}
            };
            foreach (KeyValuePair<int,Student> item in dictionaryStudents)
            {
                Console.WriteLine("Key : "+item.Key+" ID : "+item.Value.ID+" , Name : "+item.Value.Name+", Branch : "+item.Value.Branch+"");
            }

            //convert an Array to a Dictionary
            Student[] arrayStudents = new Student[3];
            arrayStudents[0] = new Student() { ID = 101, Name = "Anurag", Branch = "CSE" };
            arrayStudents[1] = new Student() { ID = 102, Name = "Mohanty", Branch = "CSE" };
            arrayStudents[2] = new Student(){ID = 103,Name = "Sambit",Branch = "ETC"};

            Console.WriteLine("\nConvert An Array to  a Dictionary");
            Dictionary<int, Student> dicStudent = arrayStudents.ToDictionary(std => std.ID, std => std);
            // or
            Dictionary<int, Student> dicStudent2 = arrayStudents.ToDictionary(stu => stu.ID);
            // or use a foreach loop
            Dictionary<int, Student> dict = new Dictionary<int, Student>();
            foreach (Student std in arrayStudents)
            {
                dict.Add(std.ID, std);
            }
        }
        public void Conversion_between_Array_List_and()
        {
            Employee emp1 = new Employee()
            {
               ID = 101,
               Name = "Pranaya",
               Gender = "Male",
               Salary = 20000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 30000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 40000
            };
            // create an array of employees with size 3
            Employee[] arrayEmployees = new Employee[3];
            arrayEmployees[0] = emp1;
            arrayEmployees[1] = emp2;
            arrayEmployees[2] = emp3;

            //To convert an array to a list us ToList() method
            List<Employee> listEmployees = arrayEmployees.ToList();
            // To Convert a List to an array, use ToArray() methed
            Employee[] arrayAllEmployeesFromList = listEmployees.ToArray();
            //to convert a list to a dinctionary  use ToDictionary() method
            Dictionary<int, Employee> dictionaryEmployees = listEmployees.ToDictionary(employee => employee.ID, employee => employee);
            // To Convert an array to a Dictionary, use ToDictionary() method
            Dictionary<int, Employee> dictionaryEmployeeFromArray = arrayEmployees.ToDictionary(employee => employee.ID, employee => employee);
            //To Convert a dictionary to an array, use ToArray method on the values
            Employee[] arrayAllEmployeesFromDictionary = dictionaryEmployeeFromArray.Values.ToArray();
            //To convert a dictionary to a list,use to List Method on the values
            List<Employee> listAllEmployeesFromDictionary = dictionaryEmployeeFromArray.Values.ToList();
        }
        public void ListVsDictionary()
        {
            Country country1 = new Country()
            {
                Code = "AUS",
                Name = "AUSTRAILA",
                Capital = "Canberra"
            };
            Country country2 = new Country()
            {
                Code = "IND",
                Name = "INDIA",
                Capital = "New Delhi"
            };
            Country country3 = new Country()
            {
                Code = "USA",
                Name = "UNITED STATES",
                Capital = "Washington D.C."
            };
            Country country4 = new Country()
            {
                Code = "GBR",
                Name = "UNITED KINGDOM",
                Capital = "Londan"
            };
            Country country5 = new Country()
            {
                Code = "CAN",
                Name = "CANADA",
                Capital = "Ottawa"
            };
            // creat list for country
            List<Country> listCountries = new List<Country>();
            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);
            listCountries.Add(country5);
            // create Dictionary for country
            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            dictionaryCountries.Add(country1.Code, country1);
            dictionaryCountries.Add(country2.Code, country2);
            dictionaryCountries.Add(country3.Code, country3);
            dictionaryCountries.Add(country4.Code, country4);
            dictionaryCountries.Add(country5.Code, country5);
            string strUserChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter code");
                string strCountryCode = Console.ReadLine().ToUpper();
                // Find() method of the list class loops thru each object in the list until a match is found. so if we want to
                // lookup a value using a key dictionay is bettr for performance over list.
                //Country resultCountry = listCountries.Find(country =>country.Code == strCountryCode);
                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;
                if (resultCountry == null)
                {
                    Console.WriteLine("The country code you entered does not exist");
                }
                else
                {
                    Console.WriteLine("Name = " + resultCountry.Name + " Capital = " + resultCountry.Capital + "");
                }
                do
                {
                    Console.WriteLine("Do you want to continue - YES OR NO?");
                    strUserChoice = Console.ReadLine().ToUpper();

                } while (strUserChoice != "NO" && strUserChoice != "YES");
            } while (strUserChoice == "YES");
        }

        public void GenericStackCollection()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            // Adding Duplicate
            stack.Push(30);
            // As int is not a Reference type so null can not be accepted by this stack
            //stack.Push(null); Compile-Time Error

            // As the stack is integer type, so stsring values can not be accepted
            //stack.Push("Hello"); // Compile-Time Error
            
            //Removind Element from Generic Stack
            stack.Pop();
            Console.WriteLine("Generic Stack Elements");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek Element: "+stack.Peek()+"");

            // Copying the stack to an object
            int[] stackCopy = new int[stack.Count];
            stack.CopyTo(stackCopy, 0);
            Console.WriteLine("\nStack Copy Array Elements:");
            foreach (var item in stackCopy)
            {
                Console.WriteLine(item);
            }

            // Create Employee Object
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 20000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 30000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 40000
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Male",
                Salary = 40000
            };
            Employee emp5 = new Employee()
            {
                ID = 105,
                Name = "Preety",
                Gender = "Female",
                Salary = 50000
            };
            // Create a Generic Stack of Employees
            Stack<Employee> stackEmployees = new Stack<Employee>();
            // To add an item into the stack, use the Push() method.
            stackEmployees.Push(emp1);
            stackEmployees.Push(emp2);
            stackEmployees.Push(emp3);
            stackEmployees.Push(emp4);
            stackEmployees.Push(emp5);
            Console.WriteLine("Retrive Using Foreach Loop");
            foreach (Employee emp in stackEmployees)
            {
                Console.WriteLine(emp.ID +" - "+ emp.Name + " - " + emp.Gender + " - "+ emp.Salary);
                Console.WriteLine("Items left in the Stack = "+stackEmployees.Count+"");
            }
            Console.WriteLine("---------------------------------------");

        }

        public void GenericQueueCollection()
        {
            // Creating a Queue to store Integer values
            Queue<int> queue = new Queue<int>();
            // Adding Elements to the Queue using Enqueue Method
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            //Adding Duplicate
            //queue.Enqueue(30);
            // As int is not a Reference type so null can not be accepted by this queue
            //queue.Enqueue(null); Compile-Time Error
            // As the queue is integer type, so string values can not be accepted
            //queue.Enqueue("Hello"); Compile-Time Error

            //Accessing all the Elements of the Queue using For Each Loop
            Console.WriteLine("Generic Queue Elements");
            Console.WriteLine("Generic Queue Elements Count: "+queue.Count+"");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            // Returing an Element from the Queue using Peek Method
            Console.WriteLine("\nPeek Element : "+queue.Peek()+"");
            // Removing and Returning an Element from the Begining of the Stack using Dequeue method
            Console.WriteLine("\nDeleted Element: "+queue.Dequeue()+"");
            // Printing Elements After Removing the First Added Element
            Console.WriteLine("\nAll Queue Elements After Deletion: Count "+queue.Count+"");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            // Copying the queue to an object array
            int[] queueCopy = new int[queue.Count];
            queue.CopyTo(queueCopy, 0);
            Console.WriteLine("\nQueue Copy Array Elements :");
            foreach (var item in queueCopy)
            {
                Console.WriteLine(item);
            }
            // Removing All Elements from Queue using Clear Method
            queue.Clear();
            Console.WriteLine("\nAll Queue Elements Counts After Clear : Count "+queue.Count+"");

            // Create Employee Object
            Employee emp1 = new Employee()
            {
                ID =101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 200000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 300000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 400000
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Male",
                Salary = 500000
            };
            Employee emp5 = new Employee()
            {
                ID = 105,
                Name = "Preety",
                Gender = "Female",
                Salary = 600000
            };
            //Create a Generic Queue of Employees
            Queue<Employee> queueEmployees = new Queue<Employee>();
            queueEmployees.Enqueue(emp1);
            queueEmployees.Enqueue(emp2);
            queueEmployees.Enqueue(emp3);
            queueEmployees.Enqueue(emp4);
            queueEmployees.Enqueue(emp5);
            foreach (Employee emp in queueEmployees)
            {
                Console.WriteLine(emp.ID + " - " + emp.Name + " - " + emp.Gender + " - " + emp.Salary);
                Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
            }
        }

        public void GenericHashSetDemo()
        {
            //Creating HashSet
            HashSet<string> hashSetCountries = new HashSet<string>();
            // Adding Elements to HashSet using Add Method
            hashSetCountries.Add("INDIA");
            hashSetCountries.Add("USA");
            hashSetCountries.Add("UK");
            //Adding Duplicate Elements will not give compile time error
            //But duplicate elements are simply ignored and will not be added into the collection
            hashSetCountries.Add("UK");
            hashSetCountries.Add("INDIA");
            Console.WriteLine("Elements Count : "+hashSetCountries.Count+"");
            Console.WriteLine("Accessing HashSet Elements:");
            foreach (var item in hashSetCountries)
            {
                Console.WriteLine(item);
            }
            //Adding Elements to HashSet Collection using Collection Initializer in C#:
            hashSetCountries = new HashSet<string>
            {
                "INDIA",
                "USA",
                "UK"
            };
            // Removing element from HashSet using Remove() method
            hashSetCountries.Remove("UK");
            // Remove Element from HashSet Using RemoveWhere() method
            int NumberOfElementRemoved = hashSetCountries.RemoveWhere(x => x.Length > 3);
            //Remove All Elements Using Clear method
            hashSetCountries.Clear();
        }
        public void HashSet_Operations()
        {
            // Creating Hashset Collection1
            HashSet<string> hashSetCountries1 = new HashSet<string>();
            // Adding Elements to HashSet using add method
            hashSetCountries1.Add("IND");
            hashSetCountries1.Add("USA");
            hashSetCountries1.Add("UK");
            hashSetCountries1.Add("NZ");
            hashSetCountries1.Add("BAN");
            Console.WriteLine("HashSet 1 Elements");
            HashSet<string>.Enumerator em = hashSetCountries1.GetEnumerator();
            while (em.MoveNext())
            {
                string val = em.Current;
                Console.WriteLine(val);
            }
            foreach (var item in hashSetCountries1)
            {
                Console.WriteLine(item);
            }
            //creating HashSet Collection 2
            HashSet<string> hashSetCountries2 = new HashSet<string>();
            //Adding Elements to  HashSet using add method
            hashSetCountries2.Add("IND");
            hashSetCountries2.Add("SA");
            hashSetCountries2.Add("SL");
            hashSetCountries2.Add("USA");
            hashSetCountries2.Add("ZIM");
            Console.WriteLine("\nHashSet 2 Elements");
            foreach (var item in hashSetCountries2)
            {
                Console.WriteLine(item);
            }
            // Using UnionWith Method
            hashSetCountries1.UnionWith(hashSetCountries2);
            Console.WriteLine("\nHashSet 1 Elements After UnionWith");
            foreach (var item in hashSetCountries1)
            {
                Console.WriteLine(item);
            }
            // Using IntersecWith method
            hashSetCountries1.IntersectWith(hashSetCountries2);
            Console.WriteLine("\nHashSet 1 Elements After IntersetWith");
            foreach (var item in hashSetCountries1)
            {
                Console.WriteLine(item);
            }
            // Using ExceptWith Mehod
            hashSetCountries1.ExceptWith(hashSetCountries2);
            Console.WriteLine("\nHashSet 1 Elements After EXcepWith");
            foreach (var item in hashSetCountries1)
            {
                Console.WriteLine(item);
            }
            //Using SymmeticExceptWith method
            hashSetCountries1.SymmetricExceptWith(hashSetCountries2);
            Console.WriteLine("\nHashSet 1 Elements After SymmetricExceptWith");
            foreach (var item in hashSetCountries1)
            {
                Console.WriteLine(item);
            }

            HashSet<Student> hashSetStudents = new HashSet<Student>()
            {
                new Student(){ID = 101,Name = "Anurag",Branch ="CSE"},
                new Student(){ID=102,Name = "Mohanty",Branch = "ETC"}
            };
            Console.WriteLine("HashSet Students List");
            foreach (var item in hashSetStudents)
            {
                Console.WriteLine("ID: "+item.ID+" Name: "+item.Name+" Brance: "+item.Branch+"");
            }
        }
        public void IEquatable_Interface()
        {
            HashSet<Student> hashSetStudents = new HashSet<Student>()
            {
                new Student(){ ID = 101, Name ="Anurag", Branch="CSE"},
                //Adding Dupliocate Element
                new Student(){ ID = 101, Name ="Anurag", Branch="CSE"},
                new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"},
                new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}
            };
            Console.WriteLine("HashSet Students List");
            foreach (var item in hashSetStudents)
            {
                Console.WriteLine("ID: " + item.ID + " Name: " + item.Name + " Brance: " + item.Branch + "");
            }
        }
        public void GenericSortedListDemo()
        {
            //Creating Generic SortedList Collection
            SortedList<int, string> genericSortedList = new SortedList<int, string>();
            // Adding Elements to SortedList Collection using Add Method in Random order
            genericSortedList.Add(1, "One");
            genericSortedList.Add(5, "Fivw");
            genericSortedList.Add(4, "Four");
            genericSortedList.Add(2, "Two");
            genericSortedList.Add(3, "Three");
            // You cannot pass null as a key 
            //genericSortedList.Add(null, "Ten");Compile-Time error
            // Duplicate key not allowed
            Console.WriteLine("Accessing Generic SortedList using For loop");
            for (int i = 0; i < genericSortedList.Count; i++)
            {
                Console.WriteLine("Keys: "+genericSortedList.Keys[i] +"\tValues: "+genericSortedList.Values[i]+"");
            }
            //Accessing Generic SortedList collection using For Each loop
            Console.WriteLine("\nAccessing SortedList using For Each Loop");
            foreach (KeyValuePair<int,string> item in genericSortedList)
            {
                Console.WriteLine("Key: "+item.Key+" Values: "+item.Value+"");
            }
            // Creating Generic SortedList Collection using Initializer
            SortedList<int, string> genericSortedList2 = new SortedList<int, string>
            {
                {1,"One"},
                {5,"Five"},
                {4,"Four"},
                {3,"Three"},
                {2,"Two"},
            };
            // Remove value having key using Remove() Mehod
            genericSortedList2.Remove(5);
            // Remove element at index 1 using RemoveAt() method
            genericSortedList2.RemoveAt(1);
            // Remove all key/value pairs Using Clear Method
            genericSortedList2.Clear();
            //Checking the key using the ContainsKey method
            genericSortedList2.ContainsKey(2);
            //Checking the value using the ContainsValue method
            genericSortedList2.ContainsValue("Three");

            // Here we are cerating a sortedList whose key is int and value is Student
            SortedList<int, Student> genericSortedlistStudent = new SortedList<int, Student>
            {
                {101, new Student(){ID = 101,Name="Anurag",Branch = "CSE"}},
                {102, new Student(){ID = 102,Name="Rahul",Branch = "IT"}}
            };
            Console.WriteLine("Generic SortedList Students");
            foreach (KeyValuePair<int,Student> item in genericSortedlistStudent)
            {
                Console.WriteLine("Key: "+item.Key+" ID: "+item.Value.ID+" Name: "+item.Value.Name+" Branch: "+item.Value.Branch+"");
            }
        }
        public void GenericsSortedSetDemo()
        {
            // creating an Instance of Sorted class to store Integer values
            SortedSet<int> sortedSetNumbers = new SortedSet<int>();
            // Adding Elements to SortedSet using Add method
            sortedSetNumbers.Add(10);
            sortedSetNumbers.Add(5);
            sortedSetNumbers.Add(50);
            sortedSetNumbers.Add(37);
            sortedSetNumbers.Add(18);
            sortedSetNumbers.Add(37);
            // Accessing the SortedSet Elements using For Each loop
            Console.WriteLine("SortedSet Elements");
            foreach (var item in sortedSetNumbers)
            {
                Console.WriteLine(item);
            }
            //Adding Elements using Collection Initializer
            SortedSet<int> sortedSetNumbers2 = new SortedSet<int>
            {
                10,
                5,
                50,
                37,
                18,
                37
            };
            // Accessign the SortedSet Elements using Enumerator
            SortedSet<int>.Enumerator em = sortedSetNumbers2.GetEnumerator();
            while(em.MoveNext())
            {
                int val = em.Current;
                Console.WriteLine(val);
            }
            // Creating SortedSet and Adding Elements to SortedSet using collection Initializer
            //SortedSet<string> sorted
        }

        public void GenericSortedDictionaryCollection()
        {
            // Creating Generic SortedDictionary Collection with key as interger and value as string
            SortedDictionary<int, string> genericSortedDictionary = new SortedDictionary<int, string>();
            //Adding Elements 
            genericSortedDictionary.Add(1, "One");
            genericSortedDictionary.Add(2, "Two");
            genericSortedDictionary.Add(3, "Three");
            genericSortedDictionary.Add(4, "Four");
            genericSortedDictionary.Add(5, "Five");
            // Duplicat key not allowed
            //Accessing Generic SortedDictionary
            Console.WriteLine("Accessing SortedDictionary Collection using for Each loop");
            foreach (var item in genericSortedDictionary)
            {
                Console.WriteLine("Key: "+item.Key+" Value: "+item.Value+"");
            }
            //Accessing Generic SortedDictionary using For loop
            Console.WriteLine("\nAccessing SortedDictionary Collection using for loop");
            for (int i = 0; i < genericSortedDictionary.Count; i++)
            {
                KeyValuePair<int, string> element = genericSortedDictionary.ElementAt(i);
                Console.WriteLine("Key: "+element.Key+" Value: "+element.Value+"");
            }
            //Accessing SortedDictionary Collection Individual Elements using key and Indexer
            Console.WriteLine("\nAccessing SortedList Individual Elements using key as Indexer");
            Console.WriteLine("Key: 1, Value: "+genericSortedDictionary[1]+"");
            Console.WriteLine("Key: 2, Value: " + genericSortedDictionary[2] + "");
            Console.WriteLine("Key: 3, Value: " + genericSortedDictionary[5] + "");

            // Adding Elemenst using collection Initializer
            SortedDictionary<int, string> genericSortedDictionary2 = new SortedDictionary<int, string>()
            {
                {1,"one"},
                {2,"Two"},
                {3,"Three"},
                {4,"Four"},
                {5,"Five"}
            };
            //Remove value haning key 5 using Romove() Method
            genericSortedDictionary2.Remove(5);
            //Remove all key/value pairs using clear Method
            genericSortedDictionary2.Clear();

            // To get an IDictionaryEnumerator for the SortedDictionary
            IDictionaryEnumerator meyEnumerator = genericSortedDictionary.GetEnumerator();
            //if MoveNext passes the end of the collection, the enumerator is positioned
            //after the last element in the collection and MoveNext returns false.
            while (meyEnumerator.MoveNext())
            {
                Console.WriteLine("Key: "+meyEnumerator.Key+" Value: "+meyEnumerator.Value+"");
            }

            SortedDictionary<int,Student> sortedDictionaryStudent = new SortedDictionary<int,Student>()
            {
                {101, new Student(){ID = 101,Name="Anurag",Branch = "CSE"}},
                {104, new Student(){ID = 104,Name="Pranaya",Branch = "ETC"}},
                {103, new Student(){ID = 103,Name="Sambit",Branch = "CSE"}},
                {102, new Student(){ID = 102,Name="Mohanty",Branch = "CSE"}},
                {102, new Student(){ID = 102,Name="Raju",Branch = "CSE"}}
            };
            foreach (KeyValuePair<int,Student> item in sortedDictionaryStudent)
	        {
		        Console.WriteLine("Key: "+item.Key+" ID : "+item.Value.ID+" Name: "+item.Value.Name+" Branch: "+item.Value.Branch+"");
	        }
        }
        public void GenericLinkedListCollection()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("India");
            linkedList.AddLast("USA");
            linkedList.AddLast("Srilanka");
            linkedList.AddLast("UK");
            linkedList.AddLast("Japan");
            Console.WriteLine("LinkedList Elements");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            //Removind Element using Remove(LinkedListNode) Method
            //linkedList.Remove(linkedList.First);// Remove first Node
            //linkedList.Remove(linkedList.Last);// Remove Seconde node
            //linkedList.Remove(linkedList.) remove specific node
            //Removing element using RemoveFirst()
            //linkedList.RemoveFirst();
            //linkedList.RemoveLast();
            //linkedList.Clear();//remove all

            // Operations
            // Adding a node at the first position of a Linked List
            linkedList.AddFirst("New York");
            // Adding a node a the last postion of a Linked List
            linkedList.AddLast("Austarlia");
            // Add a Node After a Given Node of a Linked List
            LinkedListNode<string> RussiaNode = linkedList.AddLast("Russia");
            linkedList.AddAfter(RussiaNode, "Africa");
            // Add a node Befoer a Given node of Linked List
            linkedList.AddBefore(RussiaNode, "Africa");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            // complex type 
            Student st1 = new Student(){ID = 101,Name ="Anurag", Branch="CSE"};
            Student st2 = new Student() { ID = 102, Name = "Mohanty", Branch = "CSE" };
            Student st3 = new Student() { ID = 103, Name = "Sambit", Branch = "CSE" };
            Student st4 = new Student() { ID = 104, Name = "Pranaya", Branch = "CSE" };
            LinkedList<Student> linkedListStudent = new LinkedList<Student>();
            linkedListStudent.AddLast(st1);
            linkedListStudent.AddLast(st2);
            linkedListStudent.AddLast(st3);
            linkedListStudent.AddLast(st4);
            Console.WriteLine("LinkedList Elements");
            foreach (var item in linkedListStudent)
            {
                Console.WriteLine("Id: "+item.ID+" Name: "+item.Name+" Branch: "+item.Branch+"");
            }
        }
        //Example to Understand Thread Safety Problem with Generic 
        //Collections in C#:
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        public void ThreadSafetyProblemWithGeneric()
        {

        }
        public void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                dictionary.Add(i, "Added By Mehtod " + i);
            }
        }
    }
    class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
    class Student : IEquatable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public bool Equals(Student other)
        {
            return this.ID.Equals(other.ID);
        }
        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }
    }
}
