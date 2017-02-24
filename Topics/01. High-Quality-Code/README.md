<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# What Is High-Quality Programming Code?
## Code Correctness, Readability, Maintainability  

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic02.png" style="top:-1%; left:87%; width:12.09%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic03.png" style="top:55%; left:68%; width:32.37%; z-index:-1" /> -->  

<div class="signature">
	<p class="signature-course">High-Quality Code</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="http://telerikacademy.com/ " class="signature-link">http://telerikacademy.com/</a>
</div>




<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [Why Quality Is Important](#qualityimportance)?
- [Software Quality: External and Internal](#softwarequality)
- [What is High-Quality Code?](#whatishqc)
- [Code Conventions](#conventions)
- [Managing Complexity](#complexity)
- [Characteristics of Quality Code](#characteristics)

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic04.png" style="top:44.96%; left:75.79%; width:28.21%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # What is High-Quality Programming Code? -->

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:55%; left:54%; width:30%; z-index:-1; border: 1px solid white; border-radius:5px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:55%; left:15%; width:30%; z-index:-1; border: 1px solid white; border-radius:5px;" /> -->


<!-- attr: {id:'qualityimportance', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="recommendedbooks"></a> Why Quality Is Important?
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

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:14.52%; left:92.19%; width:14.99%; z-index:2; border: 1px solid white; border-radius:5px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

<!-- # Why Quality Is Important? -->
- Now the code is formatted, but still unclear.

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



<!-- attr: { id:'softwarequality', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="softwarequality"></a> Software Quality
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

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:16.75%; left:86%; width:18.51%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:61.71%; left:86%; width:19.86%; z-index:-1; border: 1px solid white; border-radius:5px;" /> -->


<!-- attr: { id:'whatishqc', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="whatishqc"></a> What is High-Quality Programming Code?
- **High-quality programming code:**
  - Easy to read and understand
    - Easy to modify and maintain
  - Correct behavior in all cases
    - Well tested
  - Well architectured and designed
  - Well documented
    - Self-documenting code
  - Well formatted   

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:24.68%; left:76%; width:25%; z-index:-1; border: 1px solid white; border-radius:5px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic12.png" style="top:54.66%; left:76%; width:25%; z-index:-1; border: 1px solid white; border-radius:5px;" /> -->


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
<!-- # Code Conventions -->

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic13.png" style="top:38.79%; left:14.03%; width:28.21%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic14.png" style="top:38.91%; left:69.24%; width:28.21%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:50.25%; left:46.78%; width:14.10%; z-index:-1" /> -->


<!-- attr: { id:'conventions', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="conventions"></a> Code Conventions
- **Code conventions** are formal guidelines about the style of the source code:
  - Code formatting conventions
    - Indentation, whitespace, etc.
  - Naming conventions
    - **PascalCase** or **camelCase**, prefixes, suffixes, etc.
  - Best practices
    - Classes, interfaces, enumerations, structures, inheritance, exceptions, properties, events, constructors, fields, operators, etc.  

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:18%; left:70%; width:25%; z-index:-1" /> -->


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
<!-- # Managing Complexity  -->

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:40%; left:75%; width:25%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:45%; left:15%; width:15%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic19.png" style="top:40%; left:30%; width:36%; z-index:-1" /> -->


<!-- attr: { id:'complexity', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="complexity"></a>Managing Complexity
- **Managing complexity** has central role in software development
  - Minimize the amount of complexity that anyone’s brain has to deal with at a certain time
- Architecture and design challenges
  - Design modules and classes to reduce complexity
- Code construction challenges
  - Apply good software construction practices: classes, methods, variables, naming, statements, error handling, formatting, comments, etc.


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Extras
- Key to being an effective programmer:
  - Maximizing the portion of a program that you can **safely ignore**
    - While working on any one section of code
  - Most practices discussed later propose ways to achieve this important goal




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Code Quality: Characteristics -->

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic21.png" style="top:11.46%; left:19.59%; width:68.86%; z-index:-1; opacity:0.6;" /> -->


<!-- attr: { id:'characteristics', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="characteristics"></a> Key Characteristics of HQC - 1
- **Correct behavior**
  - Conforming to the requirements
  - Stable, no hangs, no crashes
  - Bug free – works as expected
  - Correct response to incorrect usage
- **Readable** – easy to read
- **Understandable** – self-documenting
- **Maintainable** – easy to modify when required  

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic22.png" style="top:16%; left:84%; width:19.39%; z-index:-1" /> -->



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Key Characteristics of HQC - 2
- Good **identifiers' names**
  - Good names for variables, constants, methods, parameters, classes, structures, fields, properties, interfaces, structures, enumerations, namespaces,
- High-quality **classes**, interfaces and class hierarchies
  - Good abstraction and encapsulation
  - Simplicity, reusability, minimal complexity
  - Strong cohesion, loose coupling


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Key Characteristics of HQC - 3
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
# Key Characteristics of HQC - 4
- Correctly used **control structures**
  - Simple statements
  - Simple conditional statements and simple conditions
  - Well organized loops without deep nesting
- Good code **formatting**
  - Reflecting the logical structure of the program
  - Good formatting of classes, methods, blocks, whitespace, long lines, alignment, etc.  

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic25.png" style="top:16.75%; left:80.47%; width:24.89%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Key Characteristics of HQC - 5
- High-quality **documentation** and comments
  - Effective comments
  - Self-documenting code
- **Defensive programming** and exceptions
  - Ubiquitous use of defensive programming
  - Well organized exception handling
- Code tuning and **optimization**
  - Quality code instead of good performance
  - Code performance when required  

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic26.png" style="top:21.54%; left:79.53%; width:25.56%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic27.png" style="top:49.37%; left:87.02%; width:17.63%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Key Characteristics of HQC - 6
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


<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Questions? -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - [High Quality Code - Part 1](http://academy.telerik.com/student-courses/programming/high-quality-code-part-1/about)
  - Telerik Software Academy
    - [telerikacademy.com](https://telerikacademy.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Software Academy Forums
    - [forums.academy.telerik.com](forums.academy.telerik.com)