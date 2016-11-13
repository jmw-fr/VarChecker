# VarChecker

## Introduction

The project page is here : https://jmw-fr.github.io/VarChecker/

The source code is here : https://github.com/jmw-fr/VarChecker/


VarChecker is a helper library that simplifies the check of variable values.

How many times have you written this code :

```
if (value == null)
{
	throw new ArgumentNullException();
}
```

VarChecker simplifies the writing of this check with fluent assertion :

```
value.CannotBeNotNull();
```

It then checks for null and throw a ArgumentNullException for you. Your code is cleaner.

VarChecker allows you to check :
- null references,
- empty collections,
- strings.

## Quick start

Install the nuget package:
```
Install-Package VarChecker
```

Reference the package in your source:
```
using Jmw.VarChecker; // C#
```
Or
```
Imports Jmw.VarChecker ' VB.Net
```
Then use it !

```
public void MyFunction(string input)
{
  // It will check for null and throw ArgumentNullException
  input.CannotBeNotNull();
}
```