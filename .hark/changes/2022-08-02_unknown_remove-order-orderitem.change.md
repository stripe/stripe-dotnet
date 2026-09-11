---
title: Remove `Order` and `OrderItem` resources and APIs as those have been deprecated for multiple years.
is_breaking: true
section: ⚠️ Removed
released_in_version: 40.0.0
---

* Remove `OrderPaymentSucceeded`, `OrderUpdated`, and `OrderReturnCreated` event constants. These events are deprecated.
* Remove `Order` and `OrderId` properties in `Charge` entity. The property was deprecated.
