---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3301
is_stripe_api_change: true
released_in_version: 50.4.0-alpha.3
---

* Add support for new resources `V2.Billing.CadenceSpendModifier`, `V2.Billing.OneTimeItem`, and `V2.Billing.RateCardCustomPricingUnitOverageRate`
* Add support for `Create`, `Delete`, `Get`, and `List` methods on resource `V2.Billing.RateCardCustomPricingUnitOverageRate`
* Add support for `Create`, `Get`, `List`, and `Update` methods on resource `V2.Billing.OneTimeItem`
* Add support for `Get` method on resource `V2.Billing.CadenceSpendModifier`
* Add support for `SettlementType` on `ApplicationFee`
* Add support for `RateCardCustomPricingUnitOverageRateDetails` on `InvoiceItem.Pricing` and `InvoiceLineItem.Pricing`
* Add support for `DefaultSettings` on `InvoiceScheduleDetailsOptions`
* Add support for `PaymentBehavior` on `SubscriptionResumeOptions`
* Add support for `EffectiveAt` and `SpendModifierRule` on `V2.Billing.IntentAction.Apply`, `V2.Billing.IntentAction.Remove`, `V2BillingIntentActionApplyOptions`, and `V2BillingIntentActionRemoveOptions`
* Change type of `V2.Billing.IntentAction.Apply.Type`, `V2.Billing.IntentAction.Remove.Type`, `V2BillingIntentActionApplyOptions.Type`, and `V2BillingIntentActionRemoveOptions.Type` from `literal('invoice_discount_rule')` to `enum('invoice_discount_rule'|'spend_modifier_rule')`
