
# Lesson 3-4: Binary Number Conversion in C#

## Overview
In this lesson, we explore how to create a method that converts a decimal number into its binary representation. This is a practical and useful application of loops, conditionals, and string manipulation.

---

## Key Concepts

### 1. Binary Conversion
- Created a method (`BinaryConverter`) to convert a decimal number to a binary number.
- Used a `while` loop to repeatedly divide the number by 2 and collect the binary digits.
- Reversed the binary digits to get the correct binary representation.

    Example:
    ```csharp
    public static void BinaryConverter(int anyNumber)
    {
        string binaryText = "";

        while (anyNumber != 0)
        {
            if (anyNumber % 2 == 0)
            {
                binaryText += "0";
            }
            else
            {
                binaryText += "1";
            }
            anyNumber = anyNumber / 2;
        }

        // Reverse the text to get the proper binary number
        binaryText = new string(binaryText.Reverse().ToArray());
        Console.WriteLine($"The binary representation is: {binaryText}");
    }
    ```

---

### 2. Extra Useful Application
This binary converter method is highly practical and can be adapted for other purposes, such as:
- Converting numbers to other numeral systems (e.g., octal, hexadecimal).
- Learning how binary numbers are used in computer systems.

---

## Learning Outcomes
By the end of this lesson, students were able to:
- Understand how to use loops and conditionals for iterative calculations.
- Apply string manipulation techniques to format and display results.
- Develop an appreciation for binary representation in computing.

---

## Next Steps
- Extend the `BinaryConverter` method to handle larger numbers.
- Write similar methods to convert binary numbers back to decimal.
- Explore how binary is used in applications like bit manipulation and encryption.

