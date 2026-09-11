---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3430
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.5.0-alpha.1
---

* Add support for new resource `CustomerTaxExemption`
* Add support for `Create`, `Delete`, `Get`, and `List` methods on resource `CustomerTaxExemption`
* Add support for `Details` on `Account.FutureRequirements.Errors`, `Account.Requirements.Errors`, `BankAccount.FutureRequirements.Errors`, `BankAccount.Requirements.Errors`, `Capability.FutureRequirements.Error`, `Capability.Requirements.Error`, `Person.FutureRequirements.Error`, and `Person.Requirements.Error`
* Add support for `PaymentMethodSettings` on `AccountSession.Components`
* ⚠️ Remove support for `SequraPayments` on `Account.Capabilities`
* Add support for `SubscriptionPause` on `BillingPortalSessionFlowDataOptions`
* ⚠️ Remove support for `Sequra` on `Charge.PaymentMethodDetails`, `Checkout.Session.PaymentMethodOptions`, `ConfirmationToken.PaymentMethodPreview`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, and `PaymentRecord.PaymentMethodDetails`
* Add support for `FundingSourceGroup` on `Charge.PaymentMethodDetails.Card.Wallet.Link`
* Add support for `EnablementDetails` on `Checkout.Session.AutomaticTax`
* Add support for `Credit` on `FinancialConnections.Transaction.Classifications`
* Add support for `UserConsent` on `Identity.VerificationSessionCreateOptions` and `Identity.VerificationSessionUpdateOptions`
* Add support for `Billie` on `InvoicePaymentSettingsPaymentMethodOptionsOptions` and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Add support for `CompanyDetails` on `Invoice.PaymentSettings.PaymentMethodOptions.Billie`, `PaymentIntent.PaymentMethodOptions.Billie`, `PaymentIntentPaymentMethodOptionsBillieOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions.Billie`, and `Subscription.PaymentSettings.PaymentMethodOptions.Billie`
* Add support for `Reference` on `Invoice.PaymentSettings.PaymentMethodOptions.Billie`, `PaymentIntent.PaymentMethodOptions.Billie`, `PaymentIntentPaymentMethodOptionsBillieOptions`, and `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions.Billie`
* Add support for `PosCondition` on `Issuing.Authorization` and `Issuing.TestHelpersAuthorizationCreateOptions`
* Add support for `CryptoWallet` on `Issuing.CardCreateOptions`, `Issuing.CardUpdateOptions`, and `Issuing.Card`
* Add support for `PaymentEvaluations` and `PaymentMethodDetails` on `PaymentAttemptRecordReportAuthorizedOptions`
* Add support for `BlikRecurringPayments` on `V2.Core.Account.Configuration.Merchant.Capabilities` and `V2CoreAccountConfigurationMerchantCapabilitiesOptions`
* Add support for `UserAccess` on `V2.Iam.ActivityLog.Details`
