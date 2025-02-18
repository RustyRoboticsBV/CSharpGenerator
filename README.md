# CSharpGenerator
A simple, lightweight generator for C# code, written in C#.
It is meant to ease maintenance in situations where you have multiple similar scripts with minor differences.

It supports generation of files, namespaces, classes, structs, enums, interfaces, delegates, events, methods, constructors, finalizers, operators, indexers, properties and fields. All types and members can be annotated with attributes and a summary.
The generator does NOT support method implementation generation - these must be provided by the user. The generator makes no attempt to check the semantic correctness of the generated program.

Static constructors, constructor calling, the where keyword and preprocessor directives are planned, but are not yet implemented.

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

    simpleClassFile.SaveToFile();

    Output
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