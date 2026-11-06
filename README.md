# SDC220L
## Repository for my project, its phases. and all commits

## Features Progress:
- Calculator Operations: 4 operations using 2 inputs > 4 operations accepting 2+ numbers
- Addition: Integer addition > Adds as many number as user input, accepts double vals
- Subtraction: 2 floating-point vals > subtracts 2nd value from the first
- Multiplication: 2 floating-point vals > multiplies all number submitted
- Division: 2 floating-point vals > divides first val by second val, utilize DivideByZeroException
- Input Validation: Menu choice > Utilizes TryParse loops & checks 2 valid, finite, numbers
- Exception Handling: None used > DivideByZeroException & ArgumentException
- Memory: Not used > Store, retrieve, replace, clear, and display numbers in a max of 10
- Menu: 4 ops & quit option > Updated to include Memory & Quit

## Features:

## Calculator Operations:
- adds 2+ numbers
- subtract second number from the first
- multiply 2+ numbers
- divide first number by the second
- results to 2 decimal places

## Input validating & error handling:
- requires 2 values
- accepts space separated numeric inputs
- uses double.TryParse
- asks for a resubmit when values are invalid
- DivideByZeroException
- Catches exceptions

## Memory Menu:
- Stores numbers
- Retrieves stored number by position
- Replaces stored numbers
- Displays stored numbers
- Memory limited to 10 stored numbers
- returns to main

## Code Organization:
Program.cs — Runs the application, displays the main and memory menus, gathers and validates input, handles division exceptions, manages the memory list, and displays results.
Calculator.cs — Contains the calculator operations and shared number-count validation. Each operation accepts a List<double>.



# Project summary
## Project Name: Bre's Prototype Calculator
## Project Description: Console-based calculator developed using C#. The goal was to create a functional calculator that performs basic math operations while showcasing programming concepts learned throughout my Object Oriented Programming Using C# class. Beginning the project with a simple calculator, it progressed to be able to support multi-number calculations, error handling, and a memory feature to allow for the storage, retrieval, replacement, and clearing of numerical values.
## Project Tasks: 
- ** Task 1: Setup Workspaces
  - Create C# console application
  - Create GitHub repository
  - Establish classes (program.cs & calculator.cs)
- ** Task 2: Create Core Application
  - Create welcome message & menu
  - Create the structure that will be updated throughout
  - Display results in formatted output
- ** Task 3: Expand Functionalities
  - Update calculator to accept multiple numbers
  - Utilize lists of double values
  - Create memory feature that accepts up to 10 numbers to hold
  - Allow for retrieval, replacement, clearing, and display of stored numbers
- ** Task 4: Implement Validation and Exception Handling
  - Validate number input using TryParse
  - Require at least 2 numbers for calculations
  - Prevent division by 0 using DivideByZeroException
  - Throw proper error messages when necessary
  - Reject invalid numerical values
- ** Task 5: Document and Finalize
  - Review and refine calculator functionality
  - Create documentation using README.md
  - Document progress
 ## Skills:
 - C#
 - GitHub Utilization & Updating
 - Debugging
 - Object Oriented Programming
 - Lists & Collections
 - Loops & Conditional Statements
 - Accept & Validate User Input
 - Exception Handling & Error Management
 - Mathematical Operations Using Double Data Types
 - Organize and Maintain Code
 - Document Progress
## Development Processes:
- Incremental Development
- Testing & Debugging
- Organizing
## Project Link
https://github.com/brenordq/SDC220L.git
