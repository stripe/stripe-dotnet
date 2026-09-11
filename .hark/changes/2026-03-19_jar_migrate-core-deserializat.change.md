---
title: Migrate core deserialization and default JSON library to System.Text.Json
pr_link: https://github.com/stripe/stripe-dotnet/pull/3327
is_breaking: true
released_in_version: 51.0.0
---

- System.Text.Json replaces Newtonsoft Json.NET as the default JSON library used in serialization and deserialization of Stripe.net objects.  This is most likely non-breaking for most users.
- Serializing Stripe objects using either System.Text.Json or Newtonsoft Json.NET now represents decimal-format strings as JSON string values to match the Stripe API format.
