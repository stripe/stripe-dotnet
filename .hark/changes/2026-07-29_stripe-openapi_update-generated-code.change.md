---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3417
is_stripe_api_change: true
released_in_version: 52.2.0
---

* Add support for new resource `FinancialConnections.Authorization`
* Add support for `Unreject` method on resource `Account`
* Add support for `List` method on resource `PaymentRecord`
* Add support for `SmartDisputesManagement` on `AccountSession.Components.DisputesList.Features`, `AccountSession.Components.PaymentDetails.Features`, `AccountSession.Components.PaymentDisputes.Features`, `AccountSession.Components.Payments.Features`, `AccountSessionComponentsDisputesListFeaturesOptions`, `AccountSessionComponentsPaymentDetailsFeaturesOptions`, `AccountSessionComponentsPaymentDisputesFeaturesOptions`, and `AccountSessionComponentsPaymentsFeaturesOptions`
* Add support for `AdministrativeAddress` and `PrincipalPlaceOfBusiness` on `Account.Company`, `AccountCompanyOptions`, and `TokenAccountCompanyOptions`
* Add support for `SepaDebitPayments` on `AccountSettingsOptions`
* Remove support for `ProofOfRegistration` on `AccountDocumentsOptions`.  This field was limited-use and is being deprecated.
* Add support for `PayoutsAction` on `AccountRejectOptions`
* Remove support for `DynamicTaxRates` on `CheckoutSessionLineItemOptions`.  This field was limited-use and is being deprecated.
* Add support for `SetupFutureUsage` on `Checkout.Session.PaymentMethodOptions.Payco`, `Checkout.Session.PaymentMethodOptions.SamsungPay`, `CheckoutSessionPaymentMethodOptionsPaycoOptions`, `CheckoutSessionPaymentMethodOptionsSamsungPayOptions`, `PaymentIntent.PaymentMethodOptions.Payco`, `PaymentIntent.PaymentMethodOptions.SamsungPay`, `PaymentIntentPaymentMethodOptionsPaycoOptions`, `PaymentIntentPaymentMethodOptionsSamsungPayOptions`, and `PaymentLinkPaymentIntentDataOptions`
* Add support for `Network` on `Dispute.PaymentMethodDetails.Card`
* Add support for `Limits` and `ManualEntry` on `FinancialConnections.SessionCreateOptions` and `FinancialConnections.Session`
* Add support for `RequirePaymentMethodSupport` on `FinancialConnections.Session.Filters` and `FinancialConnectionsSessionFiltersOptions`
* Add support for `BankAccountToken` on `FinancialConnections.Session`
* Add support for `Metadata` on `InvoiceSubscriptionDetailsOptions`
* Add support for `BusinessName` on `Issuing.Card.Shipping` and `IssuingCardShippingOptions`
* Add support for `AllowedPaymentMethodTypes` on `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentUpdateOptions`, `PaymentIntent`, `SetupIntentConfirmOptions`, `SetupIntentCreateOptions`, `SetupIntentUpdateOptions`, and `SetupIntent`
* Add support for `Referrer` on `PaymentIntentRadarOptionsOptions`
* Add support for `ConsentCollection` and `ShippingOptions` on `PaymentLinkUpdateOptions`
* Add support for `CustomFields`, `Description`, and `Footer` on `Quote.InvoiceSettings`, `QuoteInvoiceSettingsOptions`, `SubscriptionSchedule.DefaultSettings.InvoiceSettings`, `SubscriptionSchedule.Phase.InvoiceSettings`, `SubscriptionScheduleDefaultSettingsInvoiceSettingsOptions`, and `SubscriptionSchedulePhaseInvoiceSettingsOptions`
* Add support for `CustomerAccount` and `Customer` on `Refund`
* Add support for `PaymentMethod` on `Refund` and `Topup`
* Add support for `Trial` on `SubscriptionSchedule.Phase`
* Add support for `MassTransitParkingTax` and `ParkingTax` on `Tax.Registration.CountryOptions.Us` and `TaxRegistrationCountryOptionsUsOptions`
* Add support for `InitiatedBy` and `PaymentMethodOptions` on `Topup`
* Add support for `AdditionalAddresses` on `V2.Core.Account.Identity.BusinessDetails`, `V2CoreAccountIdentityBusinessDetailsOptions`, and `V2CoreAccountTokenIdentityBusinessDetailsOptions`
* Add support for snapshot events `FinancialConnectionsAccountExpectedDeactivationDateUpdated`, `FinancialConnectionsAccountSupportedPaymentMethodTypesUpdated`, and `FinancialConnectionsAccountUpcomingDeactivation` with resource `FinancialConnections.Account`
* Add support for snapshot events `FinancialConnectionsAuthorizationExpectedDeactivationDateUpdated` and `FinancialConnectionsAuthorizationUpcomingDeactivation` with resource `FinancialConnections.Authorization`
