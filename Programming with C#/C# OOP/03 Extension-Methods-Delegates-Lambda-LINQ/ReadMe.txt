01 Substring task -> task 1
02 IEnum task -> task 2
03 Students task -> tasks 3, 4, 5
04 Numbers task -> task 6
05 Delegate task -> task 7
07 Students task -> tasks 9 - 19

exercises:
01 Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
02 Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
03 Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.
04 Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
05 Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.
06 Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
07 Using delegates write a class Timer that can execute certain method at each t seconds.
08* Read in MSDN about the keyword event in C# and how to publish events. Re-implement the above using .NET events and following the best practices.
09 Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. Create a List<Student> with sample students. Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.
10 Implement the previous using the same query expressed with extension methods.
11 Extract all students that have email in abv.bg. Use string methods and LINQ.
12 Extract all students with phones in Sofia. Use LINQ.
13 Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties � FullName and Marks. Use LINQ.
14 Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.
15 Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
16* Create a class Group with properties GroupNumber and DepartmentName. Introduce a property Group in the Student class. Extract all students from "Mathematics" department. Use the Join operator.
17 Write a program to return the string with maximum length from an array of strings. Use LINQ.
18 Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.
19 Rewrite the previous using extension methods.
20* By using delegates develop an universal static method to calculate the sum of infinite convergent series with given precision depending on a function of its term. By using proper functions for the term calculate with a 2-digit precision the sum of the infinite series:
	1 + 1/2 + 1/4 + 1/8 + 1/16 + �
	1 + 1/2! + 1/3! + 1/4! + 1/5! + �
	1 + 1/2 - 1/4 + 1/8 - 1/16 + � 
