## Kindra Bilodeau
#### ASP.NET Homework 5

1. **What is a view engine?**
  - Used to produce content sent to clients
2. **What is Razor?**
  - The default view engine, that incorporates data into HTML documents  
3. **What do views do? List two specific things in your answer to this question.**
  - Views exist to express one or more parts of the mode to the user
  - Views format data
4. **How does Razor respond when it encounters statements that begin with the at character (@)? Be
specific.**
  - tells it to code
5. **How does Razor respond when it encounters statements that begin with the at character followed by
the colon (@:)? Be specific.**
  - tell razor not to code
6. **Describe how you implement a standard formatting for all pages in an ASP.NET application.**
  - With a view
7. **What is the difference in using Razor to interpolate data values as stand-alone HTML elements and
as attributes to HTML elements. What is the similarity?**
  -
8. **What is a view start file and where is it located?**
  - It allows you to make updates to layout in one place verses having to find each view that uses it.
  - it lives in the View folder
9. **What is a Razor code block? What is the syntax of a Razor code block?**
  - It allows you use C# in a view.
  - It's opened and closed with a @ { }
10. **Describe the different roles of action methods and views.**
  - Action Methods - pass a view model object to the view
  - Views - use the view model object to present content to the user
11. **Describe the use of the @using statement. Give an example of how you would use it.**
  - The name space that should be searched for int the view
