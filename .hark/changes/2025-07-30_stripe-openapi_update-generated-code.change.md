---
title: Update generated code for beta
pr_link: https://github.com/stripe/stripe-dotnet/pull/3143
is_stripe_api_change: true
released_in_version: 48.5.0-beta.1
---

* Add support for new resources `Billing.MeterUsageRow`, `Billing.MeterUsage`, and `Terminal.OnboardingLink`
* Add support for `Get` method on resource `Billing.MeterUsage`
* Add support for `Create` method on resource `Terminal.OnboardingLink`
* Add support for `MonthlyPayoutDays` and `WeeklyPayoutDays` on `BalanceSettings.Payouts.Schedule` and `BalanceSettingsPayoutsScheduleOptions`
* Remove support for `MonthlyAnchor` and `WeeklyAnchor` on `BalanceSettings.Payouts.Schedule` and `BalanceSettingsPayoutsScheduleOptions`
* Add support for `DelayDaysOverride` on `BalanceSettingsSettlementTimingOptions`
* Remove support for `DelayDays` on `BalanceSettingsSettlementTimingOptions`
* Add support for `UpdateDiscounts` on `CheckoutSessionPermissionsOptions`
* Add support for `Discounts` and `SubscriptionData` on `Checkout.SessionUpdateOptions`
* Add support for `SmartDisputes` on `Dispute`
* Add support for `Upi` on `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `QuotePreviewInvoice.PaymentSettings.PaymentMethodOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Add support for `TransactionId` on `PaymentAttemptRecord.PaymentMethodDetails.Cashapp` and `PaymentRecord.PaymentMethodDetails.Cashapp`
* Add support for `AmountDetails` on `PaymentIntentCaptureOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentIncrementAuthorizationOptions`, and `PaymentIntentUpdateOptions`
* Add support for `PaymentDetails` on `PaymentIntentIncrementAuthorizationOptions`
* Add support for `Storer` on `V2.Core.Account.Identity.Attestations.TermsOfService` and `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`
* Add support for `CollectionOptions` on `V2.Core.AccountLink.UseCase.AccountOnboarding`, `V2.Core.AccountLink.UseCase.AccountUpdate`, `V2CoreAccountLinkUseCaseAccountOnboardingOptions`, and `V2CoreAccountLinkUseCaseAccountUpdateOptions`
* Change type of `V2.Core.AccountLink.UseCase.AccountOnboarding.Configurations`, `V2.Core.AccountLink.UseCase.AccountUpdate.Configurations`, `V2CoreAccountLinkUseCaseAccountOnboardingOptions.Configurations`, and `V2CoreAccountLinkUseCaseAccountUpdateOptions.Configurations` from `literal('recipient')` to `enum('customer'|'merchant'|'recipient'|'storer')`
* Add support for `BankAccountType` on `V2.MoneyManagement.PayoutMethod.BankAccount`
* Add support for thin event `V2CoreAccountLinkReturnedEvent`
* Add support for thin event `V2MoneyManagementPayoutMethodUpdatedEvent` with related object `V2.MoneyManagement.PayoutMethod`
* Remove support for thin event `V2CoreAccountLinkCompletedEvent`
* Remove support for thin event `V2OffSessionPaymentRequiresCaptureEvent` with related object `V2.Payments.OffSessionPayment`
