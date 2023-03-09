# TEAM-International_QA-Automation-Bootcamp_Test

Task:
- write a console application;
Input of application (via keyboard):
- coordinates of 3 points in 2-dimensional coordinate system;

Output of application (to console):
- the length of triangle sides;
- is it equilateral triangle?
- is it isosceles triangle?
- is it right triangle?
- the perimeter of the triangle;
- even numbers from 0 to value of triangle perimeter.

The source code of the application should be uploaded to a public github repository (see instruction in
separated file).
Note:
- input values can be with fractional part;
- output values can be rounded;
- you can choose you own precision during calculations:
For example, for a triangle А(0,0), В(0,4), С(0,4) sides length will be 4, 5,656854249492381, 4. It is
the right triangle, because АВ 2 + АС 2 = ВС 2 . But 4 2 + 4 2 != 5,656854249492381 2 (due to a precision of
double variable type). To solve this problem, you can say that the triangle is right if ВС 2 – (АВ 2 + АС 2 )
&lt;= delta, where delta – you own precision.

Useful links:
https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022 - simple
C# console app;
https://docs.microsoft.com/en-gb/dotnet/csharp/language-reference/statements/selection-statements - the
if statement
https://docs.microsoft.com/en-gb/dotnet/csharp/language-reference/statements/iteration-statements - the
for statement;
https://docs.microsoft.com/en-us/dotnet/api/system.double.parse?view=net-6.0
https://docs.microsoft.com/en-us/dotnet/api/system.double.tryparse?view=net-6.0 – converting string to
double;
https://docs.microsoft.com/en-us/dotnet/api/system.math.pow?view=net-6.0 - raise a specified number to
the specified power
https://docs.microsoft.com/en-us/dotnet/api/system.math.sqrt?view=net-6.0 - calculate square root of a
specified number.
