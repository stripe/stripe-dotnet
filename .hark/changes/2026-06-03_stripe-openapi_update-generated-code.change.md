---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3389
is_breaking: true
is_stripe_api_change: true
released_in_version: 51.3.0-alpha.2
---

* Add support for new resources `DelegatedCheckout.OrderEvent`, `DelegatedCheckout.Order`, `V2.Billing.ContractLicensePricingQuantityChange`, `V2.Billing.Contract`, and `V2.Signals.AccountSignal`
* Add support for `Get` method on resource `DelegatedCheckout.Order`
* Add support for `ListOrders` method on resource `DelegatedCheckout.RequestedSession`
* Add support for `Get` and `List` methods on resource `V2.Signals.AccountSignal`
* Add support for `Activate`, `Cancel`, `Create`, `Get`, `List`, and `Update` methods on resource `V2.Billing.Contract`
* Add support for `BirthAddress` on `AccountIndividualOptions`, `AccountPersonCreateOptions`, `AccountPersonUpdateOptions`, `Person`, `TokenAccountIndividualOptions`, and `TokenPersonOptions`
* Change type of `ChargePaymentDetailsMoneyServicesOptions.TransactionType` and `PaymentIntentPaymentDetailsMoneyServicesOptions.TransactionType` from `literal('account_funding')` to `enum('account_funding'|'debt_repayment')`
* Add support for `ProvisioningDecision` and `TokenType` on `Issuing.Authorization.TokenDetails` and `Issuing.Token`
* Add support for `TokenDecisionRecommendation` on `Issuing.Authorization.TokenDetails.NetworkData.Visa` and `Issuing.Token.NetworkData.Visa`
* Add support for `Language` on `Issuing.Token.NetworkData.Device`
* Add support for `DigitalAssetCategory` on `PaymentIntentPaymentMethodOptionsCardPaymentDetailsMoneyServicesAccountFundingOptions` and `PaymentIntentPaymentMethodOptionsCardPresentPaymentDetailsMoneyServicesAccountFundingOptions`
* Add support for `StaticAddress` on `PaymentIntent.PaymentMethodOptions.Crypto.DepositOptions` and `PaymentIntentPaymentMethodOptionsCryptoDepositOptionsOptions`
* Add support for `PaymentReference` on `PaymentIntentPaymentsOrchestrationOptions`
* ⚠️ Remove support for `PaymentDetails` on `PaymentIntentPaymentsOrchestrationOptions`
* ⚠️ Change type of `PaymentIntent.PaymentDetails.MoneyServices.TransactionType` from `literal('account_funding')` to `enum('account_funding'|'debt_repayment')`
* Add support for `EndingBefore`, `Limit`, and `StartingAfter` on `PaymentLocationListOptions`
* Add support for `Schema` on `V2.Data.Reporting.QueryRun.Result.File` and `V2.Reporting.ReportRun.Result.File`
* Add support for `Include` on `V2.Data.Reporting.QueryRunGetOptions` and `V2.Reporting.ReportRunGetOptions`
* Add support for `RequirementsCollector` on `V2CoreAccountDefaultsResponsibilitiesOptions`
* Add support for event notification `V2SignalsAccountSignalMerchantDelinquencyReadyEvent` with related object `V2.Signals.AccountSignal`
