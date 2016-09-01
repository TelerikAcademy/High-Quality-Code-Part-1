<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# High-Quality Classes and Class Hierarchies
## Best Practices in the Object-Oriented Design

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic01.png" style="top:57%; left:69%; width:26.25%; z-index:-1;" /> -->

<div class="signature">
	<p class="signature-course"> High-Quality Code</p>
	<p class="signature-initiative"> Telerik Software Academy</p>
	<a href="http://telerikacademy.com" class="signature-link"> http://telerikacademy.com </a>
</div>

<!-- section start -->
<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [Basic Principles](#basics)
  - Cohesion, Coupling,Inheritance, Polymorphism
- [High-Quality Classes](#hqclasses)
  - Good Abstraction, Correct Encapsulation, Correct Inheritance
  - Class Methods, Constructors, Data
  - Good Reasons to Create a Class
- [Typical Mistakes to Avoid in OO Design](#mistakes)

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic03.png" style="top:47.46%; left:83.24%; width:24.96%; z-index:-1" /> -->

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Basic Principles
## Cohesion, Coupling,Inheritance and Polymorphism

<!-- attr: {id:'basics', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="basics"></a> Cohesion
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

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:29%; left:6.55%; width:26.22%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:29%; left:39.30%; width:27.89%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:29%; left:73.92%; width:29.09%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic08.png" style="top:60%; left:9.13%; width:17.85%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:60%; left:42.43%; width:18.84%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:60%; left:74.64%; width:26.35%; z-index:-1" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Strong Cohesion
- Strong cohesion example
  - Class `System.Math`
    - Sin(), Cos(), Asin()
    - Sqrt(), Pow(), Exp()
    - Math.PI, Math.E

```cs
float sideA = 40f, sideB = 69f;
float angleAB = Math.PI / 3;
float sideC =
	Math.Pow(sideA, 2) + Math.Pow(sideB, 2) -
	2 * sideA * sideB * Math.Cos(angleAB);

float sidesSqrtSum =
	Math.Sqrt(sideA) +
	Math.Sqrt(sideB) +
	Math.Sqrt(sideC);
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:42.84%; left:88.31%; width:9.07%; z-index: 10" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Coupling
- **Coupling** describes how tightly a class or routine is related to other classes or routines
- **Coupling** must be kept **loose**
  - Modules must depend little on each other
  - All classes and routines must have
    - Small, direct, visible, and flexible relationships to other classes and routines
  - One module must be easily used by other modules, without complex dependencies


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Loose and Tight Coupling
- **Loose Coupling**
  - Easily replace old HDD
  - Easily place this HDD to <br> another motherboard
- **Tight Coupling**
  - Where is the video adapter?
  - Can you change the video <br> controller on this MB?

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic12.png" style="top:47.25%; left:64.17%; width:25.74%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic13.png" style="top:14.05%; left:64.17%; width:25.74%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic14.png" style="top:6.40%; left:85.37%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:42.46%; left:85.37%; width:9.14%; z-index:-1" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Loose Coupling – _Example_

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:9.34%; left:89.49%; width:9.07%; z-index:10" /> -->

```cs
class Report
{
  public string Content { get; set; }
  public bool LoadFromFile(string fileName) {…}
}
class Printer
{
  public void Print(string content) {…}
}
class Program
{    
  static void Main()
  {
    Report myReport = new Report();          
    Printer myPrinter = new Printer();
    myReport.LoadFromFile("C:\\DailyReport.rep");
    myPrinter.Print(myReport.Content);
  }
}
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Tight Coupling – _Example_

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:10.22%; left:88.57%; width:9.14%; z-index:10" /> -->

```cs
class MathParams
{
  public static double operand;
  public static double result;
}
class MathUtil
{
  public static void Sqrt()
  {
    MathParams.result = CalcSqrt(MathParams.operand);
  }
}
…
MathParams.operand = 64;
MathUtil.Sqrt();
Console.WriteLine(MathParams.result);
```

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
- In **JS** inheritance is supported indirectly
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
  - Virtual methods (`virtual`)
  - Abstract methods (`abstract`)
  - Interfaces methods (`interface`)
- In C# **override** overrides a virtual method
- In JavaScript **all methods are virtual**
  - The child class can just "override" any method from any object
  - There are no interfaces (JS is typeless language)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Polymorphism – _Example_

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:9.35%; left:86.43%; width:9.07%; z-index:10" /> -->

```cs
public class Person
{
  public virtual void PrintName() {
    Console.Write("I am a person.");
  }
}
public class Student : Person
{
  public override void PrintName() {
    Console.Write("I am a student. " + base.PrintName());
  }
}
public class Trainer : Person
{
  public override void PrintName() {
    Console.Write("I am a trainer.");
  }
}
```

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# High-Quality Classes
## How to Design High-Quality Classes? Abstraction, Cohesion and Coupling

<!-- attr: { id:'hqclasses', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="hqclasses"></a> High-Quality Classes: Abstraction
- Present a consistent level of **abstraction** in the class contract (publicly visible members)
  - What abstraction the class is implementing?
  - Does it represent only one thing?
  - Does the class name well describe its purpose?
  - Does the class define clear and easy to understand public interface?
  - Does the class hide all its implementation details?

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Good Abstraction – _Example_

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic20.png" style="top:9.35%; left:86.31%; width:9.07%; z-index:10" /> -->

```cs
public class Font
{
   public string Name { get; set; }
   public float SizeInPoints { get; set; }
   public FontStyle Style { get; set; }
   public Font(
      string name, float sizeInPoints, FontStyle style)
   {
      this.Name = name;
      this.SizeInPoints = sizeInPoints;
      this.Style = style;
   }
   public void DrawString(DrawingSurface surface,
      string str, int x, int y) { … }
   public Size MeasureString(string str) { … }
}
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Bad Abstraction – _Example_

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic21.png" style="top:10.35%; left:88.78%; width:9.14%; z-index:10" /> -->

```cs
public class Program
{
  public string title;
  public int size;
  public Color color;
  public void InitializeCommandStack();
  public void PushCommand(Command command);
  public Command PopCommand();
  public void ShutdownCommandStack();
  public void InitializeReportFormatting();
  public void FormatReport(Report report);
  public void PrintReport(Report report);
  public void InitializeGlobalData();
  public void ShutdownGlobalData();
}
```

<div class="fragment balloon" style="top:18.13%; left:39.34%; width:41.43%">Does this class really represent a "program"? Is this name good?</div>
<div class="fragment balloon" style="top:61.01%; left:73.36%; width:27.33%">Does this class really have a single purpose?</div>

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Establishing Good Abstraction
- Define operations along with their opposites
  - _Example:_ `Open()` and `Close()`
- Move unrelated methods in another class
  - _Example:_ In class `Employee` if you need to calculate **Age** by given **DateOfBirth**, create а static method `CalcAgeByBirthDate(…)` in a separate class
- Group related methods intro a single class
- Does the class name correspond to the class content?


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!--# Establishing Good Abstraction-->
- Beware of breaking the interface abstraction due to evolution
  - Don't add public members inconsistent with abstraction
  - _Example_: in class called **Employee** at some time we add method for accessing the DB with SQL

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic22.png" style="top:57.00%; left:88.57%; width:9.14%; z-index:10" /> -->

```cs
{
  public string FirstName { get; set; }
  public string LastName; { get; set; }
  …
  public SqlCommand FindByPrimaryKeySqlCommand(int id);
}
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Encapsulation
- Minimize visibility of classes and members
  - In C# start from `private` and move to `internal`, `protected` and `public` if required
- Classes should hide their implementation details
  - A principle called **encapsulation** in OOP
  - Anything which is not part of the class interface should be declared `private`
  - Classes with good encapsulated classes are: less complex, easier to maintain, more loosely coupled
- Classes should keep their state **clean**


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!--# Encapsulation-->
- Never declare fields `public` (except constants)
  - Use properties / methods to access the fields
- Don't put private implementation details in the `public` interface
  - All `public` members should be consistent with the abstraction represented by the class
- Don't make a method `public` just because it calls only `public` methods
- Don't make assumptions about how the class will be used or will not be used

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!--# Encapsulation-->
- Don't violate encapsulation semantically!
  - Don't rely on non-documented internal behavior or side effects
  - Wrong example:
    - Skip calling `ConnectToDB()` because you just called `FindEmployeeById()` which should open connection
  - Another wrong example:
    - Use `String.Empty` instead of `Titles.NoTitle` because you know both values are the same

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
  - _Example_: if the class `Timer` has private method `Start()`, don't define `Start()` in `AtomTimer`
- Move common interfaces, data, and behavior as high as possible in the inheritance tree
  - This maximizes the code reuse
- Be suspicious of base classes of which there is only one derived class
  - Do you really need this additional level of inheritance?


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Inheritance -->
- Be suspicious of classes that override a routine and **do nothing** inside
  - Is the overridden routine used correctly?
- Avoid **deep inheritance** trees
  - Don't create more than 6 levels of inheritance
- Avoid using a base class’s protected data fields in a derived class
  - Provide protected accessor methods or properties instead


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Inheritance -->
- Prefer inheritance to extensive type checking:
- Consider inheriting `Circle` and `Square` from `Shape` and override the abstract action `Draw()`

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic25.png" style="top:35.60%; left:88.63%; width:9.14%; z-index:10" /> -->

```cs
switch (shape.Type)
{
  case Shape.Circle:
    shape.DrawCircle();
    break;
  case Shape.Square:
    shape.DrawSquare();
    break;
  ...
}
```

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
  - **Creational patterns** like Singleton, Factory Method, Abstract Factory
  - **Structural patterns** like Adapter, Bridge, Composite, Decorator, Façade
  - **Behavioral patterns** like Command, Iterator, Observer, Strategy, Template Method


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
<!-- # Top Reasons to Create Class -->
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

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic26.png" style="top:24.08%; left:88.57%; width:9.07%; z-index:19" /> -->

```cs
namespace Utils
{
  class MathUtils { … }
  class StringUtils { … }
}

namespace DataAccessLayer
{
  class GenericDAO<Key, Entity> { … }
  class EmployeeDAO<int, Employee> { … }
  class AddressDAO<int, Address> { … }
}
```

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Typical Mistakes to Avoid
## Lessons Learned from the OOP Exam at Telerik Software Academy

<!-- attr: { id:'mistakes', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="mistakes"></a> Plural Used for a Class Name
- **Never use plural in class names** unless they hold some kind of collection!

```cs
public class Teachers : ITeacher
{
  public string Name { get; set; }
  public List<ICourse> Courses { get; set; }
}
```

```cs
public class GameFieldConstants
{
  public const int MIN_X = 100;
  public const int MAX_X = 700;
}
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic30.png" style="top:52.40%; left:88.07%; width:9.07%; z-index:10" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic31.png" style="top:25.55%; left:88.08%; width:9.14%; z-index:10" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Throwing an Exception <br> Without Parameters
- Don't throw exception without parameters:

```cs
public ICourse CreateCourse(string name, string town)
{
  if (name == null)
  {
    throw new ArgumentNullException();
  }
  if (town == null)
  {
    throw new ArgumentNullException();
  }
  return new Course(name, town);
}
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic32.png" style="top:27.55%; left:89.08%; width:9.14%; z-index:10" /> -->
<div class="fragment balloon" style="top:51.17%; left:71.40%; width:23.80%">Which parameter is **null** here?</div>

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Parameters Checked in the Getter
- Check for invalid data in the **setters** and **constructors**, not in the getter!

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic33.png" style="top:34.48%; left:88.37%; width:9.14%; z-index:10" /> -->

```cs
public string Town
{
   get
   {
      if (string.IsNullOrWhiteSpace(this.town))
         throw new ArgumentNullException();

      return this.town;
   }
   set { this.town = value; }
}
```

<div class="fragment balloon" style="top:44.46%; left:53.18%; width:25.52%">Put this check in the setter!</div>

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Missing this for Local Members
- Always use **this.XXX** instead of **XXX** to access members within the class:

```cs
public class Course
{
  public string Name { get; set; }

  public Course(string name)
  {
    Name = name;
  }
}
```

<div class="fragment balloon" style="top:58.73%; left:34.55%; width:27.96%">Use **this.Name**</div>

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic34.png" style="top:25.31%; left:89.03%; width:9.14%; z-index:10" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Empty String for Missing Values
- Use **null** when a value is missing, not **0** or **""**
  - Make a field / property nullable to access **null** values or just disallow missing values
- Bad example:
```cs
Teacher teacher = new Teacher("");
```
- Correct alternatives:
```cs
Teacher teacher = new Teacher();
```
```cs
Teacher teacher = new Teacher(null);
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic36.png" style="top:40.76%; left:89.40%; width:8.52%; z-index:10" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic37.png" style="top:62.39%; left:89.05%; width:8.46%; z-index:10" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic35.png" style="top:73.18%; left:89.00%; width:8.46%; z-index:10" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Magic Numbers in the Classes
- Don't use "**magic**" numbers
  - Especially when the class has members related to those numbers:

```cs
public class Wolf : Animal
{
  …
  bool TryEatAnimal(Animal animal)
  {
     if (animal.Size <= 4)
     {
       return true;
     }
  }
}
```

<div class="fragment balloon" style="top:72.11%; left:49.78%; width:51.60%">This if statement is very wrong. **4** is the size of the **Wolf**, which has a **Size** property inherited from **Animal**. Why not use **this.Size** instead of **4**?</div>

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic38.png" style="top:30.85%; left:88.31%; width:9.14%; z-index:10" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Base Constructor Not Called
- Call the base constructor to **reuse** the object's state initialization code:

```cs
public class Course
{
  public string Name { get; set; }
  public Course(string name)
  { this.Name = name; }
}
public class LocalCourse : Course
{
  public string Lab { get; set; }
  public Course(string name, string lab)
  {
    this.Name = name;
    this.Lab = lab;
  }
}
```

<div class="fragment balloon" style="top:71.12%; left:64.76%; width:26.45%">**: base (name)**</div>
<div class="fragment balloon" style="top:79.56%; left:41.97%; width:35.26%">Call the base constructor instead!</div>

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic39.png" style="top:26.80%; left:88.03%; width:9.14%; z-index:10" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Repeating Code in the <br> Base and Child Classes
- Never **copy-paste** the code of the base in the inherited class

```cs
public class Course
{
  public string Name { get; set; }
  public ITeacher Teacher { get; set; }
}
public class LocalCourse
{
  public string Name { get; set; }
  public ITeacher Teacher { get; set; }
  public string Lab { get; set; }
}
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic40.png" style="top:36.53%; left:88.03%; width:9.14%; z-index:10" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Broken Encapsulation through a Parameterless Constructor
- Be careful to keep fields well encapsulated

```cs
public class Course
{
  public string Name { get; private set; }
  public ITeacher Teacher { get; private set; }

  public Course(string name, ITeacher teacher)
  {
    if (name == null) ArgumentNullException("name");
    if (teacher == null) ArgumentNullException("teacher");
    this.Name = name;
    this.Teacher = teacher;
  }

  public Course() { }
}
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic41.png" style="top:28.64%; left:88.51%; width:9.14%; z-index:10" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Coupling the Base Class <br> With Its Child Classes
- A class should **never** know about its children!

```cs
public class Course
{
  public override string ToString()
  {
    if (this is ILocalCourse)
    {
      return "Lab = " + ((ILocalCourse)this).Lab;
    }
    if (this is IOffsiteCourse)
    {
      return "Town = " + ((IOffsiteCourse)this).Town;
    }
    ...
  }
}
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic42.png" style="top:28.68%; left:88.63%; width:9.14%; z-index:10" /> -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Hidden Interpretation of Base Class as Its Specific Child Class
- Don't define **IEnumerable<T>** fields and use them as **List<T>** (broken abstraction)

```cs
public class Container<T>
{
  public IEnumerable<T> Items { get; }
  public Container()
  {
    this.Items = new List<T>();
  }
  public void AddItem (T item)
  {
    (this.Items as List<T>).Add(item);
  }
}
```

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic43.png" style="top:36.87%; left:88.63%; width:9.14%; z-index:10" /> -->

<!-- section start -->
<!-- attr: { hasScriptWrapper:true, class:"slide-section", showInPresentation: true } -->
<!-- # High Quality Classes
## Questions? -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - [Unit Testing Course](http://academy.telerik.com/student-courses/programming/high-quality-code/about)
  - Telerik Software Academy
    - [telerikacademy.com](https://telerikacademy.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Software Academy Forums
    - [forums.academy.telerik.com](forums.academy.telerik.com)
