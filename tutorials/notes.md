Tuples are an ordered sequence of values with a fixed length. Each element of a tuple has a type and an optional name.

Tuples are structural types. In other words, tuple types don't have names like string or int. A tuple type is defined by the number of members, referred to as arity, and the types of those members. The member names are for convenience. You can assign a tuple to a tuple with the same arity and types even if the members have different names.

Tuple types don't have names, so you can't convey meaning to the set of values. Tuple types can't add behavior. 

The preceding record declaration is a single line of code that ends in ;. You can add behavior to a record type by declaring members. A record member can be a function or more data elements. The members of a type are in the type declaration, between { and } characters.

A record type is a class type - it is a shorthand for a record class: A class type that includes extra behavior. 

A record struct is a struct type that includes the extra behavior added to all record types.

All concrete named types in C# are either class or struct types, including record types. A class is a reference type. A struct is a value type. Variables of a value type store the contents of the instance inline in memory. In other words, a record struct Point stores two integers: X and Y. Variables of a reference type store a reference, or pointer, to the storage for the instance. In other words, a record class Point stores a reference to a block of memory that holds the values for X and Y.

Properties are data elements and can have code that enforces validation or other rules. 

Methods are blocks of code that perform a single function.
