# Unexpected Side Effects from Property Access in C#

This example demonstrates a potential issue in C# where accessing a property within a class might trigger unintended side effects due to complex logic within the property's setter.  Improper usage of properties can lead to bugs that are difficult to track down.

**Scenario:** The `Value` property has a setter that performs additional operations beyond simple assignment.  Accessing `Value` in `SomeMethod` might trigger these side effects unexpectedly.

**Solution:** Consider refactoring properties with complex setters to separate methods that more clearly reflect the intended behavior. This improves code clarity and reduces unexpected side effects.