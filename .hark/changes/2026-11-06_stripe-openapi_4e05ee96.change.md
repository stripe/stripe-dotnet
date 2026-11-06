---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3489
semver_level: minor
is_stripe_api_change: true
---

* Add support for new resources `Tax.Certificate`, `Tax.FormCorrection`, `V2.Extend.ObjectDefinitionVersion`, and `V2.Extend.ObjectDefinition`
* Add support for `Create`, `Delete`, `Get`, and `List` methods on resource `Tax.Certificate`
* Add support for `Create` method on resource `Tax.Form`
* Add support for `Get` and `List` methods on resources `V2.Extend.ObjectDefinitionVersion` and `V2.Extend.ObjectDefinition`
* Add support for `Bills`, `FinancialAccountRewards`, `FinancialAccountsTransactions`, `FinancialAccounts`, `NetworkCostPassthroughReport`, and `RecipientsList` on `AccountSessionComponentsOptions`
* Add support for `BusinessProfileManagement` on `AccountSessionComponentsOptions`, `V2.Core.AccountSession.Components`, and `V2CoreAccountSessionComponentsOptions`
* Add support for `ExportTaxTransactions`, `ProductTaxCodeSelector`, and `TaxThresholdMonitoring` on `AccountSession.Components`
* Add support for `AeonPay`, `AuPay`, `Dbarai`, and `Merpay` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `FundingSources` on `Charge.PaymentMethodDetails.Card.Wallet.Link` and `Charge.PaymentMethodDetails.Link`
* Add support for `Fleet` on `Charge.PaymentMethodDetails.CardPresent`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, and `PaymentRecord.PaymentMethodDetails.CardPresent`
* Add support for `Fingerprint` on `Charge.PaymentMethodDetails.Paypay`, `PaymentAttemptRecord.PaymentMethodDetails.Paypay`, `PaymentRecord.PaymentMethodDetails.Paypay`, and `SetupAttempt.PaymentMethodDetails.Paypay`
* Add support for `CustomPaymentMethodOptions` on `Checkout.SessionCreateOptions`
* Add support for `StripeBalance` on `Checkout.Session.PaymentMethodOptions` and `CheckoutSessionPaymentMethodOptionsOptions`
* Add support for `SetupFutureUsage` on `Checkout.Session.PaymentMethodOptions.Paypay` and `CheckoutSessionPaymentMethodOptionsPaypayOptions`
* Add support for `ReasonDetails` and `Reason` on `CustomerCustomerTaxExemptionCreateOptions` and `CustomerTaxExemption`
* Add support for `TaxCodeGroup` on `CustomerCustomerTaxExemptionUsOptions` and `CustomerTaxExemption.Us`
* Add support for `TargetDate` on `Invoice.PaymentSettings.PaymentMethodOptions.SepaDebit` and `InvoicePaymentSettingsPaymentMethodOptionsSepaDebitOptions`
* Add support for `PaymentMethodDetails` on `PaymentAttemptRecordReportAuthenticatedOptions`
* Change type of `PaymentAttemptRecordPaymentMethodDetailsOptions.Type` and `PaymentRecordPaymentMethodDetailsOptions.Type` from `literal('card')` to `enum('card'|'us_bank_account')`
* Add support for `DisputeDetails` on `PaymentAttemptRecord` and `PaymentRecord`
* Add support for `EvCharging` and `FleetData` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.CardPresent` and `PaymentIntentAmountDetailsLineItemsPaymentMethodOptionsCardPresentOptions`
* Add support for `FinancialConnections` on `PaymentIntent.PaymentMethodOptions.BacsDebit` and `PaymentIntentPaymentMethodOptionsBacsDebitOptions`
* Add support for `PaymentDetails` on `PaymentIntent.PaymentMethodOptions.CardPresent` and `PaymentIntent.PaymentMethodOptions.Card`
* Add support for `RakutenPay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* Add support for `SepaDebit` on `Radar.PaymentEvaluation.PaymentDetails.MoneyMovementDetails` and `RadarPaymentEvaluationPaymentDetailsMoneyMovementDetailsOptions`
* Add support for `CardTesting` on `Radar.PaymentEvaluation.Signals`
* Add support for `PaymentMethod` on `RefundCreateOptions`
* Add support for `PaymentRecord` on `Refund`
* Add support for `Bizum` and `Upi` on `Refund.DestinationDetails`
* Add support for `TaxInvoiceMonth` on `Reporting.ReportRun.Parameters`
* Add support for `RadarOptions` on `SetupIntentConfirmOptions`, `SetupIntentCreateOptions`, and `SetupIntent`
* Add support for `BillingGroup` on `SubscriptionCreateOptions`, `SubscriptionListOptions`, `SubscriptionUpdateOptions`, and `Subscription`
* Add support for `NetworkDetails` on `Treasury.InboundTransfer.FailureDetails`, `Treasury.OutboundPayment.ReturnedDetails`, and `Treasury.OutboundTransfer.ReturnedDetails`
* Add support for event notification `V2ExtendObjectDefinitionCreatedEvent` with related object `V2.Extend.ObjectDefinition`
* Add support for event notification `V2ExtendObjectDefinitionVersionCreatedEvent` with related object `V2.Extend.ObjectDefinitionVersion`
