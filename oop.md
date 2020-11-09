## Abstraction

It is good to hide some of the implementation parts from the outside world. This also helps if we change one of them to make sure nothing in the outside world will break, because it is hidden to our object only.

## Inheritance

With _Inheritance_ we can easly reuse code, because the derived classes receive all Base class members (fields, properties, methods etc.).

By default if nothing specified the classes we create inherit from **object**, even if we dont see it.

One class can only inherit from another one class, not more than one. But we can implement from many interfaces to achieve some goals.

Example

- **Animal** - Base class, Parent class, Superclass
  - **Cat** - Derived class, Child class, Subclass
  - **Dog** - Derived class, Child class, Subclass

## Encapsulation

Encapsulation is focused on hiding implementation.

We should write all our class fields as private and then use them in constructor or with getter and setters.

## Polymorphism
