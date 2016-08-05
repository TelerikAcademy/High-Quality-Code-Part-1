<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Naming Identifiers
## Naming Variables, Methods, Classes, Etc.
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic00.png" style="top:0.88%; left:22.46%; width:83.75%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic01.png" style="top:52.34%; left:54.27%; width:49.37%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic02.png" style="top:19.27%; left:7.13%; width:17.08%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic03.png" style="top:11.39%; left:92.63%; width:12.09%; z-index:-1" /> -->
<div class="signature">
	<p class="signature-course">- High-Quality Code</p>
	<p class="signature-initiative">- Telerik Software Academy</p>
	<a href="- http://academy.telerik.com " class="signature-link">- http://academy.telerik.com </a>
</div>




<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- General Naming Guidelines
  - The Power of Meaningful Names
- Naming Classes / Types / Applications
  - Naming Classes, Interfaces, Types, Delegates, Enumerations, Namespaces, Files, Folders, Assemblies, Applications
- Naming Methods and Method Parameters
- Naming Variables and Constants
- Other Naming Guidelines




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# General Naming Guidelines
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic04.png" style="top:13.22%; left:32.35%; width:44.46%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# General Naming Guidelines
- Always use **English**
  - How will you feel if you read Vietnamese code with variables named in Vietnamese?
  - English is the only language that all software developers speak
- Avoid abbreviations
  - _Example_: scrpCnt vs. **scriptsCount**
- Avoid hard-to-pronounce names
  - _Example_: dtbgRegExPtrn vs. **dateTimeBulgarianRegExPattern**
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic05.png" style="top:59.94%; left:89.82%; width:15.51%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Use Meaningful Names
- Always prefer **meaningful names**
  - Names should answer these questions:
    - **What does this class do? What is the intent of this variable? What is this variable / class used for?**
  - _Example_s:
    - **FactorialCalculator**, **studentsCount**, **Math.PI**, **configFileName**, **CreateReport**
  - Incorrect examples: 
    - k, k2, k3, junk, f33, KJJ, button1, variable, temp, tmp, temp_var, something, someValue
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic06.png" style="top:12.94%; left:92.07%; width:14.63%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic07.png" style="top:38.32%; left:95.02%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic08.png" style="top:56.42%; left:101.49%; width:7.52%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Names Should Be Meaningful in Their Context
- Whether a name is meaningful or not depends on its **context** (its enclosing type)
- _Example_s of meaningful names:
  - **Generate()** in the class **LabyrinthGenerator**
  - **Find(string** **fileName)** in the class **FileFinder**
  - **Deposit(decimal** **amount)** in the class **Account**
- _Example_s of meaningless names:
  - Generate() in the class Program
  - Find(string name) in the class Program
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic09.png" style="top:26.45%; left:96.19%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic10.png" style="top:63.47%; left:95.86%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Fake Meaningful Names
- Junior developers often use “**fake**” meaningful names that are in fact meaningless
  - Bad naming examples:
    - Topic6Exercise12, LoopsExercise12, Problem7, OOPLecture_LastExercise
  - Yes, Topic6Exercise12 indicates that this is solution to exercise 12, but what is it about?
    - Sum of numbers or Tetris game?
  - Better naming:
    - **MaximalNumbersSubsequence**
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic11.png" style="top:59.06%; left:79.53%; width:26.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic12.png" style="top:61.71%; left:69.60%; width:7.30%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic13.png" style="top:25.68%; left:95.84%; width:9.14%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Naming Classes, Types and Application Components
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic14.png" style="top:35.26%; left:30.46%; width:48.34%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Classes and Types
- Naming types (classes, structures, etc.)
  - Use **PascalCase** character casing
    - In C#, JavaScript, Java, PHP
  - _Example_s:
    - **RecursiveFactorialCalculator**, **TreeSet**, **XmlDocument**, **IEnumerable**, **Color**, **TreeNode**, **InvalidTransactionException**, **MainForm**
  - Incorrect examples: 
    - recursiveFactorialCalculator, recursive_factorial_calculator,  RECURSIVE_FACTORIAL_CALCULATOR
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic15.png" style="top:26.45%; left:94.50%; width:10.58%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic16.png" style="top:62.51%; left:91.61%; width:10.66%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Classes and Structuresin C#, JavaScript, C++ and Java 
- Use the following formats:
  - [Noun]
  - [Adjective] + [Noun]
- _Example_s:
  - **Student**, **FileSystem**, **BinaryTreeNode**, **Constants**, **MathUtils**, **CheckBox**, **Calendar**
- Incorrect examples:
  - Move, FindUsers, Fast, ExtremlyFast, Optimize, Check,  FastFindInDatabase
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic17.png" style="top:17.85%; left:74.85%; width:29.09%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic18.png" style="top:41.43%; left:99.36%; width:7.76%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic19.png" style="top:64.35%; left:98.24%; width:7.48%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Interfaces in C#
- Following formats are acceptable:
  - '**I**' + [Verb] + '**able**'
  - '**I**' + [Noun], '**I**' + [Adjective] + [Noun]
- _Example_s:
  - **IEnumerable**, **IFormattable**, **IDataReader**,**IList**, **IHttpModule**,**ICommandExecutor**
- Incorrect examples:
  - List, iFindUsers, IFast, IMemoryOptimize, Optimizer, FastFindInDatabase, CheckBox
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic20.png" style="top:13.22%; left:90.76%; width:13.68%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic21.png" style="top:33.50%; left:97.66%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic22.png" style="top:54.32%; left:98.43%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Interfaces in Java
- Following formats are acceptable:
  - [Verb] + '**able**'
  - [Noun], [Adjective] + [Noun]
- _Example_s:
  - **Serializable** , **Enumerable**, **Comparable**, **Runnable**, **CharSequence**, **OutputStream**
- Incorrect examples:
  - list, FindUsers, Run, Inumber, OPTIMIZER, IMemoryOptimize, FastFindInDatabase 
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic23.png" style="top:20.28%; left:81.19%; width:22.23%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic24.png" style="top:32.62%; left:69.24%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic25.png" style="top:52.89%; left:100.12%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Enumerations in C#
- Several formats are acceptable:
  - [Noun] or [Verb] or [Adjective]
- Use the same style for all members
- _Example_s:
  - **enum Day {Monday,** **Tuesday,** **Wednesday,** **…}**, **enum AppState {Running,** **Finished,** **…}**, 	 **enum WindowState {Normal,** **Maximized,** **…}**
- Incorrect examples:
  - enum Color {red, green, blue, white},enum PAGE_FORMAT {A4, A5, A3, LEGAL, …}
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic26.png" style="top:11.46%; left:84.21%; width:22.92%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic27.png" style="top:31.74%; left:99.18%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic28.png" style="top:60.83%; left:96.37%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Enumerations in Java
- Several formats are acceptable:
  - [Noun] or [Verb] or [Adjective]
- Use **PascalCase** for the enumeration		 and  **CAPITALS** for its members
- _Example_s:
  - **enum Suit** **{CLUBS,** **DIAMONDS,** **HEARTS, SPADES}**, **enum Color** **{RED,** **GREEN,** **BLUE,** **…}**
- Incorrect examples:
  - enum Color {red, green, blue, white},enum PAGE_FORMAT {A4, A5, A3, LEGAL, …}
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic29.png" style="top:13.22%; left:91.16%; width:14.61%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic30.png" style="top:40.88%; left:94.50%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic31.png" style="top:61.16%; left:95.08%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Special Classes
- Attributes
  - Add '**Attribute**' as suffix
  - _Example_: **WebServiceAttribute**
  - Incorrect example: WebService
- Collection Classes
  - Add '**Collection**' as suffix
  - _Example_: **StringsCollection**
  - Incorrect example: ListOfStrings
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic32.png" style="top:15.87%; left:83.27%; width:22.92%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Exceptions
  - Add '**Exception**' as suffix
  - Use informative name
  - _Example_: **FileNotFoundException**
  - Incorrect example: FileNotFoundError
- Delegate Classes
  - Add '**Delegate**' or '**EventHandler**' as suffix
  - _Example_: **DownloadFinishedDelegate**
  - Incorrect example: WakeUpNotification
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic33.png" style="top:14.24%; left:82.65%; width:20.86%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Length of Class Names
- How **long** could be the name of a class / struct / interface / enum / delegate?
  - The name should be **as long as required**
  - Don't abbreviate the names if thiscould make them unclear
  - Your IDE has autocomplete, right?
- _Example_s: **FileNotFoundException**, **CustomerSupportNotificationService**
- Incorrect examples: FNFException, CustSuppNotifSrvc
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic34.png" style="top:32.62%; left:84.16%; width:22.08%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic35.png" style="top:47.72%; left:92.51%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic36.png" style="top:66.34%; left:88.89%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Namespaces in C#
- Namespaces naming guidelines
  - Use **PascalCase**
- Following formats are acceptable:
  - **Company** **.** **Product** **.** **Component** **.****…**
  - **Product** **.** **Component** **.****…**
- _Example_:
  - **Telerik.WinControls.GridView**
- Incorrect examples:
  -  Telerik_WinControlsGridView, Classes
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic37.png" style="top:11.46%; left:81.21%; width:26.63%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic38.png" style="top:38.79%; left:84.21%; width:20.47%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic39.png" style="top:41.43%; left:71.64%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic40.png" style="top:59.94%; left:91.13%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Java Packages /JS Namespaces
- Packages naming guidelines
  - Use **camelCase**
- Following formats are acceptable:
  - **com** **.** **company** **.** **product** **.** **component** **.** **…**
  - **product** **.** **component** **.** **…**
- _Example_:
  - **com.apple.quicktime**, **hibernate.core**
- Incorrect examples:
  - IBM.DB2.Data, ibm.db2_data, Tetris.UI
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic41.png" style="top:16.75%; left:84.22%; width:19.86%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic42.png" style="top:43.20%; left:76.26%; width:11.46%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic43.png" style="top:65.23%; left:99.96%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Project Folders
- Project folders' names should follow the project namespaces / packages
- _Example_s:
  - **com**
    - **apple**
      - **quicktime**
  - **Telerik.WinControls.GridView**
- Incorrect examples:
  - com_apple_quicktime, quicktime.src
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic44.png" style="top:24.71%; left:74.85%; width:29.57%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic45.png" style="top:40.55%; left:47.72%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic46.png" style="top:60.83%; left:95.44%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Files in C# / Java
- Files with source code should have names matching their content
  - File containing a class **Student** should be names **Student.cs** / **student.java**
- _Example_:
  - **StudentDAO.cs**, **Constants.java**, **CryptographyAlgorithms.cs**
- Incorrect examples:
  - Program.cs, SourceCode.java, _d2.cs, WebApplication1.jsp, Page1.aspx
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic47.png" style="top:44.96%; left:87.95%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic48.png" style="top:63.47%; left:98.24%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Files in JavaScript
- Use **small letters and hyphens**for JavaScript file names (+ optionally **.min** + version)
  - Put a single library / component in a single file
- _Example_s:
  - **jquery-1.8.2.min.js**, **widgets.js**, **kendo.common.min.js**, **scriptaculous.js**
- Incorrect examples:
  - KendoUI.js, jQuery_classes.js, MyAjax.Library.js, jQuery-1.8.2.js
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic49.png" style="top:34.38%; left:95.44%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic50.png" style="top:59.94%; left:97.31%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming .NET Assemblies
- .NET assembly names should follow the root namespace in its class hierarchy
- _Example_s:
  - **Oracle.DataAccess.dll**
  - **Interop.CAPICOM.dll**
  - **Telerik.WinControls.GridView.dll**
- Incorrect examples:
  - OracleDataAccess.dll
  - Telerik_WinControlsGridView.dll
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic51.png" style="top:22.92%; left:81.40%; width:21.16%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic52.png" style="top:36.14%; left:67.37%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic53.png" style="top:61.71%; left:93.57%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming JAR Files in Java
- JAR files names should consist of single word or several words separated by hyphen
  - Can contain version information
- _Example_s:
  - **xalan25.jar**
  - **ant-apache-log4j.jar**
- Incorrect examples:
  - Ant.Apache.Log4J.jar
  - Oracle.JDBC.Drivers.jar
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic54.png" style="top:31.74%; left:73.92%; width:32.12%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic55.png" style="top:38.79%; left:62.69%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic56.png" style="top:59.06%; left:66.43%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Applications
- Applications should be named **meaningfully**
  - Use [Noun] or [Adjective] + [Noun]
  - Use **PascalCase**
- _Example_s:
  - **BlogEngine**
  - **NewsAggregatorSerivice**
- Incorrect examples:
  - ConsoleApplication4, WebSite2
  - zadacha_14, online_shop_temp2
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic57.png" style="top:29.09%; left:70.83%; width:32.89%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic58.png" style="top:37.02%; left:41.17%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic59.png" style="top:64.35%; left:88.43%; width:7.93%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Naming Methods and Method Parameters
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic60.png" style="top:12.09%; left:30.63%; width:47.60%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Methods
- Methods naming guidelines
  - Use meaningful method names
  - Method names should answer the question:
    - **What does this method do?**
  - If you cannot find a good name for a method, think about whether it has a **clear intent**
- _Example_s: **FindStudent**, **LoadReport**, **Sinus**
- Incorrect examples: Method1, DoSomething, HandleStuff, SampleMethod, DirtyHack
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic61.png" style="top:10.58%; left:81.40%; width:22.04%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic62.png" style="top:48.19%; left:101.99%; width:6.17%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic63.png" style="top:68.47%; left:102.77%; width:6.17%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Use **PascalCase**  for C# and **camelCase** for JavaScript, PHP and Java
  - _Example_ (C#): **LoadSettings**
  - _Example_ (JS/PHP/Java): **loadSettings**
- Prefer the following formats:
  - [Verb], [Verb] + [Noun],[Verb] + [Adjective] + [Noun]
- _Example_s: **Show**, **LoadSettingsFile**, **FindNodeByPattern**, **ToString**, **PrintList**
- Incorrect examples: Student, Generator, Counter, White, Approximation, MathUtils
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic64.png" style="top:36.14%; left:87.95%; width:16.75%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic65.png" style="top:21.74%; left:94.50%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic66.png" style="top:66.41%; left:101.78%; width:6.17%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic67.png" style="top:50.98%; left:92.63%; width:6.17%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Methods Returning a Value
- Methods returning values should **describe the returned value**
- _Example_s:
    - **ConvertMetersToInches**,not MetersInches or Convert or ConvertUnit
    - **Meters2Inches** is still acceptable
    - **CalculateSinus** is good but **Sinus**is still acceptable
  - Ensure that the unit of measure is obvious
    - Prefer MeasureFontInPixels to MeasureFont
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic68.png" style="top:20.42%; left:67.37%; width:36.14%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic69.png" style="top:34.97%; left:103.86%; width:6.17%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic70.png" style="top:26.27%; left:59.67%; width:6.17%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic71.png" style="top:51.13%; left:82.96%; width:9.11%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic72.png" style="top:42.75%; left:77.04%; width:6.17%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Single Purpose of All Methods
- Methods should have a **single purpose**!
  - Otherwise they cannot be named well
  - How to name a method that creates annual incomes report, downloads updates from internet and scans the system for viruses?
  - CreateAnnualIncomesReportDownloadUpdatesAndScanForViruses is a nice name, right?
- Methods that have multiple purposes (weak cohesion) are hard to be named
  - Need to be refactored instead of named
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic73.png" style="top:36.14%; left:101.99%; width:6.17%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Consistency in Methods Naming
- Use **consistent** naming in the entire project
  - **LoadFile**, **LoadImageFromFile**, **LoadSettings**, **LoadFont**, **LoadLibrary**, but not ReadTextFile
- Use consistently the opposites at the same level of abstraction:
  - **LoadLibrary** vs. **UnloadLibrary**,but not  FreeHandle
  - **OpenFile** vs. **CloseFile**, but not  DeallocateResource
  - **GetName** vs. **SetName**, but not  AssignName
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic74.png" style="top:44.96%; left:87.02%; width:15.87%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Length of Method Names
- How long could be the name of a method?
  - The name should be **as long as required**
  - Don't abbreviate
  - Your IDE has autocomplete
- _Example_s (C#):
  - **LoadCustomerSupportNotificationService**, **CreateMonthlyAndAnnualIncomesReport**
- Incorrect examples:
  - LoadCustSuppSrvc, CreateMonthIncReport
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic75.png" style="top:27.80%; left:71.91%; width:31.86%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic76.png" style="top:39.28%; left:43.04%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic77.png" style="top:59.94%; left:52.40%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Method Parameters
- Method parameters names
  - Preferred form: [Noun] or [Adjective] + [Noun]
  - Should be in **camelCase**
  - Should be meaningful
  - Unit of measure should be obvious
- _Example_s: **firstName**, **report**, **speedKmH**, **usersList**, **fontSizeInPixels**, **font**
- Incorrect examples: p, p1, p2, populate, LastName, last_name, convertImage
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic78.png" style="top:28.89%; left:86.08%; width:18.51%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic79.png" style="top:51.81%; left:98.24%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic80.png" style="top:64.74%; left:98.76%; width:7.93%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Naming Variables and Constants
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic81.png" style="top:11.93%; left:21.52%; width:64.79%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Variables
- Variable names
  - Should be in **camelCase**
  - Preferred form: [Noun] or [Adjective] + [Noun]
  - Should explain the purpose of the variable
    - If you can't find good name for a variable check if it has a single purpose
    - Exception: variables with very small scope, e.g. the index variable in a 3-lines long for-loop
  - Names should be consistent in the project
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic82.png" style="top:12.39%; left:69.24%; width:34.38%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Variables – _Example_
- _Example_s:
  - **firstName**, **report**, **config**, **usersList** , **fontSize**, **maxSpeed**, **font**, **startIndex**, **endIndex**, **charsCount**, **configSettingsXml**, **dbConnection**, **createUserSqlCommand**
- Incorrect examples:
  - foo, bar, p, p1, p2, populate, LastName, last_name, LAST_NAME, convertImage, moveMargin, MAXSpeed, _firtName, __temp, firstNameMiddleNameAndLastName
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic83.png" style="top:11.02%; left:75.79%; width:28.21%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic84.png" style="top:22.04%; left:99.44%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic85.png" style="top:52.89%; left:100.12%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# More about Naming Variables
- The name should address the problem we solve, not to the means used to solve it
  - Prefer nouns from the business domain to computer science terms
- _Example_s:
  - **accounts**, **customers**, **customerAddress**, **accountHolder**, **paymentPlan**, **vipPlayer**
- Incorrect examples:
  - paymentsPriorityQueue, playersArray, accountsLinkedList, customersHashtable
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic86.png" style="top:37.81%; left:100.12%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic87.png" style="top:57.50%; left:100.64%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Boolean Variables
- Give to boolean variables names that imply **true** or **false**
- Use positive boolean variable names
  - Incorrect example:
- _Example_s:
  - **hasPendingPayment**, **customerFound**, **validAddress**, **positiveBalance**, **isPrime**
- Incorrect examples:
  - notFound, findCustomerById, player, programStop, run, list, isUnsuccessfull
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic88.png" style="top:41.63%; left:95.75%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic89.png" style="top:61.32%; left:98.56%; width:7.93%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic90.png" style="top:31.29%; left:97.36%; width:5.73%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Special Variables
- Naming counters
  - Establish a convention, e.g. [Noun] + '**Count**'
  - _Example_s: **ticketsCount**, **customersCount**
- State
  - Establish a convention, e.g. [Noun] + '**State**'
  - _Example_s: **blogParseState**, **threadState**
- Variables with small scope and span
  - E.g. loop counters
  - Short names can be used, e.g. **index**, **i**, **u**
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic91.png" style="top:10.58%; left:73.92%; width:25.56%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Temporary Variables
- Do you really think **temporary** variables exist?
  - All variables in the program are temporary because are used temporary only during the program execution, right?
- Temporary variables can always be named better than temp or tmp:

```cs
// Swap a[i] and a[j]
int temp = a[i];
a[i] = a[j];
a[j] = temp;
```


```cs
// Swap a[i] and a[j]
int oldValue = a[i];
a[i] = a[j];
a[j] = oldValue;
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic92.png" style="top:62.10%; left:94.92%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic93.png" style="top:62.54%; left:40.34%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Length of Variable Names
- How long could be the name of a variable?
  - Depends on the variable scope and live time
  - More "famous" variables should have longer and more descriptive name
- Acceptable naming examples:
- Unacceptable naming examples:

```cs
for (int i=0; i<users.Length; i++)
  if (i % 2 == 0)
    sum += users[i].Weight;
```


```cs
class Student {
  public string lastName;
}
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic94.png" style="top:37.81%; left:96.84%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic95.png" style="top:61.65%; left:55.20%; width:7.93%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic96.png" style="top:61.71%; left:96.37%; width:7.93%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic97.png" style="top:46.97%; left:52.71%; width:7.30%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Constants in C#
- Use **CAPITAL_LETTERS** or **PascalCase**for **const** fields and **PascalCase** for **readonly**
- Use meaningful names that describe their value
- _Example_s:
- Incorrect examples:

```cs
private const int READ_BUFFER_SIZE = 8192;
public static readonly PageSize DefaultPageSize = PageSize.A4;
private const int FONT_SIZE_IN_POINTS = 16;
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic98.png" style="top:9.67%; left:95.68%; width:6.60%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic99.png" style="top:33.43%; left:99.18%; width:8.82%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic100.png" style="top:54.75%; left:100.32%; width:7.93%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Constants inJavaScript, Java, PHP and C++
- Use **CAPITAL_LETTERS** for JavaScript /Java / PHP / C++ constants
- Use meaningful names
  - Constants should describe their value
- _Example_s:
- Incorrect examples:

```cs
public static final int READ_BUFFER_SIZE = 8192;
public static final PageSize DEFAULT_PAGE_SIZE = PageSize.A4;
public static final int FONT_SIZE_IN_POINTS = 16;
```

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic101.png" style="top:19.88%; left:87.95%; width:16.70%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Other Naming Guidelines 
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic102.png" style="top:14.10%; left:25.02%; width:58.18%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Names to Avoid
- Don't use **numbers** in the identifiers names
  - _Example_: 
    - **PrintReport** and PrintReport2
    - What is the difference?
  - Exceptions:
    - When the number is part of the name itself,e.g. **RS232Port**, **COM3**, **Win32APIFunctions**
- Don't use Cyrillic or letters from other alphabet
  - FindСтудентByName, DisplayΩ2Protein
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic103.png" style="top:21.05%; left:84.01%; width:22.23%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic104.png" style="top:20.46%; left:40.43%; width:5.99%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic105.png" style="top:20.28%; left:77.56%; width:5.39%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic106.png" style="top:44.08%; left:99.18%; width:7.46%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic107.png" style="top:64.16%; left:101.41%; width:6.71%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Never Give Misleading Name!
- Giving a misleading name is even worse than giving a totally unclear name
- _Example_:
  - Consider a method that calculates the sum of all elements in an array
  - Its should be named **Sum** or **CalculateSum**
  - What about naming it CalculateAverageor Max or CheckForNegativeNumber?
  - It's crazy, but be careful with "copy-paste"
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic108.png" style="top:42.38%; left:100.00%; width:6.98%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic109.png" style="top:55.54%; left:100.93%; width:6.28%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# What's Wrong with This Code?
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic110.png" style="top:22.88%; left:85.14%; width:14.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Identifiers

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
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic111.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic112.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic113.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic114.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1" /> -->




