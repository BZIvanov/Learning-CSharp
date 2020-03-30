# C#

## Installation

When installing from the *Workloads* select **.Net desktop development**.

Also install **ASP.NET and web development** for building web applications.

## Basics

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

- internal - accessible only from the same assembly

- abstract - abstract classes can not be instantiated.

### struct

- structures are similar to classes, they are used for more simple data types. For example **int** is of type struct

### methods

- the keyword before the method name is the return type of the method

- Main - main method is the starting point of an application. To call a method from the same class in the main method, that method has to be static.

- private - usable only within the class

- protected - accessible only from the class and its derived classes

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
