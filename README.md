Problem 1. School classes (Tema 1 - OOP Advanced)
We are given a school. 
In the school there are classes of students. 
Each class has a set of teachers. 
Each teacher teaches, a set of disciplines. 
Students have a name and unique class number. 
Classes have unique text identifier. 
Teachers have a name. 
Disciplines have a name, number of lectures and number of exercises. 
Both teachers and students are people. 
Students, classes, teachers and disciplines could have optional comments (free text block).
Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.


Problem 2. Students and workers (Tema 1 - OOP Advanced)
Define abstract class Human with a first name and a last name. 
Define a new class Student which is derived from Human and has a new field – grade. 
Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker. 
Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.


Problem 3. Animal hierarchy (Tema 1 - OOP Advanced)
Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
Dogs, frogs and cats are Animals. 
All animals can produce sound (specified by the ISound interface). 
Kittens and tomcats are cats. All animals are described by age, name and sex. 
Kittens can be only female and tomcats can be only male. 
Each animal produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method.

Problem 4. Model in c# the following business model
Store (IStore)
Customer (IPerson)
Order (IOrder)
Producer (IProducer)
Car (IVehicle)

Inside the main method to implement the following behavior: 
Alex intended to buy a Ford Focus 2015 model. 
He walked to the FordStore in Bucuresti and agreed to buy one for 15000Euro.
They informed him it will take 4 weeks for delivery.
He then decided to visit another store SkodaStore and agreed to buy one for 14000Euro and 3 weeks delivery.
He then canceled his original order from the FordStore.
After 3 weeks, he received the model.

Problem 5. Shapes
Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).
Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.


Problem 6. Bank accounts
A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based).
Deposit accounts are allowed to deposit and withdraw money.
Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). 
In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces.
You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
 
 

