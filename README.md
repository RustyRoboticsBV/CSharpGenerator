# CSharpGenerator
A simple generator for C# code.
It supports generation of namespaces, classes, structs, enums, interfaces, delegates, events, methods (including constructors, finalizers, operators), properties and fields. All types and members can be annotated with attributes and a summary.
The generator does NOT support method inplementation generation - these must be provided by the user. Lesser-used types such as records and record structs are also not supported.

Generics, indexers, static constructors, constructor calling and preprocessor directives are planned, but are not yet implemented.
