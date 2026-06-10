# Minigames

A C# console application that combines multiple interactive modules including games and utilities.

---

## Features

 **Wordle Game**  
  Guess the hidden word with feedback on letters.

 **Hangman Game**  
  Guess letters to reveal the hidden word before running out of attempts.

 **Impatient Calculator**  
  Enter numbers within a time limit or defaults are used.

 **Personality Calculator**  
  Get a fun personality result based on your input.

---

## Project Structure
/Models       → Core data classes
/Modules      → Game & calculator modules
/Interfaces   → Shared interfaces (IModule)
/DTOs         → Data Transfer Objects
/Enums        → Enumerations used across app
/Helpers      → Utility/helper classes
/Exceptions   → Custom exceptions
Program.cs    → Application entry point

---

## Concepts Covered

### Object-Oriented Programming (OOP)
- Classes & Objects  
- Encapsulation  
- Polymorphism  
- Interfaces  

### C# Features
- Lists & Dictionaries  
- LINQ queries  
- Enums  
- Exception handling  
- Async/Await (timeout handling)  

### Code Practices
- File-scoped namespaces  
- One class per file  
- Structured project layout  

---

##  How to Run

1. Clone the repository:
```bash
git clone <your-repo-url>
```

Navigate into the project folder:

Shellcd <project-folder>Show more lines

Run the application:

``Shelldotnet run``

Example Menu
Welcome to Interactive Console Hub 

1. Play Wordle
2. Play Hangman
3. Use Impatient Calculator
4. Personality Calculator
5. Exit


Technologies Used

C#
.NET Console Application
Git & GitHub


Future Improvements
