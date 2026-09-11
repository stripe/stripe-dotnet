---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3419
is_stripe_api_change: true
released_in_version: 52.3.0-alpha.2
---

* Add support for new resource `Billing.FeedbackOptions`
* Add support for `SequraPayments` on `Account.Capabilities`
* Add support for `FeedbackOptions` on `BillingPortal.Configuration.Features.SubscriptionCancel.CancellationReason`
* Add support for `Sequra` on `Charge.PaymentMethodDetails`, `Checkout.Session.PaymentMethodOptions`, `ConfirmationToken.PaymentMethodPreview`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, and `PaymentRecord.PaymentMethodDetails`
* Add support for `RetrievalReferenceNumber` on `Charge.PaymentMethodDetails.CardPresent`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, and `PaymentRecord.PaymentMethodDetails.CardPresent`
* Add support for `PricingGroup` on `Charge.PaymentMethodDetails.Link`
* Add support for `TaxRates` on `Checkout.Session.ShippingOption`, `CheckoutSessionShippingOptionOptions`, and `CheckoutSessionShippingOptionsOptions`
* Add support for `FundingTypesBlocked` on `Checkout.Session.PaymentMethodOptions.Card.Restrictions`
* Add support for `Healthcare` on `Issuing.TestHelpersAuthorizationCreateOptions`, `IssuingAuthorizationPurchaseDetailsOptions`, and `IssuingTransactionPurchaseDetailsOptions`
* Add support for `IsAnomalous` on `PaymentAttemptRecordReportGuaranteedOptions`
* Add support for `AadeData` on `PaymentIntent.PaymentMethodOptions.CardPresent`
* Add support for `FeedbackOption` on `Subscription.CancellationDetails`
* Add support for `Application` on `V2.Payments.OffSessionPayment`
* Add support for `Status` on `V2.MoneyManagement.FinancialAccountStatementListOptions`
