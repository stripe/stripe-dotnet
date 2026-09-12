---
title: Update generated code for beta
pr_url: https://github.com/stripe/stripe-dotnet/pull/3390
is_breaking: true
is_stripe_api_change: true
released_in_version: 52.2.0-beta.1
---

* Add support for `Redaction` on `Card`, `Charge`, `Checkout.Session`, `Customer`, `Issuing.Authorization`, `Issuing.Card`, `Issuing.Cardholder`, `Issuing.Dispute`, `Issuing.Transaction`, `PaymentIntent`, `PaymentMethod`, `SetupIntent`, `Source`, and `Token`
* Add support for `DisclaimerVariant` on `Capital.FinancingOffer` and `Capital.FinancingSummary.Details`
* Add support for `Active` on `FinancialConnections.Account.StatusDetails` and `FinancialConnections.Authorization.StatusDetails`
* Change type of `FinancialConnectionsSessionLimitsOptions.Accounts` from `longInteger` to `emptyable(longInteger)`
* Add support for `Pause` on `InvoiceSubscriptionDetailsOptions`
* Add support for `ReleaseDetails` on `Reserve.Hold`
* Add support for `BuyerId` on `SharedPayment.GrantedToken.PaymentMethodDetails.Bizum` and `SharedPayment.GrantedToken.PaymentMethodDetails.Blik`
* Add support for `Fingerprint` on `SharedPayment.GrantedToken.PaymentMethodDetails.Pix`
* Add support for `MoneyManager` on `V2.Core.Account.Configuration`, `V2.Core.Account.Identity.Attestations.TermsOfService`, `V2CoreAccountConfigurationOptions`, `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`, and `V2CoreAccountTokenIdentityAttestationsTermsOfServiceOptions`
* ⚠️ Remove support for `Storer` on `V2.Core.Account.Configuration`, `V2.Core.Account.Identity.Attestations.TermsOfService`, `V2CoreAccountConfigurationOptions`, `V2CoreAccountIdentityAttestationsTermsOfServiceOptions`, and `V2CoreAccountTokenIdentityAttestationsTermsOfServiceOptions`
* ⚠️ Remove support for `MaximumRps` on `V2.Core.BatchJobCreateOptions` and `V2.Core.BatchJob`
* Add support for `Bic` on `V2.MoneyManagement.FinancialAddress.Credentials.UsBankAccount`
* ⚠️ Remove support for `SwiftCode` on `V2.MoneyManagement.FinancialAddress.Credentials.UsBankAccount`
* Add support for `Processing` on `V2.MoneyManagement.OutboundPayment.StatusDetails` and `V2.MoneyManagement.OutboundTransfer.StatusDetails`
* Add support for `AccountHolderName` on `V2.MoneyManagement.ReceivedCredit.BankTransfer.UsBankAccount`
* Add support for `Statuses` on `V2.MoneyManagement.FinancialAccountListOptions`
* ⚠️ Remove support for `Status` on `V2.MoneyManagement.FinancialAccountListOptions`
* Add support for event notifications `V2CoreAccountIncludingConfigurationMoneyManagerCapabilityStatusUpdatedEvent` and `V2CoreAccountIncludingConfigurationMoneyManagerUpdatedEvent` with related object `V2.Core.Account`
* Add support for event notification `V2MoneyManagementOutboundPaymentUnderReviewEvent` with related object `V2.MoneyManagement.OutboundPayment`
* Add support for event notification `V2MoneyManagementOutboundTransferUnderReviewEvent` with related object `V2.MoneyManagement.OutboundTransfer`
* ⚠️ Remove support for event notifications `V2CoreAccountIncludingConfigurationStorerCapabilityStatusUpdatedEvent` and `V2CoreAccountIncludingConfigurationStorerUpdatedEvent` with related object `V2.Core.Account`
