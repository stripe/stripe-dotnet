---
title: Use a neutral address options type for V2 requests
semver_level: major
jira_tickets_closed:
  - DEVSDK-3119
---

* ⚠️ Change V2 request address properties from the V1 `Stripe.AddressOptions` and `Stripe.AddressJapanOptions` types to `Stripe.V2.AddressOptions`. The V2 type supports the standard address fields and optional `Town` without implying that the address must be in Japan.
