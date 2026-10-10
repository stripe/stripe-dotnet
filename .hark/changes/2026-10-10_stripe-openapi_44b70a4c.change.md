---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3479
semver_level: major
is_stripe_api_change: true
---

* ⚠️ Remove support for `Capture` method on resource `V2.Payments.OffSessionPayment`
* ⚠️ Remove support for `AcknowledgeConfirmationOfPayee` and `InitiateConfirmationOfPayee` methods on resource `V2.Core.Vault.GbBankAccount`
* Add support for `WechatPayMobileWebPayments` on `Account.Settings` and `AccountSettingsOptions`
* ⚠️ Remove support for `WechatPayPayments` on `Account.Settings` and `AccountSettingsOptions`
* Add support for `SettlementReserved` on `Balance`
* Add support for `Carecredit`, `Getflex`, and `Sezzle` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `MandateOptions` on `CheckoutSessionPaymentMethodOptionsCardOptions`
* Add support for `ContactEmail` on `V2.Core.AccountEvaluation.AccountData`, `V2.Signals.AccountActivity.AccountDetails.Data`, `V2.Signals.AccountEvaluation.AccountDetails.Data`, `V2CoreAccountEvaluationAccountDataOptions`, `V2SignalsAccountActivityAccountDetailsDataOptions`, and `V2SignalsAccountEvaluationAccountDetailsDataOptions`
* Add support for `BreB`, `Nip`, and `Pix` on `V2.MoneyManagement.FinancialAddress.BankAccount` and `V2.MoneyManagement.ReceivedCredit.BankTransfer.OriginatingBankAccount`
* ⚠️ Remove support for `AmountCapturable` on `V2.Payments.OffSessionPayment`
* ⚠️ Remove support for `Capture` on `V2.Payments.OffSessionPaymentCreateOptions` and `V2.Payments.OffSessionPayment`
* Add support for snapshot events `ThreeDSecureAuthenticationCanceled`, `ThreeDSecureAuthenticationChallengeStarted`, `ThreeDSecureAuthenticationErrored`, `ThreeDSecureAuthenticationFailed`, `ThreeDSecureAuthenticationRequiresChallenge`, `ThreeDSecureAuthenticationRequiresSubmission`, and `ThreeDSecureAuthenticationSucceeded` with resource `ThreeDSecure.Authentication`
* ⚠️ Remove support for event notification `V2PaymentsOffSessionPaymentRequiresCaptureEvent` with related object `V2.Payments.OffSessionPayment`
