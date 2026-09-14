---
title: Remove `Order` and `OrderItem` resources and APIs as those have been deprecated for multiple years.
semver_level: major
section: ⚠️ Removed
released_in_version: 40.0.0
---

* Remove `OrderPaymentSucceeded`, `OrderUpdated`, and `OrderReturnCreated` event constants. These events are deprecated.
* Remove `Order` and `OrderId` properties in `Charge` entity. The property was deprecated.
