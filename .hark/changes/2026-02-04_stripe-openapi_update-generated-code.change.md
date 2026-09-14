---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3299
is_stripe_api_change: true
released_in_version: 50.4.0-alpha.2
---

* Add support for new resource `V2.Core.ConnectionSession`
* Add support for `Create` and `Get` methods on resource `V2.Core.ConnectionSession`
* Add support for `List` method on resources `V2.Payments.SettlementAllocationIntentSplit` and `V2.Payments.SettlementAllocationIntent`
* Add support for `AgenticCommerceSettings` on `AccountSessionComponentsOptions`
* Add support for `TerminalHardwareOrders` and `TerminalHardwareShop` on `AccountSession.Components` and `AccountSessionComponentsOptions`
* Add support for `NetworkCostPassthroughReport` on `AccountSession.Components`
* Add support for `CadenceData` on `V2.Billing.IntentCreateOptions` and `V2.Billing.Intent`
* Add support for `CancellationDetails` on `V2.Billing.IntentAction.Deactivate`, `V2.Billing.PricingPlanSubscription`, and `V2BillingIntentActionDeactivateOptions`
* Add support for `ContactPhone` on `V2.Core.AccountCreateOptions`, `V2.Core.AccountTokenCreateOptions`, `V2.Core.AccountUpdateOptions`, and `V2.Core.Account`
* Add support for `RegistrationDate` on `V2.Core.Account.Identity.BusinessDetails`, `V2CoreAccountIdentityBusinessDetailsOptions`, and `V2CoreAccountTokenIdentityBusinessDetailsOptions`
* Add support for `Reference` on `V2.MoneyManagement.Adjustment`
* Add support for `AccruedFees` on `V2.MoneyManagement.FinancialAccount`
* Add support for `StartingBalance` on `V2.MoneyManagement.FinancialAccount.Payments`
* Add support for `AccountHolderAddress` and `AccountHolderName` on `V2.MoneyManagement.FinancialAddress.Credentials.UsBankAccount`
* Add support for `Fingerprint` on `V2.MoneyManagement.PayoutMethod.Card`
* Add support for `CardSpend` on `V2.MoneyManagement.ReceivedCredit` and `V2.MoneyManagement.ReceivedDebit`
* Add support for `ApplicationFeeRefund`, `ApplicationFee`, `Charge`, `Dispute`, `Payout`, `Refund`, `ReserveHold`, `ReserveRelease`, `Topup`, `TransferReversal`, and `Transfer` on `V2.MoneyManagement.Transaction.Flow` and `V2.MoneyManagement.TransactionEntry.TransactionDetails.Flow`
