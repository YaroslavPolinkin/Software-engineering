## a. DRY (Don't Repeat Yourself) 
- the code contains methods to [prevent repetition](lab1/SElab1/SElab1/Money.cs#L43-L57)

## b. KISS (Keep It Simple, Stupid) 
- The code has a fairly simple logic and does not contain unnecessary complexity.

## c. SOLID:

- Single Responsibility Principle - Each of the classes performs one main function: [Money](lab1/SElab1/SElab1/Money.cs) - money transactions, [Product](lab1/SElab1/SElab1/Product.cs) - product representation,
  [Warehouse](lab1/SElab1/SElab1/Warehouse.cs) - warehouse management,
  [Reporting](lab1/SElab1/SElab1/Reporting.cs) - generating reports on warehouse products.

- Open/Closed Principle - Classes can be easily extended by adding new methods or functionality without having to change the existing code.

- Liskov Substitution Principle - Classes use other classes through their [abstractions](lab1/SElab1/SElab1/Product.cs#L18-L26) (for example, through interfaces or base classes), which contributes to flexibility and the ability to replace objects of one class with objects of another class without changing the logic of the program.

- Interface Segregation Principle - Classes do not have large, non-specific interfaces, but use only those methods that are necessary for their functioning.

- Dependency Inversion Principle - Classes are not tied to specific implementations, but depend on abstractions (for example, interfaces), which allows you to change the behaviour of the program by replacing specific implementations without changing the calling code.

## d. YAGNI (You Ain't Gonna Need It) 

- Don't include unnecessary functionality or complexity in my code, only include functionality when it is really needed.

## e. Composition Over Inheritance 

- Classes do not use inheritance, but are composed of other classes (for example, the [Warehouse class contains a list of objects of the Product class](lab1/SElab1/SElab1/Warehouse.cs#L15-L20)), which allows you to better control the behaviour of objects.

## f. Program to Interfaces not Implementations 

- The code uses interfaces where possible. For example, [the Reporting class takes a Warehouse object in its constructor](lab1/SElab1/SElab1/Reporting.cs#L13-L16), rather than a specific implementation of the Warehouse class.

## g. Fail Fast 

- [Validation](lab1/SElab1/SElab1/Reporting.cs#L28-L44) checks are used to ensure that my Reporting class methods are valid and that elements are present to ensure that they are safe and do not make unexpected errors.

In summary, the code adheres to many important programming principles, which contributes to its cleanliness, flexibility, and ease of extension.
