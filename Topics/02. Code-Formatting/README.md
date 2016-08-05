<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Code Formatting
## Any fool can write code that a computer can understand. Good programmers write code that humans can understand.
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic00.png" style="top:6.97%; left:57.65%; width:17.08%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic01.png" style="top:4.71%; left:90.39%; width:14.20%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic02.png" style="top:13.67%; left:7.96%; width:20.73%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic03.png" style="top:51.60%; left:80.59%; width:23.69%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic04.png" style="top:50.22%; left:50.53%; width:26.45%; z-index:-1" /> -->
<div class="signature">
	<p class="signature-course">- High-Quality Code</p>
	<p class="signature-initiative">- Telerik Software Academy</p>
	<a href="- http://academy.telerik.com " class="signature-link">- http://academy.telerik.com </a>
</div>




<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- Why Do We Need Code Formatting?
- Formatting Methods
- Formatting Types
- Common Mistakes
- Alignments
- Automated Tools
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:26.45%; left:67.37%; width:38.24%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Code Formatting
## Why do we need it?How can white spaces and parenthesis help us?
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:57.16%; left:13.10%; width:9.70%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:45.12%; left:37.43%; width:18.51%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic08.png" style="top:36.32%; left:73.92%; width:25.56%; z-index:-1" /> -->




<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Code Formatting Fundamentals
- Good formatting goals
  - To improve code readability
  - To improve code maintainability
- Fundamental principle of code formatting:
  - Any (consistent) formatting style that follows the above principle is good
  - Good formatting don’t affect speed, memory use or other aspects of the program


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Formatting Blocks in C#
- Put **{** and **}** alone on a line under the corresponding parent block
- Indent the block contents by a single [Tab]
  - Visual Studio will replace the [Tab] with 4 spaces
- _Example_:

```cs
if (some condition)
{
    // Block contents indented by a single [Tab]
    // VS will replace the [Tab] with 4 spaces
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Formatting Blocks in JavaScript
- Put **{** at the end of the block and **}** alone on a line under the corresponding parent block
- Indent the block contents by a single [Tab]
  - [tab] or spaces depends on the team style
- _Example_:

```cs
if (some condition) {
    // Block contents indented by a single [Tab]
    // Choosing between [tab] and spaces depends
    //  on project formatting style
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Why are Brackets Obligatory?

```cs
// swap left and right elements for whole array
for (var i = 0; i < MaxElements; i++)
{
    leftElement = left[i];
    left[i] = right[i];
    right[i] = leftElement;
}
```


```cs
x = (3 + 4) * (2 + 7);
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:10.89%; left:95.59%; width:9.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:30.70%; left:94.82%; width:9.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:57.16%; left:95.83%; width:9.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic12.png" style="top:65.15%; left:95.77%; width:9.45%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Empty Lines between Methods
- Use empty line for separation between methods:

```cs
public class Factorial
{
  private static ulong CalcFactorial(uint num)
  {
    if (num == 0)
      return 1;
    else
      return num * CalcFactorial(num - 1);
  }
    
  static void Main()
  {
    ulong factorial = CalcFactorial(5);
    Console.WriteLine(factorial);
  }
}
```

<div class="fragment balloon" style="top:51.92%; left:47.60%; width:37.02%">Leave empty line between methods</div>
<div class="fragment balloon" style="top:33.68%; left:49.11%; width:52.27%">Always use **{** and **}** after **if**</div>
<div class="fragment balloon" style="top:33.68%; left:49.11%; width:52.27%">(there is no space to do it here)</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Methods Indentation
- Methods should be indented with a single [Tab] from the class body
- Methods body should be indented with a single [Tab] as well

```cs
public class Indentation_Example_
{
    private int Zero()
    {
        return 0;
    }
}
```

<div class="fragment balloon" style="top:48.65%; left:50.25%; width:45.84%">The entire method is indented with a single [Tab]</div>
<div class="fragment balloon" style="top:72.11%; left:21.82%; width:49.37%">Method body is also indented</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Brackets in Methods Declaration
- Brackets in the method declaration should be formatted as follows:
- Don't  use spaces between the brackets:
- The same applies for **if**-conditions and **for**-loops:

```cs
private static ulong CalcFactorial(uint num)
```


```cs
if (condition) { … }
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic13.png" style="top:21.79%; left:93.83%; width:9.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic14.png" style="top:40.05%; left:93.83%; width:9.45%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Separating Parameters
- Separate method parameters by comma followed by a space
  - Don't put space before the comma
  - _Example_s:
  - Incorrect examples:

```cs
private void RegisterUser(string username, string password)
```


```cs
RegisterUser("academy", "s3cr3t!p@ssw0rd");
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Empty Lines in Method Body
- Use an empty line to separate logically related sequences of lines:

```cs
private List<Report> PrepareReports()
{
    List<Report> reports = new List<Report>();

    // Create incomes reports
    Report incomesSalesReport = PrepareIncomesSalesReport();
    reports.Add(incomesSalesReport);
    Report incomesSupportReport = PrepareIncomesSupportReport();
    reports.Add(incomesSupportReport);

    // Create expenses reports
    Report expensesPayrollReport = PrepareExpensesPayrollReport();
    reports.Add(expensesPayrollReport);
    Report expensesMarketingReport = PrepareExpensesMarketingReport();
    reports.Add(expensesMarketingReport);

    return reports;
}
```

<div class="fragment balloon" style="top:30.01%; left:68.76%; width:23.80%">Empty line</div>
<div class="fragment balloon" style="top:48.72%; left:68.76%; width:23.80%">Empty line</div>
<div class="fragment balloon" style="top:72.11%; left:44.08%; width:23.80%">Empty line</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Formatting Types
- Formatting classes / structures / interfaces / enumerations
  - Indent the class body with a single [Tab]
  - Use the following order of definitions:
    - Constants, delegates, inner types, fields, constructors, properties, methods
    - Static members, public members, protected members,  internal members, private members
  - The above order of definitions is not the only possible correct one


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Formatting Types – _Example_ in C#

```cs
public class Dog
{
    // Static variables
    public const string SPECIES = 
        "Canis Lupus Familiaris";
    // Instance variables
    private int age;
    // Constructors
    public Dog(string name, int age)
    {
        this.Name = name;
       this.age = age;
    } 
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->


```cs
    // Properties
    public string Name { get; set; }
    // Methods
    public void Breath()
    {
        // TODO: breathing process
    }
    public void Bark()
    {
        Console.WriteLine("wow-wow");
    }
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Formatting Conditional Statements and Loops
- Formatting conditional statements and loops
  - Always use **{ }** block after **if** / **for** / **while**, even when a single operator follows
  - Indent the block body after **if** / **for** / **while**
  - Always put a new line after a **if** / **for** / **while** block!
  - Always put the **{** on the next line (in C#)
  - Always put the **{** on the same line (in JavaScript)
  - Never indent with more than one [Tab]


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Conditional Statements andLoops Formatting – C# _Example_s
- _Example_:
- Incorrect examples:

```cs
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("i={0}", i);
}
```

<div class="fragment balloon" style="top:29.01%; left:65.50%; width:23.80%">The **{** and **}** are missing</div>
<div class="fragment balloon" style="top:41.75%; left:67.39%; width:32.22%">Never put multiple stetements on the same line!</div>
<div class="fragment balloon" style="top:68.30%; left:66.12%; width:33.50%">In C# the **{** should be on the next line</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Using Empty Lines
- Empty lines are used to separate logically unrelated parts of the source code
  - Don't put empty lines when not needed!
<div class="fragment balloon" style="top:49.63%; left:58.18%; width:26.86%">An empty lineseparates the methods</div>
<div class="fragment balloon" style="top:27.82%; left:58.18%; width:39.67%">An empty lineafter the foreach block</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Misplaced Empty Lines – _Example_
<div class="fragment balloon" style="top:40.18%; left:55.54%; width:37.44%">What do these empty lines serve for?</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Breaking Long Lines
- Break long lines after punctuation
- Indent the second line by single [Tab]
- Do not additionally indent the third line
- _Example_s:




<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Breaking Long Linesin C# and JavaScript
- In C# use single [Tab] after breaking a long line:
- In JavaScript use double [Tab] in the carried long lines:


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Alignments
- All types of alignments are considered harmful
  - Alignments are hard-to-maintain!
  - Modifying one line of code shouldn’t require modifying several others
- Incorrect examples:
<div class="fragment balloon" style="top:61.49%; left:70.52%; width:31.74%">Think about renaming **Student** to **SchoolStudent**</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Automated Tools
- Take advantage of your IDE to help formatting the code **[Ctrl+K+D]**
  - Automatic alignment
  - Indentation
- Style Code analysis
  - Visual Studio – StyleCop
    - http://code.msdn.microsoft.com/sourceanalysis
  - Eclipse – CheckStyle
    - http://sourceforge.net/projects/eclipse-cs/
  - JSHint, JSLint – JavaScript code analysis (all IDEs)
    - http://www.jshint.com/, http://www.jslint.com/  


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Code Formatting

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
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1" /> -->




