---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3495
semver_level: major
is_stripe_api_change: true
---

* Add support for new resources `Tax.Certificate`, `Tax.FormCorrection`, `V2.Core.AccountSession`, `V2.Extend.ObjectDefinitionVersion`, `V2.Extend.ObjectDefinition`, and `V2.MoneyManagement.SpendingMandate`
* ⚠️ Remove support for resource `V2.Core.AccountSessionResource`
* Add support for `Create`, `Delete`, `Get`, and `List` methods on resource `Tax.Certificate`
* Add support for `Create` method on resource `Tax.Form`
* Add support for `Cancel`, `Get`, and `List` methods on resource `V2.MoneyManagement.SpendingMandate`
* Add support for `Get` and `List` methods on resources `V2.Extend.ObjectDefinitionVersion` and `V2.Extend.ObjectDefinition`
* Add support for `Bills`, `FinancialAccountRewards`, `FinancialAccountsTransactions`, `FinancialAccounts`, `NetworkCostPassthroughReport`, and `RecipientsList` on `AccountSessionComponentsOptions`
* Add support for `BusinessProfileManagement` on `AccountSessionComponentsOptions` and `V2CoreAccountSessionResourceComponentsOptions`
* Add support for `ExportTaxTransactions`, `ProductTaxCodeSelector`, and `TaxThresholdMonitoring` on `AccountSession.Components`
* Add support for `AeonPay`, `AuPay`, `Dbarai`, and `Merpay` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntentPaymentMethodDataOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `FundingSources` on `Charge.PaymentMethodDetails.Card.Wallet.Link` and `Charge.PaymentMethodDetails.Link`
* Add support for `Fleet` on `Charge.PaymentMethodDetails.CardPresent`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, and `PaymentRecord.PaymentMethodDetails.CardPresent`
* Add support for `CardholderMessage` on `Charge.PaymentMethodDetails.CardPresent.Receipt`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent.Receipt`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent.Receipt`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent.Receipt`, and `PaymentRecord.PaymentMethodDetails.CardPresent.Receipt`
* Add support for `Fingerprint` on `Charge.PaymentMethodDetails.Paypay`, `PaymentAttemptRecord.PaymentMethodDetails.Paypay`, `PaymentRecord.PaymentMethodDetails.Paypay`, and `SetupAttempt.PaymentMethodDetails.Paypay`
* Add support for `CustomPaymentMethodOptions` and `PricingToken` on `Checkout.SessionCreateOptions`
* Add support for `StripeBalance` on `Checkout.Session.PaymentMethodOptions` and `CheckoutSessionPaymentMethodOptionsOptions`
* Add support for `SetupFutureUsage` on `Checkout.Session.PaymentMethodOptions.Paypay` and `CheckoutSessionPaymentMethodOptionsPaypayOptions`
* Add support for `MarketingAttributions` on `CustomerUpdateOptions`
* Add support for `ReasonDetails` and `Reason` on `CustomerCustomerTaxExemptionCreateOptions` and `CustomerTaxExemption`
* Add support for `TaxCodeGroup` on `CustomerCustomerTaxExemptionUsOptions` and `CustomerTaxExemption.Us`
* Add support for `FraudulentSelfie` on `Identity.VerificationReport.Signals`
* Add support for `TargetDate` on `Invoice.PaymentSettings.PaymentMethodOptions.SepaDebit` and `InvoicePaymentSettingsPaymentMethodOptionsSepaDebitOptions`
* Add support for `TossPay` on `Mandate.PaymentMethodDetails`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, and `SetupAttempt.PaymentMethodDetails`
* Add support for `PaymentEvaluations` and `PaymentMethodDetails` on `PaymentAttemptRecordReportAuthenticatedOptions`
* Add support for `ThreeDSecure` on `PaymentAttemptRecordPaymentMethodDetailsCardOptions` and `PaymentRecordPaymentMethodDetailsCardOptions`
* Change type of `PaymentAttemptRecordPaymentMethodDetailsOptions.Type` and `PaymentRecordPaymentMethodDetailsOptions.Type` from `literal('card')` to `enum('card'|'us_bank_account')`
* Add support for `DisputeDetails` on `PaymentAttemptRecord` and `PaymentRecord`
* Add support for `EvCharging` and `FleetData` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.CardPresent` and `PaymentIntentAmountDetailsLineItemsPaymentMethodOptionsCardPresentOptions`
* Add support for `FinancialConnections` on `PaymentIntent.PaymentMethodOptions.BacsDebit`, `PaymentIntentPaymentMethodOptionsBacsDebitOptions`, `SetupIntent.PaymentMethodOptions.BacsDebit`, and `SetupIntentPaymentMethodOptionsBacsDebitOptions`
* Add support for `WechatPayRedirectToMiniProgram` on `PaymentIntent.NextAction`
* Add support for `PaymentDetails` on `PaymentIntent.PaymentMethodOptions.CardPresent` and `PaymentIntent.PaymentMethodOptions.Card`
* Add support for `RakutenPay` on `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, and `PaymentMethodConfiguration`
* Add support for `SepaDebit` on `Radar.PaymentEvaluation.PaymentDetails.MoneyMovementDetails` and `RadarPaymentEvaluationPaymentDetailsMoneyMovementDetailsOptions`
* Add support for `CardTesting` on `Radar.PaymentEvaluation.Signals`
* Add support for `PaymentMethod` on `RefundCreateOptions`
* Add support for `PaymentRecord` on `Refund`
* Add support for `Bizum` and `Upi` on `Refund.DestinationDetails`
* Add support for `TaxInvoiceMonth` on `Reporting.ReportRun.Parameters`
* Add support for `RadarOptions` on `SetupIntentConfirmOptions`, `SetupIntentCreateOptions`, and `SetupIntent`
* Add support for `ReferralFeeDetails` on `SharedPayment.GrantedToken`, `SharedPayment.IssuedTokenCreateOptions`, and `SharedPayment.IssuedToken`
* Add support for `BillingGroup` on `SubscriptionCreateOptions`, `SubscriptionListOptions`, `SubscriptionUpdateOptions`, and `Subscription`
* Add support for `DeviceHealthDetails` and `DeviceHealth` on `Terminal.Reader`
* Add support for `NetworkDetails` on `Treasury.InboundTransfer.FailureDetails`, `Treasury.OutboundPayment.ReturnedDetails`, and `Treasury.OutboundTransfer.ReturnedDetails`
* Add support for `Reference` on `V2.MoneyManagement.FinancialAddress.BankAccount.Iban`
* Add support for `CheckSend` on `V2.MoneyManagement.OutboundPayment.To.PayoutMethodOptions`, `V2.MoneyManagement.OutboundPayment.TrackingDetails`, `V2.MoneyManagement.PayoutIntent.To.PayoutMethodOptions`, `V2.MoneyManagement.PayoutMethod`, `V2MoneyManagementOutboundPaymentToPayoutMethodOptionsOptions`, `V2MoneyManagementOutboundSetupIntentPayoutMethodDataOptions`, and `V2MoneyManagementPayoutIntentToPayoutMethodOptionsOptions`
* Add support for `SpendingMandate` on `V2.MoneyManagement.ReceivedDebit.BankTransfer` and `V2.MoneyManagement.ReceivedDebitListOptions`
* Add support for `AdditionalDetails` on `V2.Signals.AccountSignal.CustomerRisk`
* Add support for event notification `V2ExtendObjectDefinitionCreatedEvent` with related object `V2.Extend.ObjectDefinition`
* Add support for event notification `V2ExtendObjectDefinitionVersionCreatedEvent` with related object `V2.Extend.ObjectDefinitionVersion`
* Add support for event notifications `V2MoneyManagementSpendingMandateCanceledEvent`, `V2MoneyManagementSpendingMandateCreatedEvent`, `V2MoneyManagementSpendingMandateExpiredEvent`, `V2MoneyManagementSpendingMandatePendingCancellationEvent`, and `V2MoneyManagementSpendingMandateUpdatedEvent` with related object `V2.MoneyManagement.SpendingMandate`
* ⚠️ Add error type `MerchantNotGatedException` on `V2.Core.Vault.NetworkToken#CreateFromCredential`
