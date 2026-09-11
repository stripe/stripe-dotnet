---
title: Update generated code for private-preview
pr_link: https://github.com/stripe/stripe-dotnet/pull/3274
is_stripe_api_change: true
released_in_version: 50.2.0-alpha.2
---

* Add support for new resource `Tax.Location`
* Add support for `Create`, `Get`, and `List` methods on resource `Tax.Location`
* Add support for `PerformanceLocation` on `CheckoutSessionLineItemPriceDataProductDataTaxDetailsOptions`, `InvoiceLineItemPriceDataProductDataTaxDetailsOptions`, `InvoiceLinePriceDataProductDataTaxDetailsOptions`, `PaymentLinkLineItemPriceDataProductDataTaxDetailsOptions`, `ProductTaxDetailsOptions`, `Tax.CalculationLineItem`, and `TaxCalculationLineItemOptions`
* Change type of `DelegatedCheckout.RequestedSessionUpdateOptions.Metadata` from `map(string: string)` to `emptyable(map(string: string))`
* Change type of `DelegatedCheckout.RequestedSessionUpdateOptions.PaymentMethodData` from `payment_method_data` to `emptyable(payment_method_data)`
* Change type of `DelegatedCheckout.RequestedSessionUpdateOptions.SharedMetadata` from `map(string: string)` to `emptyable(map(string: string))`
* Add support for `Subscription` on `Invoice.Parent.ScheduleDetails` and `QuotePreviewInvoice.Parent.ScheduleDetails`
* Change type of `PaymentIntentPaymentDetailsBenefitOptions.FrMealVoucher` and `SetupIntentSetupDetailsBenefitOptions.FrMealVoucher` from `payment_details_benefit_fr_meal_voucher` to `emptyable(payment_details_benefit_fr_meal_voucher)`
* Add support for `TaxDetails` on `PlanProductOptions` and `PriceProductDataOptions`
* Add support for `AdmissionsTax`, `AttendanceTax`, `EntertainmentTax`, `GrossReceiptsTax`, `HospitalityTax`, `LuxuryTax`, `ResortTax`, and `TourismTax` on `Tax.Registration.CountryOptions.Us`
* Add support for `Requirements` on `TaxCode`
