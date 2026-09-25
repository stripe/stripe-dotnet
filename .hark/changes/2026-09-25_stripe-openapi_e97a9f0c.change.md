---
title: Update generated code
pr_url: https://github.com/stripe/stripe-dotnet/pull/3443
semver_level: major
is_stripe_api_change: true
---

* Add support for new resources `Apps.Install`, `ProductCatalog.TrialOffer`, `Tax.Location`, and `ThreeDSecure.Authentication`
* Add support for `Create`, `Get`, `List`, `Uninstall`, and `Update` methods on resource `Apps.Install`
* Add support for `Create`, `Get`, `List`, and `Update` methods on resource `ProductCatalog.TrialOffer`
* Add support for `Create`, `Get`, and `List` methods on resource `Tax.Location`
* Add support for `Cancel`, `Create`, `Get`, `List`, and `Submit` methods on resource `ThreeDSecure.Authentication`
* Add support for `Pause` method on resource `Subscription`
* Add support for `PerformanceLocation` on `Tax.CalculationLineItem` and `TaxCalculationLineItemOptions`
* Add support for `Destination` on `Reserve.Hold`, `Reserve.Plan`, and `Reserve.Release`
* Add support for `ManualRelease` on `Reserve.Plan`
* Add support for `SpecifiedCommercialTransactionsActUrl` on `Account.BusinessProfile` and `AccountBusinessProfileOptions`
* Add support for `BlikRecurringPayments` and `SequraPayments` on `Account.Capabilities` and `AccountCapabilitiesOptions`
* Add support for `PaypayPayments` on `Account.Capabilities`, `Account.Settings`, `AccountCapabilitiesOptions`, and `AccountSettingsOptions`
* Add support for `SepaDebitPayments` on `AccountSettingsOptions`
* Add support for `Paypay` on `Charge.PaymentMethodDetails`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `Sequra` on `Charge.PaymentMethodDetails`, `Checkout.Session.PaymentMethodOptions`, `CheckoutSessionPaymentMethodOptionsOptions`, `ConfirmationToken.PaymentMethodPreview`, `ConfirmationTokenPaymentMethodDataOptions`, `PaymentAttemptRecord.PaymentMethodDetails`, `PaymentIntent.PaymentMethodOptions`, `PaymentIntentPaymentMethodDataOptions`, `PaymentIntentPaymentMethodOptionsOptions`, `PaymentMethodConfigurationCreateOptions`, `PaymentMethodConfigurationUpdateOptions`, `PaymentMethodConfiguration`, `PaymentMethodCreateOptions`, `PaymentMethod`, `PaymentRecord.PaymentMethodDetails`, and `SetupIntentPaymentMethodDataOptions`
* Add support for `ElectronicCommerceIndicator` on `Charge.PaymentMethodDetails.Card`
* ⚠️ Change type of `Charge.PaymentMethodDetails.Card.Mandate` from `string` to `expandable($Mandate)`
* Add support for `AllowedPaymentMethodTypes` on `Checkout.SessionCreateOptions` and `Checkout.Session`
* ⚠️ Remove support for `PaymentMethodTypes` on `Checkout.SessionCreateOptions`, `PaymentIntentConfirmOptions`, `PaymentIntentCreateOptions`, `PaymentIntentUpdateOptions`, `SetupIntentCreateOptions`, and `SetupIntentUpdateOptions`
* Add support for `TaxDetails` on `CheckoutSessionLineItemPriceDataProductDataOptions`, `InvoiceLineItemPriceDataProductDataOptions`, `InvoiceLinePriceDataProductDataOptions`, `PaymentLinkLineItemPriceDataProductDataOptions`, `PlanProductOptions`, `PriceProductDataOptions`, `ProductCreateOptions`, `ProductUpdateOptions`, and `Product`
* Add support for `Blik` on `CheckoutSessionPaymentMethodOptionsOptions`, `Invoice.PaymentSettings.PaymentMethodOptions`, `InvoicePaymentSettingsPaymentMethodOptionsOptions`, `Mandate.PaymentMethodDetails`, `SetupAttempt.PaymentMethodDetails`, `SetupIntent.PaymentMethodOptions`, `SetupIntentPaymentMethodOptionsOptions`, `Subscription.PaymentSettings.PaymentMethodOptions`, and `SubscriptionPaymentSettingsPaymentMethodOptionsOptions`
* Change type of `CheckoutSessionPaymentMethodOptionsBancontactOptions.SetupFutureUsage` and `PaymentIntentPaymentMethodOptionsBlikOptions.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
* ⚠️ Change type of `Checkout.Session.PaymentMethodOptions.Bancontact.SetupFutureUsage` and `PaymentIntent.PaymentMethodOptions.Blik.SetupFutureUsage` from `literal('none')` to `enum('none'|'off_session')`
* Add support for `Country` on `FinancialConnectionsSessionFiltersOptions`
* ⚠️ Remove support for `Countries` on `FinancialConnections.Session.Filters` and `FinancialConnectionsSessionFiltersOptions`
* Add support for `InvoicingRules` on `InvoiceItemUpdateOptions` and `InvoiceItem`
* Add support for `CompanyDetails` on `Invoice.PaymentSettings.PaymentMethodOptions.Billie`, `InvoicePaymentSettingsPaymentMethodOptionsBillieOptions`, `PaymentIntent.PaymentMethodOptions.Billie`, `PaymentIntentPaymentMethodOptionsBillieOptions`, `Subscription.PaymentSettings.PaymentMethodOptions.Billie`, and `SubscriptionPaymentSettingsPaymentMethodOptionsBillieOptions`
* Add support for `Reference` on `Invoice.PaymentSettings.PaymentMethodOptions.Billie`, `InvoicePaymentSettingsPaymentMethodOptionsBillieOptions`, `PaymentIntent.PaymentMethodOptions.Billie`, and `PaymentIntentPaymentMethodOptionsBillieOptions`
* Add support for `Pause` on `InvoiceSubscriptionDetailsOptions`
* ⚠️ Change type of `InvoiceSubscriptionDetailsOptions.BillingCycleAnchor` from `enum('now'|'unchanged') | DateTime` to `billing_cycle_anchor_param`
* Add support for `CurrentTrial` on `InvoiceSubscriptionDetailsItemOptions`, `SubscriptionItemCreateOptions`, `SubscriptionItemOptions`, `SubscriptionItemUpdateOptions`, and `SubscriptionItem`
* Add support for `StatusDetails` on `Invoice` and `Subscription`
* Add support for `India` on `Mandate.PaymentMethodDetails.Card`
* Add support for `Momo` on `PaymentAttemptRecord.PaymentMethodDetails` and `PaymentRecord.PaymentMethodDetails`
* Add support for `Link` on `PaymentAttemptRecord.PaymentMethodDetails.Card.Wallet` and `PaymentRecord.PaymentMethodDetails.Card.Wallet`
* Add support for `FundingSourceGroup` on `PaymentAttemptRecord.PaymentMethodDetails.Link` and `PaymentRecord.PaymentMethodDetails.Link`
* Add support for `MandateOptions` on `PaymentIntent.PaymentMethodOptions.Blik` and `PaymentIntentPaymentMethodOptionsBlikOptions`
* Add support for `PaymentRecord` on `PaymentIntent`
* Add support for `ExpiresAt` on `PaymentIntent.NextAction.SwishHandleRedirectOrDisplayQrCode.QrCode`
* ⚠️ Remove support for `Payto` on `PaymentMethodUpdateOptions`
* Add support for `Canceled` on `PaymentRecordReportPaymentAttemptOptions` and `PaymentRecordReportPaymentOptions`
* Add support for `EarlyFraudWarning` and `FraudulentDispute` on `Radar.PaymentEvaluation.Signals`
* ⚠️ Change type of `Radar.PaymentEvaluation.Signals.FraudulentPayment.Score` from `number` to `nullable(number)`
* Add support for `PauseSchedules` on `SubscriptionScheduleCreateOptions`, `SubscriptionScheduleUpdateOptions`, and `SubscriptionSchedule`
* ⚠️ Change type of `SubscriptionResumeOptions.BillingCycleAnchor` and `SubscriptionUpdateOptions.BillingCycleAnchor` from `enum('now'|'unchanged')` to `billing_cycle_anchor_param`
* Add support for `BillingCycleAnchor` on `Subscription.TrialSettings.EndBehavior` and `SubscriptionTrialSettingsEndBehaviorOptions`
* Add support for `PaymentBehavior` on `SubscriptionResumeOptions`
* Add support for `CancelAtPeriodEnd` on `Subscription.PendingUpdate`
* ⚠️ Remove support for `Igic` on `Tax.Registration.CountryOptions.At`, `Tax.Registration.CountryOptions.Be`, `Tax.Registration.CountryOptions.Bg`, `Tax.Registration.CountryOptions.Cy`, `Tax.Registration.CountryOptions.Cz`, `Tax.Registration.CountryOptions.De`, `Tax.Registration.CountryOptions.Dk`, `Tax.Registration.CountryOptions.Ee`, `Tax.Registration.CountryOptions.Es`, `Tax.Registration.CountryOptions.Fi`, `Tax.Registration.CountryOptions.Fr`, `Tax.Registration.CountryOptions.Gr`, `Tax.Registration.CountryOptions.Hr`, `Tax.Registration.CountryOptions.Hu`, `Tax.Registration.CountryOptions.Ie`, `Tax.Registration.CountryOptions.It`, `Tax.Registration.CountryOptions.Lt`, `Tax.Registration.CountryOptions.Lu`, `Tax.Registration.CountryOptions.Lv`, `Tax.Registration.CountryOptions.Mt`, `Tax.Registration.CountryOptions.Nl`, `Tax.Registration.CountryOptions.Pl`, `Tax.Registration.CountryOptions.Pt`, `Tax.Registration.CountryOptions.Ro`, `Tax.Registration.CountryOptions.Se`, `Tax.Registration.CountryOptions.Si`, `Tax.Registration.CountryOptions.Sk`, `TaxRegistrationCountryOptionsAtOptions`, `TaxRegistrationCountryOptionsBeOptions`, `TaxRegistrationCountryOptionsBgOptions`, `TaxRegistrationCountryOptionsCyOptions`, `TaxRegistrationCountryOptionsCzOptions`, `TaxRegistrationCountryOptionsDeOptions`, `TaxRegistrationCountryOptionsDkOptions`, `TaxRegistrationCountryOptionsEeOptions`, `TaxRegistrationCountryOptionsEsOptions`, `TaxRegistrationCountryOptionsFiOptions`, `TaxRegistrationCountryOptionsFrOptions`, `TaxRegistrationCountryOptionsGrOptions`, `TaxRegistrationCountryOptionsHrOptions`, `TaxRegistrationCountryOptionsHuOptions`, `TaxRegistrationCountryOptionsIeOptions`, `TaxRegistrationCountryOptionsItOptions`, `TaxRegistrationCountryOptionsLtOptions`, `TaxRegistrationCountryOptionsLuOptions`, `TaxRegistrationCountryOptionsLvOptions`, `TaxRegistrationCountryOptionsMtOptions`, `TaxRegistrationCountryOptionsNlOptions`, `TaxRegistrationCountryOptionsPlOptions`, `TaxRegistrationCountryOptionsPtOptions`, `TaxRegistrationCountryOptionsRoOptions`, `TaxRegistrationCountryOptionsSeOptions`, `TaxRegistrationCountryOptionsSiOptions`, and `TaxRegistrationCountryOptionsSkOptions`
* Add support for `AdmissionsTax`, `AttendanceTax`, `EntertainmentTax`, `GrossReceiptsTax`, `HospitalityTax`, `LuxuryTax`, `ResortTax`, and `TourismTax` on `Tax.Registration.CountryOptions.Us` and `TaxRegistrationCountryOptionsUsOptions`
* Add support for `Requirements` on `TaxCode`
* Add support for snapshot events `AppsInstallCreated`, `AppsInstallDeleted`, and `AppsInstallUpdated` with resource `Apps.Install`
