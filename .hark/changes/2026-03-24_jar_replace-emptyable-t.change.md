---
title: Replace Emptyable<T> with SetTracker pattern for explicit null support
pr_url: https://github.com/stripe/stripe-dotnet/pull/3342
is_breaking: true
released_in_version: 51.0.0
---

- ⚠️  Full support for unsetting metadata entries and certain Options properties.  Set the metadata entry or nullable property to `null` and the SDK will send an empty string for V1 APIs and a null value for V2 APIs.
  - ⚠️  This changes the meaning of setting a property to `null` if that property is defined as nullable in our API Ref.  If you currently pre-initialize your Options values to null this could have unintended consequences.
- ⚠️  Removed `IEmptyable`, `IEmptyable<T>`, `Emptyable<T>`, `EmptyableConverter<T>`, and `STJEmptyableConverter<T>` - replaced by SetTracker pattern on Options properties.
