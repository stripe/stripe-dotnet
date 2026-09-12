---
title: Fix emptyable property serialization for third-party serializers
pr_url: https://github.com/stripe/stripe-dotnet/pull/3366
released_in_version: 51.0.1
---

* Fixes a bug where serializing Options objects through a third-party serializer (e.g. AWS Lambda) could cause the SDK to unintentionally clear fields on the API. Emptyable properties now have null-skipping annotations so third-party serializers omit unset properties during round-trips.
