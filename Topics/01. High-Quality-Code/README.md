<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# What Is High-Quality Programming Code?
## Code Correctness, Readability, Maintainability
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic00.png" style="top:51.34%; left:52.40%; width:53.42%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic01.png" style="top:14.43%; left:6.55%; width:17.08%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic02.png" style="top:4.71%; left:92.63%; width:12.09%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic03.png" style="top:50.80%; left:66.06%; width:32.37%; z-index:-1" /> -->
<div class="signature">
	<p class="signature-course">- High-Quality Code</p>
	<p class="signature-initiative">- Telerik Software Academy</p>
	<a href="- http://academy.telerik.com " class="signature-link">- http://academy.telerik.com </a>
</div>




<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- Why Quality Is Important?
- Software Quality: External and Internal
- What is High-Quality Code?
- Code Conventions
- Managing Complexity
- Characteristics of Quality Code
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic04.png" style="top:44.96%; left:75.79%; width:28.21%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# What is High-Quality Programming Code?
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:45.84%; left:61.75%; width:39.52%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:45.84%; left:8.42%; width:39.67%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Why Quality Is Important?
- What does this code do? Is it correct?

```cs
static void Main()
{
  int value=010, i=5, w;
  switch(value){case 10:w=5;Console.WriteLine(w);break;case 9:i=0;break;
          case 8:Console.WriteLine("8 ");break;
     default:Console.WriteLine("def ");{
	        Console.WriteLine("hoho ");	}
     for (int k = 0; k < i; k++, Console.WriteLine(k - 'f'));break;} { Console.WriteLine("loop!"); }
}
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:14.52%; left:92.19%; width:14.99%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Now the code is formatted, but is still unclear.

```cs
static void Main()
{
  int value = 010, i = 5, w;
  switch (value)
  {
    case 10: w = 5; Console.WriteLine(w); break;
    case 9: i = 0; break;
    case 8: Console.WriteLine("8 "); break;
    default:
      Console.WriteLine("def ");
      Console.WriteLine("hoho ");
      for (int k = 0; k < i; k++,
       Console.WriteLine(k - 'f')) ; 
      break;
    }
    Console.WriteLine("loop!");
}
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic08.png" style="top:10.58%; left:79.93%; width:26.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Software Quality
- **External quality**
  - Does the software behave correctly?
  - Are the produced results correct?
  - Does the software run fast?
  - Is the software UI easy-to-use?
  - Is the code secure enough?
- **Internal quality**
  - Is the code easy to read and understand?
  - Is the code well structured?
  - Is the code easy to modify?
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:16.75%; left:87.95%; width:18.51%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:61.71%; left:86.52%; width:19.86%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# What is High-Quality Programming Code?
- **High-quality programming code:**
  - Easy to read and understand
    - Easy to modify and maintain
  - Correct behavior in all cases
    - Well tested
  - Well architectured and designed
  - Well documented
    - Self-documenting code 
  - Well formatted
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:24.68%; left:77.80%; width:27.19%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic12.png" style="top:54.66%; left:80.02%; width:25.56%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- **High-quality programming code**:
  - Strong cohesion at all levels: modules, classes, methods, etc.
    - Single unit is responsible for single task
  - Loose coupling between modules, classes, methods, etc.
    - Units are independent one of another
  - Good formatting
  - Good names for classes, methods, variables, etc.
  - Self-documenting code style




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Code Conventions
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic13.png" style="top:38.79%; left:14.03%; width:28.21%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic14.png" style="top:38.91%; left:69.24%; width:28.21%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:50.25%; left:46.78%; width:14.10%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Code Conventions
- **Code conventions** are formal guidelines about the style of the source code:
  - Code formatting conventions
    - Indentation, whitespace, etc.
  - Naming conventions
    - **PascalCase** or **camelCase**, prefixes, suffixes, etc.
  - Best practices
    - Classes, interfaces, enumerations, structures, inheritance, exceptions, properties, events, constructors, fields, operators, etc.
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:19.39%; left:75.19%; width:28.77%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Microsoft has official **C#** code conventions
  - Design Guidelines for Developing Class Libraries: http://msdn.microsoft.com/en-us/library/ms229042.aspx
- Semi-official **JavaScript** code conventions
  - http://javascript.crockford.com/code.html, http://google-styleguide.googlecode.com/svn/trunk/javascriptguide.xml
- Large organization follow strict conventions
  - Code conventions can vary in different teams
- High-quality code goes **beyond code conventions**
  - Software quality is a way of thinking!




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Managing Complexity
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:13.06%; left:70.17%; width:31.74%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:14.00%; left:10.29%; width:28.35%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic19.png" style="top:12.34%; left:29.01%; width:45.84%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Managing Complexity
- **Managing complexity**has central role in software construction
  - Minimize the amount of complexity that anyone’s brain has to deal with at certain time 
- Architecture and design challenges
  - Design modules and classes to reduce complexity
- Code construction challenges
  - Apply good software construction practices: classes, methods, variables, naming, statements, error handling, formatting, comments, etc.


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Key to being an effective programmer:
  - Maximizing the portion of a program that you can **safely ignore**
    - While working on any one section of code
  - Most practices discussed later propose ways to achieve this important goal
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic20.png" style="top:53.77%; left:10.29%; width:85.51%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Code Quality: Characteristics
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic21.png" style="top:11.46%; left:19.59%; width:68.86%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Key Characteristics of High-Quality Code
- **Correct behavior**
  - Conforming to the requirements
  - Stable, no hangs, no crashes
  - Bug free – works as expected
  - Correct response to incorrect usage
- **Readable** – easy to read
- **Understandable** – self-documenting
- **Maintainable** – easy to modify when required
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic22.png" style="top:17.28%; left:86.08%; width:19.39%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic23.png" style="top:41.02%; left:87.02%; width:17.63%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Good **identifiers' names**
  - Good names for variables, constants, methods, parameters, classes, structures, fields, properties, interfaces, structures, enumerations, namespaces, 
- High-quality **classes**, interfaces and class hierarchies
  - Good abstraction and encapsulation
  - Simplicity, reusability, minimal complexity
  - Strong cohesion, loose coupling


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- High-quality **methods**
  - Reduced complexity, improved readability
  - Good method names and parameter names
  - Strong cohesion, loose coupling
- **Variables**, **data**, **expressions** and **constants**
  - Minimal variable scope, span, live time
  - Simple expressions
  - Correctly used constants
  - Correctly organized data
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic24.png" style="top:57.30%; left:78.60%; width:25.56%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Correctly used **control structures**
  - Simple statements
  - Simple conditional statements and simple conditions
  - Well organized loops without deep nesting
- Good code **formatting**
  - Reflecting the logical structure of the program
  - Good formatting of classes, methods, blocks, whitespace, long lines, alignment, etc.
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic25.png" style="top:16.75%; left:80.47%; width:24.89%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- High-quality **documentation** and comments
  - Effective comments
  - Self-documenting code
- **Defensive programming**and exceptions
  - Ubiquitous use of defensive programming
  - Well organized exception handling
- Code tuning and **optimization**
  - Quality code instead of good performance
  - Code performance when required
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic26.png" style="top:21.54%; left:79.53%; width:25.56%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic27.png" style="top:49.37%; left:87.02%; width:17.63%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Following the corporate **code conventions**
  - Formatting and style, naming, etc.
  - Domain-specific best practices
- Well **tested** and **reviewed**
  - Testable code
  - Well designed **unit tests**
    - Tests for all scenarios
    - High code coverage
  - Passed code reviews and inspections
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic28.png" style="top:31.74%; left:82.34%; width:21.16%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# What Is High-Quality Programming Code?
- Questions?


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
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic29.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic30.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic31.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic32.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1" /> -->




