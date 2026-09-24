---
title: Generate operation-specific address options for V2 requests
semver_level: major
---

* ⚠️ Change ordinary V2 request address properties that include `Town` from `Stripe.AddressJapanOptions` to operation-specific address option types. V2 Kana and Kanji script addresses continue to use `Stripe.AddressJapanOptions`.
