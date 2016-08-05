<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# High-Quality Classesand Class Hierarchies
## Best Practices in the Object-Oriented Design
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic00.png" style="top:53.10%; left:59.47%; width:43.40%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic01.png" style="top:49.16%; left:52.40%; width:17.08%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic02.png" style="top:18.03%; left:6.55%; width:14.24%; z-index:-1" /> -->
<div class="signature">
	<p class="signature-course">- High-Quality Code</p>
	<p class="signature-initiative">- Telerik Software Academy</p>
	<a href="- http://academy.telerik.com " class="signature-link">- http://academy.telerik.com </a>
</div>




<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- Basic Principles
  - Cohesion, Coupling,Inheritance, Polymorphism
- High-Quality Classes
  - Good Abstraction, Correct Encapsulation, Correct Inheritance
  - Class Methods, Constructors, Data
  - Good Reasons to Create a Class
- Typical Mistakes to Avoid in OO Design
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic03.png" style="top:11.46%; left:79.24%; width:24.96%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Basic Principles
## Cohesion, Coupling,Inheritance and Polymorphism
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic04.png" style="top:12.34%; left:32.75%; width:44.08%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Cohesion
- **Cohesion** measures how closely are all the routines in a class/module
  - Cohesion must be **strong**
  - Classes must contain strongly related functionality and aim for **single purpose**
- **Strong cohesion** is a useful tool for managing complexity 
  - Well-defined abstractions keep cohesion strong
  - Bad abstractions have weak cohesion


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Good and Bad Cohesion
- Good: hard disk, CD-ROM, floppy
- Bad: spaghetti code
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:20.51%; left:6.55%; width:26.22%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:20.28%; left:39.30%; width:27.89%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:21.28%; left:73.92%; width:29.09%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic08.png" style="top:52.01%; left:9.13%; width:17.85%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:52.89%; left:37.43%; width:18.84%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:45.51%; left:67.64%; width:33.35%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Strong Cohesion
- Strong cohesion example
  - Class **System.****Math**
    - **Sin()**, **Cos()**, **Asin()**
    - **Sqrt()**, **Pow()**, **Exp()**
    - **Math.PI**, **Math.E**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:45.84%; left:96.31%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Coupling
- **Coupling** describes how tightly a class or routine is related to other classes or routines
- Coupling must be kept **loose**
  - Modules must depend little on each other 
  - All classes and routines must have
    - Small, direct, visible, and flexible relationships to other classes and routines
  - One module must be easily used by other modules, without complex dependencies


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Loose and Tight Coupling
- **Loose Coupling**
  - Easily replace old HDD
  - Easily place this HDD to another motherboard
- Tight Coupling
  - Where is the video adapter?
  - Can you change the video controller on this MB?
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic12.png" style="top:47.25%; left:70.17%; width:31.74%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic13.png" style="top:14.05%; left:70.17%; width:31.74%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic14.png" style="top:11.40%; left:96.37%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:45.46%; left:96.37%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Loose Coupling – _Example_
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:12.34%; left:92.49%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Tight Coupling – _Example_
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:13.22%; left:93.57%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Inheritance
- **Inheritance** is the ability of a class to implicitly gain all members from another class
  - Inheritance is principal concept in OOP
  - The class whose methods are inherited is called **base** (parent) class
  - The class that gains new functionality is called **derived** (child) class
- Use inheritance to:
  - **Reuse repeating code**: data and program logic
  - Simplify code maintenance


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Inheritance in C# and JS
- In **C#** all class members are inherited
  - Fields, methods, properties, etc.
  - Structures cannot be inherited, only classes
  - No multiple inheritance is supported
  - Only multiple interface implementations
- In **JS**inheritance is supported indirectly
  - Several ways to implement inheritance
  - Multiple inheritance is not supported
  - There are no interfaces (JS is typeless language)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Polymorphism 
- **Polymorphism** is a principal concept in OOP
- The ability to handle the objects of a specific class as instances of its parent class
  - To call abstract functionality
- Polymorphism allows to create hierarchies with more valuable logical structure
- Polymorphism is a tool to enable **code reuse**
  - Common logic is taken to the base class
  - Specific logic is implemented in the derived class in a overridden method


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Polymorphism in C# and JS
- In C# polymorphism is implemented through:
  - Virtual methods (**virtual**) 
  - Abstract methods (**abstract**)
  - Interfaces methods (**interface**)
- In C# **override** overrides a virtual method
- In JavaScript **all methods are virtual**
  - The child class can just "override" any method from any object
  - There are no interfaces (JS is typeless language)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Polymorphism – _Example_
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:64.35%; left:91.43%; width:9.07%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# High-Quality Classes
## How to Design High-Quality Classes? Abstraction, Cohesion and Coupling
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic19.png" style="top:12.55%; left:40.23%; width:29.09%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# High-Quality Classes: Abstraction
- Present a consistent level of **abstraction** in the class contract (publicly visible members)
  - What abstraction the class is implementing?
  - Does it represent only one thing?
  - Does the class name well describe its purpose?
  - Does the class define clear and easy to understand public interface?
  - Does the class hide all its implementation details?


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Good Abstraction – _Example_
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic20.png" style="top:13.35%; left:97.31%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Bad Abstraction – _Example_
<div class="fragment balloon" style="top:15.13%; left:50.34%; width:41.43%">Does this class really represents a "program"? Is this name good?</div>
<div class="fragment balloon" style="top:61.01%; left:73.36%; width:27.33%">Does this class really have a single purpose?</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic21.png" style="top:9.75%; left:99.78%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Establishing Good Abstraction
- Define operations along with their opposites, e.g.
  - **Open()** and **Close()**
- Move unrelated methods in another class, e.g.
  - In class **Employee** if you need to calculate **Age** by given **DateOfBirth**
  - Create а static method **CalcAgeByBirthDate(…)** in a separate class **DateUtils**
- Group related methods intro a single class
- Does the class name correspond to the class content?


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Beware of breaking the interface abstraction due to evolution
  - Don't add public members inconsistent with abstraction
  - _Example_: in class called **Employee** at some time we add method for accessing the DB with SQL
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic22.png" style="top:52.01%; left:93.57%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Encapsulation
- Minimize visibility of classes and members
  - In C# start from **private** and move to **internal**, **protected** and **public** if required
- Classes should hide their implementation details
  - A principle called **encapsulation** in OOP
  - Anything which is not part of the class interface should be declared **private**
  - Classes with good encapsulated classes are: less complex, easier to maintain, more loosely coupled
- Classes should keep their state clean &rarr; throw an exception if invalid data is being assigned


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Never declare fields public (except constants)
  - Use properties / methods to access the fields
- Don't put private implementation details in the public interface
  - All public members should be consistent with the abstraction represented by the class
- Don't make a method public just because it calls only public methods
- Don't make assumptions about how the class will be used or will not be used


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Don't violate encapsulation semantically!
  - Don't rely on non-documented internal behavior or side effects
  - Wrong example: 
    - Skip calling ConnectToDB() because you just called FindEmployeeById() which should open connection
  - Another wrong example:
    - Use String.Empty instead of **Titles.NoTitle** because you know both values are the same
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic23.png" style="top:33.83%; left:101.78%; width:6.91%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic24.png" style="top:54.82%; left:101.78%; width:6.91%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Inheritance or Containment?
- Containment is "**has a**" relationship
  - _Example_: **Keyboard** has a set of **Key**s
- Inheritance is "**is a**" relationship
  - Design for inheritance: make the class **abstract**
  - Disallow inheritance: make the class **sealed**
  - Subclasses must be usable through the base class interface
    - Without the need for the user to know the difference


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Inheritance
- Don't hide methods in a subclass
  - _Example_: if the class **Timer** has private method **Start()**, don't define **Start()** in **AtomTimer**
- Move common interfaces, data, and behavior as high as possible in the inheritance tree
  - This maximizes the code reuse
- Be suspicious of base classes of which there is only one derived class
  - Do you really need this additional level of inheritance?


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Be suspicious of classes that override a routine and **do nothing**inside
  - Is the overridden routine used correctly?
- Avoid **deep inheritance**trees
  - Don't create more than 6 levels of inheritance
- Avoid using a base class’s protected data fields in a derived class
  - Provide protected accessor methods or properties instead


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Prefer inheritance to extensive type checking:
- Consider inheriting **Circle** and **Square** from **Shape** and override the abstract action **Draw()**
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic25.png" style="top:47.00%; left:91.63%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Class Methods and Data
- Keep the number of methods in a class as small as possible &rarr; reduce complexity
- Minimize direct methods calls to other classes
  - Minimize indirect methods calls to other classes
  - Less external method calls == less coupling
  - Also known as "**fan-out**"
- Minimize the extent to which a class collaborates with other classes
  - Reduce the **coupling** between classes


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Class Constructors
- Initialize all member data in all constructors, if possible
  - Uninitialized data is error prone
  - Partially initialized data is even more evil
  - Incorrect example: assign **FirstName** in class **Person** but leave **LastName** empty
- Initialize data members in the same order in which they are declared
- Prefer deep copies to shallow copies (**ICloneable** should make deep copy)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Use Design Patterns
- Use private constructor to prohibit direct class instantiation
- Use design patterns for common design situations
  - **Creational patterns**like Singleton, Factory Method, Abstract Factory
  - **Structural patterns**like Adapter, Bridge, Composite, Decorator, Façade
  - **Behavioral patterns**like Command, Iterator, Observer, Strategy, Template Method


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Top Reasons to Create Class
- Model real-world objects with OOP classes
- Model abstract objects, processes, etc.
- Reduce complexity
  - Work at higher level
- Isolate complexity
  - Hide it in a class
- Hide implementation details &rarr; encapsulation
- Limit effects of changes
  - Changes affect only their class


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Hide global data
  - Work through methods
- Group variables that are used together
- Make central points of control
  - Single task should be done at single place
  - Avoid duplicating code
- Facilitate code reuse
  - Use class hierarchies and virtual methods
- Package related operations together


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Namespaces
- Group related classes together in namespaces
- Follow consistent naming convention
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic26.png" style="top:27.08%; left:93.57%; width:9.07%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Typical Mistakes to Avoid
## Lessons Learned from theOOP Exam at Telerik Software Academy
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic27.png" style="top:11.46%; left:31.05%; width:46.83%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic28.png" style="top:32.62%; left:44.83%; width:32.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic29.png" style="top:4.41%; left:58.01%; width:29.06%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Plural Used for a Class Name
- **Never use plural in class****names**unless they hold some kind of collection!
- Bad example:
- Good example:
<div class="fragment balloon" style="top:19.00%; left:53.03%; width:43.20%">Singular: **Teacher** (a single teacher, not several).</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic30.png" style="top:58.40%; left:93.07%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic31.png" style="top:31.55%; left:93.08%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Throwing an Exceptionwithout Parameters
- Don't throw exception without parameters:
<div class="fragment balloon" style="top:41.17%; left:71.40%; width:23.80%">Which parameter is **null** here?</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic32.png" style="top:25.24%; left:99.78%; width:7.37%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Parameters Checked in the Getter
- Check for invalid data in the **setters** and **constructors**, not in the getter!
<div class="fragment balloon" style="top:29.46%; left:58.18%; width:25.52%">Put this check in the setter!</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic33.png" style="top:23.48%; left:96.37%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Missing this for Local Members
- Always use **this.XXX** instead of **XXX** to access members within the class:
<div class="fragment balloon" style="top:54.23%; left:40.55%; width:27.96%">Use **this.Name**</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic34.png" style="top:24.31%; left:96.03%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Empty String for Missing Values
- Use **null** when a value is missing, not **0** or **""**
  - Make a field / property nullable to access **null** values or just disallow missing values
- Bad example:
- Correct alternatives:
<div class="fragment balloon" style="top:44.91%; left:67.88%; width:33.50%">Empty name is very bad idea! Use **null**.</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic35.png" style="top:61.18%; left:97.00%; width:8.46%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic36.png" style="top:36.76%; left:97.40%; width:8.52%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic37.png" style="top:52.39%; left:97.05%; width:8.46%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Magic Numbers in the Classes
- Don't use "**magic**" numbers
  - Especially when the class has members related to those numbers:
<div class="fragment balloon" style="top:52.11%; left:49.78%; width:51.60%">This if statement is very wrong. **4** is the size of the **Wolf**, which has a **Size** property inherited from **Animal**. Why not use **this.Size** instead of **4**?</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic38.png" style="top:30.85%; left:97.31%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Base Constructor Not Called
- Call the base constructor to **reuse** the object's state initialization code:
<div class="fragment balloon" style="top:46.12%; left:68.76%; width:26.45%">**: base (name)**</div>
<div class="fragment balloon" style="top:64.56%; left:46.97%; width:35.26%">Call the base constructor instead!</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic39.png" style="top:21.80%; left:96.03%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Repeating Code in theBase and Child Classes
- Never **copy-paste** the code of the base in the inherited class
<div class="fragment balloon" style="top:49.95%; left:51.13%; width:48.12%">Why are these fields duplicated and not inherited?</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic40.png" style="top:27.53%; left:96.03%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Broken Encapsulation through a Parameterless Constructor
- Be careful to keep fields well encapsulated
<div class="fragment balloon" style="top:61.75%; left:50.25%; width:37.91%">Breaks encapsulation: **Name** & **Teacher** can be left **null**.</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic41.png" style="top:24.64%; left:94.51%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Coupling the Base Classwith Its Child Classes
- Base class should **never** know about its children!
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic42.png" style="top:24.68%; left:92.63%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Hidden Interpretation of Base Class as Its Specific Child Class
- Don't define **IEnumerable<T>** fields and use them as **List<T>** (broken abstraction)
<div class="fragment balloon" style="top:54.71%; left:59.26%; width:29.53%">Bad practice: hidden **List<T>**</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic43.png" style="top:28.07%; left:96.02%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Use **List<T>** in the field and return it where **IEnumerable<T>** is required:
<div class="fragment balloon" style="top:55.90%; left:58.51%; width:35.89%">This partially breaks encapsulation. Think about **cloning** to keep your items safe.</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic44.png" style="top:26.96%; left:95.38%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Repeating Code Not MovedUpper in the Class Hierarchy
<div class="fragment balloon" style="top:41.40%; left:71.40%; width:24.68%">Repeating code</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic45.png" style="top:14.99%; left:97.31%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- When overriding methods, call the base method if you need its functionality, **don't copy-paste** it!
<div class="fragment balloon" style="top:28.29%; left:71.40%; width:24.68%">Repeating code</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic46.png" style="top:14.09%; left:97.31%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Move the Repeating Code inUpper in the Class Hierarchy
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic47.png" style="top:16.05%; left:99.50%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic48.png" style="top:14.99%; left:99.50%; width:9.07%; z-index:-1" /> -->




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
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic49.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic50.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic51.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic52.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1" /> -->




