# C#

## Installation

When installing from the *Workloads* select **.Net desktop development**.

Also install **ASP.NET and web development** for building web applications.

## Basics

- under our project we can find Dependencies file. It looks as an xml file where we can find dependencies to other for example class libraries, that we have included in our project.

- running your application - use *ctrl + F5*. For console application you will see the result in a popup.

- running in a debug mode - use *F5*

- *ctrl + left click* on a keyword will open more details

- we can not use key words as variable names. For example *int* keyword, but if we really need that we can use int as variable name by prefixing it with *@* so it will be **@int**

- unit testing - to create unit testing right-click your project > Add > New Project > NUnit Test Project(.Net Core) and click Next

### namespace

- namespace - it is collection of classes and we can have multiple namespaces.

- namespace - we have access to all our classes in our namespace, but if we want access to another classes which are part of another namespace we need to import them. We can do that by uisng **using** key word and then the name of the namespace.

- adding new namespace - in VS right-click *your project* > **Add** > **New Project** > from the popup select **Class Library**

### classes

- constructor - to be valid constructor it needs to be named exactly the same as the class. And return type is not specified.

- for naming classes we should use PascalCase

- public - placing public before the class keyword will make the class accessible anywhere in our application

- internal - accessible only from the same assembly. If nothing specified, classes by default are internal

- abstract - abstract classes can not be instantiated (with **new**). It is the opposite of sealed, meaning that we can inherit from it, but can not instantiate it.

- sealed - this keyword can be used only on classes. It will disallow us to inherit from that class.

Fields and methods and everything the class is holding, in terms of terminology is called members.

### struct

- structures are similar to classes, they are used for more simple data types. For example **int** is of type struct

### methods

- the keyword before the method name is the return type of the method

- Main - main method is the starting point of an application. To call a method from the same class in the main method, that method has to be static.

- virtual - if we want to make a method overridable in the derived class we need to specify, that the method is virtual.

- private - usable only within the class

- protected - accessible only from the class and its derived classes. But it will be still not accessible by instances of the class

- static - we can access static method directly from the class without creating an instance/object of the class.

- void - void keyword means our method doesn't return anything it just contains some peace of code.

- abstract - if we have an abstract method the class holding the method should be also abstract. Abstract method should not have any implementation. The idea of abstract methods is too require some design for the app, but to leave the exact implementation of the logic to the derived class/method

### Arrays

- Array - it has fixed size. If we create an int array for example and we don't specify values, the array will be filled with 0's, boolean array will be filled with false's and so on.

### Lists

- List similar to arrays but size is not fixed, we can add or remove elements.

### Stack

- Working on the principle LIFO

### Queue

- Working on the principle FIFO

### **out** keyword

- With **out** keyword we can get more than one thing from a method, otherwise we can only one. The logic is the with **out** followed by a variable name we can save something in that variable while at the same time the method is returning something else.

### interfaces

Interfaces are similar to classes, but they have only definition without implementation, meaning that they only describe how something should look like.

One big benefit of using interface is that usually we can have some List with type of Cat class, which is kind of limitation to us. With interfaces we can use List with type of Animal class, where we can have different types of Animals, not only Cat.

### IEnumerable

With the help of this interface we can turn a class to something which can be used in foreach loop.
