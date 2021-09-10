# Abstract Factory Pattern

The Abstract Factory Pattern is a creational pattern in which interfaces are defined for creating families of related objects without specifying their actual implementations.

## The Problem

Imagine that we are creating a restaurant menu generator. Our code consists of classes that represent:
1. A family of related products, say: `Appetizer`, `Cold Dish`, `MainDish` and `Dessert`.
2. Several variants of this family. For example, the above products are available in these variants: `Vegetarian`, `Meat Based`, `Fish Based`, and `Surf and Turf`.

We need a way to create individual menu objects so that they match other objects of the same family. Customers can get quite mad when they receive non-matching dishes.

Also, we don't want to change existing code when adding new products or families of products to the program. Chefs tend to update their recipes, and we wouldn't want to change the core code each time it happens.

## The Solution

The first thing the Abstract Factory pattern suggests is to explicitly declare interfaces for each distinct product of the product family (e.g., appetizer, cold dish, or dessert). Then we can make all variants of products follow those interfaces. For example, all appetizer variants of products can immplement the `Appetizer` interface; all dessert variants can implement the `Dessert` interface, and so on.

The next move is to declare the *Abstract Factory*-an interface with a list of creation methods for all products that are part of the product family (for example, `createAppetizer`, `createColdDish` and `createDessert`). These methods must return **abstract** product types represented by the interfaces we extracted previously: `Appetizer`, `ColdDish`, `Dessert` and so on.

Now, how about the product variants? For each variant of a product family, we create a separate factory class based on the `AbstractFactory` interface. A factory is a class that returns products of a particular kind. For example, a `VegetarianMealFactory` can only create `VegetarianAppetizer`, `VegetarianColdDish`, `VegetarianMainDish` and `VegetarianDessert` objects. 

The client code has to work with both factories and products via their respective abstract interfaces. This lets us change the type of a factory that we pass to the client code, as well as the product variant that the client code receives, without breaking the actual code.

Say the client wants a factory to produce a dessert. The client doesn't have to be aware of the factory's class, nor does it matter what kind of dessert it gets. Whether is a vegetarian dessert, or a surf-and-turf dessert, the client must treat all desserts in the same manner, using the abstract `Dessert` interface. With this approach, the only thing that the client knows about the dessert, is that implements the `Dessert` interface's methods in some way. Also whichever variant of the chair is returned, it'll always match the type of appetizer or main dish produced by the same factory object. 

## Structure

![Abstract Factory Structure]()

1. **Abstract Products** declare interfaces for a set of distinct but related products which make up a product family.
2. **Concrete Products** are various implementations of abstract products, grouped by variants. Each abstract product (appetizer, main dish) must be implemented in all given variants (Vegetarian, Surf and Turf).
3. The **Abstract Factory** interface declares a set of methods for creating each of the abstract products.
4. **Concrete Factories** implement creation methods of the abstract factory. Each concrete factory corresponds to a specific variant of products and creates only those product variants.
5. Although concrete factories instantiate concrete products, signatures of their creation methods must return the corresponding *abstract* products. This way the client code that uses a factory doesn't get copled to the specific variant of the product it gets from the factory. The **Client** can work with any concrete factory/product variant, as long as it communicates with their objects via abstract interfaces. 

## When to Use

### Use the Abstract Factory when your code needs to work with various families of related products, but you don’t want it to depend on the concrete classes of those products—they might be unknown beforehand or you simply want to allow for future extensibility.

he Abstract Factory provides us with an interface for creating objects from each class of the product family. As long as our code creates objects via this interface, we don’t have to worry about creating the wrong variant of a product which doesn’t match the products already created by our app.

- Consider implementing the Abstract Factory when you have a class with a set of Factory Methods that blur its primary responsibility.
- In a well-designed program each class is responsible only for one thing. When a class deals with multiple product types, it may be worth extracting its factory methods into a stand-alone factory class or a full-blown Abstract Factory implementation.

## How to Implement

1. Map out a matrix of distinct product types versus variants of these products.
2. Declare abstract product interfaces for all product types. Then make all concrete product classes implement these interfaces.
3. Declare the abstract factory interface with a set of creation methods for all abstract products.
4. Implement a set of concrete factory classes, one for each product variant.
5. Create factory initialization code somewhere in the app. It should instantiate one of the concrete factory classes, depending on the application configuration or the current environment. Pass this factory object to all classes that construct products.
6. Scan through the code and find all direct calls to product constructors. Replace them with calls to the appropriate creation method on the factory object.

## Pros and Cons

|||
|:---|:---|
|✔️  You can be sure that the products you’re getting from a factory are compatible with each other.|❌ The code may become more complicated than it should be, since a lot of new interfaces and classes are introduced along with the pattern. |
|✔️ You avoid tight coupling between concrete products and client code.||
|✔️ *Single Responsibility Principle*. You can extract the product creation code into one place, making the code easier to support.||
|✔️ *Open/Closed Principle*. You can introduce new variants of products without breaking existing client code.||
