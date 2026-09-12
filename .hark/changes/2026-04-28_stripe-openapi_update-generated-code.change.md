---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3375
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.2.0-alpha.2
---

* Add support for new resource `V2.Data.Analytics.MetricQueryResult`
* Add support for `Create`, `Get`, and `Revoke` methods on resource `SharedPayment.IssuedToken`
* Add support for `Create` method on resource `V2.Data.Analytics.MetricQueryResult`
* Add support for `BalanceReport` and `PayoutReconciliationReport` on `AccountSession.Components` and `AccountSessionComponentsOptions`
* Add support for `AppDistribution` and `SunbitPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
* Add support for `Sunbit` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Last4` on `Charge.PaymentMethodDetails.GiftCard`, `PaymentAttemptRecord.PaymentMethodDetails.GiftCard`, and `PaymentRecord.PaymentMethodDetails.GiftCard`
* Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.Klarna`, `PaymentAttemptRecord.PaymentMethodDetails.Klarna`, and `PaymentRecord.PaymentMethodDetails.Klarna`
* Add support for `Blik` on `CheckoutSessionPaymentMethodOptionsOptions`, `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Add support for `SharedPaymentGrantedToken` on `ConfirmationTokenPaymentMethodDataOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethod`, and `SetupIntentPaymentMethodDataOptions`
* ⚠️ Change type of `CreditNote.TotalTaxes.TaxRateDetails.TaxRate`, `CreditNoteLineItem.Taxes.TaxRateDetails.TaxRate`, `Invoice.TotalTaxes.TaxRateDetails.TaxRate`, `InvoiceLineItem.Taxes.TaxRateDetails.TaxRate`, and `QuotePreviewInvoice.TotalTaxes.TaxRateDetails.TaxRate` from `string` to `expandable($TaxRate)`
* Add support for `BuyerConsents` on `DelegatedCheckout.RequestedSessionConfirmOptions`
* Add support for `Consents` on `DelegatedCheckout.RequestedSession.BuyerConsents.Marketing`
* Add support for `PaymentFacilitatorId` and `SubMerchantId` on `IssuingAuthorizationMerchantDataOptions` and `IssuingTransactionMerchantDataOptions`
* Add support for `CardPresence` on `Issuing.Authorization`
* Add support for `AllowedCardPresences` and `BlockedCardPresences` on `Issuing.Card.SpendingControls`, `Issuing.Cardholder.SpendingControls`, `IssuingCardSpendingControlsOptions`, and `IssuingCardholderSpendingControlsOptions`
* ⚠️ Change type of `PaymentAttemptRecord.PaymentMethodDetails.GiftCard.Balance` and `PaymentRecord.PaymentMethodDetails.GiftCard.Balance` from `PaymentFlowsPrivatePaymentMethodsGiftCardDeprecatedDetailsResourceBalanceAmount` to `nullable(PaymentsPrimitivesPaymentRecordsResourcePaymentMethodGiftCardDetailsResourceBalance)`
* Add support for `AmountToConfirm` on `PaymentIntentConfirmOptions`
* Add support for `KlarnaDisplayQrCode` on `PaymentIntent.NextAction`
* Add support for `ValidationErrors` on `Privacy.RedactionJob`
* Add support for `TaxDetails` on `Product`
* Add support for `Moto` on `SetupAttempt.PaymentMethodDetails.Card`
* Add support for `AdmissionsTax`, `AttendanceTax`, `EntertainmentTax`, `GrossReceiptsTax`, `HospitalityTax`, `LuxuryTax`, `ResortTax`, and `TourismTax` on `TaxRegistrationCountryOptionsUsOptions`
* Add support for `Purpose` on `Treasury.OutboundPaymentCreateOptions` and `Treasury.OutboundPayment`
* Add support for `CryptoWallet` on `V2.MoneyManagement.FinancialAddress.Credentials`
* Add support for `MxBankAccount` on `V2.MoneyManagement.FinancialAddress.Credentials` and `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* Add support for `CryptoWalletTransfer` on `V2.MoneyManagement.ReceivedCredit`
* Add support for `EuBankAccount` on `V2.MoneyManagement.ReceivedCredit.BankTransfer`
* Add support for `CryptoProperties` and `SettlementCurrency` on `V2.MoneyManagement.FinancialAddressCreateOptions`
* Add support for event notifications `V2CoreApprovalRequestCreatedEvent` and `V2CoreApprovalRequestExpiredEvent` with related object `V2.Core.ApprovalRequest`
* Add support for event notification `V2ExtendExtensionRunFailedEvent`
