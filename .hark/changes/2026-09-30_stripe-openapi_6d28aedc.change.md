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
* Add support for `BlikRecurringPayments` and `SequraPayments` on `Account.Capabilities`, `AccountCapabilitiesOptions`, `V2.Core.Account.Configuration.Merchant.Capabilities`, and `V2CoreAccountConfigurationMerchantCapabilitiesOptions`
* Add support for `PaypayPayments` on `Account.Capabilities`, `Account.Settings`, `AccountCapabilitiesOptions`, and `AccountSettingsOptions`
* Add support for `SepaDebitPayments` on `AccountSettingsOptions` and `V2CoreAccountConfigurationMerchantOptions`
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
* ⚠️ Remove support for `Configurations` on `V2.Core.AccountLink.UseCase.AccountOnboarding`, `V2.Core.AccountLink.UseCase.AccountUpdate`, `V2CoreAccountLinkUseCaseAccountOnboardingOptions`, and `V2CoreAccountLinkUseCaseAccountUpdateOptions`
* Add support for `SatispayPayments` on `V2.Core.Account.Configuration.Merchant.Capabilities` and `V2CoreAccountConfigurationMerchantCapabilitiesOptions`
* Add support for `SnapshotEvent` on `V2.Core.Event`
* Add support for snapshot events `AppsInstallCreated`, `AppsInstallDeleted`, and `AppsInstallUpdated` with resource `Apps.Install`
* Add support for event notifications `V1AccountApplicationAuthorizedEvent`, `V1AccountApplicationDeauthorizedEvent`, `V1AccountExternalAccountCreatedEvent`, `V1AccountExternalAccountDeletedEvent`, `V1AccountExternalAccountUpdatedEvent`, `V1BillingPortalSessionCreatedEvent`, and `V1EntitlementsActiveEntitlementSummaryUpdatedEvent`
* Add support for event notification `V1AccountUpdatedEvent` with related object `Account`
* Add support for event notifications `V1ApplicationFeeCreatedEvent` and `V1ApplicationFeeRefundedEvent` with related object `ApplicationFee`
* Add support for event notification `V1ApplicationFeeRefundUpdatedEvent` with related object `ApplicationFeeRefund`
* Add support for event notification `V1BalanceAvailableEvent` with related object `Balance`
* Add support for event notification `V1BalanceSettingsUpdatedEvent` with related object `BalanceSettings`
* Add support for event notification `V1BillingAlertTriggeredEvent` with related object `Billing.Alert`
* Add support for event notification `V1BillingCreditBalanceTransactionCreatedEvent` with related object `Billing.CreditBalanceTransaction`
* Add support for event notifications `V1BillingCreditGrantCreatedEvent` and `V1BillingCreditGrantUpdatedEvent` with related object `Billing.CreditGrant`
* Add support for event notifications `V1BillingMeterCreatedEvent`, `V1BillingMeterDeactivatedEvent`, `V1BillingMeterReactivatedEvent`, and `V1BillingMeterUpdatedEvent` with related object `Billing.Meter`
* Add support for event notifications `V1BillingPortalConfigurationCreatedEvent` and `V1BillingPortalConfigurationUpdatedEvent` with related object `BillingPortal.Configuration`
* Add support for event notification `V1CapabilityUpdatedEvent` with related object `Capability`
* Add support for event notification `V1CashBalanceFundsAvailableEvent` with related object `CashBalance`
* Add support for event notifications `V1ChargeCapturedEvent`, `V1ChargeExpiredEvent`, `V1ChargeFailedEvent`, `V1ChargePendingEvent`, `V1ChargeRefundedEvent`, `V1ChargeSucceededEvent`, and `V1ChargeUpdatedEvent` with related object `Charge`
* Add support for event notifications `V1ChargeDisputeClosedEvent`, `V1ChargeDisputeCreatedEvent`, `V1ChargeDisputeFundsReinstatedEvent`, `V1ChargeDisputeFundsWithdrawnEvent`, and `V1ChargeDisputeUpdatedEvent` with related object `Dispute`
* Add support for event notifications `V1ChargeRefundUpdatedEvent`, `V1RefundCreatedEvent`, `V1RefundFailedEvent`, and `V1RefundUpdatedEvent` with related object `Refund`
* Add support for event notifications `V1CheckoutSessionAsyncPaymentFailedEvent`, `V1CheckoutSessionAsyncPaymentSucceededEvent`, `V1CheckoutSessionCompletedEvent`, and `V1CheckoutSessionExpiredEvent` with related object `Checkout.Session`
* Add support for event notifications `V1ClimateOrderCanceledEvent`, `V1ClimateOrderCreatedEvent`, `V1ClimateOrderDelayedEvent`, `V1ClimateOrderDeliveredEvent`, and `V1ClimateOrderProductSubstitutedEvent` with related object `Climate.Order`
* Add support for event notifications `V1ClimateProductCreatedEvent` and `V1ClimateProductPricingUpdatedEvent` with related object `Climate.Product`
* Add support for event notifications `V1CouponCreatedEvent`, `V1CouponDeletedEvent`, and `V1CouponUpdatedEvent` with related object `Coupon`
* Add support for event notifications `V1CreditNoteCreatedEvent`, `V1CreditNoteUpdatedEvent`, and `V1CreditNoteVoidedEvent` with related object `CreditNote`
* Add support for event notifications `V1CustomerCreatedEvent`, `V1CustomerDeletedEvent`, and `V1CustomerUpdatedEvent` with related object `Customer`
* Add support for event notifications `V1CustomerDiscountCreatedEvent`, `V1CustomerDiscountDeletedEvent`, and `V1CustomerDiscountUpdatedEvent` with related object `Discount`
* Add support for event notifications `V1CustomerSubscriptionCreatedEvent`, `V1CustomerSubscriptionDeletedEvent`, `V1CustomerSubscriptionPausedEvent`, `V1CustomerSubscriptionPendingUpdateAppliedEvent`, `V1CustomerSubscriptionPendingUpdateExpiredEvent`, `V1CustomerSubscriptionResumedEvent`, `V1CustomerSubscriptionTrialWillEndEvent`, and `V1CustomerSubscriptionUpdatedEvent` with related object `Subscription`
* Add support for event notifications `V1CustomerTaxIdCreatedEvent`, `V1CustomerTaxIdDeletedEvent`, and `V1CustomerTaxIdUpdatedEvent` with related object `TaxId`
* Add support for event notification `V1CustomerCashBalanceTransactionCreatedEvent` with related object `CustomerCashBalanceTransaction`
* Add support for event notification `V1FileCreatedEvent` with related object `File`
* Add support for event notifications `V1FinancialConnectionsAccountAccountNumbersUpdatedEvent`, `V1FinancialConnectionsAccountCreatedEvent`, `V1FinancialConnectionsAccountDeactivatedEvent`, `V1FinancialConnectionsAccountDisconnectedEvent`, `V1FinancialConnectionsAccountExpectedDeactivationDateUpdatedEvent`, `V1FinancialConnectionsAccountReactivatedEvent`, `V1FinancialConnectionsAccountRefreshedBalanceEvent`, `V1FinancialConnectionsAccountRefreshedOwnershipEvent`, `V1FinancialConnectionsAccountRefreshedTransactionsEvent`, `V1FinancialConnectionsAccountSupportedPaymentMethodTypesUpdatedEvent`, `V1FinancialConnectionsAccountUpcomingAccountNumberExpiryEvent`, and `V1FinancialConnectionsAccountUpcomingDeactivationEvent` with related object `FinancialConnections.Account`
* Add support for event notifications `V1IdentityVerificationSessionCanceledEvent`, `V1IdentityVerificationSessionCreatedEvent`, `V1IdentityVerificationSessionProcessingEvent`, `V1IdentityVerificationSessionRedactedEvent`, `V1IdentityVerificationSessionRequiresInputEvent`, and `V1IdentityVerificationSessionVerifiedEvent` with related object `Identity.VerificationSession`
* Add support for event notifications `V1InvoiceCreatedEvent`, `V1InvoiceDeletedEvent`, `V1InvoiceFinalizationFailedEvent`, `V1InvoiceFinalizedEvent`, `V1InvoiceMarkedUncollectibleEvent`, `V1InvoiceOverdueEvent`, `V1InvoiceOverpaidEvent`, `V1InvoicePaidEvent`, `V1InvoicePaymentActionRequiredEvent`, `V1InvoicePaymentAttemptRequiredEvent`, `V1InvoicePaymentFailedEvent`, `V1InvoicePaymentSucceededEvent`, `V1InvoiceSentEvent`, `V1InvoiceUpcomingEvent`, `V1InvoiceUpdatedEvent`, `V1InvoiceVoidedEvent`, and `V1InvoiceWillBeDueEvent` with related object `Invoice`
* Add support for event notification `V1InvoicePaymentPaidEvent` with related object `InvoicePayment`
* Add support for event notifications `V1InvoiceitemCreatedEvent` and `V1InvoiceitemDeletedEvent` with related object `InvoiceItem`
* Add support for event notifications `V1IssuingAuthorizationCreatedEvent`, `V1IssuingAuthorizationRequestEvent`, and `V1IssuingAuthorizationUpdatedEvent` with related object `Issuing.Authorization`
* Add support for event notifications `V1IssuingCardCreatedEvent` and `V1IssuingCardUpdatedEvent` with related object `Issuing.Card`
* Add support for event notifications `V1IssuingCardholderCreatedEvent` and `V1IssuingCardholderUpdatedEvent` with related object `Issuing.Cardholder`
* Add support for event notifications `V1IssuingDisputeClosedEvent`, `V1IssuingDisputeCreatedEvent`, `V1IssuingDisputeFundsReinstatedEvent`, `V1IssuingDisputeFundsRescindedEvent`, `V1IssuingDisputeSubmittedEvent`, and `V1IssuingDisputeUpdatedEvent` with related object `Issuing.Dispute`
* Add support for event notifications `V1IssuingPersonalizationDesignActivatedEvent`, `V1IssuingPersonalizationDesignDeactivatedEvent`, `V1IssuingPersonalizationDesignRejectedEvent`, and `V1IssuingPersonalizationDesignUpdatedEvent` with related object `Issuing.PersonalizationDesign`
* Add support for event notifications `V1IssuingTokenCreatedEvent` and `V1IssuingTokenUpdatedEvent` with related object `Issuing.Token`
* Add support for event notifications `V1IssuingTransactionCreatedEvent`, `V1IssuingTransactionPurchaseDetailsReceiptUpdatedEvent`, and `V1IssuingTransactionUpdatedEvent` with related object `Issuing.Transaction`
* Add support for event notification `V1MandateUpdatedEvent` with related object `Mandate`
* Add support for event notifications `V1PaymentIntentAmountCapturableUpdatedEvent`, `V1PaymentIntentCanceledEvent`, `V1PaymentIntentCreatedEvent`, `V1PaymentIntentPartiallyFundedEvent`, `V1PaymentIntentPaymentFailedEvent`, `V1PaymentIntentProcessingEvent`, `V1PaymentIntentRequiresActionEvent`, and `V1PaymentIntentSucceededEvent` with related object `PaymentIntent`
* Add support for event notifications `V1PaymentLinkCreatedEvent` and `V1PaymentLinkUpdatedEvent` with related object `PaymentLink`
* Add support for event notifications `V1PaymentMethodAttachedEvent`, `V1PaymentMethodAutomaticallyUpdatedEvent`, `V1PaymentMethodDetachedEvent`, and `V1PaymentMethodUpdatedEvent` with related object `PaymentMethod`
* Add support for event notifications `V1PayoutCanceledEvent`, `V1PayoutCreatedEvent`, `V1PayoutFailedEvent`, `V1PayoutPaidEvent`, `V1PayoutReconciliationCompletedEvent`, and `V1PayoutUpdatedEvent` with related object `Payout`
* Add support for event notifications `V1PersonCreatedEvent`, `V1PersonDeletedEvent`, and `V1PersonUpdatedEvent` with related object `Person`
* Add support for event notifications `V1PlanCreatedEvent`, `V1PlanDeletedEvent`, and `V1PlanUpdatedEvent` with related object `Plan`
* Add support for event notifications `V1PriceCreatedEvent`, `V1PriceDeletedEvent`, and `V1PriceUpdatedEvent` with related object `Price`
* Add support for event notifications `V1ProductCreatedEvent`, `V1ProductDeletedEvent`, and `V1ProductUpdatedEvent` with related object `Product`
* Add support for event notifications `V1PromotionCodeCreatedEvent` and `V1PromotionCodeUpdatedEvent` with related object `PromotionCode`
* Add support for event notifications `V1QuoteAcceptedEvent`, `V1QuoteCanceledEvent`, `V1QuoteCreatedEvent`, and `V1QuoteFinalizedEvent` with related object `Quote`
* Add support for event notifications `V1RadarEarlyFraudWarningCreatedEvent` and `V1RadarEarlyFraudWarningUpdatedEvent` with related object `Radar.EarlyFraudWarning`
* Add support for event notifications `V1ReviewClosedEvent` and `V1ReviewOpenedEvent` with related object `Review`
* Add support for event notifications `V1SetupIntentCanceledEvent`, `V1SetupIntentCreatedEvent`, `V1SetupIntentRequiresActionEvent`, `V1SetupIntentSetupFailedEvent`, and `V1SetupIntentSucceededEvent` with related object `SetupIntent`
* Add support for event notification `V1SigmaScheduledQueryRunCreatedEvent` with related object `Sigma.ScheduledQueryRun`
* Add support for event notifications `V1SourceCanceledEvent`, `V1SourceChargeableEvent`, `V1SourceFailedEvent`, and `V1SourceRefundAttributesRequiredEvent` with related object `Source`
* Add support for event notifications `V1SubscriptionScheduleAbortedEvent`, `V1SubscriptionScheduleCanceledEvent`, `V1SubscriptionScheduleCompletedEvent`, `V1SubscriptionScheduleCreatedEvent`, `V1SubscriptionScheduleExpiringEvent`, `V1SubscriptionScheduleReleasedEvent`, and `V1SubscriptionScheduleUpdatedEvent` with related object `SubscriptionSchedule`
* Add support for event notification `V1TaxSettingsUpdatedEvent` with related object `Tax.Settings`
* Add support for event notifications `V1TaxRateCreatedEvent` and `V1TaxRateUpdatedEvent` with related object `TaxRate`
* Add support for event notifications `V1TerminalReaderActionFailedEvent`, `V1TerminalReaderActionSucceededEvent`, and `V1TerminalReaderActionUpdatedEvent` with related object `Terminal.Reader`
* Add support for event notifications `V1TestHelpersTestClockAdvancingEvent`, `V1TestHelpersTestClockCreatedEvent`, `V1TestHelpersTestClockDeletedEvent`, `V1TestHelpersTestClockInternalFailureEvent`, and `V1TestHelpersTestClockReadyEvent` with related object `TestHelpers.TestClock`
* Add support for event notifications `V1TopupCanceledEvent`, `V1TopupCreatedEvent`, `V1TopupFailedEvent`, `V1TopupReversedEvent`, and `V1TopupSucceededEvent` with related object `Topup`
* Add support for event notifications `V1TransferCreatedEvent`, `V1TransferReversedEvent`, and `V1TransferUpdatedEvent` with related object `Transfer`
