Phase 1 — Project Setup

 Create C# console project - done
 Use file-scoped namespaces (namespace MyApp;)
 Organise folders:

 Models - done
 Enums - done
 DTOs - done
 Helpers  - done
 Modules - done
 Interfaces - done
 Exceptions - done


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
 Implement menu loop with while  - done


✅ Phase 3 — Models (Entities)

 Create at least 4 classes (e.g., Player, GameSession, GameStats, WordEntry)
 Each class must include:

 Private fields - done
 Public properties - done
 Constructor - done
 At least one method - done


 Add relationships between classes  - done


✅ Phase 4 — Enums

 Create at least 3 enums - done

 Example: 


 At least one enum must have explicit values  - done
 Use enums in conditions or switch expressions  - done


✅ Phase 5 — Collections

 Use List<T> (e.g., words, guesses, sessions) - done
 Add/remove/iterate over lists - done
 Use Dictionary<TKey, TValue> - done
 Use at least one List with custom objects - done
 Use IEnumerable<T> where appropriate


✅ Phase 6 — Control Flow

 Add if / else if / else logic - done
 Use at least one switch expression - done
 Include:

 for loop 
 foreach loop - done
 while loop - done


 Use ternary operator (? :)


✅ Phase 7 — Methods

 Create at least 5 methods
 At least 2 should return values
 At least 1 void method
 Demonstrate method overloading
 Use optional parameters
 Use out or ref parameter


✅ Phase 8 — OOP

 Implement interface (IModule)  - done
 Use polymorphism
 Use encapsulation (private + public accessors)  - done
 Ensure classes interact properly


✅ Phase 9 — DTOs

 Create at least 3 DTOs:

 Input DTO  (Data Transfer Object)
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

 Use Console.ReadLine()  - done
 Use TryParse() methods - done
 Use Console.WriteLine()  - done
 Use string interpolation ($"...")  - done
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