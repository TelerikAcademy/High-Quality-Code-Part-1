<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Code Formatting
## Any fool can write code that a computer can understand. Good programmers write code that humans can understand.  

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic01.png" style="top:65%; left:85%; width:14%; z-index:-1" /> -->

<div class="signature">
	<p class="signature-course">High-Quality Code</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="http://telerikacademy.com/" class="signature-link">http://telerikacademy.com/</a>
</div>




<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [Why Do We Need Code Formatting?](#formattingcode)
- [Formatting Methods](#formattingmethods)
- [Formatting Types](#formattingtypes)
- [Common Mistakes](#commonmistakes)
- [Alignments](#alignments)
- [Automated Tools](#automatedtools)  

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:25%; left:60%; width:37%; z-index:-1; border:1px solid white;border-radius:5px;" /> -->




<!-- section start -->
<!-- attr: {  class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
#   Code Formatting
## Why do we need it? How can white spaces and parenthesis help us?





<!-- attr: { id:'formattingcode', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="formattingcode"></a> Code Formatting
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
# Formatting Blocks in JS
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
# Why are Brackets <br /> Obligatory?

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


<!-- attr: { id:'formattingmethods',showInPresentation:true, hasScriptWrapper:true } -->
# <a id="formattingmethods"></a> Empty Lines between <br /> Methods
- Use empty line for separation between methods:

```cs
public class Factorial
{
  private static ulong CalcFactorial(uint num)
  {
    	if (num == 0) return 1;
    	else return num * CalcFactorial(num - 1);
  }

  static void Main()
  {
    	ulong factorial = CalcFactorial(5);
			Console.WriteLine(factorial);
  }
}
```

<div class="fragment balloon" style="top:63%; left:47.60%; width:37.02%">Leave empty line between methods</div>
<div class="fragment balloon" style="top:43%; left:49.11%; width:52.27%">Always use **{** and **}** after **if**</div>
<div class="fragment balloon" style="top:43%; left:49.11%; width:52.27%">(there is no space to do it here)</div>


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


<!-- attr: { id:'commonmistakes', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="commonmistakes"></a> Brackets in Methods Declaration
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
  - _Examples_:
  - Incorrect examples:

```cs
private void RegisterUser(string username, string password)
```


```cs
RegisterUser("academy", "s3cr3t!p@ssw0rd");
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Empty Lines
- Use an empty line to separate logically related sequences of lines:

```cs
private List<Report> PrepareReports()
{
    List<Report> reports = new List<Report>();

    // Create incomes reports
    Report incomesSalesReport = PrepareIncomesSalesReport();
    Report incomesSupportReport = PrepareIncomesSupportReport();
    reports.Add(incomesSalesReport, incomesSupportReport);

    // Create expenses reports
    Report expensesPayrollReport = PrepareExpensesPayrollReport();
    Report expensesMarketingReport = PrepareExpensesMarketingReport();
    reports.Add(expensesPayrollReport, expensesMarketingReport);

    return reports;
}
```

<div class="fragment balloon" style="top:47%; left:60%; width:23.80%">Empty line</div>
<div class="fragment balloon" style="top:70%; left:60%; width:23.80%">Empty line</div>
<div class="fragment balloon" style="top:90%; left:50%; width:23.80%">Empty line</div>


<!-- attr: { id:'formattingtypes',showInPresentation:true, hasScriptWrapper:true } -->
# <a id="formattingtypes"></a> Formatting Types
- Formatting classes / structures / interfaces / enumerations
  - Indent the class body with a single [Tab]
  - Use the following order of definitions:
    - Constants, delegates, inner types, fields, constructors, properties, methods
    - Static members, public members, protected members,  internal members, private members
  - The above order of definitions is not the only possible correct one


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Formatting Types  <br /> – _Example in C#_

```cs
public class Dog
{
    // Static variables
    public const string SPECIES = "Canis Lupus Familiaris";

		// Instance variables
    private int age;

		// Constructors
    public Dog(string name, int age)
    {
        this.Name = name;
        this.Аge = age;
    }
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Formatting Types <br /> – _Example in C#_

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
# Conditional Statements and Loops Formatting <br/> – _Examples in C#_
- Incorrect examples:

```cs
for (int i = 0; i < 10;) {
    Console.WriteLine("i={0}", i);  i++; Console.WriteLine();
}
```

<div class="fragment balloon" style="top:35%; left:65.50%; width:23.80%">The **{** and **}** are missing</div>
<div class="fragment balloon" style="top:47%; left:67.39%; width:32.22%">Never put multiple statements on the same line!</div>
<div class="fragment balloon" style="top:60%; left:66.12%; width:33.50%">In C# the **{** should be on the next line</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Using Empty Lines
- Empty lines are used to separate logically unrelated parts of the source code
  - Don't put empty lines when not needed!
<div class="fragment balloon" style="top:48%; left:58.18%; width:26.86%">An empty line separates the methods</div>
<div class="fragment balloon" style="top:60%; left:58.18%; width:39.67%">An empty line after the foreach block</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Misplaced Empty Lines – _Example_

```cs
for (int i = 0; i < 10;)
{
    Console.WriteLine("i={0}", i);  





		i++;


		Console.WriteLine();
}
```

<div class="fragment balloon" style="top:40.18%; left:55.54%; width:37.44%">What do these empty lines serve for?</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Breaking Long Lines
- Break long lines after punctuation
- Indent the second line by single [Tab]
- Do not additionally indent the third line
- _Examples_:

```cs
public void GetAllAbstractPaintings()
{
	   var paintings = this.Database.Paintings.All()
		 	.Where(x => x.PaintingStyle == PaintingStyleType.Abstract)
			 .Select(x => x.OriginalPaintingPath).ToList();

	   return this.View(paintings);
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Breaking Long Lines <br/> in C# and JavaScript
- In C# use single [Tab] after breaking a long line:
- In JavaScript use double [Tab] in the carried long lines:


<!-- attr: { id:'alignments', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="alignments"></a> Alignments
- All types of alignments are considered harmful
  - Alignments are hard-to-maintain!
  - Modifying one line of code shouldn’t require modifying several others
- Incorrect examples:  

```cs
public void NotCool()
{
	var student          = new Student("Ivan", "Kolev", 21);
	var studentGrades    = new List<int>() { 2, 3, 4, 5, 6 };
	var school           = new SMG("Kopernik");
	var studenstInSchool = new List<Student>();
}

```

<!-- attr: {  id:'automatedtools',showInPresentation:true, hasScriptWrapper:true } -->
# <a id="automatedtools"></a> Automated Tools
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

 - Any questions?
  - Any questions?
	 - Any questions?
	  - Any questions?
		 - Any questions?
		  - Any questions?
			 - Any questions?
			  - Any questions?
				 - Any questions?
				  - Any questions?
					 - Any questions?
					  - Any questions?
						 - Any questions?
						  - Any questions?
							 - Any questions?


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
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:37%; left:60%; width:35%; z-index:-1; border: 1px solid white; border-radius: 5px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:19.00%; left:82%; width:13.01%; z-index:-1" /> -->
