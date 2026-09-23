---
title: Use a neutral address options type for V2 requests
semver_level: major
jira_tickets_closed:
  - DEVSDK-3119
---

* ⚠️ Change V2 request address properties from `Stripe.AddressJapanOptions` to `Stripe.V2.AddressOptions`. The new type supports the standard address fields and `Town` without implying that the address must be in Japan.
