---
title: Add support for multiple coupons on Billing APIs
pr_link: https://github.com/stripe/stripe-dotnet/pull/2121
is_stripe_api_change: true
released_in_version: 37.27.0
---

* Add support for arrays of expandable API resources otherwise returning an array of strings by default
* Add support for `Id`, `Invoice` and `InvoiceItem` on `Discount`.
* Add support for `Discounts` on `Invoice`, `InvoiceItem`, `InvoiceLineItem`
* Add support for `DiscountAmounts` on `CreditNote`, `CreditNoteLineItem`, `InvoiceLineItem`
* Add support for `TotalDiscountAmounts` on `Invoice`
