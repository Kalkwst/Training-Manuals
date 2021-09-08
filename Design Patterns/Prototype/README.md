# Prototype Pattern

The Prototype pattern is a creational pattern in which objects are created using a prototypical instance of said object.  This pattern is particularly useful for creating lots of instances of an object, all of which share some or all of their values.

## The Problem

Imagine that we want to model the color spectrum. There are about 10 million visible colors, so modeling them as individual classes (e.g., `Red`, `Light Mauve`, [`Goose Turd Green`](https://www.colourlovers.com/color/54FFA2/Goose_Turd_Green), [`Lusty Galland`](https://colorsinspo.com/solid-colors/lusty-gallant/), etc) would be rather impractical.

However, a color is a color, no matter what color it is; colors have the same properties (e.g., `RGB values`, `HEX values`, `HSL values` etc) as each other even if they don't have the same values.

So, it would be great if we could create a way to create a lot of simiral objects, without having to worry about private fields and extra dependencies.

## The Solution

The Prototype pattern delegates the cloning process to the actual objects that are being cloned. This is achieved by declaring a comon interface for all objects that support cloning. This interface, allows us to clone an object without coupling the code to the class of that object. Usually, such an interfaces contains just a single `Clone` method.

The implementation of the clone method is more or less the same in all classes. The method creates an object of the primogenitor class and carries over all of the field values from the priimogenitor object to the descendant object.

## Structure

### Basic Implementation

![Prototype Basic Implementation](https://github.com/Kalkwst/Training-Manuals/blob/feature/Prototype/Design%20Patterns/Prototype/img/BasePrototype.png)

1. The **Prototype** interface declares the cloning methods. In most cases, it's a single `Clone` method.
2. The **Concrete Prototype** class implements the cloning method. In addition to copying the original object's data to the clone, this method may also handle some edge cases of cloning process related to cloning linked objects, untangling recursive dependencies, etc.
3. The **Client** can produce a copy of any object that follows the prototype interface.

### Prototype Registry Implementation

![Prototype Registry Implementation](https://github.com/Kalkwst/Training-Manuals/blob/feature/Prototype/Design%20Patterns/Prototype/img/PrototypeRegistry.png)

1. The **Prototype Registry** provides an easy way to access frequently-used prototypes. It stores a set of pre-built objects that are ready to be copied. The simplest prototype registry is a `name -> prototype` has map. However, if you need better search criteria than a simple name, you can build a much more robust version of the registry.

## When to Use

### Use the prototype pattern when your code shouldn't depend on the concrete classes of objects that you need to copy

This happens a lot when your code works with objects passed to you from a third party code via some interface. The concete classes of these objects are unknown, and you couldn't depend on them even if you wanted to.

The prototype pattern provides the client code with a general interface for working with all objects that support cloning. This interface makes the client code dependent from the concrete classes of objects that it clones.

### Use the pattern when you want to reduce the number of subclasses that only differ in the way they initialize their respective objects

The Prototype pattern lets you use a set of pre-built objects, configured in various ways, as prototypes.

Instead of instantiating a subclass that matches some configuration, the client can simply look for an appropriate prototype and clone it.

## How to Implement

1. Create the prototype interface and declare the `Clone` method in it. Or just add the method to all classes of an existing class hierarchy, if you have one.
2. A prototype class must define the alternative constructor that accepts an object of that class as an argument. The constructor must copy the values of all fields defined in the class from the passed object into the newly created instance. If you’re changing a subclass, you must call the parent constructor to let the superclass handle the cloning of its private fields.

    If your programming language doesn’t support method overloading, you may define a special method for copying the object data. The constructor is a more convenient place to do this because it delivers the resulting object right after you call the `new` operator.
3. The cloning method usually consists of just one line: running a `new` operator with the prototypical version of the constructor. Note, that every class must explicitly override the cloning method and use its own class name along with the `new` operator. Otherwise, the cloning method may produce an object of a parent class.
4. Optionally, create a centralized prototype registry to store a catalog of frequently used prototypes.

    You can implement the registry as a new factory class or put it in the base prototype class with a static method for fetching the prototype. This method should search for a prototype based on search criteria that the client code passes to the method. The criteria might either be a simple string tag or a complex set of search parameters. After the appropriate prototype is found, the registry should clone it and return the copy to the client.

    Finally, replace the direct calls to the subclasses’ constructors with calls to the factory method of the prototype registry.

## Pros and Cons

|||
|:---|:---|
|✔️ You can clone objects without coupling to their concrete classes.|❌ Cloning complex objects that have circular references might be very tricky.|
|✔️ You can get rid of repeated initialization code in favor of cloning pre-built prototypes.||
|✔️ You can produce complex objects more conveniently.||
|✔️ You get an alternative to inheritance when dealing with configuration presets for complex objects.||
