---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3495
semver_level: major
is_stripe_api_change: true
---

* Add support for new resource `V2.MoneyManagement.SpendingMandate`
* Add support for `Cancel`, `Get`, and `List` methods on resource `V2.MoneyManagement.SpendingMandate`
* Add support for `CardholderMessage` on `Charge.PaymentMethodDetails.CardPresent.Receipt`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent.Receipt`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent.Receipt`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent.Receipt`, and `PaymentRecord.PaymentMethodDetails.CardPresent.Receipt`
* Add support for `PricingToken` on `Checkout.SessionCreateOptions`
* Add support for `MarketingAttributions` on `CustomerUpdateOptions`
* Add support for `FraudulentSelfie` on `Identity.VerificationReport.Signals`
* Add support for `TossPay` on `Mandate.PaymentMethodDetails`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, and `SetupAttempt.PaymentMethodDetails`
* Add support for `PaymentEvaluations` on `PaymentAttemptRecordReportAuthenticatedOptions`
* Add support for `ThreeDSecure` on `PaymentAttemptRecordPaymentMethodDetailsCardOptions` and `PaymentRecordPaymentMethodDetailsCardOptions`
* Add support for `WechatPayRedirectToMiniProgram` on `PaymentIntent.NextAction`
* Add support for `CustomerPresence` and `PaymentType` on `Radar.PaymentEvaluation.PaymentDetails.MoneyMovementDetails.SepaDebit` and `RadarPaymentEvaluationPaymentDetailsMoneyMovementDetailsSepaDebitOptions`
* Add support for `FinancialConnections` on `SetupIntent.PaymentMethodOptions.BacsDebit` and `SetupIntentPaymentMethodOptionsBacsDebitOptions`
* Add support for `ReferralFeeDetails` on `SharedPayment.GrantedToken`, `SharedPayment.IssuedTokenCreateOptions`, and `SharedPayment.IssuedToken`
* Add support for `DeviceHealthDetails` and `DeviceHealth` on `Terminal.Reader`
* Add support for `CheckSend` on `V2.MoneyManagement.OutboundPayment.To.PayoutMethodOptions`, `V2.MoneyManagement.OutboundPayment.TrackingDetails`, `V2.MoneyManagement.PayoutIntent.To.PayoutMethodOptions`, `V2.MoneyManagement.PayoutMethod`, `V2MoneyManagementOutboundPaymentToPayoutMethodOptionsOptions`, `V2MoneyManagementOutboundSetupIntentPayoutMethodDataOptions`, and `V2MoneyManagementPayoutIntentToPayoutMethodOptionsOptions`
* Add support for `SpendingMandate` on `V2.MoneyManagement.ReceivedDebit.BankTransfer` and `V2.MoneyManagement.ReceivedDebitListOptions`
* Add support for event notifications `V2MoneyManagementSpendingMandateCanceledEvent`, `V2MoneyManagementSpendingMandateCreatedEvent`, `V2MoneyManagementSpendingMandateExpiredEvent`, `V2MoneyManagementSpendingMandatePendingCancellationEvent`, and `V2MoneyManagementSpendingMandateUpdatedEvent` with related object `V2.MoneyManagement.SpendingMandate`
* ⚠️ Add error type `MerchantNotGatedException` on `V2.Core.Vault.NetworkToken#CreateFromCredential`
