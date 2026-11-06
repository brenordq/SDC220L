# SDC220L
Repository for my project, its phases. and all commits

Features Progress:
- Calculator Operations: 4 operations using 2 inputs > 4 operations accepting 2+ numbers
- Addition: Integer addition > Adds as many number as user input, accepts double vals
- Subtraction: 2 floating-point vals > subtracts 2nd value from the first
- Multiplication: 2 floating-point vals > multiplies all number submitted
- Division: 2 floating-point vals > divides first val by second val, utilize DivideByZeroException
- Input Validation: Menu choice > Utilizes TryParse loops & checks 2 valid, finite, numbers
- Exception Handling: None used > DivideByZeroException & ArgumentException
- Memory: Not used > Store, retrieve, replace, clear, and display numbers in a max of 10
- Menu: 4 ops & quit option > Updated to include Memory & Quit

Features:

Calculator Operations:
- adds 2+ numbers
- subtract second number from the first
- multiply 2+ numbers
- divide first number by the second
- results to 2 decimal places

Input validating & error handling:
- requires 2 values
- accepts space separated numeric inputs
- uses double.TryParse
- asks for a resubmit when values are invalid
- DivideByZeroException
- Catches exceptions

Memory Menu:
- Stores numbers
- Retrieves stored number by position
- Replaces stored numbers
- Displays stored numbers
- Memory limited to 10 stored numbers
- returns to main

Code Organization:
Program.cs — Runs the application, displays the main and memory menus, gathers and validates input, handles division exceptions, manages the memory list, and displays results.
Calculator.cs — Contains the calculator operations and shared number-count validation. Each operation accepts a List<double>.

