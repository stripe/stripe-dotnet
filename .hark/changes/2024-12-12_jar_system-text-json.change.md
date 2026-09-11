---
title: System.Text.Json Serialization Support in .NET SDK Objects
pr_link: https://github.com/stripe/stripe-dotnet/pull/3033
released_in_version: 47.2.0-beta.3
---

- Add System.Text.Json support for serializing Stripe.net entities and objects for applications running on .NET 6 and above. Now you can pass a Stripe.net object or collection of objects to the System.Text.Json serializer and it will produce the correct JSON string.
