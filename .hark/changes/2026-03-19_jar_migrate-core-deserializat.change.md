---
title: Migrate core deserialization and default JSON library to System.Text.Json
pr_url: https://github.com/stripe/stripe-dotnet/pull/3327
semver_level: major
released_in_version: 51.0.0
---

- System.Text.Json replaces Newtonsoft Json.NET as the default JSON library used in serialization and deserialization of Stripe.net objects.  This is most likely non-breaking for most users.
- Serializing Stripe objects using either System.Text.Json or Newtonsoft Json.NET now represents decimal-format strings as JSON string values to match the Stripe API format.
