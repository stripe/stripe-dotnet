---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3423
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.4.0-alpha.2
---

* Add support for new resources `Billing.FeedbackOption` and `PaymentPlan`
* ⚠️ Remove support for resource `Billing.FeedbackOptions`
* Add support for `Create`, `Get`, `List`, and `Update` methods on resource `PaymentPlan`
* Add support for `Update` method on resource `V2.MoneyManagement.Transaction`
* Add support for `WechatPayPayments` on `Account.Settings` and `AccountSettingsOptions`
* ⚠️ Change type of `BillingPortal.Configuration.Features.SubscriptionCancel.CancellationReason.FeedbackOptions` from `$Billing.FeedbackOptions` to `$Billing.FeedbackOption`
* Add support for `SubscriptionPause` on `BillingPortal.Session.Flow`
* Add support for `ActiveEntitlements` on `CustomerSession.Components`
* Add support for `SharedPaymentIssuedToken` on `DelegatedCheckout.RequestedSessionConfirmOptions`
* Add support for `ManagedPayments` on `InvoiceCreateOptions`, `InvoiceItemCreateOptions`, `InvoiceItem`, `Invoice`, and `QuotePreviewInvoice`
* Add support for `PaymentPlan` on `Invoice`
* Add support for `EstimatedFeeDetails` and `EstimatedFee` on `Issuing.Authorization.PendingRequest.HoldAmountDetails` and `Issuing.Authorization.RequestHistory.HoldAmountDetails`
* ⚠️ Remove support for `Cryptogram` on `PaymentAttemptRecord.PaymentMethodDetails.Card.ThreeDSecure` and `PaymentRecord.PaymentMethodDetails.Card.ThreeDSecure`
* ⚠️ Change type of `ProductCatalog.TrialOffer.EndBehavior.Transition.Price` from `$Price` to `deletable($Price)`
* ⚠️ Change type of `Subscription.CancellationDetails.FeedbackOption` from `$Billing.FeedbackOptions` to `$Billing.FeedbackOption`
* Add support for `CancelAtPeriodEnd` on `Subscription.PendingUpdate`
* Add support for `Igic` on `Tax.Registration.CountryOptions.At`, `Tax.Registration.CountryOptions.Be`, `Tax.Registration.CountryOptions.Bg`, `Tax.Registration.CountryOptions.Cy`, `Tax.Registration.CountryOptions.Cz`, `Tax.Registration.CountryOptions.De`, `Tax.Registration.CountryOptions.Dk`, `Tax.Registration.CountryOptions.Ee`, `Tax.Registration.CountryOptions.Es`, `Tax.Registration.CountryOptions.Fi`, `Tax.Registration.CountryOptions.Fr`, `Tax.Registration.CountryOptions.Gr`, `Tax.Registration.CountryOptions.Hr`, `Tax.Registration.CountryOptions.Hu`, `Tax.Registration.CountryOptions.Ie`, `Tax.Registration.CountryOptions.It`, `Tax.Registration.CountryOptions.Lt`, `Tax.Registration.CountryOptions.Lu`, `Tax.Registration.CountryOptions.Lv`, `Tax.Registration.CountryOptions.Mt`, `Tax.Registration.CountryOptions.Nl`, `Tax.Registration.CountryOptions.Pl`, `Tax.Registration.CountryOptions.Pt`, `Tax.Registration.CountryOptions.Ro`, `Tax.Registration.CountryOptions.Se`, `Tax.Registration.CountryOptions.Si`, and `Tax.Registration.CountryOptions.Sk`
* Add support for `Metadata` on `V2.Billing.Contract.PricingLines.Data.Pricing.PriceDetails.PricingOverrides.Data`, `V2.Billing.Contract.PricingOverrides.Data`, `V2.Billing.ContractUpdateOptions`, `V2.MoneyManagement.Transaction`, `V2BillingContractPricingLineActionUpdateOptions`, `V2BillingContractPricingOverrideActionAddOptions`, `V2BillingContractPricingOverrideActionUpdateOptions`, and `V2BillingContractPricingOverrideOptions`
* Add support for `TaxAmount` on `V2.MoneyManagement.OutboundPaymentQuote.EstimatedFee`
* Add support for `PayoutMethodOptions` on `V2.MoneyManagement.OutboundPaymentQuote.To` and `V2MoneyManagementOutboundPaymentQuoteToOptions`
* Change type of `V2BillingContractPricingLineActionUpdatePricingPriceDetailsPricingOverrideActionUpdateOptions.Metadata` from `string` to `emptyable(string)`
* Add support for snapshot events `PaymentPlanCreated`, `PaymentPlanInstallmentDue`, `PaymentPlanInstallmentPaid`, `PaymentPlanInstallmentWillBeDue`, and `PaymentPlanUpdated` with resource `PaymentPlan`
