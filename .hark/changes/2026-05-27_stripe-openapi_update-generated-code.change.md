---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3386
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.2.0
---

* Add support for new resource `V2.Commerce.ProductCatalogImport`
* Add support for `Create` and `Get` methods on resource `V2.Commerce.ProductCatalogImport`
* Add support for `BizumPayments` and `ScalapayPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
* Add support for `AutomaticTransferRulesByCurrency` on `BalanceSettings.Payments.Payouts` and `BalanceSettingsPaymentsPayoutsOptions`
* Add support for `StartOfDay` on `BalanceSettings.Payments.SettlementTiming` and `BalanceSettingsPaymentsSettlementTimingOptions`
* Add support for `Description` on `ChargeTransferDataOptions`, `PaymentIntent.TransferData`, and `PaymentIntentTransferDataOptions`
* Add support for `Bizum` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, `SetupIntent.PaymentMethodOptions`, `SetupIntentPaymentMethodDataOptions`, and `SetupIntentPaymentMethodOptionsOptions`
* Add support for `Scalapay` on `Charge.PaymentMethodDetails`, `Checkout.Session.PaymentMethodOptions`, `CheckoutSessionPaymentMethodOptionsOptions`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, `Refund.DestinationDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Mandate` on `Charge.PaymentMethodDetails.Twint`, `PaymentAttemptRecord.PaymentMethodDetails.Twint`, and `PaymentRecord.PaymentMethodDetails.Twint`
* Change type of `CheckoutSessionPaymentMethodOptionsTwintOptions.SetupFutureUsage` and `PaymentIntentPaymentMethodOptionsTwintOptions.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
* ⚠️ Change type of `Checkout.Session.PaymentMethodOptions.Twint.SetupFutureUsage` and `PaymentIntent.PaymentMethodOptions.Twint.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
* Add support for `CreditedItems` on `InvoiceItem.ProrationDetails`
* Add support for `Discountable` on `InvoiceScheduleDetailsPhaseAddInvoiceItemOptions`, `SubscriptionAddInvoiceItemOptions`, `SubscriptionSchedule.Phase.AddInvoiceItem`, and `SubscriptionSchedulePhaseAddInvoiceItemOptions`
* Add support for `BillingSchedules` on `InvoiceSubscriptionDetailsOptions`, `SubscriptionCreateOptions`, `SubscriptionUpdateOptions`, and `Subscription`
* Add support for `AmountPaidOffStripe` on `Invoice`
* Add support for `Twint` on `Mandate.PaymentMethodDetails` and `SetupAttempt.PaymentMethodDetails`
* Add support for `Metadata` on `PaymentIntent.TransferData`, `PaymentIntentTransferDataOptions`, and `Subscription.PendingUpdate`
* Add support for `PaymentData` on `PaymentIntent.TransferData` and `PaymentIntentTransferDataOptions`
* Add support for `BlikAuthorize` on `PaymentIntent.NextAction` and `SetupIntent.NextAction`
* Add support for `PaymentMethodOptions` on `PaymentLinkCreateOptions`, `PaymentLinkUpdateOptions`, and `PaymentLink`
* Add support for `Active` on `PaymentMethodConfigurationListOptions`
* Add support for `BilledUntil` on `SubscriptionItem`
* Add support for `Discount` and `Discounts` on `Subscription.PendingUpdate`
* Add support for `VerifoneM425`, `VerifoneP630`, `VerifoneUx700`, and `VerifoneV660p` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `Terminal.Configuration`
* Add support for `ApiError` and `PrintContent` on `Terminal.Reader.Action`
* Add support for `Customer` on `TestHelpers.TestClockCreateOptions`
* Add support for `Signer` on `V2.Core.Account.Identity.BusinessDetails.Documents.ProofOfRegistration`, `V2.Core.Account.Identity.BusinessDetails.Documents.ProofOfUltimateBeneficialOwnership`, `V2CoreAccountIdentityBusinessDetailsDocumentsProofOfRegistrationOptions`, `V2CoreAccountIdentityBusinessDetailsDocumentsProofOfUltimateBeneficialOwnershipOptions`, `V2CoreAccountTokenIdentityBusinessDetailsDocumentsProofOfRegistrationOptions`, and `V2CoreAccountTokenIdentityBusinessDetailsDocumentsProofOfUltimateBeneficialOwnershipOptions`
* Add support for `AzureEventGrid` on `V2.Core.EventDestinationCreateOptions` and `V2.Core.EventDestination`
* Add support for event notifications `V2CommerceProductCatalogImportsFailedEvent`, `V2CommerceProductCatalogImportsProcessingEvent`, `V2CommerceProductCatalogImportsSucceededEvent`, and `V2CommerceProductCatalogImportsSucceededWithErrorsEvent` with related object `V2.Commerce.ProductCatalogImport`
