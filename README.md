# Operator-Overloading in C#

This repository demonstrates the implementation of operator overloading in Object-Oriented Programming (OOP) using C#. The example focuses on a `DateTime` class, showcasing how to overload various operators to perform operations on time objects, including addition, subtraction, comparison, and increment/decrement operations.

## Features

### 1. **Addition of Two Time Objects**

The `DateTime` class allows you to add two times objects using the `+` operator, resulting in a new `DateTime` object that represents the sum of the two times values.

```csharp
DateTime d1 = new DateTime(2, 30, 45); // 2 hours, 30 minutes, 45 seconds
DateTime d2 = new DateTime(1, 45, 20); // 1 hour, 45 minutes, 20 seconds
DateTime sum = d1 + d2;                // Result: 4 hours, 16 minutes, 5 seconds
```

### 2. **Subtraction of Two Times Objects**

You can subtract one time object from another using the `-` operator, yielding a new `DateTime` object that represents the difference between the two time values.

```csharp
DateTime d1 = new DateTime(2, 30, 45);
DateTime d2 = new DateTime(1, 20, 30);
DateTime difference = d1 - d2;         // Result: 1 hour, 10 minutes, 15 seconds
```

### 3. **Adding Seconds to a Time Object**

The `DateTime` class supports adding a specific number of seconds to a time object using the `+` operator.

```csharp
int additionalSeconds = 7800;          // 7800 seconds = 2 hours, 10 minutes
DateTime d5 = d1 + additionalSeconds;  // 4 hours, 40 minutes, 45 seconds
Console.WriteLine("d1 + 7800 seconds = " + d5.ToString());
DateTime d6 = additionalSeconds + d1;  // 4 hours, 40 minutes, 45 seconds
Console.WriteLine("7800 + d1 seconds = " + d6.ToString());
```

### 4. **Increment and Decrement Operators**

The `DateTime` class supports both the prefix and postfix increment (`++`) and decrement (`--`) operators, which add or subtract one second from the time object.

```csharp
// Test Case for '++'
DateTime d7 = new DateTime(1, 59, 59); // 1 hour, 59 minutes, 59 seconds
d7++; // 1 hour, 59 minutes, 59 seconds
Console.WriteLine("d7++ = " + (d7).ToString());      // 2 hours, 0 minutes, 59 seconds
Console.WriteLine("++d7 = " + (++d7).ToString());    // 2 hours, 1 minutes, 0 seconds

// Test Case for '--'
DateTime d8 = new DateTime(1, 1, 0);   // 1 hour, 1 minutes, 0 seconds
d8--; // 1 hours, 1 minutes, 0 seconds
Console.WriteLine("d8-- = " + d8.ToString()); // 1 hours, 0 minutes, 0 seconds
Console.WriteLine("--d8 = " + (--d8).ToString()); // 0 hours, 59 minutes, 0 seconds
```

### 5. **Comparison Operators**

The `DateTime` class overloads various comparison operators to enable direct comparisons between time objects:
- `<`  : Less than
- `>`  : Greater than
- `<=` : Less than or equal to
- `>=` : Greater than or equal to
- `==` : Equal to
- `!=` : Not equal to

```csharp
DateTime d1 = new DateTime(3, 15, 0);
DateTime d2 = new DateTime(4, 10, 30);

bool smaller = d1 < d2;   // true
bool bigger = d1 > d2;     // false
bool lessOrEqual = d1 <= d2 // true
bool biggerOrEqual = d1 >= d2 // false
bool isEqual = d1 == d2;    // false
bool isNotEqual = d1 != d2; // true

```

### 6. **Boolean Check**

Additionally, a boolean check is implemented to evaluate if a `DateTime` object represents a valid time.

```csharp
if (d9) Console.WriteLine("d9 is not null");
else Console.WriteLine("d9 is null");
```

## Getting Started

To explore and run the examples provided in this repository, follow these steps:

1. Clone the repository:
    ```bash
    git clone https://github.com/OmarMuhamad/Operator-Overloading.git
    ```
2. Open the project in your favorite C# IDE (e.g., Visual Studio).
3. Build and run the project to see operator overloading in action.

## Example Output

```plaintext
d1 = 02:30:45
d2 = 01:20:30
d1 - d2 = 01:10:15
d1 + d2 = 03:51:15

d1 + 7800 seconds = 04:40:45
7800 + d1 seconds = 04:40:45

d7 = 01:59:59
d7++ = 02:00:59
++d7 = 02:01:59

d8 = 01:01:00
d8-- = 01:00:00
--d8 = 00:59:00

d1 = 02:30:45
d2 = 01:20:30
d1 > d2 = True
d1 < d2 = False
d2 <= d1 = True
d2 >= d1 = False
d2 == d9 = True
d1 != d2 = True
d9 is not null
```

## Contributing

Contributions are welcome! If you find a bug or have a feature request, you can just open an issue or submit a pull request.

