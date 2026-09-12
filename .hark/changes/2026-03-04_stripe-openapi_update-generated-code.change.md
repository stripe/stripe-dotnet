---
title: Update generated code for private-preview
pr_url: https://github.com/stripe/stripe-dotnet/pull/3309
is_breaking: true
is_stripe_api_change: true
released_in_version: 50.5.0-alpha.2
---

* Add support for new resources `Billing.AlertRecovered` and `Profile`
* Add support for `Reauthorize` method on resource `PaymentIntent`
* Add support for `Settings` on `QuoteLine.Action.AddDiscount`, `QuoteLine.Action.AddItem.Discount`, `QuoteLine.Action.SetDiscounts`, `QuoteLine.Action.SetItems.Discount`, `QuotePreviewSubscriptionSchedule.Phase.Discount`, `QuotePreviewSubscriptionSchedule.Phase.Item.Discount`, `SubscriptionSchedule.Phase.Discount`, and `SubscriptionSchedule.Phase.Item.Discount`
* Add support for `SmartDisputes` on `Account.Settings`, `AccountSettingsOptions`, `V2.Core.Account.Configuration.Merchant`, and `V2CoreAccountConfigurationMerchantOptions`
* Add support for `EmailCustomersOnSuccessfulPayment` on `Account.Settings.Payments` and `AccountSettingsPaymentsOptions`
* Add support for `BalanceUpdateDetails` on `Billing.CreditBalanceSummary.Balance`
* Add support for `Reauthorization` and `ReauthorizeBefore` on `Charge.PaymentMethodDetails.CardPresent`, `Charge.PaymentMethodDetails.Card`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, and `PaymentRecord.PaymentMethodDetails.CardPresent`
* Add support for `Location` and `Reader` on `Charge.PaymentMethodDetails.CardPresent`, `Charge.PaymentMethodDetails.InteracPresent`, `ConfirmationToken.PaymentMethodPreview.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.CardPresent`, `PaymentAttemptRecord.PaymentMethodDetails.InteracPresent`, `PaymentMethod.Card.GeneratedFrom.PaymentMethodDetails.CardPresent`, `PaymentRecord.PaymentMethodDetails.CardPresent`, and `PaymentRecord.PaymentMethodDetails.InteracPresent`
* Add support for `ManagedPayments` on `Checkout.SessionCreateOptions`, `Checkout.Session`, `PaymentIntent`, `SetupIntent`, and `Subscription`
* Add support for `Digital` on `DelegatedCheckout.RequestedSession.FulfillmentDetails.FulfillmentOptions`, `DelegatedCheckout.RequestedSession.FulfillmentDetails.SelectedFulfillmentOption`, and `DelegatedCheckoutRequestedSessionFulfillmentDetailsSelectedFulfillmentOptionOptions`
* Add support for `AffiliateAttributions` on `DelegatedCheckout.RequestedSessionConfirmOptions`, `DelegatedCheckout.RequestedSessionCreateOptions`, and `DelegatedCheckout.RequestedSession`
* Add support for `FulfillmentType` on `DelegatedCheckout.RequestedSession.LineItemDetail`
* Add support for `MarketplaceSellerDetails`, `NetworkProfile`, `PrivacyNoticeUrl`, `ReturnPolicyUrl`, `StorePolicyUrl`, and `TermsOfServiceUrl` on `DelegatedCheckout.RequestedSession.SellerDetails`
* Add support for `AmountToCounter` on `DisputeUpdateOptions`
* Add support for `DisplayName` and `ServiceUserNumber` on `Mandate.PaymentMethodDetails.BacsDebit`
* Add support for `RequestReauthorization` on `PaymentIntent.PaymentMethodOptions.CardPresent`, `PaymentIntent.PaymentMethodOptions.Card`, `PaymentIntentPaymentMethodOptionsCardOptions`, and `PaymentIntentPaymentMethodOptionsCardPresentOptions`
* Add support for `TransactionPurpose` on `PaymentIntent.PaymentMethodOptions.UsBankAccount` and `PaymentIntentPaymentMethodOptionsUsBankAccountOptions`
* Add support for `OptionalItems` on `PaymentLinkUpdateOptions`
* ⚠️ Remove support for `CardIssuerDecline` on `Radar.PaymentEvaluation.Insights`
* Add support for `PaymentBehavior` on `SubscriptionItemDeleteOptions`
* Add support for `BillingCycleAnchor` on `Subscription.TrialSettings.EndBehavior`
* Add support for `Lk` on `Tax.Registration.CountryOptions` and `TaxRegistrationCountryOptionsOptions`
* Add support for `Cellular` and `StripeS710` on `Terminal.ConfigurationCreateOptions`, `Terminal.ConfigurationUpdateOptions`, and `Terminal.Configuration`
* Add support for `RecipientOnboarding` and `RecipientUpdate` on `V2.Core.AccountLink.UseCase` and `V2CoreAccountLinkUseCaseOptions`
* Add support for `Consumer` on `V2.Core.Account.Configuration.Storer.Capabilities` and `V2CoreAccountConfigurationStorerCapabilitiesOptions`
* Add support for `FundsUsageType` on `V2.MoneyManagement.FinancialAccount.Storage` and `V2MoneyManagementFinancialAccountStorageOptions`
* Add support for `Purpose` on `V2.MoneyManagement.OutboundPaymentCreateOptions` and `V2.MoneyManagement.OutboundPayment`
* Add support for `BranchNumber` and `SwiftCode` on `V2.MoneyManagement.PayoutMethod.BankAccount`
* Add support for snapshot event `BillingAlertRecovered` with resource `Billing.AlertRecovered`
* Add support for snapshot events `ReserveHoldCreated` and `ReserveHoldUpdated` with resource `Reserve.Hold`
* Add support for snapshot events `ReservePlanCreated`, `ReservePlanDisabled`, `ReservePlanExpired`, and `ReservePlanUpdated` with resource `Reserve.Plan`
* Add support for snapshot event `ReserveReleaseCreated` with resource `Reserve.Release`
* Add support for event notification `V2BillingRateCardCustomPricingUnitOverageRateCreatedEvent` with related object `V2.Billing.RateCardCustomPricingUnitOverageRate`
* Add support for event notifications `V2IamStripeAccessGrantApprovedEvent`, `V2IamStripeAccessGrantCanceledEvent`, `V2IamStripeAccessGrantDeniedEvent`, `V2IamStripeAccessGrantRemovedEvent`, `V2IamStripeAccessGrantRequestedEvent`, and `V2IamStripeAccessGrantUpdatedEvent`
