using Delegates;
using System;

Console.Write("Enter string: ");
var str = Console.ReadLine();

MyClass myClass = new(str);

Funct fun = myClass.Space;
fun += myClass.Reverse;

Run run = new();
run.runFunc(fun, str);
