<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# High-Quality Methods
## How to Design and Implement High-Quality Methods? Understanding Cohesion and Coupling
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic00.png" style="top:12.54%; left:5.61%; width:17.08%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic01.png" style="top:2.75%; left:32.75%; width:70.52%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic02.png" style="top:50.78%; left:50.53%; width:53.77%; z-index:-1" /> -->
<div class="signature">
	<p class="signature-course">- High-Quality Code</p>
	<p class="signature-initiative">- Telerik Software Academy</p>
	<a href="- http://academy.telerik.com " class="signature-link">- http://academy.telerik.com </a>
</div>




<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- Why Do We Need Methods?
- Strong Cohesion
- Loose Coupling
- Methods Parameters
- Pseudo Code
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic03.png" style="top:20.72%; left:66.43%; width:38.24%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic04.png" style="top:51.13%; left:28.07%; width:30.81%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Why Do WeNeed Methods?
- start:
-   mov ah,08
-   int 21h
-   mov bl,al
-  JMP output
-   mov ah,01
-   int 21h
- output:
-   mov dl,"("
-   mov ah,02
-   int 21h
-   mov dl,bl
-   int 21h
-   mov dl,")"
-   int 21h
- exit:
-   mov ah,4ch
-   mov al,00
-   int 21h
- Jump
- Imagine a long program consisting of instructions and jumps not organized in any structural way  
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic05.png" style="top:46.72%; left:53.33%; width:39.88%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Why We Need Methods?
- **Methods** (functions, routines) are important in software development
  - **Reduce complexity**
    - Divide and conquer: complex problems are split into composition of several simple
  - **Improve code readability**
    - Small methods with good method names make the code self-documenting
  - **Avoid duplicating code**
    - Duplicating code is hard to maintain


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- **Methods** simplify software development
  - **Hide implementation details**
    - Complex logic is encapsulated and hidden behind a simple interface
    - Algorithms and data structures are hidden and can be transparently replaced later
  - **Increase the level of abstraction**
    - Methods address the business problem, not the technical implementation:


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Using Methods: Fundamentals
- Fundamental principle of correct method usage:
- Methods should do exactly **what their names say**
  - Nothing less (work in all possible scenarios)
  - Nothing more (no side effects)
- In case of incorrect input or incorrect preconditions, an **error** should be indicated


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Bad Methods – _Example_s
<div class="fragment balloon" style="top:10.53%; left:52.46%; width:37.91%">What will happen if we sum **2,000,000,000** + **2,000,000,000**?</div>
<div class="fragment balloon" style="top:41.63%; left:44.08%; width:31.74%">What will happen if **a** **=** **b** **=** **c** **=** **-1**?</div>
<div class="fragment balloon" style="top:30.37%; left:62.53%; width:34.44%">Result: **-294967296**</div>
<div class="fragment balloon" style="top:69.87%; left:34.22%; width:64.35%">The same result as when **a** **=** **b** **=** **c** **=** **1** &rarr; both triangles have the same size.</div>
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic06.png" style="top:14.45%; left:99.81%; width:9.14%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic07.png" style="top:49.37%; left:99.78%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Good Methods – _Example_s
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic08.png" style="top:38.10%; left:99.38%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic09.png" style="top:7.35%; left:99.38%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Indicating an Error
- Some methods do not correctly indicate errors
- If the property name does not exist
  - A null reference exception will be thrown (implicitly) &rarr; it is not meaningful
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic10.png" style="top:21.49%; left:96.89%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Use the correct exception handling instead:
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic11.png" style="top:20.28%; left:95.92%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Symptoms of Wrong Methods
- Method that does something different than its name is wrong for at least one of these reasons:
  - The method sometimes returns incorrect result &rarr; **bug**
  - The method returns incorrect output when its input is incorrect or unusual &rarr; **low** **quality**
    - Could be acceptable for private methods only
  - The method does too many things &rarr; **bad** **cohesion**
  - The method has side effects &rarr; **spaghetti** **code**
  - Method returns strange value when an error condition happens &rarr; **it should indicate the error**


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Wrong Methods – _Example_s
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic12.png" style="top:7.90%; left:100.62%; width:9.14%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic13.png" style="top:42.59%; left:100.52%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Strong Cohesion
- Methods should have **strong cohesion**
  - Should address single task and address it well
  - Should have clear intent
- Methods that  address several tasks in the same time are hard to be named
- Strong cohesion is used in engineering
  - In computer hardware any PC component solves a single task
  - E.g. hard disk performs a single task – storage


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Acceptable Types of Cohesion
- **Functional cohesion** (independent function)
  - Method performs certain well-defined calculation and returns a single result
  - The entire input is passed through parameters and the entire output is returned as result
  - No external dependencies or side effects
  - _Example_s:
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic14.png" style="top:56.87%; left:97.31%; width:4.80%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic15.png" style="top:61.86%; left:97.62%; width:4.80%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic16.png" style="top:67.15%; left:97.62%; width:4.80%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- **Sequential cohesion** (algorithm)
  - Method performs certain sequence of operations to perform a single task and achieve certain result
    - It encapsulates an algorithm
  - _Example_:
    - Connect to mail server
    - Send message headers
    - Send message body
    - Disconnect from the server
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic17.png" style="top:41.33%; left:96.86%; width:6.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- **Communicational cohesion** (common data)
  - A set of operations used to process certain data and produce a result
  - _Example_:
    - Retrieve input data from database
    - Perform internal calculations over retrieved data
    - Build the report
    - Format the report as Excel worksheet
    - Display the Excel worksheet on the screen
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic18.png" style="top:35.72%; left:95.69%; width:5.86%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- **Temporal cohesion**(time related activities)
  - Operations that are generally not related but need to happen in a certain moment
  - _Example_s:
    - Load user settings
    - Check for updates
    - Load all invoices from the database
    - Sequence of actions to handle the event
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic19.png" style="top:35.34%; left:96.65%; width:6.52%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic20.png" style="top:61.58%; left:96.65%; width:6.52%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Unacceptable Cohesion
- Logical cohesion
  - Performs a different operation depending on an input parameter
  - Incorrect example:
  - Can be acceptable in event handlers (e.g. the **KeyDown** event in Windows Forms)
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic21.png" style="top:35.26%; left:94.50%; width:7.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Unacceptable Cohesion
- Coincidental cohesion (spaghetti)
  - Not related (random) operations are grouped in a method for unclear reason
  - Incorrect example:
    - Prepares annual incomes report for given customer
    - Sorts an array of integers in increasing order
    - Calculates the square root of given number
    - Converts given MP3 file into WMA format
    - Sends email to given customer
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic22.png" style="top:34.10%; left:94.78%; width:7.05%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Loose Coupling
- What is **loose coupling**?
  - Minimal dependences of the method on the other parts of the source code
  - Minimal dependences on the class members or external classes and their members
  - No side effects
  - If the coupling is loose, we can easily reuse a method or group of methods in a new project
- Tight coupling &rarr; spaghetti code


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- The ideal coupling
  - A methods depends only on its parameters
  - Does not have any other input or output
  - _Example_: **Math.Sqrt()**
- Real world
  - Complex software cannot avoid coupling but could make it as loose as possible
  - _Example_: complex encryption algorithm performs initialization, encryption, finalization


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Coupling – _Example_
- Intentionally increased coupling for more flexibility (.NET cryptography API):
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic23.png" style="top:64.08%; left:93.30%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Loose Coupling – _Example_
- To reduce coupling we can make **utility classes**
  - Hide the complex logic and provide simple straightforward interface (a.k.a. **façade**):
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic24.png" style="top:63.36%; left:93.33%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Tight Coupling – _Example_
- Passing parameters through class fields
  - Typical example of tight coupling
  - Don't do this unless you have a good reason!
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic25.png" style="top:28.39%; left:96.78%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Tight Coupling in Real Code
- Say, we have a large piece of software
  - We need to update subsystems and the subsystems are not really independent
  - E.g. a change in filtering affects sorting, etc:
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic26.png" style="top:40.67%; left:95.86%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Cohesion Problems in Real Code
- Say, we have an application consisting of two layers: 
- Do not use a method for both top-down and bottom-up updates!
  - Both updates are essentially different, e.g. a **RemoveCustomer()** method in the **DataLayer**

```cs
Data Layer
```


```cs
Presentation Layer
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Loose Coupling and OOP
- Reducing coupling with OOP techniques
  - **Abstraction**
    - Define a public interface and hide the implementation details
  - **Encapsulation**
    - Make methods and fields private unless they are definitely needed
    - Define new members as private
    - Increase visibility as soon as this is needed


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Acceptable Coupling
- Method is coupled to its **parameters**
  - This is the best type of coupling
- Method in a class is coupled to some **class fields**
  - This coupling is usual, do not worry too much
- Method in a class is coupled to **static** methods, properties or constants in **external class**
  - This is normal, usually is not a problem
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic27.png" style="top:19.81%; left:98.69%; width:6.64%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic28.png" style="top:39.35%; left:98.69%; width:6.64%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic29.png" style="top:66.62%; left:98.69%; width:6.64%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Non-Acceptable Coupling
- Method in a class is coupled to **static fields**in external class
  - Use private fields and public properties
- Methods take as input data some fields that could be passed as parameters
  - Check the intent of the method
  - Is it designed to process internal class data or is utility method?
- Method is defined public without being part of the public class's interface &rarr; possible coupling


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Methods Parameters
- Put most important parameters first
  - Put the main input parameters first
  - Put non-important optional parameters last
  - _Example_:
  - Incorrect example:
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic30.png" style="top:38.38%; left:99.38%; width:6.64%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic31.png" style="top:60.50%; left:100.88%; width:5.44%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic32.png" style="top:71.07%; left:100.88%; width:5.44%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Do not modify the input parameters
  - Use new variable instead
  - Incorrect example:
  - Correct example:
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic33.png" style="top:28.07%; left:97.83%; width:7.97%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic34.png" style="top:55.05%; left:97.27%; width:7.97%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Use parameters consistently
  - Use the same names and the same order in all methods
  - Incorrect example:
  - Output parameters should be put last
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic35.png" style="top:59.34%; left:101.40%; width:6.17%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic36.png" style="top:41.56%; left:101.40%; width:6.17%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Pass Entire Object or Its Fields?
- When should we pass an object containing few values and when these values separately?
  - Sometime we pass an object and use only a single field of it. Is this a good practice?
  - _Example_s:
  - Look at the method's level of abstraction
    - Is it intended to operate with employees of with rates and months? &rarr; the first is incorrect


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# How Much Parameters Methods Should Have?
- Limit the number of parameters to **7 (+/-2)**
  - 7 is a "magic" number in psychology
  - Human brain cannot process more than 7 (+/-2) things in the same time
- If the parameters need to be too many, reconsider the method's intent
  - Does it have a clear intent?
  - Consider extracting few of the parameters in a new class


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Methods Length
- How long should a method be?
  - There is no specific restriction
  - Avoid methods longer than **one screen**(30 lines)
  - Long methods are not always bad
    - Be sure you have a good reason for their length
  - **Cohesion**and**coupling**are more important than the method length!
  - Long methods often contain portions that could be extracted as separate methods with good name and clear intent &rarr; check this!


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Pseudocode
- **Pseudocode** can be helpful in:
  - Routines design
  - Routines coding
  - Code verification
  - Cleaning up unreachable 			 branches in a routine
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic37.png" style="top:33.16%; left:61.40%; width:43.87%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Designing in Pseudocode
- What the routine will abstract  i.e. the information a routine will **hide**?
- Routine input parameters
- Routine output
- Preconditions
  - Conditions that have to be true before a routine is called
- Postconditions
  - Conditions that have to be true after routine execution


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Design Before Coding
- Why it is better to spend time on design before you start coding?
  - The functionality may be already available in a library, **so you do not need to code at all!**
  - You need to think of the best way to implement the task considering your project requirements
  - If you fail on writing the code right the first time, you need to know that **programmers get emotional to their code**


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Pseudocode _Example_

```cs
Routine that evaluates an aggregate expression for a database column (e.g. Sum, Avg, Min)
Parameters: Column Name, Expression
Preconditions:
Check whether the column exists and throw an argument exception if not 
If  the expression parser cannot parse the expression throw an ExpressionParsingException
Routine code: Call the evaluate method on the DataView class and return the resulting value as string
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Public Routines in Libraries
- Public routines in libraries and system software is hard to change
  - Because customers want **no breaking changes**
- Two reasons why you need to change a public routine:
  - New functionality has to be added conflicting with the old features
  - The name is confusing and makes the usage of the library unintuitive
- Design better upfront, or refactor carefully


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Method Deprecation
- **Deprecated** method
  - About to be removed in future versions
- When deprecating an old method
  - Include that in the documentation
  - **Specify the new routine that has to be used**
- Use the **[Obsolete]** attribute in .NET


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Inline Routines
- **Inline** routines provide two benefits:
  - Abstraction
  - Performance benefit of not creating a new routine on the stack
- Some applications (e.g. **games**) need that optimization
  - Used for the most frequently used routines
  - _Example_: a short routine called 100,000 times
- Not all languages support Inline routines


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Conclusion
- Designing and coding routines is engineering activity
  - There is no perfect solution
- Competing solutions usually demonstrate different trade-offs
  - The challenge of the programmer is to
    - Evaluate the requirements
    - Choose the most appropriate solution from the available options
    - Ensure loose coupling / strong cohesion


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# High-Quality Methods

```cs
http://academy.telerik.com
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - csharpfundamentals.telerik.com
  - Telerik Software Academy
    - academy.telerik.com
  - Telerik Academy @ Facebook
    - facebook.com/TelerikAcademy
  - Telerik Software Academy Forums
    - forums.academy.telerik.com
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic38.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic39.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic40.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic41.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1" /> -->




