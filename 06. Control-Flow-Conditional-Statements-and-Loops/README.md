<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Control Flow, Conditional Statements and Loops
## Correctly Organizing the Control Flow Logic
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic00.png" style="top:3.15%; left:83.27%; width:17.08%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic01.png" style="top:6.15%; left:18.20%; width:56.35%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic02.png" style="top:52.89%; left:63.62%; width:39.04%; z-index:-1" /> -->
<div class="signature">
	<p class="signature-course">- High-Quality Code</p>
	<p class="signature-initiative">- Telerik Software Academy</p>
	<a href="- http://academy.telerik.com " class="signature-link">- http://academy.telerik.com </a>
</div>




<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- Organizing Straight-line Code
- Using Conditional Statements
- Using Loops
- Other Control Flow Structures
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic03.png" style="top:24.34%; left:69.82%; width:38.24%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic04.png" style="top:45.84%; left:16.84%; width:40.22%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Organizing Straight-Line Code
## Order and Separate Your Dependencies Correctly
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic05.png" style="top:22.29%; left:58.27%; width:43.26%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Straight-Line Code
- When statements’ order matters
  - **Make dependencies obvious**
  - Name methods according to dependencies
  - Use method parameters
  - Document the control flow if needed
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic06.png" style="top:51.76%; left:96.37%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic07.png" style="top:15.71%; left:96.37%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- When statements’ order does not matter
  - Make code read from top to bottom like a newspaper
  - **Group related statements together**
  - Make clear boundaries for dependencies
    - Use blank lines to separate dependencies
    - User separate method
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic08.png" style="top:26.45%; left:84.21%; width:22.40%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Straight-Line Code – _Example_s
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic09.png" style="top:8.82%; left:98.84%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Straight-Line Code – _Example_s
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic10.png" style="top:10.58%; left:99.29%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Straight-Line Code – Summary
- The most important thing to consider when organizing straight-line code is
  - **Ordering dependencies**
- Dependencies should be made **obvious**
  - Through the use of good routine names, parameter lists and comments
- If code doesn’t have order dependencies
  - Keep related statements together




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Using Conditional Statements
## Using Control Structures
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic11.png" style="top:10.91%; left:62.69%; width:37.91%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Using Conditional Statements
- Always use **{** and **}** for the conditional statements body, even when it is a single line:
- Why omitting the brackets could be harmful?
  - This is misleading code + misleading formatting
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic12.png" style="top:23.50%; left:96.11%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic13.png" style="top:48.66%; left:96.11%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Always put the normal (expected) condition first after the **if** clause
- Start from most common cases first, then go to the unusual ones
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic14.png" style="top:52.01%; left:46.78%; width:6.17%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic15.png" style="top:52.01%; left:101.34%; width:6.17%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Avoid comparing to **true** or **false**:
- Always consider the else case
  - If needed, document why the else isn’t necessary
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic16.png" style="top:45.84%; left:93.30%; width:9.07%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic17.png" style="top:16.89%; left:95.55%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic18.png" style="top:16.89%; left:46.78%; width:6.94%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Avoid double negation
- Write **if** clause with a meaningful statement
- Use meaningful boolean expressions, which read like a sentence
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic19.png" style="top:17.69%; left:48.58%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic20.png" style="top:40.54%; left:48.58%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic21.png" style="top:17.69%; left:99.30%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic22.png" style="top:40.54%; left:99.30%; width:6.94%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Be aware of copy/paste problems in **if-else** bodies
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic23.png" style="top:25.56%; left:49.71%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic24.png" style="top:25.56%; left:99.30%; width:6.94%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Use Simple Conditions
- Do not use complex **if** conditions
  - You can always simplify them by introducing boolean variables or boolean methods
  - Incorrect example:
  - Complex boolean expressions can be harmful
  - How you will find the problem if you get **IndexOutOfRangeException**?
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic25.png" style="top:44.12%; left:98.36%; width:6.94%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Simplifying Boolean Conditions
- The last example can be easily refactored into self-documenting code:
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic26.png" style="top:44.96%; left:99.18%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Use object-oriented approach
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic27.png" style="top:15.87%; left:97.04%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Now the code:
  - Models the real scenario
  - Stays close to the problem domain
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic28.png" style="top:8.82%; left:95.17%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Use Decision Tables
- Sometimes a **decision table**can be used for simplicity
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic29.png" style="top:22.04%; left:97.98%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Positive Boolean Expressions
- Starting with a **positive expression**improves the readability
- Use De Morgan’s laws for negative checks
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic30.png" style="top:21.27%; left:100.73%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic31.png" style="top:21.16%; left:48.27%; width:6.94%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Use Parentheses for Simplification
- Avoid complex boolean conditions without parenthesis
- Using parenthesis helps readability as well as ensure correctness
- Too many parenthesis have to be avoided as well
  - Consider separate Boolean methods or variables in those cases
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic32.png" style="top:22.92%; left:66.15%; width:5.62%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic33.png" style="top:43.20%; left:66.15%; width:5.62%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Boolean Expression Evaluation
- Most languages evaluate from left to right
  - Stop evaluation as soon as some of the boolean operands is satisfied
- Useful when checking for **null**
- There are languages that does not follow this “short-circuit” rule


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Numeric Expressions as Operands
- Write numeric boolean expressions as they are presented on a number line
  - Contained in an interval
  - Outside of an interval
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic34.png" style="top:31.74%; left:47.37%; width:5.62%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic35.png" style="top:38.92%; left:47.39%; width:5.62%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic36.png" style="top:53.77%; left:47.37%; width:5.62%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic37.png" style="top:60.96%; left:47.37%; width:5.62%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Avoid Deep Nesting of Blocks
- **Deep nesting**of conditional statements and loops makes the code unclear
  - More than 2-3 levels is too deep
  - Deeply nested code is complex and hard to read and understand
  - Usually you can extract portions of the code in separate methods
    - This simplifies the logic of the code
    - Using good method name makes the code self-documenting


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Deep Nesting – _Example_
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic38.png" style="top:8.82%; left:96.03%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic39.png" style="top:8.82%; left:96.03%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Avoiding Deep Nesting – _Example_
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic40.png" style="top:8.82%; left:96.03%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic41.png" style="top:16.75%; left:95.44%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Using Case Statement
- Choose the most effective ordering of cases
  - Put the normal (usual) case first
  - Order cases by frequency
  - Put the most unusual (exceptional) case last
  - Order cases alphabetically or numerically
- Keep the actions of each case simple
  - Extract complex logic in separate methods
- Use the default clause in a **case** statement or the last **else** in a chain of **if-else** to trap errors


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Incorrect Case Statement
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic42.png" style="top:9.96%; left:95.94%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Improved Case Statement
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic43.png" style="top:11.46%; left:95.17%; width:9.07%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Case – Best Practices
- Avoid using fallthroughs
- When you do use them, document them well
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic44.png" style="top:28.21%; left:97.27%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Overlapping control structures is evil:
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic45.png" style="top:15.54%; left:94.89%; width:9.14%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Control Statements – Summary
- For simple if-else-s, pay attention to the order of the **if** and **else** clauses
  - Make sure the nominal case is clear
- For if-then-else chains and case statements, choose the most readable order
- Optimize boolean statements to improve readability
- Use the default clause in a case statement or the last else in a chain of if-s to trap errors




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Using Loops
## Choose Appropriate Loop Type
## and Don’t Forget to Break
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic46.png" style="top:21.16%; left:65.88%; width:37.55%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Using Loops
- Choosing the correct type of loop:
  - Use **for** loop to repeat some block of code a certain number of times
  - Use **foreach** loop to process each element of an array or a collection
  - Use **while** / **do****-****while** loop when you don't know how many times a block should be repeated
- Avoid deep nesting of loops
  - You can extract the loop body in a new method


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Loops: Best Practices
- Keep loops simple
  - This helps readers of your code
- Treat the inside of the loop as it were a routine
  - Don’t make the reader look inside the loop to understand the loop control
- Think of a loop as a black box:


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Keep loop’s housekeeping at the start or at the end of the loop block
- Use meaningful variable names to make loops readable
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic47.png" style="top:22.04%; left:40.70%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic48.png" style="top:22.04%; left:101.63%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic49.png" style="top:69.57%; left:40.70%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic50.png" style="top:69.57%; left:101.63%; width:6.94%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Avoid empty loops
- Be aware of your language (loop) semantics
  - C# – access to modified closure
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic51.png" style="top:17.74%; left:98.36%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic52.png" style="top:33.61%; left:98.36%; width:6.94%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Loops: Tips on for-Loop
- Don’t explicitly change the index value to force the loop to stop
  - Use **while**-loop with **break** instead
- Put only the controlling statements in the loop header
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic53.png" style="top:45.23%; left:45.40%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic54.png" style="top:45.05%; left:99.83%; width:6.94%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->

- Avoid code that depends on the loop index’s final value
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic55.png" style="top:69.59%; left:49.41%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic56.png" style="top:69.59%; left:101.70%; width:6.94%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Loops: break and continue
- Use continue for tests at the top of a loop to avoid nested if-s
- Avoid loops with lots of break-s scattered trough it
- Use break and continue only with caution
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic57.png" style="top:47.60%; left:35.79%; width:38.35%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# How Long Should a Loop Be?
- Try to make the loops **short enough**to view it all at once (one screen)
- Use methods to shorten the loop body
- Make long loops especially clear 
- Avoid deep nestingin loops
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic58.png" style="top:37.70%; left:66.21%; width:29.50%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Other Control Flow Structures
## To Understand Recursion,One Must First Understand Recursion
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic59.png" style="top:17.78%; left:63.70%; width:37.02%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The return Statement
- Use return when it enhances readability
- Use return to avoid deep nesting
- Avoid multiple return-s in long methods
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic60.png" style="top:55.71%; left:49.14%; width:6.94%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic61.png" style="top:55.71%; left:101.99%; width:6.94%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Recursion
- Useful when you want to walk a tree / graph-like structures
- Be aware of infinite recursion or indirect recursion
- Recursion example:
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic62.png" style="top:42.31%; left:98.17%; width:6.94%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Recursion Tips
- Ensure that recursion has end (bottom)
- Verify that recursion is not very high-cost
  - Check the occupied system resources
  - You can always use stack classes and iteration
- Don’t use recursion when there is better **linear** (iteration based) solution, e.g.
  - Factorials
  - Fibonacci numbers
- Some languages optimize tail-call recursions


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# GOTO
- Avoid **goto**-s, because they have a tendency to introduce spaghetti code
- “A Case Against theGO TO Statement” by Edsger Dijkstra
- Use **goto**-s as a last resort
  - If they make the code more maintainable
- C# supports **goto** withlabels, but avoid it!
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic63.png" style="top:26.46%; left:52.40%; width:13.22%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic64.png" style="top:39.67%; left:71.11%; width:31.74%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Control Flow, Conditional Statements and Loops

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
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic65.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic66.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic67.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="\imgs\pic68.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1" /> -->




