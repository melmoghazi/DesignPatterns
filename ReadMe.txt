Design pattern is an elegant solution to repeating problem.
23 desgin pattern in the book "Design Patterns elements of reusable object-oriented software" by GoF.
Desgin Patterns:
 1-Creational, creation of the objects.
 2-Structural, relationship between objects.
 3-Behavioural, interaction or communication between objects.
---------------------------------------------------------------------------------
1- Singleton pattern 
Not in 23 Design Patterns
Type? Creational pattern.
Why? Used to be sure that there is only one instance of a class while the application is running.
When? when you have a static data or little change
Example1: configuration values, appsettings file. 
Example2: lookups.
Implementd example: exchange rate between currencies.
---------------------------------------------------------------------------------
2- Adapter pattern
In 23 Design Patterns
Type? Stuctural 
Why? to change the object to be compatable with other client such as callig other api or system.
When? when you need to dail with other old or unchanged systems.
Example1: the mobile charger 
Implementd example: employee deductional salary - +
---------------------------------------------------------------------------------
3- Strategy Pattern or named policy pattern
In 23 Design Patterns
Type? Behavioural
Why? used to select function algorithm at runtime based on some input parameters.
     or to determine a way of execution when some thing happen.
Example1: string comparison (case sensitive, case insensitive)
Exmaple2: saving file in different format (pdf, text, doc)
Example3: payment methods (fawry, paypal)
Example4: customer data is in DB or in APIs.
Implementd example: customer discounts.
---------------------------------------------------------------------------------         
4- Simple Factory Design Pattern
Not in 23 Design Patterns
Type? Creational
Why? to make one place resposible of creating an instance of a related classes.
(DRY) Do not Repeat Yourself or Your code. 
Encapsulate what varies (الاشياء التى تتغير كثيرا تكون فى مكان واحد)
The best benifit is the code reusability and centeralization.
Implementd example: customer discounts.
---------------------------------------------------------------------------------     
5- Null Object Design Pattern
Not in 23 Design Patterns
Type? behavioural
Why? to eliminate null checks
Implementd example: customer discounts.
--------------------------------------------------------------------------------- 
6- Template Method Design Pattern
In 23 Design Patterns
Type? Behavioural
Why? To order steps of doing a specific task without caring about what each step do.
--------------------------------------------------------------------------------- 
7- Factory Method Design Pattern
Not in 23 Design Patterns
Type? Creational 
Why? usually used in the abstraction layer to put in one place group of realed classes(derived)
and hide the creation logic of creating these classes.
Example1: payment wayes in the ecommerce systems.
--------------------------------------------------------------------------------- 
8- State Design Pattern
In 23 Design Patterns
Type? Behavioural 
Why? Represent the state of the object
Example1: ATM Machine
Example2: online order state(draft,confirm, processing, cancel, shipped, delivered, return)
--------------------------------------------------------------------------------- 
9- Command (Basics) Design Pattern
In 23 Design Patterns
Type? Behavioural 
Why? To encapsulate request(method call) inside object.
---------------------------------------------------------------------------------
10- Command (Macros) Design Pattern
In 23 Design Patterns
---------------------------------------------------------------------------------
11- Command (Undo/Redo) Design Pattern
In 23 Design Patterns
---------------------------------------------------------------------------------
12- Memento Design Pattern
In 23 Design Patterns
---------------------------------------------------------------------------------
13- Builder Design Pattern
Not in 23 Design Patterns
Type? Creational
Why? facilitate create the complex objects تسهيل إنشاء الكائنات المعقدة
Example: Salary Calculator class.
Naming convention create class suffix with word Builder.
---------------------------------------------------------------------------------
14- Decorator Design Pattern (wrapper)
In 23 Design Patterns
Type? Structural
Why? To update or add new functionality to an object at runtime.
Example: OrderProcess wrapper the process method.
Naming convention create class suffix with word Decorator.
---------------------------------------------------------------------------------
15- Chain of Responsibility Design Pattern
In 23 Design Patterns
Type? Behavioural
Why? chain of objects to process a request.
Example: middlewares in dotnet.
Example: Vacation day request approval workflow.

---------------------------------------------------------------------------------