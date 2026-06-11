Phase 1 — Project Setup

 Create C# console project - done
 Use file-scoped namespaces (namespace MyApp;)
 Organise folders:

 Models - done
 Enums
 DTOs
 Helpers
 Modules - done
 Interfaces - done
 Exceptions


 Create Program.cs entry point - done


✅ Phase 2 — Core Architecture

 Create IModule interface - done

 string Name
 void Run()


 Create modules:

 HangmanGame - done
 ImpatientCalculator
 PersonalityCalculator


 Ensure one class per file - done
 Create menu system using List<IModule> - done
 Implement menu loop with while


✅ Phase 3 — Models (Entities)

 Create at least 4 classes (e.g., Player, GameSession, GameStats, WordEntry)
 Each class must include:

 Private fields
 Public properties
 Constructor
 At least one method


 Add relationships between classes


✅ Phase 4 — Enums

 Create at least 3 enums

 Example: GameStatus, Difficulty, PersonalityType


 At least one enum must have explicit values
 Use enums in conditions or switch expressions


✅ Phase 5 — Collections

 Use List<T> (e.g., words, guesses, sessions)
 Add/remove/iterate over lists
 Use Dictionary<TKey, TValue>
 Use at least one List with custom objects
 Use IEnumerable<T> where appropriate


✅ Phase 6 — Control Flow

 Add if / else if / else logic
 Use at least one switch expression
 Include:

 for loop
 foreach loop
 while loop


 Use ternary operator (? :)


✅ Phase 7 — Methods

 Create at least 5 methods
 At least 2 should return values
 At least 1 void method
 Demonstrate method overloading
 Use optional parameters
 Use out or ref parameter


✅ Phase 8 — OOP

 Implement interface (IModule)
 Use polymorphism
 Use encapsulation (private + public accessors)
 Ensure classes interact properly


✅ Phase 9 — DTOs

 Create at least 3 DTOs:

 Input DTO
 Output DTO
 Transfer DTO


 At least one DTO must use record
 Add comments explaining DTO usage


✅ Phase 10 — Helpers

 Create at least 2 helper classes
 Ensure all methods are static
 Helpers must not hold state
 Include at least one generic method


✅ Phase 11 — Error Handling

 Use try-catch blocks
 Catch at least 2 exception types
 Include a finally block
 Create a custom exception
 Throw and catch it


✅ Phase 12 — Input & Output

 Use Console.ReadLine()
 Use TryParse() methods
 Use Console.WriteLine()
 Use string interpolation ($"...")
 Implement full menu system


✅ Phase 13 — LINQ

 Use .Where()
 Use .OrderBy() or .OrderByDescending()
 Use .Select() or .Any() or .All()
 Chain at least one query
 Display results


✅ Phase 14 — Code Quality

 Add XML comments (///)
 Add inline comments (//)
 Remove unused code
 Avoid magic numbers (use constants/enums)
 Keep methods small
 Avoid deep nesting (>3 levels)
 Ensure project compiles with no errors or warnings