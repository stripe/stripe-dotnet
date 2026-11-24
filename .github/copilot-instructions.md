# Copilot Code Review Instructions

### JSON serialization

Stripe.net supports both Newtonsoft.Json and System.Text.Json, and integrators may serialize SDK objects (for example, to put an `EventNotification` on a queue) and deserialize them later.

- **Check that new or changed types in the serialization path round-trip through both libraries.** This applies to any type used as a property of a serialized object, including types that don't derive from `StripeEntity` (such as `EventNotification` and the types of its properties). Flag a type if both of these are true:
  - Its state can't be set during deserialization: properties are getter-only or have non-public setters, or the state is only set through a constructor that takes arguments.
  - It has neither a `[JsonConverter]` for both libraries (`Newtonsoft.Json.JsonConverter` and `System.Text.Json.Serialization.JsonConverter`) nor a constructor that both libraries can use to set that state.

  Both libraries silently skip properties they can't set. A type like this serializes fine but deserializes into an empty object, with no error.
- **Expect a test that serializes and deserializes the type with both libraries** and asserts that the values survive. Don't rely on the wholesome tests in `src/StripeTests/Wholesome/` for this: the converter checks there only scan `StripeEntity` subclasses and `INestedOptions` classes.
- **If a type's JSON shape changes, check that the previous shape can still be read**, since payloads written by earlier versions may already be stored.
