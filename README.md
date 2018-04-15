# Immutable UI

Immutable UI is a collection of
immutable data objects that mirror object-oriented user interface APIs. It's like a "shadow DOM" for .NET apps.

So far, only Xamarin.Forms has been bound but I hope to also
cover UIKit. And I still haven't bound events... wip :-)


## Try it

1. Open ImmutableUI.sln in Visual Studio.

2. Select the project **FormsButtonCounter** in the Samples folder, and run it.

3. Click the "Increment" button a few times.

4. Note that the label increases.


## Immutable UI Models

There is an immutable model class provided for
every UI class in Xamarin.Forms.

To keep ourselves sain, each of these objects is suffixed with **Model**
and is contained in the namespace **ImmutableUI.Forms**.
(If the names weren't suffixed then terribly annoying name collisions
would happen with the OOP API.)

For example, `Xamarin.Forms.Button` has an immutable counterpart named `ImmutableUI.Forms.ButtonModel`.

### Thread Safety

UI Model objects can be used on multiple threads simulataneously since there's no risk of corrupting state.

### Sharing

Immutable objects can be added to multiple UI trees to make multiple displays and caching easy.

### Structural Equality

Every object implements deep versions of `Equals` and `GetHashCode` so
that you can reliably test if two UIs are identical. This also allows
you to use these objects as keys in dictionaries and sets.

### Fluent Setter Interface

Let's be honest, immutable objects are a bit of a pain to deal with - 
sometimes you just want to set a property. Well, you still can't quite do
that, but this library does provide a fluent interface to help out. Here it is in action:

```csharp
var basicButton = new Button().WithFontSize(24).WithTextColor(Color.Green);
var okButton = basicButton.WithText("OK").WithCommand(ok);
var cancelButton = basicButton.WithText("Cancel").WithTextColor(Color.Red).WithCommand(cancel);
```

### Complete Constructors

Every object's constructor accepts any of the properties stored in the object. In fact, constructing objects is your only chance to set these properties.

Every constructor parameter is a lowercased named after its corresponding
property. Each one also has a default so you aren't forced to specify
everything.

The fluent example above would can be written using constructors:

```csharp
var basicButton = new Button(fontSize: 24, textColor: Color.Green);
```

### Serializable

Every object is light-weight and can be serialized and deserialized
using your favorite library.

This means your UI can now be serialized. This opens up many opportunities
for quick state restoration, in-app gui design, etc.

### Works with the Mutable Objects

None of these objects would be useful unless they could work with
their original mutable counterparts.

This is accomplished with two methods:

* `Create*` creates the mutable counterpart to the immutable object and
sets its properties appropriately. For example, `ButtonModel` objects
have a `CreateButton` method that returns a `Xamarin.Forms.Button`.
This is the easiest way to create real UI objects from these lightweight
immutable objects.

* `Apply` sets the properties of the mutable oop object to match the
properties of the immutable object. The following example shows its
simplest use:

```csharp
// Create the UI object independently of the immutable object
var button = new Button();
// Now create our immutable object model
var buttonModel = new ButtonModel(text: "Hello");
// Set the properties of `button` to those of the model
buttonModel.Apply(button);
```

**Important note:** While all methods on these model objects are
thread safe thanks to their immutability, you must run the `Apply`
method on the UI thread of your app because it 
directly manipulates the UI. This synchronization is not handled
for you.

## Related Work

* [Elmish.XamarinForms](https://github.com/fsprojects/Elmish.XamarinForms) brings the Elm UI programming model to Xamarin.Forms

