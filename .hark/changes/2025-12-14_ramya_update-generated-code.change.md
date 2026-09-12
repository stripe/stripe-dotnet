---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3273
is_stripe_api_change: true
released_in_version: 50.2.0-alpha.1
---

* Add support for new resources `SharedPayment.GrantedToken`, `V2.Iam.ApiKey`, `V2.Payments.SettlementAllocationIntentSplit`, `V2.Payments.SettlementAllocationIntent`, and `V2.Tax.ManualRule`
* Add support for `Get` method on resource `SharedPayment.GrantedToken`
* Add support for `Create` and `Update` test helper methods on resource `SharedPayment.GrantedToken`
* Add support for `Create`, `Deactivate`, `Get`, `List`, and `Update` methods on resource `V2.Tax.ManualRule`
* Add support for `Cancel`, `Create`, `Get`, `Submit`, and `Update` methods on resource `V2.Payments.SettlementAllocationIntent`
* Add support for `Cancel`, `Create`, and `Get` methods on resource `V2.Payments.SettlementAllocationIntentSplit`
* Add support for `Create`, `Expire`, `Get`, `List`, `Rotate`, and `Update` methods on resource `V2.Iam.ApiKey`
* Add support for `CheckScanning` on `AccountSessionComponentsOptions`
* Add support for `TaxDetails` on `CheckoutSessionLineItemPriceDataProductDataOptions`, `InvoiceLineItemPriceDataProductDataOptions`, `InvoiceLinePriceDataProductDataOptions`, `PaymentLinkLineItemPriceDataProductDataOptions`, `ProductCreateOptions`, and `ProductUpdateOptions`
* Add support for `PaymentMethodData` on `DelegatedCheckout.RequestedSessionConfirmOptions`
* Add support for `ProductDetails` on `DelegatedCheckout.RequestedSession.LineItemDetail`
* Add support for `Wallets` on `Issuing.CardListOptions`
* Add support for `PrimaryAccountIdentifier` on `Issuing.Card.Wallets.ApplePay` and `Issuing.Card.Wallets.GooglePay`
* Add support for `SharedPaymentGrantedToken` on `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, and `PaymentIntent`
* Add support for `Instant` on `V2.Account.Configuration.RecipientData.Features.BankAccounts`, `V2.Core.Account.Configuration.Recipient.Capabilities.BankAccounts`, `V2AccountConfigurationRecipientDataFeaturesBankAccountsOptions`, and `V2CoreAccountConfigurationRecipientCapabilitiesBankAccountsOptions`
* Add support for `CollectAt` on `V2.Billing.IntentAction.Deactivate`, `V2.Billing.IntentAction.Modify`, `V2.Billing.IntentAction.Subscribe`, `V2BillingIntentActionDeactivateOptions`, `V2BillingIntentActionModifyOptions`, and `V2BillingIntentActionSubscribeOptions`
* Remove support for `BillingDetails` on `V2.Billing.IntentAction.Deactivate`, `V2.Billing.IntentAction.Modify`, `V2.Billing.IntentAction.Subscribe`, `V2BillingIntentActionDeactivateOptions`, `V2BillingIntentActionModifyOptions`, and `V2BillingIntentActionSubscribeOptions`
* Add support for `Overrides` on `V2.Billing.IntentAction.Deactivate.PricingPlanSubscriptionDetails`, `V2.Billing.IntentAction.Modify.PricingPlanSubscriptionDetails`, `V2.Billing.IntentAction.Subscribe.PricingPlanSubscriptionDetails`, `V2BillingIntentActionDeactivatePricingPlanSubscriptionDetailsOptions`, `V2BillingIntentActionModifyPricingPlanSubscriptionDetailsOptions`, and `V2BillingIntentActionSubscribePricingPlanSubscriptionDetailsOptions`
* Remove support for `Requested` on `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Celtic.ChargeCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Celtic.SpendCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.CrossRiverBank.ChargeCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.CrossRiverBank.SpendCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Lead.PrepaidCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Stripe.ChargeCard`, `V2.Core.Account.Configuration.CardCreator.Capabilities.Commercial.Stripe.PrepaidCard`, `V2.Core.Account.Configuration.Recipient.Capabilities.CryptoWallets`, `V2.Core.Account.Configuration.Storer.Capabilities.FinancialAddresses.CryptoWallets`, `V2.Core.Account.Configuration.Storer.Capabilities.HoldsCurrencies.Usdc`, `V2.Core.Account.Configuration.Storer.Capabilities.OutboundPayments.CryptoWallets`, and `V2.Core.Account.Configuration.Storer.Capabilities.OutboundTransfers.CryptoWallets`
* Add support for `AlternativeReference` on `V2.Core.Vault.GbBankAccount`, `V2.Core.Vault.UsBankAccount`, and `V2.MoneyManagement.PayoutMethod`
* Add support for `ManagedBy` and `Payments` on `V2.MoneyManagement.FinancialAccount`
* Add support for `Speed` on `V2.MoneyManagement.OutboundPayment.DeliveryOptions`, `V2.MoneyManagement.OutboundPaymentQuote.DeliveryOptions`, `V2MoneyManagementOutboundPaymentDeliveryOptionsOptions`, and `V2MoneyManagementOutboundPaymentQuoteDeliveryOptionsOptions`
* Add support for `Types` on `V2.MoneyManagement.FinancialAccountListOptions`
* Add support for `TopImpactedAccounts` on `EventsV2CoreHealthApiErrorFiringEventImpact`, `EventsV2CoreHealthApiErrorResolvedEventImpact`, `EventsV2CoreHealthApiLatencyFiringEventImpact`, `EventsV2CoreHealthApiLatencyResolvedEventImpact`, `EventsV2CoreHealthPaymentMethodErrorFiringEventImpact`, and `EventsV2CoreHealthPaymentMethodErrorResolvedEventImpact`
* Add support for event notifications `V2CoreHealthSepaDebitDelayedFiringEvent`, `V2CoreHealthSepaDebitDelayedResolvedEvent`, and `V2PaymentsSettlementAllocationIntentNotFoundEvent`
* Add support for event notifications `V2PaymentsSettlementAllocationIntentCanceledEvent`, `V2PaymentsSettlementAllocationIntentCreatedEvent`, `V2PaymentsSettlementAllocationIntentErroredEvent`, `V2PaymentsSettlementAllocationIntentFundsNotReceivedEvent`, `V2PaymentsSettlementAllocationIntentMatchedEvent`, `V2PaymentsSettlementAllocationIntentSettledEvent`, and `V2PaymentsSettlementAllocationIntentSubmittedEvent` with related object `V2.Payments.SettlementAllocationIntent`
* Add support for event notifications `V2PaymentsSettlementAllocationIntentSplitCanceledEvent`, `V2PaymentsSettlementAllocationIntentSplitCreatedEvent`, and `V2PaymentsSettlementAllocationIntentSplitSettledEvent` with related object `V2.Payments.SettlementAllocationIntentSplit`
