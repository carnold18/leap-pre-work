C# TRAINING ESSENTIALS PART 2
Flow Control, Arrays, Exception Handling 

A. UNIT TESTING & TEST-DRIVEN DEVELOPMENT

 - This is the foundation of Agile development.
 - In TDD, develop code in phases / features where you develop pieces of code to prove that it runs as designed.
 - Goal is to have 100% coverage, testing all exposed methods.
 - The test project must have a `reference` to the class it is testing as well as require it with `using` to be able to access all functionality.

B. ARRAYS & COLLECTION

 - Arrays in C# are just like arrays in other languages, a collection of items (list) of the same type - strongly typed language.
 - They are a fixed length, where items are assigned based on position.

 ![Array](https://github.com/carnold18/leap-pre-work/tree/master/C%23%20Essentials%20Part%202/assets/arrayDeclaration.png)

 - `ref` allows you to pass in an item by reference. Usually items are passed in by value, meaning the program makes a copy of the original item and muttates the copy. Passing by reference means the original item is actually mutated. 
 - Create a constructor for a class using the shortcut: `ctor` + `Tab` + `Tab`.
 - When testing a method, the test class must include the `[TestMethod]` decorator as a flag for the program to know to run the method.
 - 

C. FLOW CONTROL

D. EXCEPTION HANDLING

E. GETTING TO PRDUCTION
