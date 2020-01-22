C# TRAINING ESSENTIALS PART 2
Flow Control, Arrays, Exception Handling 

A. UNIT TESTING & TEST-DRIVEN DEVELOPMENT

 - This is the foundation of Agile development.
 - In TDD, develop code in phases / features where you develop pieces of code to prove that it runs as designed.
 - Goal is to have 100% coverage, testing all exposed methods.
 - The test project must have a `reference` to the class it is testing as well as require it with `using` to be able to access all functionality.

B. ARRAYS & COLLECTION

 - **Arrays** in C# are just like arrays in other languages, a collection of items (list) of the same type - strongly typed language.
 - They are a fixed length, where items are assigned based on position.

 ![Array](./assets/arrayDeclaration.png)

 - `ref` allows you to pass in an item by reference. Usually items are passed in by value, meaning the program makes a copy of the original item and muttates the copy. Passing by reference means the original item is actually mutated. 
 - Create a constructor for a class using the shortcut: `ctor` + `Tab` + `Tab`.
 - When testing a method, the test class must include the `[TestMethod]` decorator as a flag for the program to know to run the method.
 - For multidimensional arrays, instantiate an array using the number of rows as of the first argument and the number of items (columns) per row second as such:

    - `var multi = new String[2,3];`
    - `var multi = new int[2,3];`

 - Multidimensional arrays are great for analytical purposes, serving as a spreadsheet. 
 - **Lists** are part of a generic C# class called collections.
 - When you see `<>` appear after a class / method, that means that it is a generic, and you can pass in a type of class (even one created by you).
    - `var awesomeSauces = new List<string>();`
    - `awesomeSauces.add("Cholula");`
    - No need to declare a size here because it is dynamic and changes as you add items.
 - Language Intgrated Query (**LINQ**)
    - Executed as a set of extension classes.
    - Adds functionality into an exsiting class without altering the original class code or creating a sub-class.

![LINQ](./assets/linq)

 - **Dictionaries** use a key:value pair to assign a value to a designated variable / key. The types of both the key and the value must be declared when initialized.

    - `var dictionaryWords = new Dictionary<string, string>();`

 - Keys must be unique - no duplicates are allowed!

C. FLOW CONTROL

D. EXCEPTION HANDLING

E. GETTING TO PRDUCTION
