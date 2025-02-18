# CSharpGenerator
A simple, lightweight generator for C# code, also written in C#.

It is meant to ease maintenance in situations where you have multiple similar scripts with minor differences.

### Features
The following C# language features can be generated:
- Files
  - Using directives
- Namespaces
- Types
  - Classes
  - Structs
  - Interfaces
  - Enums
  - Delegates
- Events
- Methods
  - Constructors
  - Finalizers
  - Operators
  - Indexers
- Properties
- Fields
- "Sections", which are defined as a grouping of type members, with a delimited comment at the top.

All types and members can be annotated with attributes and a summary. Inheritance, as well as generic, static and abstract types & methods are supported.

The generator does NOT support method implementation generation - these must be provided by the user. The generator makes no attempt to check the semantic correctness of the generated program.

### TODO
- Constructor calling from other constructors
- Preprocessor directives
- Records

### Usage
Below is an example of how to generate a simple class.

    using CSharpGenerator;

    Field field = new()
    {
        Access = AccessID.Public,
        Type = "int",
        Name = "field"
    };

    Class simpleClass = new()
    {
        Summary = "A simple class.",
        Attributes = "Serializable",
        Name = "SimpleClass",
        Members = field
    };

    Namespace exampleNamespace = new()
    {
        Name = "Example",
        Members = simpleClass
    };

    File simpleClassFile = new()
    {
        Name = "SimpleClass.cs",
        Usings = "System",
        Members = exampleNamespace
    };

    simpleClassFile.WriteToDisk();

<br/>Which results in the following output:

    using System;

    namespace Example
    {
        /// <summary>
        /// A simple class.
        /// </summary>
        [Serializable]
        public class SimpleClass
        {
            public int field;
        }
    }
