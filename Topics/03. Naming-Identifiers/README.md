<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Naming Identifiers
## Naming Variables, Methods, Classes, Etc.
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic02.png" style="top:65%; left:85%; width:17.08%; z-index:-1; border-radius:10px;" /> -->
<div class="signature">
	<p class="signature-course">High-Quality Code - Part 1</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="https://academy.telerik.com " class="signature-link">https://academy.telerik.com </a>
</div>




<!-- section start -->
<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [General Naming Guidelines](#naming-guidelines)
  - The Power of Meaningful Names
- [Naming Classes / Types / Applications](#naming-classes)
  - Naming Classes, Interfaces, Types, Delegates, Enumerations, Namespaces, Files, Folders, Assemblies, Applications
- [Naming Methods and Method Parameters](#naming-methods)
- [Naming Variables and Constants](#naming-variables)
- [Other Naming Guidelines](#other)




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # General Naming Guidelines -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic04.png" style="top:45%; left:35%; width:30%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'naming-guidelines', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="naming-guidelines"></a>General Naming Guidelines
- Always use **English**
  - How will you feel if you read Vietnamese code with variables named in Vietnamese?
  - English is the only language that all software developers speak
- Avoid abbreviations except accepted ones
  - _Example_: **scrpCnt** vs. `scriptsCount`
- Avoid hard-to-pronounce names
  - _Example_: **dtbgRegExPtrn** vs. `dateTimeBulgarianRegExPattern`
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:59.94%; left:89.82%; width:15.51%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Use Meaningful Names
- Always prefer **meaningful names**
  - Names should answer these questions:
    - **What does this class do? What is the intent of this variable? What is this variable / class used for?**
  - Correct examples:
    - **FactorialCalculator**, **studentsCount**, **Math.PI**, **configFileName**, **CreateReport**
  - Incorrect examples:
    - **k, k2, k3, junk, f33, KJJ, button1, variable, temp, tmp, temp_var, something, someValue**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:42%; left:85%; width:9.07%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic08.png" style="top:75%; left:85%; width:7.52%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Names Should Be <br /> Meaningful in Their Context
- Whether a name is meaningful or not depends on its **context** (its enclosing type)
- _Examples_ of meaningful names:
  - **Generate()** in the class **LabyrinthGenerator**
  - **Find(string** **fileName)** in the class **FileFinder**
  - **Deposit(decimal** **amount)** in the class **Account**
- _Examples_ of meaningless names:
  - **Generate()** in the class **Program**
  - **Find(string name)** in the class **Program**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:35%; left:85%; width:9.07%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:70%; left:85%; width:9.14%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Fake Meaningful Names
- Junior developers often use “**fake**” meaningful names that are in fact meaningless
  - Bad naming examples:
    - **Topic6Exercise12, LoopsExercise12, Problem7, OOPLecture_LastExercise**
  - Yes, **Topic6Exercise12** indicates that this is solution to exercise 12, but what is it about?
    - Sum of numbers or Tetris game?
  - Better naming:
    - **MaximalNumbersSubsequence**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic12.png" style="top:70%; left:69.60%; width:10%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic13.png" style="top:32%; left:88%; width:9.14%; z-index:-1; border-radius:10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Naming Classes, Types and Application Components -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic14.png" style="top:55%; left:35%; width:35%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'naming-classes', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="naming-classes"></a>Naming Classes and Types
- Naming types (classes, structures, etc.)
  - Use **PascalCase** character casing
    - In C#, JavaScript, Java, PHP
  - Correct examples:
    - **RecursiveFactorialCalculator**, **TreeSet**, **XmlDocument**, **IEnumerable**, **Color**, **TreeNode**, **InvalidTransactionException**, **MainForm**
  - Incorrect examples:
    - **recursiveFactorialCalculator, recursive_factorial_calculator,  RECURSIVE_FACTORIAL_CALCULATOR**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:26.45%; left:85%; width:10.58%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:62.51%; left:85%; width:10.66%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 0.9em' } -->
# Naming Classes and <br /> Structures in C#, JavaScript, C++ and Java
- Use the following formats:
  - [Noun]
  - [Adjective] + [Noun]
- Correct examples:
  - **Student**, **FileSystem**, **BinaryTreeNode**, **Constants**, **MathUtils**, **CheckBox**, **Calendar**
- Incorrect examples:
  - **Move, FindUsers, Fast, ExtremlyFast, Optimize, Check,  FastFindInDatabase**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:45%; left:85%; width:7.76%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic19.png" style="top:67%; left:85%; width:7.48%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Interfaces in C&num;
- Following formats are acceptable:
  - '**I**' + [Verb] + '**able**'
  - '**I**' + [Noun], '**I**' + [Adjective] + [Noun]
- Correct examples:
  - **IEnumerable**, **IFormattable**, **IDataReader**,**IList**, **IHttpModule**,**ICommandExecutor**
- Incorrect examples:
  - **List, iFindUsers, IFast, IMemoryOptimize, Optimizer, FastFindInDatabase, CheckBox**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic21.png" style="top:33.50%; left:85%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic22.png" style="top:60%; left:85%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Interfaces in Java
- Following formats are acceptable:
  - [Verb] + '**able**'
  - [Noun], [Adjective] + [Noun]
- Correct examples:
  - **Serializable** , **Enumerable**, **Comparable**, **Runnable**, **CharSequence**, **OutputStream**
- Incorrect examples:
  - **list, FindUsers, Run, Inumber, OPTIMIZER, IMemoryOptimize, FastFindInDatabase**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic24.png" style="top:30%; left:65%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic25.png" style="top:57%; left:85%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Enumerations in C&num;
- Several formats are acceptable:
  - [Noun] or [Verb] or [Adjective]
- Use the same style for all members
- Correct examples:
  - **enum Day {Monday,** **Tuesday,** **Wednesday,** **…}**, **enum AppState {Running,** **Finished,** **…}**, 	 **enum WindowState {Normal,** **Maximized,** **…}**
- Incorrect examples:
  - **enum Color {red, green, blue, white},enum PAGE_FORMAT {A4, A5, A3, LEGAL, …}**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic27.png" style="top:31.74%; left:85%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic28.png" style="top:65%; left:85%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.9em' } -->
# Naming Enumerations<br /> in Java
- Several formats are acceptable:
  - [Noun] or [Verb] or [Adjective]
- Use **PascalCase** for the enumeration		 and  **CAPITALS** for its members
- Correct examples:
  - **enum Suit** **{CLUBS,** **DIAMONDS,** **HEARTS, SPADES}**, **enum Color** **{RED,** **GREEN,** **BLUE,** **…}**
- Incorrect examples:
  - **enum Color {red, green, blue, white},enum PAGE_FORMAT {A4, A5, A3, LEGAL, …}**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic30.png" style="top:43%; left:85%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic31.png" style="top:67%; left:85%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Special Classes
- Attributes
  - Add '**Attribute**' as suffix
  - Correct example: **WebServiceAttribute**
  - Incorrect example: **WebService**
- Collection Classes
  - Add '**Collection**' as suffix
  - Correct example: **StringsCollection**
  - Incorrect example: **ListOfStrings**


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Naming Special Classes -->
- Exceptions
  - Add '**Exception**' as suffix
  - Use informative name
  - Correct example: **FileNotFoundException**
  - Incorrect example: **FileNotFoundError**
- Delegate Classes
  - Add '**Delegate**' or '**EventHandler**' as suffix
  - Correct example: **DownloadFinishedDelegate**
  - Incorrect example: **akeUpNotification**


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Length of Class Names
- How **long** could be the name of a class / struct / interface / enum / delegate?
  - The name should be **as long as required**
  - Don't abbreviate the names if this could make them unclear
  - Your IDE has autocomplete, right?
- Correct examples: **FileNotFoundException**, **CustomerSupportNotificationService**
- Incorrect examples: **FNFException, CustSuppNotifSrvc**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic34.png" style="top:22%; left:84.16%; width:15%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic35.png" style="top:55%; left:90%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic36.png" style="top:75%; left:88.89%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Namespaces in C&num;
- Namespaces naming guidelines
  - Use **PascalCase**
- Following formats are acceptable:
  - **Company** **.** **Product** **.** **Component** **.****…**
  - **Product** **.** **Component** **.****…**
- Correct example:
  - **Telerik.WinControls.GridView**
- Incorrect examples:
  -  **Telerik_WinControlsGridView, Classes**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic39.png" style="top:50%; left:71.64%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic40.png" style="top:70%; left:85%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Java Packages /JS Namespaces
- Packages naming guidelines
  - Use **camelCase**
- Following formats are acceptable:
  - **com** **.** **company** **.** **product** **.** **component** **.** **…**
  - **product** **.** **component** **.** **…**
- Correct examples:
  - **com.apple.quicktime**, **hibernate.core**
- Incorrect examples:
  - **IBM.DB2.Data, ibm.db2_data, Tetris.UI**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic41.png" style="top:20%; left:84.22%; width:15%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic42.png" style="top:55%; left:76.26%; width:10%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic43.png" style="top:75%; left:85%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Project Folders
- Project folders' names should follow the project namespaces / packages
- Correct examples:
  - **com**
    - **apple**
      - **quicktime**
  - **Telerik.WinControls.GridView**
- Incorrect examples:
  - **com_apple_quicktime, quicktime.src**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic44.png" style="top:24.71%; left:74.85%; width:29.57%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic45.png" style="top:30%; left:47.72%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic46.png" style="top:65%; left:80%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Files in C# / Java
- Files with source code should have names matching their content
  - File containing a class **Student** should be named **Student.cs** / **student.java**
-  Correct examples:
  - **StudentDAO.cs**, **Constants.java**, **CryptographyAlgorithms.cs**
- Incorrect examples:
  - **Program.cs, SourceCode.java, _d2.cs, WebApplication1.jsp, Page1.aspx**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic47.png" style="top:44.96%; left:75%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic48.png" style="top:67%; left:75%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Files in JavaScript
- Use **small letters and hyphens**for JavaScript file names (+ optionally **.min** + version)
  - Put a single library / component in a single file
-  Correct examples:
  - **jquery-1.8.2.min.js**, **widgets.js**, **kendo.common.min.js**, **scriptaculous.js**
- Incorrect examples:
  - **KendoUI.js, jQuery_classes.js, MyAjax.Library.js, jQuery-1.8.2.js**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic49.png" style="top:34.38%; left:90%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic50.png" style="top:57%; left:90%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming .NET Assemblies
- .NET assembly names should follow the root namespace in its class hierarchy
- Correct examples:
  - **Oracle.DataAccess.dll**
  - **Interop.CAPICOM.dll**
  - **Telerik.WinControls.GridView.dll**
- Incorrect examples:
  - **OracleDataAccess.dll**
  - **Telerik_WinControlsGridView.dll**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic51.png" style="top:22.92%; left:81.40%; width:21.16%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic52.png" style="top:36.14%; left:67.37%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic53.png" style="top:61.71%; left:67%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming JAR Files in Java
- JAR files names should consist of single word or several words separated by hyphen
  - Can contain version information
- Correct examples:
  - **xalan25.jar**
  - **ant-apache-log4j.jar**
- Incorrect examples:
  - **Ant.Apache.Log4J.jar**
  - **Oracle.JDBC.Drivers.jar**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic55.png" style="top:38.79%; left:65%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic56.png" style="top:59.06%; left:65%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Applications
- Applications should be named **meaningfully**
  - Use [Noun] or [Adjective] + [Noun]
  - Use **PascalCase**
- Correct examples:
  - **BlogEngine**
  - **NewsAggregatorSerivice**
- Incorrect examples:
  - **ConsoleApplication4, WebSite2**
  - **zadacha_14, online_shop_temp2**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic57.png" style="top:29.09%; left:70.83%; width:32.89%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic58.png" style="top:37.02%; left:47%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic59.png" style="top:64.35%; left:75%; width:7.93%; z-index:-1; border-radius:10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Naming Methods and Method Parameters -->


<!-- attr: { id:'naming-methods', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="naming-methods"></a> Naming Methods
- Methods naming guidelines
  - Use meaningful method names
  - Method names should answer the question:
    - **What does this method do?**
  - If you cannot find a good name for a method, think about whether it has a **clear intent**
- Correct examples: **FindStudent**, **LoadReport**, **Sinus**
- Incorrect examples: **Method1, DoSomething, HandleStuff, SampleMethod, DirtyHack**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic62.png" style="top:53%; left:93%; width:6.17%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic63.png" style="top:70%; left:93%; width:6.17%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Naming Methods  -->
- Use **PascalCase**  for C# and **camelCase** for JavaScript, PHP and Java
  - _Example_ (C#): **LoadSettings**
  - _Example_ (JS/PHP/Java): **loadSettings**
- Prefer the following formats:
  - [Verb], [Verb] + [Noun],[Verb] + [Adjective] + [Noun]
- Correct examples: **Show**, **LoadSettingsFile**, **FindNodeByPattern**, **ToString**, **PrintList**
- Incorrect examples: **Student, Generator, Counter, White, Approximation, MathUtils**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic65.png" style="top:21.74%; left:90%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic66.png" style="top:75%; left:90%; width:6.17%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic67.png" style="top:60%; left:90%; width:6.17%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Methods Returning a Value
- Methods returning values should **describe the returned value**
- _Examples_:
    - **ConvertMetersToInches**, not MetersInches or Convert or ConvertUnit
    - **Meters2Inches** is still acceptable
    - **CalculateSinus** is good but **Sinus** is still acceptable
  - Ensure that the unit of measure is obvious
    - Prefer **MeasureFontInPixels** to **MeasureFont**


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Single Purpose of All Methods
- Methods should have a **single purpose**!
  - Otherwise they cannot be named well
  - How to name a method that creates annual incomes report, downloads updates from internet and scans the system for viruses?
  - <div style="font-size: 36px">CreateAnnualIncomesReportDownloadUpdatesAndScanForViruses</div> is a nice name, right?
  - `You don't do this! No really! Never!`
- Methods that have multiple purposes (weak cohesion) are hard to be named
  - Need to be refactored instead of named
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic73.png" style="top:50%; left:0%; width:6.17%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Consistency <br /> in Methods Naming
- Use **consistent** naming in the entire project
  - **LoadFile**, **LoadImageFromFile**, **LoadSettings**, **LoadFont**, **LoadLibrary**, but not ReadTextFile
- Use consistently the opposites at the same level of abstraction:
  - **LoadLibrary** vs. **UnloadLibrary**, but NOT  FreeHandle
  - **OpenFile** vs. **CloseFile**, but NOT  DeallocateResource
  - **GetName** vs. **SetName**, but NOT  AssignName
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic74.png" style="top:44.96%; left:87.02%; width:15.87%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Length of Method Names
- How long could be the name of a method?
  - The name should be **as long as required**
  - Don't abbreviate
  - Your IDE has autocomplete
- Correct examples (C#):
  - **LoadCustomerSupportNotificationService**, **CreateMonthlyAndAnnualIncomesReport**
- Incorrect examples:
  - **LoadCustSuppSrvc, CreateMonthIncReport**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic76.png" style="top:39.28%; left:85%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic77.png" style="top:65%; left:85%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Method Parameters
- Method parameters names
  - Preferred form: [Noun] or [Adjective] + [Noun]
  - Should be in **camelCase**
  - Should be meaningful
  - Unit of measure should be obvious
- Correct examples: **firstName**, **report**, **speedKmH**, **usersList**, **fontSizeInPixels**, **font**
- Incorrect examples: **p, p1, p2, populate, LastName, last_name, convertImage**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic79.png" style="top:51.81%; left:90%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic80.png" style="top:70%; left:85%; width:7.93%; z-index:-1; border-radius:10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Naming Variables and Constants -->


<!-- attr: { id:'naming-variables', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="naming-variables"></a>Naming Variables
- Variable names
  - Should be in **camelCase**
  - Preferred form: **[Noun]** or **[Adjective] + [Noun]**
  - Should explain the purpose of the variable
    - If you can't find good name for a variable check if it has a single purpose
    - `Exception:` variables with very small scope, e.g. the index variable in a 3-lines long for-loop
  - Names should be consistent in the project


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Variables – _Example_
- Correct examples:
  - **firstName**, **report**, **config**, **usersList** , **fontSize**, **maxSpeed**, **font**, **startIndex**, **endIndex**, **charsCount**, **configSettingsXml**, **dbConnection**, **createUserSqlCommand**
- Incorrect examples:
  - **foo, bar, p, p1, p2, populate, LastName, last_name, LAST_NAME, convertImage, moveMargin, MAXSpeed, _firtName, __temp, firstNameMiddleNameAndLastName**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic84.png" style="top:35%; left:85%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic85.png" style="top:75%; left:85%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# More about Naming Variables
- The name should address the problem we solve, not to the means used to solve it
  - Prefer nouns from the business domain to computer science terms
- Correct examples:
  - **accounts**, **customers**, **customerAddress**, **accountHolder**, **paymentPlan**, **vipPlayer**
- Incorrect examples:
  - **paymentsPriorityQueue, playersArray, accountsLinkedList, customersHashtable**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic86.png" style="top:40%; left:85%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic87.png" style="top:65%; left:85%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Boolean Variables
- Give to boolean variables names that imply `true` or `false`
- Use positive boolean variable names
  - Incorrect example:
-  Correct examples:
  - **hasPendingPayment**, **customerFound**, **validAddress**, **positiveBalance**, **isPrime**
- Incorrect examples:
  - **notFound, findCustomerById, player, programStop, run, list, isUnsuccessfull**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic88.png" style="top:41.63%; left:85%; width:8.82%; z-index:-1; border-radius:10px;" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic89.png" style="top:70%; left:85%; width:7.93%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Naming Special Variables
- Naming counters
  - Establish a convention, e.g. [Noun] + '**Count**'
  - _Examples_: **ticketsCount**, **customersCount**
- State
  - Establish a convention, e.g. [Noun] + '**State**'
  - _Examples_: **blogParseState**, **threadState**
- Variables with small scope and span
  - E.g. loop counters
  - Short names can be used, e.g. **index**, **i**, **u**


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Temporary Variables
- Do you really think **temporary** variables exist?
  - All variables in the program are temporary because are used temporary only during the program execution, right?
- Temporary variables can always be named better than **temp** or **tmp**:

```cs
// Swap a[i] and a[j]
int temp = a[i]; (why not? int oldValue = a[i];)
a[i] = a[j];
a[j] = temp; (a[j] = oldValue;)
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The Length of Variable Names
- How long could be the name of a variable?
  - Depends on the variable scope and live time
  - More "famous" variables should have longer and more descriptive name
- Acceptable naming examples:
<br />
<br />
<br />
<!-- <img class="slide-image" showInPresentation="true" src="imgs\acceptable.png" style="top:43%; left:0%; width:100%; z-index:-1; border-radius:10px;" /> -->
- Unacceptable naming examples:



<!-- <img class="slide-image" showInPresentation="true" src="imgs\unacceptable.png" style="top:73%; left:0%; width:100%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.9em' } -->
# Naming Constants in C&num;
- Use **CAPITAL_LETTERS** or **PascalCase** for **const** fields and **PascalCase** for **readonly**
- Use meaningful names that describe their value
- Correct examples:

```cs
private const int READ_BUFFER_SIZE = 8192;
public static readonly PageSize DefaultPageSize = PageSize.A4;
private const int FONT_SIZE_IN_POINTS = 16;
```

- Incorrect examples:

```cs
public const int MAX = 512; // Max what? Apples or Oranges?
public const int BUF256 = 256; // What about BUF256 = 1024?
public const string GREATER = "&gt;"; // GREATER_HTML_ENTITY
public const int FONT_SIZE = 16; // 16pt or 16px?
public const PageSize PAGE = PageSize.A4; // Maybe PAGE_SIZE?
```




<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.9em' } -->
# Naming Constants
- Use **CAPITAL_LETTERS** for JavaScript /Java / PHP / C++ constants
- Use meaningful names
  - Constants should describe their value
- Correct examples:

```cs
public static final int READ_BUFFER_SIZE = 8192;
public static final PageSize DEFAULT_PAGE_SIZE = PageSize.A4;
public static final int FONT_SIZE_IN_POINTS = 16;
```

- Incorrect examples:

```cs
public static final int NAME = "BMW"; // What name? Car name?
public static final int BufSize = 256; // Use CAPITALS
public static final int font_size_pixels = 16; // CAPITALS
```


<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Other Naming Guidelines -->


<!-- attr: { id:"other", showInPresentation:true, hasScriptWrapper:true } -->
# <a id="other"></a> Names to Avoid
- Don't use **numbers** in the identifiers names
  - _Example_:
    - **PrintReport** and **PrintReport2**
    - What is the difference?
  - Exceptions:
    - When the number is part of the name itself,e.g. **RS232Port**, **COM3**, **Win32APIFunctions**
- Don't use Cyrillic or letters from other alphabet
  - FindСтудентByName, DisplayΩ2Protein
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic103.png" style="top:21.05%; left:84.01%; width:22.23%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Never Give Misleading Name!
- Giving a misleading name is even worse than giving a totally unclear name
- _Example_:
  - Consider a method that calculates the sum of all elements in an array
  - Its should be named **Sum** or **CalculateSum**
  - What about naming it **CalculateAverage** or **Max** or **CheckForNegativeNumber**?
  - It's crazy, but be careful with "copy-paste"


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.9em' } -->
# What's Wrong with This Code?
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic110.png" style="top:22.88%; left:85.14%; width:14.14%; z-index:1; border-radius:10px;" /> -->

```cs
FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew);
// Create the writer for data.
BinaryWriter w = new BinaryWriter(fs);
// Write data to Test.data.
for (int i = 0; i < 11; i++)
{
  w.Write( (int) i);
}
w.Close();
fs.Close();
// Create the reader for data.
fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
BinaryReader r = new BinaryReader(fs);
// Read data from Test.data.
for (int i = 0; i < 11; i++)
{
  Console.WriteLine(r.ReadInt32());
}
r.Close();
fs.Close();
```


<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # HQC-Part 1: Naming Identifiers
## Questions? -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - [HQC-Part 1 course](http://academy.telerik.com/student-courses/programming/high-quality-code-part-1/about)
  - Telerik Software Academy
    - [telerikacademy.com](https://telerikacademy.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Software Academy Forums
    - [forums.academy.telerik.com](forums.academy.telerik.com)
