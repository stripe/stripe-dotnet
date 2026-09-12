---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3211
is_stripe_api_change: true
released_in_version: 49.2.0-beta.1
---

* Add support for `Update` method on resource `V2.MoneyManagement.FinancialAccount`
* Add support for `ConfirmMicrodeposits`, `List`, and `SendMicrodeposits` methods on resource `V2.Core.Vault.UsBankAccount`
* Add support for `List` method on resource `V2.Core.Vault.GbBankAccount`
* Add support for `PaymentPortalUrl` on `Charge.PaymentMethodDetails.Rechnung`, `PaymentAttemptRecord.PaymentMethodDetails.Rechnung`, and `PaymentRecord.PaymentMethodDetails.Rechnung`
* Add support for `TaxIdElement` on `CustomerSession.Components` and `CustomerSessionComponentsOptions`
* Add support for `StartingAfter` on `PaymentAttemptRecordListOptions`
* Add support for `Reference` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.Klarna` and `PaymentIntentAmountDetailsLineItemsPaymentMethodOptionsKlarnaOptions`
* Add support for `SubscriptionReference` on `PaymentIntentAmountDetailsLineItem.PaymentMethodOptions.Klarna`
* Add support for `Closed` on `V2.Core.AccountListOptions` and `V2.Core.Account`
* Add support for `Usd` on `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies` and `V2CoreAccountConfigurationStorerCapabilitiesHoldsCurrenciesOptions`
* Add support for `RepresentativeDeclaration` on `V2.Core.Account.Identity.Attestations` and `V2CoreAccountIdentityAttestationsOptions`
* Add support for `Verification` on `V2.Core.Vault.UsBankAccount`
* Add support for `V1Id` on `EventsV2MoneyManagementTransactionCreatedEvent`
* Remove support for thin event `V2BillingBillSettingUpdatedEvent` with related object `V2.Billing.BillSetting`
