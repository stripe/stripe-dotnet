---
title: Update generated code
pr_link: https://github.com/stripe/stripe-dotnet/pull/3399
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.1.0
---

* Add support for `ReleaseDetails` on `Reserve.Hold`
* Add support for `BuyerId` on `Charge.PaymentMethodDetails.Bizum`, `ConfirmationToken.PaymentMethodPreview.Bizum`, `ConfirmationToken.PaymentMethodPreview.Blik`, `PaymentAttemptRecord.PaymentMethodDetails.Bizum`, `PaymentMethod.Bizum`, `PaymentMethod.Blik`, and `PaymentRecord.PaymentMethodDetails.Bizum`
* Add support for `TransactionLinkId` on `Charge.PaymentMethodDetails.Card`
* Add support for `Fingerprint` on `Charge.PaymentMethodDetails.Pix`, `ConfirmationToken.PaymentMethodPreview.Pix`, `PaymentMethod.Pix`, and `SetupAttempt.PaymentMethodDetails.Pix`
* Add support for `Sunbit` on `Checkout.Session.PaymentMethodOptions`, `CheckoutSessionPaymentMethodOptionsOptions`, `PaymentIntent.PaymentMethodOptions`, and `PaymentIntentPaymentMethodOptionsOptions`
* Add support for `BillingCycleAnchorConfig` on `CheckoutSessionSubscriptionDataOptions`
* Add support for `WechatPay` on `Checkout.Session.PaymentMethodOptions`
* Add support for `MastercardCompliance` on `Dispute.Evidence.EnhancedEvidence`, `Dispute.EvidenceDetails.EnhancedEligibility`, and `DisputeEvidenceEnhancedEvidenceOptions`
* Add support for `StatusDetails` on `FinancialConnections.Account`
* ⚠️ Remove support for `StoredCredentialUsage` on `PaymentAttemptRecord.PaymentMethodDetails.Card` and `PaymentRecord.PaymentMethodDetails.Card`
* Add support for `SetupFutureUsage` on `PaymentIntent.PaymentMethodOptions.Satispay` and `PaymentIntentPaymentMethodOptionsSatispayOptions`
* Add support for `Satispay` on `SetupAttempt.PaymentMethodDetails`
* Add support for `CustomFields`, `Description`, and `Footer` on `Subscription.InvoiceSettings` and `SubscriptionInvoiceSettingsOptions`
* Add support for `PaymentMethodOptions` and `PaymentMethod` on `TopupCreateOptions`
* Add support for `Mode` on `V2.Commerce.ProductCatalogImport`
* Add support for `SunbitPayments` on `V2.Core.Account.Configuration.Merchant.Capabilities` and `V2CoreAccountConfigurationMerchantCapabilitiesOptions`
* Add support for `CryptoMoneyManager` and `MoneyManager` on `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
* ⚠️ Remove support for `CryptoStorer` and `Storer` on `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
