# Decorator Pattern

## Intent

The **Decorator** is a structural pattern that lets you attach new behaviours to an objects by placing these objects inside special wrappers that contain the behaviors.

In other words, we can create an object and then extend it by adding a variety of "features" to it. A good analogy to simplify this pattern is: "*Wrapping a gift, putting it in a box, and wrapping a box*".

## The Problem

Imagine that you are working on a notification functionality of a microservice that lets users to be notified about important events.

The initial version of the functionality is based on the `Notificer` class with a single `Send` method. The method could accept a message argument from the client and then send the message to a list of emails. 

At some point, you realize that users of the microservice expect more than just email notifications. Business analysts dictate that users should receive an SMS about critical issues. Also a browser notification should be provided, if the user is currently browsing the website. Moreover, some users would like to have a Viber notification. Finally, traders would love to get Slack notifications.

How hard can that be? We can extend the `Notifier` class and add the additional notification methods into new subclasses. Now the client was supposed to instantiate the desired notification class and use it for all further notifications.

But then someone reasonably asked "Why can't we use several notification types at once?"

We can try to address this problem by creating special subclasses which combine several notification methods within one class. However, it can quickly become apparent that this approach will bloat the code immensely, since it causes a "combinatorial explosion" of subclasses. So, we need to find some other way to structure our notification classes so that their number won't accidentally break some Guinness record.

## The Solution

Extending a class is the first thing that comes in mind when we want to alter an object behaviour in some capacity. However, there are some serious caveats that we need to be aware, when using inheritance.

- **Inheritance is static**. We cannot alter the behaviour of an existing object at runtime. We can only swap the object with another one, that is being created by another subclass.
- **Subclasses can only have one parent class**. 

One of the ways to overcome these caveats is by using *Aggregation* or *Composition* instead of *Inheritance*. Both of the alternatives, are almost the same: one of the objects *has* a reference to another and delegates it some work, whereas with inheritance, the object itself *is* able to do that kind of work, inheriting the behaviour from its superclass.

With this new approach, we can easily substitute the linked "helper" object with another, changing the behaviour of the container at **runtime**. An object can use the behaviour of multiple classes, having references to any number of objects and delegating them all kinds of work, thus changing its behaviours. Aggregation/Composition is the key principle behind many design patterns including Decorator.

A Decorator is also called a **Wrapper**. This alias clearly expresses the main idea of the pattern. A *wrapper* is an object that can be linked with some *target* object. The wrapper contains the same set of methods as the targed and delegates to it all requests it receives. However, the rapper may alter the result by doing something either before or after it passes the request to the target. The wrapper implements the same interface as the wrapped object. That's why from the client's perspective these objects are identical. If the wrapper's reference field accepts any object that follows the interface, we can cover an object in multiple wrappers, adding the combined behaviour of all the wrappers to it. 

## Structure

![Decorator Structure](https://github.com/Kalkwst/Training-Manuals/blob/feature/Decorator/Design%20Patterns/Decorator/img/Decorator_Structure.png)

1. The **Component** declares the common interface for both wrappers and wrapped objects.
2. **Concrete Component** is a class of objects being wrapped. It defines the basic behaviour, which can be altered by decorators
3. The **Base Decorator** class has a field for referencing a wrapped object. The field’s type should be declared as the component interface so it can contain both concrete components and decorators. The base decorator delegates all operations to the wrapped object.
4. **Concrete Decorators** define extra behaviors that can be added to components dynamically. Concrete decorators override methods of the base decorator and execute their behavior either before or after calling the parent method.
5. The **Client** can wrap components in multiple layers of decorators, as long as it works with all objects via the component interface.

## When to Use

### Use the Decorator pattern when you need to be able to assign extra behaviors to objects at runtime without breaking the code that uses these objects.

The Decorator lets you structure your business logic into layers, create a decorator for each layer and compose objects with various combinations of this logic at runtime. The client code can treat all these objects in the same way, since they all follow a common interface.

### Use the pattern when it’s awkward or not possible to extend an object’s behavior using inheritance.

Many programming languages have the `final` keyword that can be used to prevent further extension of a class. For a final class, the only way to reuse the existing behavior would be to wrap the class with your own wrapper, using the Decorator pattern.

## How to Implement

1. Make sure your business domain can be represented as a primary component with multiple optional layers over it.
2. Figure out what methods are common to both the primary component and the optional layers. Create a component interface and declare those methods there.
3. Create a concrete component class and define the base behavior in it.
4. Create a base decorator class. It should have a field for storing a reference to a wrapped object. The field should be declared with the component interface type to allow linking to concrete components as well as decorators. The base decorator must delegate all work to the wrapped object.
5. Make sure all classes implement the component interface.
6. Create concrete decorators by extending them from the base decorator. A concrete decorator must execute its behavior before or after the call to the parent method (which always delegates to the wrapped object).
7. The client code must be responsible for creating decorators and composing them in the way the client needs.

## Pros and Cons

|||
|:---|:---|
|✔️ You can extend an object’s behavior without making a new subclass. |❌ It’s hard to remove a specific wrapper from the wrappers stack. |
|✔️ You can add or remove responsibilities from an object at runtime. |❌ It’s hard to implement a decorator in such a way that its behavior doesn’t depend on the order in the decorators stack. |
|✔️ You can combine several behaviors by wrapping an object into multiple decorators. |❌ The initial configuration code of layers might look pretty ugly. |
|✔️ *Single Responsibility Principle*. You can divide a monolithic class that implements many possible variants of behavior into several smaller classes.||
