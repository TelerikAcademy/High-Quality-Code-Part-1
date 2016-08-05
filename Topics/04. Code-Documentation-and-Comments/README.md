<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Code Documentation and Comments in the Program
## Revealing the Secrets of Self-Documenting Code
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic00.png" style="top:3.15%; left:83.27%; width:17.08%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic01.png" style="top:52.66%; left:62.69%; width:38.79%; z-index:-1" /> -->
<div class="signature">
	<p class="signature-course">- High-Quality Code</p>
	<p class="signature-initiative">- Telerik Software Academy</p>
	<a href="- http://academy.telerik.com " class="signature-link">- http://academy.telerik.com </a>
</div>




<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- The Concept of Self-Documenting Code
- Bad Comments 
- Good Programming Style 
- To Comment or Not to				 Comment?
- Key Points commenting
- Recommended practices
- C# XML DocumentationComments
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic02.png" style="top:28.21%; left:72.05%; width:35.40%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Comments and Code Documentation
## The Concept of Self-Documenting Code
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic03.png" style="top:12.34%; left:32.05%; width:44.96%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# What is Project Documentation?
- Consists of documents and information
  - Both inside the source-code and outside
- **External documentation**
  - At a higher level compared to the code
  - Problem definition, requirements, architecture, design, project plans, test plans. etc.
- **Internal documentation**
  - Lower-level – explains a class,method or a piece of code
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic04.png" style="top:52.51%; left:81.94%; width:22.42%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Programming Style
- Main contributor to code-level documentation
  - The program structure
  - Straight-forward, easy-to-read and easily understandable code
  - Good naming approach
  - Clear layout and formatting
  - Clear abstractions
  - Minimized complexity
  - Loose coupling and strong cohesion
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic05.png" style="top:37.91%; left:71.11%; width:32.62%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Bad Comments – _Example_
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic06.png" style="top:13.96%; left:90.81%; width:15.82%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic07.png" style="top:13.22%; left:87.02%; width:15.82%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Self-Documenting Code – _Example_

```cs
public static List<int> FindPrimes(int start, int end)
{
  List<int> primesList = new List<int>();
  for (int num = start; num <= end; num++)
  {
    bool isPrime = IsPrime(num);
    if (isPrime)
    {
      primesList.Add(num);
    }
  }
  return primesList;
}
```

<div class="fragment balloon" style="top:51.46%; left:61.71%; width:36.14%">Good code does not need comments. It is self-explaining.</div>
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic08.png" style="top:24.68%; left:89.28%; width:13.47%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->


```cs
private static bool IsPrime(int num)
{
  bool isPrime = true;
  int maxDivider = Math.Sqrt(num);
  for (int div = 2; div <= maxDivider; div++)
  {
    if (num % div == 0)
    {
      // We found a divider -> the number is not prime
      isPrime = false;
      break;
    }
  }
  return isPrime;
}
```

<div class="fragment balloon" style="top:37.64%; left:46.72%; width:53.77%">Good methods have good name and are easy to read and understand.</div>
<div class="fragment balloon" style="top:59.16%; left:39.67%; width:53.77%">This comment explain non-obvious details. It does not repeat the code.</div>
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic09.png" style="top:17.48%; left:88.89%; width:13.47%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Bad Programming Style – _Example_
<div class="fragment balloon" style="top:23.38%; left:53.16%; width:36.76%">Uninformative variable names. Crude layout.</div>
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic10.png" style="top:14.10%; left:97.19%; width:11.57%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Good Programming Style – _Example_

```cs
for (primeCandidate = 1; primeCandidate <= num; primeCandidate++)
{
    isPrime[primeCandidate] = true;
}

for (int factor = 2; factor < (num / 2); factor++)
{
    int factorableNumber = factor + factor;
    while (factorableNumber <= num)
    {
        isPrime[factorableNumber] = false;
        factorableNumber = factorableNumber + factor;
    }
}

for (primeCandidate = 1; primeCandidate <= num; primeCandidate++)
{
    if (isPrime[primeCandidate])
    {
        Console.WriteLine(primeCandidate + " is prime.");
    }
}
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic11.png" style="top:17.63%; left:95.78%; width:13.47%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Self-Documenting Code
- Code that relies on **good programming style**
  - To carry major part of the information intended for the documentation
- Self-documenting code fundamental principles


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Self-Documenting Code Checklist
- **Classes**
  - Does the class’s interface present a consistent abstraction?
  - Does the class’s interface make obvious how you should use the class?
  - Is the class well named, and does its name describe its purpose?
  - Can you treat the class as a black box?
  - Do you reuse instead of repeating code?


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- **Methods**
  - Does each routine’s name describe exactly what the method does?
  - Does each method perform one well-defined task with minimal dependencies?
- **Data Names**
  - Are type names descriptive enough to help document data declarations? 
  - Are variables used only for the purpose for which they’re named?


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- **Data Names**
  - Does naming conventions distinguish among type names, enumerated types,  named constants, local variables, class variables, and global variables?
- **Others**
  - Are data types simple so that they minimize complexity? 
  - Are related statements grouped together? 




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# To Comment or Notto Comment?
## "Everything the CompilerNeeds to Know is in the Code!"
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic12.png" style="top:9.70%; left:32.05%; width:44.96%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Effective Comments
- Effective comments **do not repeat the code**
  - They explain it at a higher level and reveal non-obvious details
- The best software documentation is the source code itself – keep it clean and readable!
- **Self-documenting code**is self-explainable and does not need comments
  - Simple design, small well named methods, strong cohesion and loose coupling, simple logic, good variable names, good formatting, … 


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Effective Comments – Mistakes
- Misleading comments
<div class="fragment balloon" style="top:29.01%; left:53.86%; width:33.30%">What problem does this algorithm solve?</div>
<div class="fragment balloon" style="top:53.06%; left:53.14%; width:36.58%">Can you guess that sum is equal to the ith Fibonacci number?</div>
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic13.png" style="top:18.01%; left:93.88%; width:11.57%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Comments repeating the code:
<div class="fragment balloon" style="top:30.34%; left:52.58%; width:20.28%">Obviously…</div>
<div class="fragment balloon" style="top:48.80%; left:64.78%; width:26.02%">You don’t say…</div>
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic14.png" style="top:22.79%; left:93.90%; width:11.57%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Poor coding style:
- Do not comment bad code,rewrite it
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic15.png" style="top:50.16%; left:73.37%; width:26.61%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic16.png" style="top:19.60%; left:95.08%; width:11.57%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Key Points for Effective Comments
- Use commenting styles that don’t break down or discourage modification
- The above comments are **unmaintainable**
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic17.png" style="top:25.40%; left:94.50%; width:11.57%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Comment the code intent, not implementation details
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic18.png" style="top:56.42%; left:87.95%; width:13.47%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Focus your documentation efforts on the code
<div class="fragment balloon" style="top:26.58%; left:67.72%; width:30.28%">Better code &rarr; less comments</div>
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic19.png" style="top:58.18%; left:87.95%; width:13.47%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Focus paragraph comments on the **why** rather than the **how**
- Use comments to prepare the reader for what is to follow
- Avoid abbreviations
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic20.png" style="top:33.86%; left:92.63%; width:9.70%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic21.png" style="top:55.04%; left:70.17%; width:26.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic22.png" style="top:59.04%; left:81.87%; width:14.99%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Comment anything that gets around an error or an undocumented feature
  - E.g. **//** **This** **is** **workaround** **for** **bug** **#3712**
- Justify violations of good programming style
- Don’t comment tricky code – rewrite it
- Use built-in features for commenting
  - XML comments in C#
  - JavaDoc in Java, …


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# General Guidelines for Higher Level Documentation 
- Describe the design approach to the class
- Describe limitations, usage assumptions, and so on
- Comment the class interface (public methods / properties / events / constructors)
- Don’t document implementation details in the class interface 
- Describe the purpose and contents of each file 
- Give the file a name related to its contents 




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# C# XML Documentation Comments
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic23.png" style="top:38.79%; left:28.07%; width:50.58%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic24.png" style="top:34.67%; left:60.82%; width:28.21%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# C# XML Documentation
- In C# you can document the code by XML tags in special comments
  - Directly in the source code
- For example:
- The XML doc comments are not **metadata**
  - Not included in the compiled assembly and not accessible through reflection


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# XML Documentation Tags
- <summary>
  - A summary of the class / method / object
- <param>
  - Describes one of the parameters for a method
- <returns>
  - A description of the returned value
- <remarks>
  - Additional information (remarks)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- <c> and <code>
  - Gives you a way to indicate code
- <see> and <seealso> and cref
  - Code reference
- <exception>
  - Lets you specify which exceptions can be thrown
- All tags: http://msdn.microsoft.com/en-us/library/5ast78ax.aspx




<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# C# XML Documentation
- Visual Studio will use the XML documentation for autocomplete
  - Automatically, just use XML docs
- Compiling the XML documentation:
  - Compile with /doc the to extract the XML doc into an external XML file
  - Use Sandcastle or other tool to generate CHM / PDF / HTML / other MSDN-style documentation
    - _Example_: http://www.ewoodruff.us/shfbdocs/


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
# Demo: C# XML Documentation Comments
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic25.png" style="top:13.33%; left:32.86%; width:43.86%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Code Documentation and Comments in the Program

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
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic26.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic27.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic28.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic29.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1" /> -->




