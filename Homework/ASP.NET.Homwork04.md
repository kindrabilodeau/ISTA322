## Kindra Bilodeau
#### ASP.NET Homework 4

1. **Using automatic properties is a shortcut that avoids several explicit steps. List the steps that the use
of automatic properties avoids.**
  - allows you to define the property without having to implement the get and set body
2. **Using the object initializer syntax is a shortcut that avoids several explicit steps. List the steps that
the use of object initializers avoids.**
  -  allows the value to set without using a constructor
3. **What is the purpose of creating extension methods?**
  - allows you to add methods to classes that you can't modify
4. **What is the one feature of extension methods that will always allow you to identify a method as an
extension method?**
  - this keyword in front of the first parameter
5. **How do you create an extension method that filters the results returned by the method on a user
specified criterion?**
  - using the yield keyword and using IEnumerable
6. **Explain the syntax of a lambda expression. The term “lambda expression” originates in the lambda
calculus developed by the mathematician Alonzo Church in the 1930’s. There is a class of programming
languages that are based on the fundamental ideas of lambda calculus.**
  - You put input parameters on the left and the expression the right
7. **This will require some outside research. What is the distinction between an anonmously typed variable
and a dynamically typed variable?**
  - anonymous types is a complier generated type
  - dynamic takes places at runtime
8. **You are having a discussion about C# with a friend of yours that uses another language. You are
tellig him about C#’s LINQ library. How would you describe to him the difference between LINQ’s
SQL-like notation and LINQ’s dot notation?**
  - dot notation is more concise but doing multiple joins is harder
  its easier to do joins with sql notation but you don't have as operations. 
9. **What, exactly, does the await keyword do?**
  - to call the asynchronus method. Tells complier to wait for the result of the task that getasync method returns
10. **What is the connection between await and the async keywords?**
  - aysnc Tells complier to wait for the result of the task that getasync method returns and executes the other statments in the same method
