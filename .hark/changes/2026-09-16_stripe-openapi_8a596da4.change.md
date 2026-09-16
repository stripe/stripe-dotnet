---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3446
semver_level: major
is_stripe_api_change: true
released_in_version: 52.5.0-alpha.4
---

* Add support for new resources `Apps.Install` and `V2.Core.Vault.NetworkToken`
* Add support for `CreateFromCredential`, `Create`, `GenerateCryptogram`, and `Get` methods on resource `V2.Core.Vault.NetworkToken`
* ⚠️ Remove support for `NestingDemo` on `AccountSession.Components`
* Add support for `SharedPaymentGrantedToken` on `Charge.PaymentMethodDetails`
* ⚠️ Change type of `Charge.PaymentMethodDetails.Card.Mandate` from `string` to `expandable($Mandate)`
* Add support for `CurrentTrial` on `Checkout.Session.Item.Subscription.Item` and `CheckoutSessionItemSubscriptionItemOptions`
* Add support for `VerificationMethod` on `Checkout.Session.PaymentMethodOptions.BacsDebit` and `CheckoutSessionPaymentMethodOptionsBacsDebitOptions`
* Add support for `Appeal` on `Dispute.Evidence`
* Add support for `BacsDebit` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Add support for `PricingToken` on `InvoiceCreatePreviewOptions`
* Add support for `ExpiresAt` on `Mandate.PaymentMethodDetails.Blik`, `PaymentIntent.NextAction.SwishHandleRedirectOrDisplayQrCode.QrCode`, and `Subscription.PaymentSettings.PaymentMethodOptions.Blik.MandateOptions`
* ⚠️ Remove support for `ExpiresAfter` on `Mandate.PaymentMethodDetails.Blik` and `Subscription.PaymentSettings.PaymentMethodOptions.Blik.MandateOptions`
* Add support for `Momo` on `PaymentAttemptRecord.PaymentMethodDetails` and `PaymentRecord.PaymentMethodDetails`
* Add support for `Link` on `PaymentAttemptRecord.PaymentMethodDetails.Card.Wallet` and `PaymentRecord.PaymentMethodDetails.Card.Wallet`
* Add support for `FundingSourceGroup` on `PaymentAttemptRecord.PaymentMethodDetails.Link` and `PaymentRecord.PaymentMethodDetails.Link`
* Add support for `PayoutMethodOptions` on `PayoutCreateOptions`
* Add support for `EarlyFraudWarning` and `FraudulentDispute` on `Radar.PaymentEvaluation.Signals`
* ⚠️ Remove support for `Igic` on `Tax.Registration.CountryOptions.At`, `Tax.Registration.CountryOptions.Be`, `Tax.Registration.CountryOptions.Bg`, `Tax.Registration.CountryOptions.Cy`, `Tax.Registration.CountryOptions.Cz`, `Tax.Registration.CountryOptions.De`, `Tax.Registration.CountryOptions.Dk`, `Tax.Registration.CountryOptions.Ee`, `Tax.Registration.CountryOptions.Fi`, `Tax.Registration.CountryOptions.Fr`, `Tax.Registration.CountryOptions.Gr`, `Tax.Registration.CountryOptions.Hr`, `Tax.Registration.CountryOptions.Hu`, `Tax.Registration.CountryOptions.Ie`, `Tax.Registration.CountryOptions.It`, `Tax.Registration.CountryOptions.Lt`, `Tax.Registration.CountryOptions.Lu`, `Tax.Registration.CountryOptions.Lv`, `Tax.Registration.CountryOptions.Mt`, `Tax.Registration.CountryOptions.Nl`, `Tax.Registration.CountryOptions.Pl`, `Tax.Registration.CountryOptions.Pt`, `Tax.Registration.CountryOptions.Ro`, `Tax.Registration.CountryOptions.Se`, `Tax.Registration.CountryOptions.Si`, and `Tax.Registration.CountryOptions.Sk`
* Add support for `Metadata` on `V2.Billing.Contract.OneTimeFees.Data`, `V2BillingContractOneTimeFeeActionAddOptions`, `V2BillingContractOneTimeFeeActionUpdateOptions`, and `V2BillingContractOneTimeFeeOptions`
* Add support for `BankAccount` and `CryptoWallet` on `V2.MoneyManagement.FinancialAddressCreateOptions` and `V2.MoneyManagement.FinancialAddress`
* Add support for `Type` on `V2.MoneyManagement.FinancialAddress` and `V2.MoneyManagement.ReceivedCredit.CryptoWalletTransfer`
* ⚠️ Remove support for `Credentials` and `Currency` on `V2.MoneyManagement.FinancialAddress`
* Add support for `AmountReceived` on `V2.MoneyManagement.ReceivedCredit`
* Add support for `OriginatingBankAccount` on `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* ⚠️ Remove support for `OriginType` on `V2.MoneyManagement.ReceivedCredit.BankTransfer` and `V2.MoneyManagement.ReceivedCredit.CryptoWalletTransfer`
* Add support for `LatestPaymentAttemptRecordDetails` on `V2.Payments.OffSessionPayment`
* Add support for `AccountReviewed` on `V2.Signals.AccountActivityCreateOptions` and `V2.Signals.AccountActivity`
* Add support for `Include` on `V2.Payments.OffSessionPaymentCreateOptions`
* ⚠️ Remove support for `Include` on `V2.MoneyManagement.FinancialAddressGetOptions` and `V2.MoneyManagement.FinancialAddressListOptions`
* ⚠️ Remove support for `CryptoProperties` and `SepaBankAccount` on `V2.MoneyManagement.FinancialAddressCreateOptions`
* Add support for error type `MerchantNotGatedException`
