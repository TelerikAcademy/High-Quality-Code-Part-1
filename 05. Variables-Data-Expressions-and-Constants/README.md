<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Correct Use of Variables, Data, Expressions and Constants
## Correctly Organizing Data and Expressions
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic00.png" style="top:5.38%; left:92.50%; width:12.09%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic01.png" style="top:52.89%; left:63.62%; width:39.04%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic02.png" style="top:54.15%; left:54.56%; width:17.08%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic03.png" style="top:4.98%; left:27.13%; width:56.35%; z-index:-1" /> -->
<div class="signature">
	<p class="signature-course">- High-Quality Code</p>
	<p class="signature-initiative">- Telerik Software Academy</p>
	<a href="- http://academy.telerik.com " class="signature-link">- http://academy.telerik.com </a>
</div>




<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- Principles for Initialization
- Scope, Lifetime, Span
- Using Variables
  - Variables Naming
  - Naming convention
  - Standard Prefixes
- Using Expressions
- Using Constants
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic04.png" style="top:22.04%; left:67.37%; width:38.24%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Principles for Initialization
## Best Practices
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic05.png" style="top:41.26%; left:60.16%; width:39.16%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic06.png" style="top:34.13%; left:11.38%; width:25.36%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Initially Assigned Variables in C#
- Static variables
- Instance variables of class instances
- Instance variables of initially assigned struct variables
- Array elements
- Value parameters
- Reference parameters
- Variables declared in a **catch** clause or a **foreach** statement
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic07.png" style="top:37.91%; left:76.72%; width:20.28%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Initially Unassigned Variables in C#
- Instance variables of initially unassigned struct variables
- Output parameters
  - Including the **this** variableof struct instance constructors
- Local variables 
  - Except those declared in a **catch**clause or a **foreach** statement
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic08.png" style="top:24.24%; left:88.89%; width:11.46%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic09.png" style="top:48.48%; left:88.89%; width:12.34%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Guidelines for Initializing Variables
- When the problems can happen?
  - The variable has never been assigned a value
  - The value in the variable is outdated
  - Part of the variable has been assigned a value and a part has not
    - E.g. **Student** class has initialized name, but faculty number is left unassigned
- Developing effective techniques for avoiding initialization problems can save a lot of time


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Variable Initialization
- Initialize all variables before their first usage
  - Local variables should be manually initialized
  - Declare and define each variable close to where it is used
  - This C# code will result in compiler error:
  - We can initialize the variable at its declaration:

```cs
int value = 0;
Console.WriteLine(value);
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic10.png" style="top:61.79%; left:95.46%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic11.png" style="top:44.68%; left:95.44%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Pay special attention to **counters** and **accumulators**
  - A common error is forgetting to reset a counter or an accumulator
<div class="fragment balloon" style="top:57.05%; left:59.06%; width:39.67%">The **sum** must be reset after the end of the inner **for** loop</div>
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic12.png" style="top:34.45%; left:95.86%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Check the need for reinitialization
  - Make sure that the initialization statement is inside the part of the code that’s repeated
- Check input parameters for validity
  - Before you assign input values to anything, make sure the values are reasonable

```cs
int input;
bool validInput = 
  int.TryParse(Console.ReadLine(), out input);
if (validInput)
{
  …
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic13.png" style="top:52.64%; left:94.50%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Partially Initialized Objects
- Ensure objects cannot get into partially initialized state
  - Make all fields private and require valid values for all mandatory fields in all constructors
  - _Example_: **Student** object is invalid unless it has **Name** and **FacultyNumber**

```cs
class Student
{
  private string name, facultyNumber;
  public Student(string name, string facultyNumber)
  { … }
}
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic14.png" style="top:50.88%; left:96.26%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Variables – Other Suggestions
- Don't define **unused variables**
  - Compilers usually issues warnings
- Don't use variables with **hidden purpose**
  - Incorrect example:
  - Use enumeration instead:

```cs
enum ResourceAccessMode { Read, Write, ReadWrite }
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic15.png" style="top:63.22%; left:95.46%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic16.png" style="top:36.70%; left:95.10%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Retuning Result from a Method
- Always assign the result of a method in some variable before returning it. Benefits:
  - Improved code **readability**
    - The returned value has self-documenting name
  - Simplified debugging
  - _Example_:
  - Incorrect example:

```cs
int salary = days * hoursPerDay * ratePerHour;
return salary;
```

<div class="fragment balloon" style="top:42.98%; left:53.77%; width:30.85%">The intent of the formula is obvious</div>
<div class="fragment balloon" style="top:60.99%; left:48.48%; width:53.77%">We can put a breakpoint at this line and check if the result is correct</div>




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Scope, Lifetime, Span
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic17.png" style="top:37.91%; left:62.69%; width:36.14%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic18.png" style="top:37.91%; left:11.46%; width:36.80%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Scope of Variables
- **Scope** – a way of thinking about a variable’s celebrity status
  - How **famous** is the variable?
  - Global (static), member variable, local
  - Most famous variables can be used anywhere, less famous variables are much more restricted
  - The scope is often combined with **visibility**
- In C# and Java, a variable can also be visible to a package or a namespace


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Visibility of Variables
- Variables' **visibility** is explicitly set restriction regarding the access to the variable
  - **public**, **protected**, **internal**, **private**
- Always try to reduce maximally the variables scope and visibility
  - This reduces potential coupling
  - Avoid public fields (exception: **readonly** / **const** in C# / **static** **final** in Java)
  - Access all fields through properties / methods


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Exceeded Scope – _Example_
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic19.png" style="top:12.03%; left:74.23%; width:30.92%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic20.png" style="top:9.28%; left:46.44%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Span of Variables
- Variable **span**
  - The of lines of code (LOC) between variable usages
  - **Average span** can be calculated for all usages
  - Variable span should be kept as low as possible
  - Define variables at their first usage, not earlier
  - Initialize variables as late as possible
  - Try to keep together lines using the same variable


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Calculating Span of Variable

```cs
1  a = 1;
2  b = 1;
3  c = 1;
4  b = a + 1;
5  b = b / c;
```

- One line between the first reference to **b** and the second
- There are no lines between the second reference to **b** and the third
- The average span for **b** is (1+0)/2 = 0.5


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Variable Live Time
- Variable **live time**
  - The number of lines of code (LOC) between the first and the last variable usage in a block
  - Live time should be kept as low as possible
- The same rules apply as for minimizing span:
  - Define variables at their first usage
  - Initialize variables just before their first use
  - Try to keep together lines using the same variable


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Measuring the Live Time of a Variable
- Average live time for all variables:
  -  ( 4 + 8 + 8 ) / 3 ≈ 7

```cs
25 recordIndex = 0;
26 while (recordIndex < recordCount) {
27 ...
28 recordIndex = recordIndex + 1;
...
62 total = 0;
63 done = false;
64 while ( !done ) {
...
69 if ( total > projectedTotal ) {
70 done = true;
```

<div class="fragment balloon" style="top:10.51%; left:44.08%; width:35.26%">**recordIndex**</div>
<div class="fragment balloon" style="top:10.51%; left:44.08%; width:35.26%">( line 28-line 25 + 1 ) = 4</div>
<div class="fragment balloon" style="top:35.77%; left:43.20%; width:36.14%">**total**</div>
<div class="fragment balloon" style="top:35.77%; left:43.20%; width:36.14%"> ( line 69-line 62 + 1 ) = 8</div>
<div class="fragment balloon" style="top:49.57%; left:65.23%; width:36.14%">**done**</div>
<div class="fragment balloon" style="top:49.57%; left:65.23%; width:36.14%">( line 70-line 63 + 1 ) = 8</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Unneeded Large Variable Span and Live Time
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic21.png" style="top:64.35%; left:76.72%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Reduced Span and Live Time

```cs
int[] numbers = new int[100];
for (int i = 0; i < numbers.Length; i++)
{
  numbers[i] = i;
}
for (int i = 0; i < numbers.Length / 2; i++)
{
  numbers[i] = numbers[i] * numbers[i];
}
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
  if (numbers[i] % 3 == 0)
  {
    count++;
  }
}
Console.WriteLine(count);
```


```cs
1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic22.png" style="top:63.44%; left:68.70%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Keep Variables LiveAs Short a Time
<div class="fragment balloon" style="top:10.21%; left:34.38%; width:22.92%">The best case</div>
- Advantages of short time and short span
  - Gives you an accurate picture of your code
  - Reduces the chance of initialization errors
  - Makes your code more readable
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic23.png" style="top:19.39%; left:6.55%; width:27.33%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic24.png" style="top:19.39%; left:39.30%; width:27.33%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic25.png" style="top:19.39%; left:72.05%; width:34.26%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Best Practices
- Initialize variables used in a loop immediately before the loop
- Don’t assign a value to a variable until just before the value is used
  - Never follow the old C / Pascal style of declaring variables in the beginning of each method
- Begin with the most restricted visibility
  - Expand the visibility only when necessary
- Group related statements together


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Group RelatedStatements – _Example_
- Six variables for just this short fragment
<div class="fragment balloon" style="top:15.58%; left:63.32%; width:38.94%">You have to keep track of **oldData**, **newData**,</div>
<div class="fragment balloon" style="top:15.58%; left:63.32%; width:38.94%"> **numOldData**, **numNewData**, **totalOldData** and **totalNewData**</div>
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic26.png" style="top:39.23%; left:92.39%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Better Grouping– _Example_
- Easier to understand, right?

```cs
void SummarizeDaily( … )
{
  GetOldData(oldData, numOldData);
  totalOldData = Sum(oldData, numOldData);
  PrintOldDataSummary(oldData, totalOldData);
  SaveOldDataSummary(totalOldData, numOldData);
  …
  GetNewData(newData, numNewData);
  totalNewData = Sum(newData, numNewData);
  PrintNewDataSummary(newData, totalNewData);
  SaveNewDataSummary(totalNewData, numNewData);
  …
}
```

<div class="fragment balloon" style="top:10.32%; left:70.49%; width:31.74%">The two blocks are each shorter and  individually contain fewer variables</div>
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic27.png" style="top:53.77%; left:94.50%; width:9.07%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Using Variables
## Best Practices
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic28.png" style="top:47.60%; left:68.30%; width:34.38%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic29.png" style="top:31.74%; left:9.20%; width:26.59%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Single Purpose
- Variables should have **single purpose**
  - Never use a single variable for multiple purposes!
  - Economizing memory is not an excuse
- Can you choose a good name for variable that is used for several purposes?
  - _Example_: variable used to count students or to keep the average of their grades
  - Proposed name: studentsCountOrAvgGrade
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic30.png" style="top:61.39%; left:102.72%; width:6.49%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Variables Naming
- The name should describe the object clearly and accurately, which the variable represents
  - Bad names: r18pq, __hip, rcfd, val1, val2
  - Good names: **account**, **blockSize**, **customerDiscount**
- Address the problem, which the variable solves – "what" instead of "how"
  - Good names: **employeeSalary**, **employees**
  - Bad names: myArray, customerFile, customerHashTable
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic31.png" style="top:21.16%; left:98.84%; width:6.49%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic32.png" style="top:63.47%; left:81.40%; width:6.49%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic33.png" style="top:31.74%; left:81.30%; width:6.68%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic34.png" style="top:51.13%; left:91.75%; width:6.68%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Poor and Good Variable Names
- What do x1, xx, and xxx mean?
- What does aretha mean ?

```cs
balance = balance - lastPayment;
monthlyTotal = NewPurchases + SalesTax(newPurchases);
balance = balance + LateFee(customerID, balance) +
  monthlyTotal;
balance = balance + Interest(customerID, balance);
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic35.png" style="top:47.35%; left:97.04%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic36.png" style="top:12.70%; left:96.97%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Considerations
- Naming depends on the scope and visibility
  - Bigger scope, visibility, longer lifetime &rarr;longer and more descriptive name:
-      
  - Variables with smaller scope and shorter lifetime can be shorter:
- The enclosing type gives a context for naming:

```cs
protected Account[] mCustomerAccounts;
```


```cs
for (int i=0; i<customers.Length; i++) { … }
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic37.png" style="top:25.56%; left:95.50%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic38.png" style="top:44.86%; left:95.50%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic39.png" style="top:64.35%; left:95.58%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Optimum Name Length
- Somewhere between the lengths of x and maximumNumberOfPointsInModernOlympics
- Optimal length – 10 to 16 symbols     
  - Too long 
  - Too short
  - Just right

```cs
numTeamMembers, teamMembersCount
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic40.png" style="top:63.47%; left:94.23%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic41.png" style="top:36.09%; left:94.16%; width:9.14%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic42.png" style="top:50.48%; left:94.16%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Specific Data Types
- Naming counters
- Naming variables for state
- Naming temporary variables
  - Bad examples:
  - Good examples:

```cs
UsersCount, RolesCount, FilesCount
```


```cs
ThreadState, TransactionState
```


```cs
index, value, count
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic43.png" style="top:65.31%; left:94.57%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic44.png" style="top:52.03%; left:94.50%; width:9.14%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic45.png" style="top:14.10%; left:94.50%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic46.png" style="top:29.64%; left:94.50%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Name Boolean variables with names implying "Yes / No" answers
- Booleans variables should bring "truth" in their name
  - Bad examples:
  - Good examples:

```cs
canRead, available, isOpen, valid
```


```cs
isReady, canRead, hasMoreData
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic47.png" style="top:64.10%; left:94.57%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic48.png" style="top:48.95%; left:94.50%; width:9.14%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic49.png" style="top:20.91%; left:94.65%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Naming enumeration types
  - Use build in enumeration types (**Enum**)
  - Or use appropriate prefixes (e.g. in JS / PHP)
- Naming constants – use capital letters
- C# constants should be in PascalCase:

```cs
Color.Red, Color.Yellow, Color.Blue
```


```cs
colorRed, colorBlue, colorYellow
```


```cs
MAX_FORM_WIDTH, BUFFER_SIZE
```


```cs
Int32.MaxValue, String.Empty, InvariantCulture
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic50.png" style="top:21.16%; left:95.17%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic51.png" style="top:35.40%; left:95.17%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic52.png" style="top:49.86%; left:95.17%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic53.png" style="top:64.63%; left:95.17%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Convention
- Some programmers resist to followstandards and conventions
  - But why?
- Conventions benefits
  - Transfer knowledge across projects
  - Helps to learn code more quickly on a new project
  - Avoid calling the same thing by two different names


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- When should we use a naming convention?
  - Multiple developers are working on the same project
  - The source code is reviewed by other programmers
  - The project is large
  - The project will be long-lived
- You always benefit from having some kind of naming convention!


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Language-Specific Conventions
- C# and Java / JavaScript conventions
  - **i** and **j** are integer indexes
  - Constants are in **ALL_CAPS** separated by underscores (sometimes **PascalCase** in C#)
  - Variable and method names use uppercase in C# and lowercase in JS for the first word
  - The underscore **_** is not used within names
    - Except for names in all caps


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Standard Prefixes
- Hungarian notation – not used
- Semantic prefixes (ex. **btnSave**)
  - Better use **buttonSave**
- Do not miss letters to make name shorter
- Abbreviate names in consistent way throughout the code
- Create names, which can be pronounced(not like btnDfltSvRzlts)
- Avoid combinations, which form another word or different meaning (ex. preFixStore)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Kinds of Names to Avoid
- Document short names in the code
- Remember, names are designed for the people, who will read the code
  - Not for those who write it
- Avoid variables with similar names, but different purpose it
- Avoid names, that sounds similar
- Avoid digits in names 
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic54.png" style="top:44.03%; left:97.44%; width:9.14%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic55.png" style="top:57.86%; left:97.44%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Avoid words, which can be easily mistaken
  - E.g. adsl, adcl, adctl, atcl
- Avoid using non-English words
- Avoid using standard types and keywords in the variable names
  - E.g. int, class, void, return
- Do not use names, which has nothing common with variables content
- Avoid names, that contains hard-readable symbols / syllables, e.g. Csikszentmihalyi
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic56.png" style="top:42.31%; left:75.79%; width:6.17%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic57.png" style="top:15.38%; left:73.34%; width:6.17%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Using Expressions
## Best Practices
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic58.png" style="top:7.05%; left:73.45%; width:33.06%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic59.png" style="top:42.31%; left:17.78%; width:40.55%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Avoid Complex Expressions
- Never use complex expressions in the code!
  - Incorrect example:
- Complex expressions are evil because:
  - Make code hard to read and understand, hard to debug, hard to modify and hard to maintain
<div class="fragment balloon" style="top:18.33%; left:51.51%; width:51.13%">What shall we do if we get at this line **IndexOutOfRangeException**?</div>
<div class="fragment balloon" style="top:50.93%; left:30.85%; width:67.88%">There are 10 potential sources of **IndexOutOfRangeException** in this expression!</div>
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic60.png" style="top:26.93%; left:101.05%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Simplifying Complex Expressions

```cs
for (int i = 0; i < xCoords.length; i++)
{
  for (int j = 0; j < yCoords.length; j++)
  {
    int maxStartIndex = findMax(i) + 1;
    int minStartIndex = findMin(i) - 1;
    int minXcoord = xCoords[minStartIndex];
    int maxXcoord = xCoords[maxStartIndex];
    int minYcoord = yCoords[minStartIndex];
    int maxYcoord = yCoords[maxStartIndex];
    int newValue = 
      matrix[maxXcoord][minYcoord] *
      matrix[maxYcoord][minXcoord];
    matrix[i][j] = newValue;
  }
}
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic61.png" style="top:54.66%; left:82.69%; width:20.28%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Using Constants
## When and How to Use Constants?
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic62.png" style="top:46.72%; left:8.42%; width:29.33%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic63.png" style="top:46.72%; left:46.78%; width:53.87%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Avoid Magic Numbers and Strings
- What is **magic number** or **value**?
  - Magic numbers / values are all literals different than **0**, **1**, **-1**, **null** and **""** (empty string)
- Avoid using magic numbers / values
  - They are **hard to maintain**
    - In case of change, you need to modify all occurrences of the magic number / constant
  - Their meaning is not obvious
    - _Example_: what the number 1024 means?
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic64.png" style="top:31.79%; left:90.76%; width:14.99%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Evil Magic Numbers
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic65.png" style="top:10.58%; left:96.12%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Turning MagicNumbers into Constants

```cs
public class GeometryUtils
{
   public const double PI = 3.14159206;
   public static double CalcCircleArea(double radius)
   {
      double area = PI * radius * radius;
      return area;
   }
   public static double CalcCirclePerimeter(double radius)
   {
      double perimeter = 2 * PI * radius;
      return perimeter;
   }
   public static double CalcElipseArea(
    double axis1, double axis2)
   {
      double area = PI * axis1 * axis2;
      return area;
   }
}
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic66.png" style="top:61.98%; left:91.11%; width:14.10%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Constants in C#
- There are two types of constants in C#
  - Compile-time constants:
    - Replaced with their value during compilation
    - No field stands behind them
  - Run-time constants:
    - Special fields initialized in the static constructor
    - Compiled into the assembly like any other class member

```cs
public const double PI = 3.14159206;
```


```cs
public static readonly string ConfigFile = "app.xml";
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic67.png" style="top:20.59%; left:97.88%; width:7.33%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic68.png" style="top:48.10%; left:97.95%; width:7.33%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Constants in JavaScript
- JS does not support constants
  - Simulated by variables / fields in **ALL_CAPS**:

```cs
var PI = 3.14159206;

var CONFIG =
{
  COLOR : "#AF77EE",
  DEFAULT_WIDTH : 200,
  DEFAULT_HEIGHT : 300
};

document.getElementById("gameField").style.width =
  CONFIG.DEFAULT_WIDTH;
document.getElementById("gameField").style.
  backgroundColor = CONFIG.COLOR;
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic69.png" style="top:28.21%; left:97.42%; width:8.71%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# When to Use Constants?
- Constants should be used in the following cases:
  - When we need to use numbers or other values and their logical meaning and value are not obvious
  - File names
  - Mathematical constants
  - Bounds and ranges

```cs
public static readonly string SettingsFileName =
  "ApplicationSettings.xml";
```


```cs
public const double E = 2.7182818284;
```


```cs
public const int READ_BUFFER_SIZE = 5 * 1024 *1024;
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic70.png" style="top:49.46%; left:97.42%; width:8.71%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic71.png" style="top:28.21%; left:97.42%; width:8.71%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic72.png" style="top:62.64%; left:97.42%; width:8.71%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# When to Avoid Constants?
- Sometime it is better to keep the magic values instead of using a constant
  - **Error messages**and **exception descriptions**
  - **SQL commands**for database operations
  - Titles of **GUI elements**(labels, buttons, menus, dialogs, etc.)
- For internationalization purposes use **resources**, not constants
  - Resources are special files embedded in the assembly / JAR file, accessible at runtime


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Correct Use of Variables, Data, Expressions and Constants

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
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic73.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic74.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic75.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic76.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1" /> -->




