---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/2692
is_stripe_api_change: true
released_in_version: 41.16.0
---

* Add support for `Paypal` on `ChargePaymentMethodDetails`, `Checkout.SessionPaymentMethodOptionsOptions`, `MandatePaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentIntentPaymentMethodOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `SetupAttemptPaymentMethodDetails`, `SetupIntentPaymentMethodDataOptions`, `SetupIntentPaymentMethodOptionsOptions`, and `SetupIntentPaymentMethodOptions`
* Add support for `NetworkToken` on `ChargePaymentMethodDetailsCard`
* Add support for `TaxabilityReason` and `TaxableAmount` on `Checkout.SessionShippingCostTaxes`, `Checkout.SessionTotalDetailsBreakdownTaxes`, `CreditNoteShippingCostTaxes`, `CreditNoteTaxAmounts`, `InvoiceShippingCostTaxes`, `InvoiceTotalTaxAmounts`, `LineItemTaxes`, `QuoteComputedRecurringTotalDetailsBreakdownTaxes`, `QuoteComputedUpfrontTotalDetailsBreakdownTaxes`, and `QuoteTotalDetailsBreakdownTaxes`
* Add support for `Brand`, `CardholderName`, `Country`, `ExpMonth`, `ExpYear`, `Fingerprint`, `Funding`, `Last4`, `Networks`, and `ReadMethod` on `PaymentMethodCardPresent` and `PaymentMethodInteracPresent`
* Add support for `PreferredLocales` on `PaymentMethodInteracPresent`
* Add support for `EffectivePercentage` on `TaxRate`
* Add support for `GbBankTransfer ` and `JpBankTransfer ` on `CustomerCashBalanceTransactionFundedBankTransfer`
