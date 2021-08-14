# Builder Pattern

The **Builder** pattern is a creational design pattern that handles the construction of complex objects step by step. It is arguably the easiest pattern to spot if the existing code needs such a redesign.

The **builder pattern** allows the creation of different **representations** of an object using **the same construction code**.

## The Problem

Imagine that we are working on a pizza ordering app, and we need to add a feature so that the user can create her own customized pizza.

The pizza can be separated into three layers, the dough, the sauce, and the toppings. So, we should ask ourselves, how would a pizza object would be constructed, by selecting among various toppings and a variety of sauces.

For example, let's think about how to create a `Pizza` object. To build a simple margherita pizza, we need thin crust, tomato sauce, and mozzarella toping. But what if we want to create the Super Deluxe Supreme. We would need to add cheesy crust, white pizza sauce, gouda flakes, smoked pork, beacon, mushrooms, tomato and onions. 

The simplest solution would be to extend the base `Pizza` class and create a set of subclasses to cover all combinations of the parameters. But eventually we are going to need a subclass for each pizza type. And if the client decide to add another parameter, such as double decker pizzas, we will be required to grow this hierarchy even more.

There's another approach that doesn't involve breeding subclasses. We can create a giant constructor right in the base `Pizza` class with all possible parameters that control the pizza object. While this approach indeed eliminates tne need for subclasses, it creates another problem.

In most cases, most of the parameters will be unused, making the constructor calls pretty ugly. For instance, only a fraction of pizzas need more than one or two vegetable toppings, so the parameters related to vegetable toppings will be useless nine times out of ten.

## The Solution

The Builder pattern suggests that we can extract the object construction code out of its own class and move it to separate objects called *builders*.

The pattern organizes object construction into a set of steps (e.g., `addCheese`, `addPepperoni`, etc.). To create an object, we execute a series of these steps on a builder object. The important part is that we don't need to call all of the steps. We can call only those steps that are necessary for producing a particular configuration of an object.

#### Director

We can also go further and extract a series of calls to the builder steps we use to construct a product into a separate class called *director*. The director class defines the order in which to execute the building steps, while the builder provides the implementation for these steps.

Having a director class in the program isn't strictly necessary. We can always call the building steps in a speific order directly from the client code. However, the director class might be a good place to add various construction routines so we can reuse them accross our program.

In addition, the director class completely hides the details of product construction from the client code. The client only needs to associate a builder with a director, launch the construction with the director, and get the result from the builder.

## Structure

![Builder Pattern Structure]()

1. The **Builder** interface declares product construction steps that are common to all types of builders.
2. **Concrete Builders** provide different implementations of the construction steps. Concrete builders may build products that don't follow the common interface.
3. **Products** are resulting products. Products constructed by different builders don't have to belong to the same class hierarchy or interface.
4. The **Director** class defines the order in which to call construction steps, so you can create and reuse specific configurations or products.
5. The **Client** must associate one of the builder objects with the director. Usually, it's done only one, via parameters of the director's constructor. Then the director uses the builder object for all further construction.

## When to Use

### Use the Builder Pattern to get rid of a "telescopic constructor"

Say you have a constructor with ten different optional parameters. Calling such a monstrocity is very inconvenient; therefore, you overload the constructor and create several shorter versions with fewer parameters. These constructors still refer to the main one, passing some defalt values into the omitted parameters.

```csharp
class Pizza {
    Pizza(int size) {...}
    Pizza(int size, bool cheese) {...}
    Pizza(int size, bool cheese, bool pepperoni) {...}
    //...
}
```

The **Builder** pattern lets you build objects step by step, using only those steps that you really need. After implementing the pattern, you don't have to create dozens of parameters into your constructors anymore.

### Use the Builder pattern when you want your code to be able to create different representations of some product

The **Builder pattern** can be applied when construction of various representations of the product involves similar steps that differ only in the details.

The base builder interface defines all possible construction steps, and concrete builders implement these steps to construct particular representations of the product. Meanwhile, the director class guides the order of construction.

###  Use the Builder to construct Composite trees or other complex objects.

The Builder pattern lets you construct products step-by-step. You could defer execution of some steps without breaking the final product. You can even call steps recursively, which comes in handy when you need to build an object tree.

A builder doesn’t expose the unfinished product while running construction steps. This prevents the client code from fetching an incomplete result.

## How to Implement

1. Make sure that you can clearly define the common construction steps for building all available product representations. Otherwise, you won’t be able to proceed with implementing the pattern.

2. Declare these steps in the base builder interface.

3. Create a concrete builder class for each of the product representations and implement their construction steps. Don’t forget about implementing a method for fetching the result of the construction. The reason why this method can’t be declared inside the builder interface is that various builders may construct products that don’t have a common interface. Therefore, you don’t know what would be the return type for such a method. However, if you’re dealing with products from a single hierarchy, the fetching method can be safely added to the base interface.

4. Think about creating a director class. It may encapsulate various ways to construct a product using the same builder object.

5. The client code creates both the builder and the director objects. Before construction starts, the client must pass a builder object to the director. Usually, the client does this only once, via parameters of the director’s constructor. The director uses the builder object in all further construction. There’s an alternative approach, where the builder is passed directly to the construction method of the director.

6. The construction result can be obtained directly from the director only if all products follow the same interface. Otherwise, the client should fetch the result from the builder.

## Pros and Cons

|||
|:---|:---|
|✔️ You can construct objects step-by-step, defer construction steps or run steps recursively.|❌ The overall complexity of the code increases since the pattern requires creating multiple new classes.|
|✔️ You can reuse the same construction code when building various representations of products.||
|✔️ *Single Responsibility Principle*. You can isolate complex construction code from the business logic of the product.||
