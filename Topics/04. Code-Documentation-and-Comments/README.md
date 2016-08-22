<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Code Documentation and Comments in the Program
## Revealing the Secrets of Self-Documenting Code
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic00.png" style="top:65%; left:85%; width:17.08%; z-index:-1; border-radius:10px;" /> -->
<div class="signature">
	<p class="signature-course">High-Quality Code - Part 1</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="https://academy.telerik.com " class="signature-link">https://academy.telerik.com </a>
</div>




<!-- section start -->
<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [The Concept of Self-Documenting Code](#concepts)
- [Bad Comments](#bad-comments)
- [Good Programming Style](#good-style)
- [To Comment or Not to Comment?](#yes-no)
- [Key Points commenting](#key-points)
- [Recommended practices](#recommended)
- [C# XML DocumentationComments](#xml-docs)




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Comments and Code Documentation
## The Concept of Self-Documenting Code -->


<!-- attr: { id:'concepts', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="concepts"></a>What is Project Documentation?
- Consists of documents and information
  - Both inside the source-code and outside
- **External documentation**
  - At a higher level compared to the code
  - Problem definition, requirements, architecture, design, project plans, test plans. etc.
- **Internal documentation**
  - Lower-level – explains a class,method or a piece of code
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic04.png" style="top:23%; left:81.94%; width:22.42%; z-index:-1" /> -->


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
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:37.91%; left:71.11%; width:32.62%; z-index:-1" /> -->


<!-- attr: { id:'bad-comments', showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.6em' } -->
# <a id="bad-comments"></a> Bad Comments – _Example_
```cs
public static List<int> FindPrimes(int start, int end)
{
    // Create new list of integers
    List<int> primesList = new List<int>();
    // Perform a loop from start to end
    for (int num = start; num <= end; num++)
    {
        // Declare boolean variable, initially true
        bool prime = true;
        // Perform loop from 2 to sqrt(num)
        for (int div = 2; div <= Math.Sqrt(num); div++)
        {
            // Check if div divides num with no remainder
            if (num % div == 0)
            {
                // We found a divider -> the number is not prime
                prime = false;
                // Exit from the loop
                break;
            }
            // Continue with the next loop value
  }

  // Check if the number is prime
  if (prime)
  {
      // Add the number to the list of primes
      primesList.Add(num);
  }
}

// Return the list of primes
return primesList;
}


```
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:13.96%; left:90.81%; width:15.82%; z-index:1" /> -->


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
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic08.png" style="top:24.68%; left:89.28%; width:13.47%; z-index:1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Self-Documenting Code – _Example_ -->

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

<div class="fragment balloon" style="top:30%; left:46.72%; width:53.77%">Good methods have good name and are easy to read and understand.</div>
<div class="fragment balloon" style="top:63%; left:39.67%; width:53.77%">This comment explain non-obvious details. It does not repeat the code.</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:17.48%; left:88.89%; width:13.47%; z-index:1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true,style:'font-size:0.8em' } -->
# Bad Programming Style – _Example_
```cs
for (i = 1; i <= num; i++)
{
    meetsCriteria[i] = true;
}
for (i = 2; i <= num / 2; i++)
{
    j = i + i;
while (j <= num)
{
        meetsCriteria[j] = false;
        j = j + i;
    }
}
for (i = 1; i <= num; i++)
{
    if (meetsCriteria[i])
    {
        Console.WriteLine(i + " meets criteria.");
    }
}
```
<div class="fragment balloon" style="top:45%; left:40%; width:36.76%">Uninformative variable names. Crude layout.</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:14.10%; left:85%; width:11.57%; z-index:1" /> -->


<!-- attr: { id:'good-style', showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.9em' } -->
# <a id="good-style"></a> Good Programming Style – _Example_

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

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:17.63%; left:85%; width:13.47%; z-index:11" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Self-Documenting Code
- Code that relies on **good programming style**
  - To carry major part of the information intended for the documentation
- Self-documenting code fundamental principles

```
The best documentation is the code itself.
```

```
Make the code self-explainable
and self-documenting, easy to read and understand.
```

```
Do not document bad code, rewrite it!
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Self-Documenting Code Checklist
- **Classes**
  - Does the class’s interface present a consistent abstraction?
  - Does the class’s interface make obvious how you should use the class?
  - Is the class well named, and does its name describe its purpose?
  - Can you treat the class as a black box?
  - Do you reuse instead of repeating code?


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Self-Documenting Code Checklist -->
- **Methods**
  - Does each routine’s name describe exactly what the method does?
  - Does each method perform one well-defined task with minimal dependencies?
- **Data Names**
  - Are type names descriptive enough to help document data declarations?
  - Are variables used only for the purpose for which they’re named?


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Self-Documenting Code Checklist -->
- **Data Names**
  - Does naming conventions distinguish among type names, enumerated types,  named constants, local variables, class variables, and global variables?
- **Others**
  - Are data types simple so that they minimize complexity?
  - Are related statements grouped together?




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # To Comment or Not to Comment?
## "Everything the Compiler Needs to Know is in the Code!" -->

<!-- attr: { id:'yes-no', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="yes-no"></a> Effective Comments
- Effective comments **do not repeat the code**
  - They explain it at a higher level and reveal non-obvious details
- The best software documentation is the source code itself – keep it clean and readable!
- **Self-documenting code** is self-explainable and does not need comments
  - Simple design, small well named methods, strong cohesion and loose coupling, simple logic, good variable names, good formatting, …


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Effective Comments – Mistakes
- Misleading comments

```cs
// write out the sums 1..n for all n from 1 to num   
current = 1;
previous = 0;
sum = 1;   
for (int i = 0; i < num; i++)
{   
   Console.WriteLine( "Sum = " + sum );   
   sum = current + previous;   
   previous = current;   
   current = sum;
}

```

<div class="fragment balloon" style="top:30%; left:53.86%; width:33.30%">What problem does this algorithm solve?</div>
<div class="fragment balloon" style="top:53.06%; left:53.14%; width:36.58%">Can you guess that sum is equal to the ith Fibonacci number?</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic13.png" style="top:18.01%; left:85%; width:11.57%; z-index:1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Effective Comments – Mistakes -->
- Comments repeating the code:

```cs
// set product to "base"
product = base;

// loop from 2 to "num"
for ( int i = 2; i <= num; i++ )
{
   // multiply "base" by "product"  
   product = product * base;
}
Console.WriteLine( "Product = " + product );
```

<div class="fragment balloon" style="top:30.34%; left:30%; width:20.28%">Obviously…</div>
<div class="fragment balloon" style="top:48.80%; left:60%; width:26.02%">You don’t say…</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic14.png" style="top:22.79%; left:85%; width:11.57%; z-index:1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Effective Comments – Mistakes -->
- Poor coding style:

```cs
// compute the square root of Num using
// the Newton-Raphson approximation
r = num / 2;
while (abs(r - (num/r)) > TOLERANCE)
{
   r = 0.5 * (r + (num/r) );
}
Console.WriteLine( "r = " + r );
```

- Do not comment bad code, rewrite it
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:19.60%; left:85%; width:11.57%; z-index:1" /> -->


<!-- attr: { id:'key-points', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="key-points"></a> Key Points for Effective Comments
- Use commenting styles that don’t break down or discourage modification

```cs
//  Variable            Meaning
//  --------            -------
//  xPos .............. X coordinate position (in meters)
//  yPos .............. Y coordinate position (in meters)
//  zPos .............. Z coordinate position (in meters)
//  radius ............ The radius of the sphere where the
                        battle ship is located (in meters)
//  distance .......... The distance from the start position
                        (in meters)
```

- The above comments are **unmaintainable**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:35%; left:85%; width:11.57%; z-index:1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.9em' } -->
<!-- # Key Points for Effective Comments -->

- Comment the code intent, not implementation details

```cs
// Scan char by char to find the command-word terminator ($)
done = false;
maxLen = inputString.Length;
i = 0;
while (!done && (i < maxLen))
{
  if (inputString[i] == '$')
  {
    done = true;
  }
  else
  {
    i++;
  }
}
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:35%; left:85%; width:13.47%; z-index:1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.9em' } -->
<!-- # Key Points for Effective Comments -->
- Focus your documentation efforts on the code

```cs
// Find the command-word terminator
foundTheTerminator = false;
maxCommandLength = inputString.Length();
testCharPosition = 0;
while (!foundTheTerminator &&
    (testCharPosition < maxCommandLength))
{
  if (inputString[testCharPosition] == COMMAND_WORD_TERMINATOR)
  {
    foundTheTerminator = true;
    terminatorPosition = testCharPosition;
  }
  else
  {
    testCharPosition = testCharPosition + 1;
  }
}
```

<div class="fragment balloon" style="top:26.58%; left:67.72%; width:30.28%">Better code &rarr; less comments</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic19.png" style="top:58.18%; left:85%; width:13.47%; z-index:1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Key Points for Effective Comments -->
- Focus paragraph comments on the **why** rather than the **how**

```cs
// Establish a new account
if (accountType == AccountType.NewAccount)
{
   …
}
```

- Use comments to prepare the reader for what is to follow
- Avoid abbreviations


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Key Points for Effective Comments -->

- Comment anything that gets around an error or an undocumented feature
  - E.g. **//** **This** **is** **workaround** **for** **bug** **#3712**
- Justify violations of good programming style
- Don’t comment tricky code – rewrite it
- Use built-in features for commenting
  - XML comments in C#
  - JavaDoc in Java, …


<!-- attr: { id:'recommended', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="recommended"></a>General Guidelines for Higher Level Documentation
- Describe the design approach to the class
- Describe limitations, usage assumptions, and so on
- Comment the class interface (public methods / properties / events / constructors)
- Don’t document implementation details in the class interface
- Describe the purpose and contents of each file
- Give the file a name related to its contents




<!-- section start -->
<!-- attr: {  class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # C# XML Documentation Comments -->


<!-- attr: { id:'xml-docs', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="xml-docs"></a>C# XML Documentation
- In C# you can document the code by XML tags in special comments
  - Directly in the source code
- For example:

```cs
/// <summary>
/// This class performs an important function.
/// </summary>
public class MyClass { }
```

- The XML doc comments are not **metadata**
  - Not included in the compiled assembly and not accessible through reflection


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.95em' } -->
# XML Documentation Tags
- **&lt;summary>**
  - A summary of the class / method / object
- **&lt;param>**

    `<param name="name">description</param>`
  - Describes one of the parameters for a method
- **&lt;returns>**
  - A description of the returned value
- **&lt;remarks>**
  - Additional information (remarks)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.9em' } -->
<!-- # XML Documentation Tags -->

- **&lt;c>** and **&lt;code>**
  - Gives you a way to indicate code
- **&lt;see>** and **&lt;seealso>** and cref
  - Code reference `<seealso cref="TestClass.Main"/>`
- **&lt;exception>**

    `<exception cref="type">description</exception>`
  - Lets you specify which exceptions can be thrown
- All tags: http://msdn.microsoft.com/en-us/library/5ast78ax.aspx

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.9em' } -->
# XML Documentation Example

```cs
/// <summary>
/// The GetZero method. Always returns zero.
/// </summary>
/// <example>  
/// This sample shows how to call the <see cref="GetZero"/> method.
/// <code>
/// class TestClass  
/// {
///     static int Main()  
///     {
///         return GetZero();
///     }
/// }
/// </code>
/// </example>
public static int GetZero()
{
    return 0;
}
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# C# XML Documentation
- Visual Studio will use the XML documentation for autocomplete
  - Automatically, just use XML docs
- Compiling the XML documentation:
  - Compile with **/doc** the to extract the XML doc into an external XML file
  - Use Sandcastle or other tool to generate CHM / PDF / HTML / other MSDN-style documentation
    - _Example_: http://www.ewoodruff.us/shfbdocs/


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Demo: C# XML Documentation Comments -->


<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # HQC-Part 1: Code Documentation and Comments
## Questions? -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - [HQC-Part 1 course](http://academy.telerik.com/student-courses/programming/high-quality-code/about)
  - Telerik Software Academy
    - [telerikacademy.com](https://telerikacademy.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Software Academy Forums
    - [forums.academy.telerik.com](forums.academy.telerik.com)
 -->
