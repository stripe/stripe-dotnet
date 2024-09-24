// File generated from our OpenAPI spec
namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Stripe;
    using Xunit;

    public class GeneratedExamplesTest : BaseStripeTest
    {
        public GeneratedExamplesTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
        }

        [Fact]
        public void TestAccountLinksPost()
        {
            var options = new AccountLinkCreateOptions
            {
                Account = "acct_xxxxxxxxxxxxx",
                RefreshUrl = "https://example.com/reauth",
                ReturnUrl = "https://example.com/return",
                Type = "account_onboarding",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.AccountLinks;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/account_links");
        }

        [Fact]
        public void TestAccountsCapabilitiesGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts.Capabilities;
            StripeList<Capability> capabilities = service.List(
                "acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/capabilities");
        }

        [Fact]
        public void TestAccountsCapabilitiesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts.Capabilities;
            service.Get("acct_xxxxxxxxxxxxx", "card_payments");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/capabilities/card_payments");
        }

        [Fact]
        public void TestAccountsCapabilitiesPost()
        {
            var options = new AccountCapabilityUpdateOptions
            {
                Requested = true,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts.Capabilities;
            service.Update("acct_xxxxxxxxxxxxx", "card_payments", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/capabilities/card_payments");
        }

        [Fact]
        public void TestAccountsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts;
            service.Delete("acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/accounts/acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsGet()
        {
            var options = new AccountListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts;
            StripeList<Account> accounts = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts", "limit=3");
        }

        [Fact]
        public void TestAccountsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts;
            service.Get("acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsLoginLinksPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts.LoginLinks;
            service.Create("acct_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/login_links");
        }

        [Fact]
        public void TestAccountsPersonsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts.Persons;
            service.Delete("acct_xxxxxxxxxxxxx", "person_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons/person_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsPersonsGet()
        {
            var options = new AccountPersonListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts.Persons;
            StripeList<Person> persons = service.List(
                "acct_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons",
                "limit=3");
        }

        [Fact]
        public void TestAccountsPersonsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts.Persons;
            service.Get("acct_xxxxxxxxxxxxx", "person_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons/person_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsPersonsPost()
        {
            var options = new AccountPersonCreateOptions
            {
                FirstName = "Jane",
                LastName = "Diaz",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts.Persons;
            service.Create("acct_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons");
        }

        [Fact]
        public void TestAccountsPersonsPost2()
        {
            var options = new AccountPersonUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts.Persons;
            service.Update(
                "acct_xxxxxxxxxxxxx",
                "person_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/persons/person_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsPost()
        {
            var options = new AccountCreateOptions
            {
                Type = "custom",
                Country = "US",
                Email = "jenny.rosen@example.com",
                Capabilities = new AccountCapabilitiesOptions
                {
                    CardPayments = new AccountCapabilitiesCardPaymentsOptions
                    {
                        Requested = true,
                    },
                    Transfers = new AccountCapabilitiesTransfersOptions
                    {
                        Requested = true,
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts");
        }

        [Fact]
        public void TestAccountsPost2()
        {
            var options = new AccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts;
            service.Update("acct_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAccountsRejectPost()
        {
            var options = new AccountRejectOptions { Reason = "fraud" };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Accounts;
            service.Reject("acct_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/accounts/acct_xxxxxxxxxxxxx/reject");
        }

        [Fact]
        public void TestApplicationFeesGet()
        {
            var options = new ApplicationFeeListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.ApplicationFees;
            StripeList<ApplicationFee> applicationFees = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees",
                "limit=3");
        }

        [Fact]
        public void TestApplicationFeesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.ApplicationFees;
            service.Get("fee_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees/fee_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestApplicationFeesRefundsGet()
        {
            var options = new ApplicationFeeRefundListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.ApplicationFees.Refunds;
            StripeList<ApplicationFeeRefund> applicationFeeRefunds = service
                .List("fee_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds",
                "limit=3");
        }

        [Fact]
        public void TestApplicationFeesRefundsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.ApplicationFees.Refunds;
            service.Get("fee_xxxxxxxxxxxxx", "fr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds/fr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestApplicationFeesRefundsPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.ApplicationFees.Refunds;
            service.Create("fee_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds");
        }

        [Fact]
        public void TestApplicationFeesRefundsPost2()
        {
            var options = new ApplicationFeeRefundUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.ApplicationFees.Refunds;
            service.Update("fee_xxxxxxxxxxxxx", "fr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/application_fees/fee_xxxxxxxxxxxxx/refunds/fr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestAppsSecretsDeletePost()
        {
            var options = new Stripe.Apps.SecretDeleteWhereOptions
            {
                Name = "my-api-key",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Apps.Secrets;
            service.DeleteWhere(options);
            this.AssertRequest(HttpMethod.Post, "/v1/apps/secrets/delete");
        }

        [Fact]
        public void TestAppsSecretsFindGet()
        {
            var options = new Stripe.Apps.SecretFindOptions
            {
                Name = "sec_123",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Apps.Secrets;
            service.Find(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets/find",
                "name=sec_123&scope[type]=account");
        }

        [Fact]
        public void TestAppsSecretsGet()
        {
            var options = new Stripe.Apps.SecretListOptions
            {
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
                Limit = 2,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Apps.Secrets;
            StripeList<Stripe.Apps.Secret> secrets = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets",
                "scope[type]=account&limit=2");
        }

        [Fact]
        public void TestAppsSecretsGet2()
        {
            var options = new Stripe.Apps.SecretListOptions
            {
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
                Limit = 2,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Apps.Secrets;
            StripeList<Stripe.Apps.Secret> secrets = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/apps/secrets",
                "scope[type]=account&limit=2");
        }

        [Fact]
        public void TestAppsSecretsPost()
        {
            var options = new Stripe.Apps.SecretCreateOptions
            {
                Name = "sec_123",
                Payload = "very secret string",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Apps.Secrets;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/apps/secrets");
        }

        [Fact]
        public void TestAppsSecretsPost2()
        {
            var options = new Stripe.Apps.SecretCreateOptions
            {
                Name = "my-api-key",
                Payload = "secret_key_xxxxxx",
                Scope = new Stripe.Apps.SecretScopeOptions { Type = "account" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Apps.Secrets;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/apps/secrets");
        }

        [Fact]
        public void TestBalanceTransactionsGet()
        {
            var options = new BalanceTransactionListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.BalanceTransactions;
            StripeList<BalanceTransaction> balanceTransactions = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/balance_transactions",
                "limit=3");
        }

        [Fact]
        public void TestBalanceTransactionsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.BalanceTransactions;
            service.Get("txn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/balance_transactions/txn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestBillingPortalConfigurationsGet()
        {
            var options = new Stripe.BillingPortal.ConfigurationListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.BillingPortal.Configurations;
            StripeList<Stripe.BillingPortal.Configuration> configurations = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/billing_portal/configurations",
                "limit=3");
        }

        [Fact]
        public void TestBillingPortalConfigurationsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.BillingPortal.Configurations;
            service.Get("bpc_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/billing_portal/configurations/bpc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestBillingPortalConfigurationsPost()
        {
            var options = new Stripe.BillingPortal.ConfigurationCreateOptions
            {
                Features = new Stripe.BillingPortal.ConfigurationFeaturesOptions
                {
                    CustomerUpdate = new Stripe.BillingPortal.ConfigurationFeaturesCustomerUpdateOptions
                    {
                        AllowedUpdates = new List<string> { "email", "tax_id" },
                        Enabled = true,
                    },
                    InvoiceHistory = new Stripe.BillingPortal.ConfigurationFeaturesInvoiceHistoryOptions
                    {
                        Enabled = true,
                    },
                },
                BusinessProfile = new Stripe.BillingPortal.ConfigurationBusinessProfileOptions
                {
                    PrivacyPolicyUrl = "https://example.com/privacy",
                    TermsOfServiceUrl = "https://example.com/terms",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.BillingPortal.Configurations;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/billing_portal/configurations");
        }

        [Fact]
        public void TestBillingPortalConfigurationsPost2()
        {
            var options = new Stripe.BillingPortal.ConfigurationUpdateOptions
            {
                BusinessProfile = new Stripe.BillingPortal.ConfigurationBusinessProfileOptions
                {
                    PrivacyPolicyUrl = "https://example.com/privacy",
                    TermsOfServiceUrl = "https://example.com/terms",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.BillingPortal.Configurations;
            service.Update("bpc_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/billing_portal/configurations/bpc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestBillingPortalSessionsPost()
        {
            var options = new Stripe.BillingPortal.SessionCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                ReturnUrl = "https://example.com/account",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.BillingPortal.Sessions;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/billing_portal/sessions");
        }

        [Fact]
        public void TestChargesCapturePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Charges;
            service.Capture("ch_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/charges/ch_xxxxxxxxxxxxx/capture");
        }

        [Fact]
        public void TestChargesGet()
        {
            var options = new ChargeListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Charges;
            StripeList<Charge> charges = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/charges", "limit=3");
        }

        [Fact]
        public void TestChargesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Charges;
            service.Get("ch_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/charges/ch_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestChargesPost()
        {
            var options = new ChargeCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Source = "tok_xxxx",
                Description = "My First Test Charge (created for API docs at https://www.stripe.com/docs/api)",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Charges;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/charges");
        }

        [Fact]
        public void TestChargesPost2()
        {
            var options = new ChargeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Charges;
            service.Update("ch_xxxxxxxxxxxxx", options);
            this.AssertRequest(HttpMethod.Post, "/v1/charges/ch_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestChargesSearchGet()
        {
            var options = new ChargeSearchOptions
            {
                Query = "amount>999 AND metadata['order_id']:'6735'",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Charges;
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/charges/search",
                "query=amount%3E999%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestCheckoutSessionsExpirePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Checkout.Sessions;
            service.Expire("sess_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/checkout/sessions/sess_xyz/expire");
        }

        [Fact]
        public void TestCheckoutSessionsExpirePost2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Checkout.Sessions;
            service.Expire("cs_test_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/checkout/sessions/cs_test_xxxxxxxxxxxxx/expire");
        }

        [Fact]
        public void TestCheckoutSessionsGet()
        {
            var options = new Stripe.Checkout.SessionListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Checkout.Sessions;
            StripeList<Stripe.Checkout.Session> sessions = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions",
                "limit=3");
        }

        [Fact]
        public void TestCheckoutSessionsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Checkout.Sessions;
            service.Get("cs_test_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions/cs_test_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCheckoutSessionsLineItemsGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Checkout.Sessions.LineItems;
            StripeList<LineItem> lineItems = service.List("sess_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/checkout/sessions/sess_xyz/line_items");
        }

        [Fact]
        public void TestCheckoutSessionsPost()
        {
            var options = new Stripe.Checkout.SessionCreateOptions
            {
                SuccessUrl = "https://example.com/success",
                CancelUrl = "https://example.com/cancel",
                Mode = "payment",
                ShippingOptions = new List<Stripe.Checkout.SessionShippingOptionOptions>
                {
                    new Stripe.Checkout.SessionShippingOptionOptions
                    {
                        ShippingRate = "shr_standard",
                    },
                    new Stripe.Checkout.SessionShippingOptionOptions
                    {
                        ShippingRateData = new Stripe.Checkout.SessionShippingOptionShippingRateDataOptions
                        {
                            DisplayName = "Standard",
                            DeliveryEstimate = new Stripe.Checkout.SessionShippingOptionShippingRateDataDeliveryEstimateOptions
                            {
                                Minimum = new Stripe.Checkout.SessionShippingOptionShippingRateDataDeliveryEstimateMinimumOptions
                                {
                                    Unit = "day",
                                    Value = 5,
                                },
                                Maximum = new Stripe.Checkout.SessionShippingOptionShippingRateDataDeliveryEstimateMaximumOptions
                                {
                                    Unit = "day",
                                    Value = 7,
                                },
                            },
                        },
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Checkout.Sessions;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout/sessions");
        }

        [Fact]
        public void TestCheckoutSessionsPost2()
        {
            var options = new Stripe.Checkout.SessionCreateOptions
            {
                SuccessUrl = "https://example.com/success",
                LineItems = new List<Stripe.Checkout.SessionLineItemOptions>
                {
                    new Stripe.Checkout.SessionLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 2,
                    },
                },
                Mode = "payment",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Checkout.Sessions;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/checkout/sessions");
        }

        [Fact]
        public void TestCountrySpecsGet()
        {
            var options = new CountrySpecListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.CountrySpecs;
            StripeList<CountrySpec> countrySpecs = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs", "limit=3");
        }

        [Fact]
        public void TestCountrySpecsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.CountrySpecs;
            service.Get("US");
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs/US");
        }

        [Fact]
        public void TestCouponsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Coupons;
            service.Delete("Z4OV52SU");
            this.AssertRequest(HttpMethod.Delete, "/v1/coupons/Z4OV52SU");
        }

        [Fact]
        public void TestCouponsGet()
        {
            var options = new CouponListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Coupons;
            StripeList<Coupon> coupons = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/coupons", "limit=3");
        }

        [Fact]
        public void TestCouponsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Coupons;
            service.Get("Z4OV52SU");
            this.AssertRequest(HttpMethod.Get, "/v1/coupons/Z4OV52SU");
        }

        [Fact]
        public void TestCouponsPost()
        {
            var options = new CouponCreateOptions
            {
                PercentOff = 25.5M,
                Duration = "repeating",
                DurationInMonths = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Coupons;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/coupons");
        }

        [Fact]
        public void TestCouponsPost2()
        {
            var options = new CouponUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Coupons;
            service.Update("Z4OV52SU", options);
            this.AssertRequest(HttpMethod.Post, "/v1/coupons/Z4OV52SU");
        }

        [Fact]
        public void TestCreditNotesGet()
        {
            var options = new CreditNoteListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.CreditNotes;
            StripeList<CreditNote> creditNotes = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes", "limit=3");
        }

        [Fact]
        public void TestCreditNotesPost()
        {
            var options = new CreditNoteCreateOptions
            {
                Invoice = "in_xxxxxxxxxxxxx",
                Lines = new List<CreditNoteLineOptions>
                {
                    new CreditNoteLineOptions
                    {
                        Type = "invoice_line_item",
                        InvoiceLineItem = "il_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.CreditNotes;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/credit_notes");
        }

        [Fact]
        public void TestCreditNotesPreviewGet()
        {
            var options = new CreditNotePreviewOptions
            {
                Invoice = "in_xxxxxxxxxxxxx",
                Lines = new List<CreditNoteLineOptions>
                {
                    new CreditNoteLineOptions
                    {
                        Type = "invoice_line_item",
                        InvoiceLineItem = "il_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.CreditNotes;
            service.Preview(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/credit_notes/preview",
                "invoice=in_xxxxxxxxxxxxx&lines[0][type]=invoice_line_item&lines[0][invoice_line_item]=il_xxxxxxxxxxxxx&lines[0][quantity]=1");
        }

        [Fact]
        public void TestCreditNotesVoidPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.CreditNotes;
            service.VoidCreditNote("cn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/credit_notes/cn_xxxxxxxxxxxxx/void");
        }

        [Fact]
        public void TestCustomerSessionsPost()
        {
            var options = new CustomerSessionCreateOptions
            {
                Customer = "cus_123",
                Components = new CustomerSessionComponentsOptions
                {
                    BuyButton = new CustomerSessionComponentsBuyButtonOptions
                    {
                        Enabled = true,
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.CustomerSessions;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/customer_sessions");
        }

        [Fact]
        public void TestCustomersBalanceTransactionsGet()
        {
            var options = new CustomerBalanceTransactionListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.BalanceTransactions;
            StripeList<CustomerBalanceTransaction> customerBalanceTransactions = service
                .List("cus_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions",
                "limit=3");
        }

        [Fact]
        public void TestCustomersBalanceTransactionsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.BalanceTransactions;
            service.Get("cus_xxxxxxxxxxxxx", "cbtxn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions/cbtxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersBalanceTransactionsPost()
        {
            var options = new CustomerBalanceTransactionCreateOptions
            {
                Amount = -500,
                Currency = "usd",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.BalanceTransactions;
            service.Create("cus_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions");
        }

        [Fact]
        public void TestCustomersBalanceTransactionsPost2()
        {
            var options = new CustomerBalanceTransactionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.BalanceTransactions;
            service.Update("cus_xxxxxxxxxxxxx", "cbtxn_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx/balance_transactions/cbtxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersCashBalanceGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.CashBalance;
            service.Get("cus_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_123/cash_balance");
        }

        [Fact]
        public void TestCustomersCashBalancePost()
        {
            var options = new CustomerCashBalanceUpdateOptions
            {
                Settings = new CustomerCashBalanceSettingsOptions
                {
                    ReconciliationMode = "manual",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.CashBalance;
            service.Update("cus_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_123/cash_balance");
        }

        [Fact]
        public void TestCustomersCashBalanceTransactionsGet()
        {
            var options = new CustomerCashBalanceTransactionListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.CashBalanceTransactions;
            StripeList<CustomerCashBalanceTransaction> customerCashBalanceTransactions = service
                .List("cus_123", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_123/cash_balance_transactions",
                "limit=3");
        }

        [Fact]
        public void TestCustomersDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers;
            service.Delete("cus_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/customers/cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersFundingInstructionsPost()
        {
            var options = new CustomerFundingInstructionsCreateOptions
            {
                BankTransfer = new CustomerFundingInstructionsBankTransferOptions
                {
                    RequestedAddressTypes = new List<string> { "zengin" },
                    Type = "jp_bank_transfer",
                },
                Currency = "usd",
                FundingType = "bank_transfer",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.FundingInstructions;
            service.Create("cus_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_123/funding_instructions");
        }

        [Fact]
        public void TestCustomersGet()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers;
            StripeList<Customer> customers = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/customers", "limit=3");
        }

        [Fact]
        public void TestCustomersGet2()
        {
            var options = new CustomerListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers;
            StripeList<Customer> customers = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/customers", "limit=3");
        }

        [Fact]
        public void TestCustomersGet3()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers;
            service.Get("cus_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersPaymentMethodsGet()
        {
            var options = new CustomerPaymentMethodListOptions
            {
                Type = "card",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.PaymentMethods;
            StripeList<PaymentMethod> paymentMethods = service.List(
                "cus_xyz",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xyz/payment_methods",
                "type=card");
        }

        [Fact]
        public void TestCustomersPaymentMethodsGet2()
        {
            var options = new CustomerPaymentMethodListOptions
            {
                Type = "card",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.PaymentMethods;
            StripeList<PaymentMethod> paymentMethods = service.List(
                "cus_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/payment_methods",
                "type=card");
        }

        [Fact]
        public void TestCustomersPost()
        {
            var options = new CustomerCreateOptions
            {
                Description = "My First Test Customer (created for API docs at https://www.stripe.com/docs/api)",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/customers");
        }

        [Fact]
        public void TestCustomersPost2()
        {
            var options = new CustomerUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers;
            service.Update("cus_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersSearchGet()
        {
            var options = new CustomerSearchOptions
            {
                Query = "name:'fakename' AND metadata['foo']:'bar'",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers;
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/search",
                "query=name%3A%27fakename%27%20AND%20metadata%5B%27foo%27%5D%3A%27bar%27");
        }

        [Fact]
        public void TestCustomersSearchGet2()
        {
            var options = new CustomerSearchOptions
            {
                Query = "name:'fakename' AND metadata['foo']:'bar'",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers;
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/search",
                "query=name%3A%27fakename%27%20AND%20metadata%5B%27foo%27%5D%3A%27bar%27");
        }

        [Fact]
        public void TestCustomersTaxIdsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.TaxIds;
            service.Delete("cus_xxxxxxxxxxxxx", "txi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids/txi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersTaxIdsGet()
        {
            var options = new CustomerTaxIdListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.TaxIds;
            StripeList<TaxId> taxIds = service.List(
                "cus_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids",
                "limit=3");
        }

        [Fact]
        public void TestCustomersTaxIdsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.TaxIds;
            service.Get("cus_xxxxxxxxxxxxx", "txi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids/txi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestCustomersTaxIdsPost()
        {
            var options = new CustomerTaxIdCreateOptions
            {
                Type = "eu_vat",
                Value = "DE123456789",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Customers.TaxIds;
            service.Create("cus_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/customers/cus_xxxxxxxxxxxxx/tax_ids");
        }

        [Fact]
        public void TestDisputesClosePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Disputes;
            service.Close("dp_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/disputes/dp_xxxxxxxxxxxxx/close");
        }

        [Fact]
        public void TestDisputesGet()
        {
            var options = new DisputeListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Disputes;
            StripeList<Dispute> disputes = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/disputes", "limit=3");
        }

        [Fact]
        public void TestDisputesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Disputes;
            service.Get("dp_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/disputes/dp_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestDisputesPost()
        {
            var options = new DisputeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Disputes;
            service.Update("dp_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/disputes/dp_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestEventsGet()
        {
            var options = new EventListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Events;
            StripeList<Event> events = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/events", "limit=3");
        }

        [Fact]
        public void TestEventsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Events;
            service.Get("evt_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/events/evt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFileLinksGet()
        {
            var options = new FileLinkListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FileLinks;
            StripeList<FileLink> fileLinks = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/file_links", "limit=3");
        }

        [Fact]
        public void TestFileLinksGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FileLinks;
            service.Get("link_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/file_links/link_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFileLinksPost()
        {
            var options = new FileLinkCreateOptions
            {
                File = "file_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FileLinks;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/file_links");
        }

        [Fact]
        public void TestFileLinksPost2()
        {
            var options = new FileLinkUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FileLinks;
            service.Update("link_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/file_links/link_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFilesGet()
        {
            var options = new FileListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Files;
            StripeList<File> files = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/files", "limit=3");
        }

        [Fact]
        public void TestFilesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Files;
            service.Get("file_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/files/file_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFilesPost()
        {
            var options = new FileCreateOptions
            {
                Purpose = "account_requirement",
                File = new System.IO.MemoryStream(
                    System.Text.Encoding.UTF8.GetBytes("File contents")),
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Files;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/files");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsDisconnectPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Accounts;
            service.Disconnect("fca_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fca_xyz/disconnect");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsDisconnectPost2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Accounts;
            service.Disconnect("fca_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fca_xxxxxxxxxxxxx/disconnect");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Accounts;
            StripeList<Stripe.FinancialConnections.Account> accounts = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Accounts;
            service.Get("fca_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsGet3()
        {
            var options = new Stripe.FinancialConnections.AccountListOptions
            {
                AccountHolder = new Stripe.FinancialConnections.AccountAccountHolderOptions
                {
                    Customer = "cus_xxxxxxxxxxxxx",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Accounts;
            StripeList<Stripe.FinancialConnections.Account> accounts = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts",
                "account_holder[customer]=cus_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsGet4()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Accounts;
            service.Get("fca_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsOwnersGet()
        {
            var options = new Stripe.FinancialConnections.AccountOwnerListOptions
            {
                Ownership = "fcaowns_xyz",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Accounts.Owners;
            StripeList<Stripe.FinancialConnections.AccountOwner> accountOwners = service
                .List("fca_xyz", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xyz/owners",
                "ownership=fcaowns_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsOwnersGet2()
        {
            var options = new Stripe.FinancialConnections.AccountOwnerListOptions
            {
                Limit = 3,
                Ownership = "fcaowns_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Accounts.Owners;
            StripeList<Stripe.FinancialConnections.AccountOwner> accountOwners = service
                .List("fca_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/accounts/fca_xxxxxxxxxxxxx/owners",
                "limit=3&ownership=fcaowns_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsRefreshPost()
        {
            var options = new Stripe.FinancialConnections.AccountRefreshOptions
            {
                Features = new List<string> { "balance" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Accounts;
            service.Refresh("fca_xyz", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fca_xyz/refresh");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsSubscribePost()
        {
            var options = new Stripe.FinancialConnections.AccountSubscribeOptions
            {
                Features = new List<string> { "transactions" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Accounts;
            service.Subscribe("fa_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fa_123/subscribe");
        }

        [Fact]
        public void TestFinancialConnectionsAccountsUnsubscribePost()
        {
            var options = new Stripe.FinancialConnections.AccountUnsubscribeOptions
            {
                Features = new List<string> { "transactions" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Accounts;
            service.Unsubscribe("fa_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/accounts/fa_123/unsubscribe");
        }

        [Fact]
        public void TestFinancialConnectionsSessionsGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Sessions;
            service.Get("fcsess_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/sessions/fcsess_xyz");
        }

        [Fact]
        public void TestFinancialConnectionsSessionsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Sessions;
            service.Get("fcsess_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/sessions/fcsess_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestFinancialConnectionsSessionsPost()
        {
            var options = new Stripe.FinancialConnections.SessionCreateOptions
            {
                AccountHolder = new Stripe.FinancialConnections.SessionAccountHolderOptions
                {
                    Type = "customer",
                    Customer = "cus_123",
                },
                Permissions = new List<string> { "balances" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Sessions;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/sessions");
        }

        [Fact]
        public void TestFinancialConnectionsSessionsPost2()
        {
            var options = new Stripe.FinancialConnections.SessionCreateOptions
            {
                AccountHolder = new Stripe.FinancialConnections.SessionAccountHolderOptions
                {
                    Type = "customer",
                    Customer = "cus_xxxxxxxxxxxxx",
                },
                Permissions = new List<string> { "payment_method", "balances" },
                Filters = new Stripe.FinancialConnections.SessionFiltersOptions
                {
                    Countries = new List<string> { "US" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Sessions;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/financial_connections/sessions");
        }

        [Fact]
        public void TestFinancialConnectionsTransactionsGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Transactions;
            service.Get("tr_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/transactions/tr_123");
        }

        [Fact]
        public void TestFinancialConnectionsTransactionsGet2()
        {
            var options = new Stripe.FinancialConnections.TransactionListOptions
            {
                Account = "fca_xyz",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.FinancialConnections.Transactions;
            StripeList<Stripe.FinancialConnections.Transaction> transactions = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/financial_connections/transactions",
                "account=fca_xyz");
        }

        [Fact]
        public void TestIdentityVerificationReportsGet()
        {
            var options = new Stripe.Identity.VerificationReportListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Identity.VerificationReports;
            StripeList<Stripe.Identity.VerificationReport> verificationReports = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_reports",
                "limit=3");
        }

        [Fact]
        public void TestIdentityVerificationReportsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Identity.VerificationReports;
            service.Get("vr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_reports/vr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationSessionsCancelPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Identity.VerificationSessions;
            service.Cancel("vs_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestIdentityVerificationSessionsGet()
        {
            var options = new Stripe.Identity.VerificationSessionListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Identity.VerificationSessions;
            StripeList<Stripe.Identity.VerificationSession> verificationSessions = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_sessions",
                "limit=3");
        }

        [Fact]
        public void TestIdentityVerificationSessionsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Identity.VerificationSessions;
            service.Get("vs_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationSessionsPost()
        {
            var options = new Stripe.Identity.VerificationSessionCreateOptions
            {
                Type = "document",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Identity.VerificationSessions;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions");
        }

        [Fact]
        public void TestIdentityVerificationSessionsPost2()
        {
            var options = new Stripe.Identity.VerificationSessionUpdateOptions
            {
                Type = "id_number",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Identity.VerificationSessions;
            service.Update("vs_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIdentityVerificationSessionsRedactPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Identity.VerificationSessions;
            service.Redact("vs_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/identity/verification_sessions/vs_xxxxxxxxxxxxx/redact");
        }

        [Fact]
        public void TestInvoiceitemsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.InvoiceItems;
            service.Delete("ii_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/invoiceitems/ii_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoiceitemsGet()
        {
            var options = new InvoiceItemListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.InvoiceItems;
            StripeList<InvoiceItem> invoiceItems = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/invoiceitems", "limit=3");
        }

        [Fact]
        public void TestInvoiceitemsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.InvoiceItems;
            service.Get("ii_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoiceitems/ii_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoiceitemsPost()
        {
            var options = new InvoiceItemCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                Price = "price_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.InvoiceItems;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/invoiceitems");
        }

        [Fact]
        public void TestInvoiceitemsPost2()
        {
            var options = new InvoiceItemUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.InvoiceItems;
            service.Update("ii_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoiceitems/ii_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoicesDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            service.Delete("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/invoices/in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoicesFinalizePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            service.FinalizeInvoice("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/finalize");
        }

        [Fact]
        public void TestInvoicesGet()
        {
            var options = new InvoiceListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            StripeList<Invoice> invoices = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices", "limit=3");
        }

        [Fact]
        public void TestInvoicesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            service.Get("in_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/invoices/in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoicesGet3()
        {
            var options = new InvoiceGetOptions
            {
                Expand = new List<string> { "customer" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            service.Get("in_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoices/in_xxxxxxxxxxxxx",
                "expand[]=customer");
        }

        [Fact]
        public void TestInvoicesMarkUncollectiblePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            service.MarkUncollectible("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/mark_uncollectible");
        }

        [Fact]
        public void TestInvoicesPayPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            service.Pay("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/pay");
        }

        [Fact]
        public void TestInvoicesPost()
        {
            var options = new InvoiceCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices");
        }

        [Fact]
        public void TestInvoicesPost2()
        {
            var options = new InvoiceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            service.Update("in_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestInvoicesSearchGet()
        {
            var options = new InvoiceSearchOptions
            {
                Query = "total>999 AND metadata['order_id']:'6735'",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoices/search",
                "query=total%3E999%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestInvoicesSendPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            service.SendInvoice("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/send");
        }

        [Fact]
        public void TestInvoicesUpcomingGet()
        {
            var options = new UpcomingInvoiceOptions
            {
                Customer = "cus_9utnxg47pWjV1e",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            service.Upcoming(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/invoices/upcoming",
                "customer=cus_9utnxg47pWjV1e");
        }

        [Fact]
        public void TestInvoicesVoidPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Invoices;
            service.VoidInvoice("in_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/invoices/in_xxxxxxxxxxxxx/void");
        }

        [Fact]
        public void TestIssuingAuthorizationsApprovePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Authorizations;
            service.Approve("iauth_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx/approve");
        }

        [Fact]
        public void TestIssuingAuthorizationsDeclinePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Authorizations;
            service.Decline("iauth_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx/decline");
        }

        [Fact]
        public void TestIssuingAuthorizationsGet()
        {
            var options = new Stripe.Issuing.AuthorizationListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Authorizations;
            StripeList<Stripe.Issuing.Authorization> authorizations = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/authorizations",
                "limit=3");
        }

        [Fact]
        public void TestIssuingAuthorizationsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Authorizations;
            service.Get("iauth_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingAuthorizationsPost()
        {
            var options = new Stripe.Issuing.AuthorizationUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Authorizations;
            service.Update("iauth_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/authorizations/iauth_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingCardholdersGet()
        {
            var options = new Stripe.Issuing.CardholderListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Cardholders;
            StripeList<Stripe.Issuing.Cardholder> cardholders = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/cardholders",
                "limit=3");
        }

        [Fact]
        public void TestIssuingCardholdersGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Cardholders;
            service.Get("ich_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/cardholders/ich_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingCardholdersPost()
        {
            var options = new Stripe.Issuing.CardholderCreateOptions
            {
                Type = "individual",
                Name = "Jenny Rosen",
                Email = "jenny.rosen@example.com",
                PhoneNumber = "+18888675309",
                Billing = new Stripe.Issuing.CardholderBillingOptions
                {
                    Address = new AddressOptions
                    {
                        Line1 = "1234 Main Street",
                        City = "San Francisco",
                        State = "CA",
                        Country = "US",
                        PostalCode = "94111",
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Cardholders;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cardholders");
        }

        [Fact]
        public void TestIssuingCardholdersPost2()
        {
            var options = new Stripe.Issuing.CardholderUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Cardholders;
            service.Update("ich_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/cardholders/ich_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingCardsGet()
        {
            var options = new Stripe.Issuing.CardListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Cards;
            StripeList<Stripe.Issuing.Card> cards = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/cards", "limit=3");
        }

        [Fact]
        public void TestIssuingCardsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Cards;
            service.Get("ic_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/cards/ic_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingCardsPost()
        {
            var options = new Stripe.Issuing.CardCreateOptions
            {
                Cardholder = "ich_xxxxxxxxxxxxx",
                Currency = "usd",
                Type = "virtual",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Cards;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/cards");
        }

        [Fact]
        public void TestIssuingCardsPost2()
        {
            var options = new Stripe.Issuing.CardUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Cards;
            service.Update("ic_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/cards/ic_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingDisputesGet()
        {
            var options = new Stripe.Issuing.DisputeListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Disputes;
            StripeList<Stripe.Issuing.Dispute> disputes = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/disputes",
                "limit=3");
        }

        [Fact]
        public void TestIssuingDisputesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Disputes;
            service.Get("idp_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/disputes/idp_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingDisputesPost()
        {
            var options = new Stripe.Issuing.DisputeCreateOptions
            {
                Transaction = "ipi_xxxxxxxxxxxxx",
                Evidence = new Stripe.Issuing.DisputeEvidenceOptions
                {
                    Reason = "fraudulent",
                    Fraudulent = new Stripe.Issuing.DisputeEvidenceFraudulentOptions
                    {
                        Explanation = "Purchase was unrecognized.",
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Disputes;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/disputes");
        }

        [Fact]
        public void TestIssuingDisputesSubmitPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Disputes;
            service.Submit("idp_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/disputes/idp_xxxxxxxxxxxxx/submit");
        }

        [Fact]
        public void TestIssuingPersonalizationDesignsGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.PersonalizationDesigns;
            StripeList<Stripe.Issuing.PersonalizationDesign> personalizationDesigns = service
                .List();
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/personalization_designs");
        }

        [Fact]
        public void TestIssuingPersonalizationDesignsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.PersonalizationDesigns;
            service.Get("pd_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/personalization_designs/pd_xyz");
        }

        [Fact]
        public void TestIssuingPersonalizationDesignsPost()
        {
            var options = new Stripe.Issuing.PersonalizationDesignCreateOptions
            {
                PhysicalBundle = "pb_xyz",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.PersonalizationDesigns;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/personalization_designs");
        }

        [Fact]
        public void TestIssuingPersonalizationDesignsPost2()
        {
            var options = new Stripe.Issuing.PersonalizationDesignUpdateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.PersonalizationDesigns;
            service.Update("pd_xyz", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/personalization_designs/pd_xyz");
        }

        [Fact]
        public void TestIssuingPhysicalBundlesGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.PhysicalBundles;
            StripeList<Stripe.Issuing.PhysicalBundle> physicalBundles = service
                .List();
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/physical_bundles");
        }

        [Fact]
        public void TestIssuingPhysicalBundlesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.PhysicalBundles;
            service.Get("pb_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/physical_bundles/pb_xyz");
        }

        [Fact]
        public void TestIssuingTransactionsGet()
        {
            var options = new Stripe.Issuing.TransactionListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Transactions;
            StripeList<Stripe.Issuing.Transaction> transactions = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/transactions",
                "limit=3");
        }

        [Fact]
        public void TestIssuingTransactionsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Transactions;
            service.Get("ipi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/issuing/transactions/ipi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestIssuingTransactionsPost()
        {
            var options = new Stripe.Issuing.TransactionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Issuing.Transactions;
            service.Update("ipi_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/issuing/transactions/ipi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestMandatesGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Mandates;
            service.Get("mandate_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/mandates/mandate_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentsApplyCustomerBalancePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.ApplyCustomerBalance("pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/apply_customer_balance");
        }

        [Fact]
        public void TestPaymentIntentsCancelPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.Cancel("pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestPaymentIntentsCapturePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.Capture("pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/capture");
        }

        [Fact]
        public void TestPaymentIntentsConfirmPost()
        {
            var options = new PaymentIntentConfirmOptions
            {
                PaymentMethod = "pm_card_visa",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.Confirm("pi_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/confirm");
        }

        [Fact]
        public void TestPaymentIntentsGet()
        {
            var options = new PaymentIntentListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            StripeList<PaymentIntent> paymentIntents = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents",
                "limit=3");
        }

        [Fact]
        public void TestPaymentIntentsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.Get("pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentsIncrementAuthorizationPost()
        {
            var options = new PaymentIntentIncrementAuthorizationOptions
            {
                Amount = 2099,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.IncrementAuthorization("pi_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/increment_authorization");
        }

        [Fact]
        public void TestPaymentIntentsPost()
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = 1099,
                Currency = "eur",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_intents");
        }

        [Fact]
        public void TestPaymentIntentsPost2()
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_intents");
        }

        [Fact]
        public void TestPaymentIntentsPost3()
        {
            var options = new PaymentIntentUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.Update("pi_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentIntentsPost4()
        {
            var options = new PaymentIntentCreateOptions
            {
                Amount = 200,
                Currency = "usd",
                PaymentMethodData = new PaymentIntentPaymentMethodDataOptions
                {
                    Type = "p24",
                    P24 = new PaymentIntentPaymentMethodDataP24Options
                    {
                        Bank = "blik",
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_intents");
        }

        [Fact]
        public void TestPaymentIntentsSearchGet()
        {
            var options = new PaymentIntentSearchOptions
            {
                Query = "status:'succeeded' AND metadata['order_id']:'6735'",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_intents/search",
                "query=status%3A%27succeeded%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestPaymentIntentsVerifyMicrodepositsPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.VerifyMicrodeposits("pi_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public void TestPaymentIntentsVerifyMicrodepositsPost2()
        {
            var options = new PaymentIntentVerifyMicrodepositsOptions
            {
                Amounts = new List<long?> { 32, 45 },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentIntents;
            service.VerifyMicrodeposits("pi_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_intents/pi_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public void TestPaymentLinksGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentLinks;
            service.Get("pl_xyz");
            this.AssertRequest(HttpMethod.Get, "/v1/payment_links/pl_xyz");
        }

        [Fact]
        public void TestPaymentLinksGet2()
        {
            var options = new PaymentLinkListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentLinks;
            StripeList<PaymentLink> paymentLinks = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/payment_links", "limit=3");
        }

        [Fact]
        public void TestPaymentLinksGet3()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentLinks;
            service.Get("plink_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_links/plink_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentLinksLineItemsGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentLinks.LineItems;
            StripeList<LineItem> lineItems = service.List("pl_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_links/pl_xyz/line_items");
        }

        [Fact]
        public void TestPaymentLinksPost()
        {
            var options = new PaymentLinkCreateOptions
            {
                LineItems = new List<PaymentLinkLineItemOptions>
                {
                    new PaymentLinkLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentLinks;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_links");
        }

        [Fact]
        public void TestPaymentLinksPost2()
        {
            var options = new PaymentLinkCreateOptions
            {
                LineItems = new List<PaymentLinkLineItemOptions>
                {
                    new PaymentLinkLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 1,
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentLinks;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_links");
        }

        [Fact]
        public void TestPaymentLinksPost3()
        {
            var options = new PaymentLinkUpdateOptions { Active = false };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentLinks;
            service.Update("plink_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_links/plink_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentMethodConfigurationsGet()
        {
            var options = new PaymentMethodConfigurationListOptions
            {
                Application = "foo",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentMethodConfigurations;
            StripeList<PaymentMethodConfiguration> paymentMethodConfigurations = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_method_configurations",
                "application=foo");
        }

        [Fact]
        public void TestPaymentMethodConfigurationsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentMethodConfigurations;
            service.Get("foo");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_method_configurations/foo");
        }

        [Fact]
        public void TestPaymentMethodConfigurationsPost()
        {
            var options = new PaymentMethodConfigurationCreateOptions
            {
                AcssDebit = new PaymentMethodConfigurationAcssDebitOptions
                {
                    DisplayPreference = new PaymentMethodConfigurationAcssDebitDisplayPreferenceOptions
                    {
                        Preference = "none",
                    },
                },
                Affirm = new PaymentMethodConfigurationAffirmOptions
                {
                    DisplayPreference = new PaymentMethodConfigurationAffirmDisplayPreferenceOptions
                    {
                        Preference = "none",
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentMethodConfigurations;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_method_configurations");
        }

        [Fact]
        public void TestPaymentMethodConfigurationsPost2()
        {
            var options = new PaymentMethodConfigurationUpdateOptions
            {
                AcssDebit = new PaymentMethodConfigurationAcssDebitOptions
                {
                    DisplayPreference = new PaymentMethodConfigurationAcssDebitDisplayPreferenceOptions
                    {
                        Preference = "on",
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentMethodConfigurations;
            service.Update("foo", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_method_configurations/foo");
        }

        [Fact]
        public void TestPaymentMethodsAttachPost()
        {
            var options = new PaymentMethodAttachOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentMethods;
            service.Attach("pm_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx/attach");
        }

        [Fact]
        public void TestPaymentMethodsDetachPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentMethods;
            service.Detach("pm_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx/detach");
        }

        [Fact]
        public void TestPaymentMethodsGet()
        {
            var options = new PaymentMethodListOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                Type = "card",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentMethods;
            StripeList<PaymentMethod> paymentMethods = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_methods",
                "customer=cus_xxxxxxxxxxxxx&type=card");
        }

        [Fact]
        public void TestPaymentMethodsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentMethods;
            service.Get("pm_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPaymentMethodsPost()
        {
            var options = new PaymentMethodCreateOptions
            {
                Type = "card",
                Card = new PaymentMethodCardOptions
                {
                    Number = "4242424242424242",
                    ExpMonth = 8,
                    ExpYear = 2024,
                    Cvc = "314",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentMethods;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payment_methods");
        }

        [Fact]
        public void TestPaymentMethodsPost2()
        {
            var options = new PaymentMethodUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PaymentMethods;
            service.Update("pm_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payment_methods/pm_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPayoutsCancelPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Payouts;
            service.Cancel("po_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payouts/po_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestPayoutsGet()
        {
            var options = new PayoutListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Payouts;
            StripeList<Payout> payouts = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/payouts", "limit=3");
        }

        [Fact]
        public void TestPayoutsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Payouts;
            service.Get("po_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/payouts/po_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPayoutsPost()
        {
            var options = new PayoutCreateOptions
            {
                Amount = 1100,
                Currency = "usd",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Payouts;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts");
        }

        [Fact]
        public void TestPayoutsPost2()
        {
            var options = new PayoutUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Payouts;
            service.Update("po_xxxxxxxxxxxxx", options);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts/po_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPayoutsReversePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Payouts;
            service.Reverse("po_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/payouts/po_xxxxxxxxxxxxx/reverse");
        }

        [Fact]
        public void TestPlansDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Plans;
            service.Delete("price_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/plans/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPlansGet()
        {
            var options = new PlanListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Plans;
            StripeList<Plan> plans = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/plans", "limit=3");
        }

        [Fact]
        public void TestPlansGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Plans;
            service.Get("price_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/plans/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPlansPost()
        {
            var options = new PlanCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Interval = "month",
                Product = "prod_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Plans;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/plans");
        }

        [Fact]
        public void TestPlansPost2()
        {
            var options = new PlanCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Interval = "month",
                Product = new PlanProductOptions { Name = "My product" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Plans;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/plans");
        }

        [Fact]
        public void TestPlansPost3()
        {
            var options = new PlanUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Plans;
            service.Update("price_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/plans/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPricesGet()
        {
            var options = new PriceListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Prices;
            StripeList<Price> prices = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/prices", "limit=3");
        }

        [Fact]
        public void TestPricesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Prices;
            service.Get("price_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/prices/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPricesPost()
        {
            var options = new PriceCreateOptions
            {
                UnitAmount = 2000,
                Currency = "usd",
                CurrencyOptions = new Dictionary<string, PriceCurrencyOptionsOptions>
                {
                    {
                        "uah", new PriceCurrencyOptionsOptions
                        {
                            UnitAmount = 5000,
                        }
                    },
                    {
                        "eur", new PriceCurrencyOptionsOptions
                        {
                            UnitAmount = 1800,
                        }
                    },
                },
                Recurring = new PriceRecurringOptions { Interval = "month" },
                Product = "prod_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Prices;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/prices");
        }

        [Fact]
        public void TestPricesPost2()
        {
            var options = new PriceCreateOptions
            {
                UnitAmount = 2000,
                Currency = "usd",
                Recurring = new PriceRecurringOptions { Interval = "month" },
                Product = "prod_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Prices;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/prices");
        }

        [Fact]
        public void TestPricesPost3()
        {
            var options = new PriceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Prices;
            service.Update("price_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/prices/price_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPricesSearchGet()
        {
            var options = new PriceSearchOptions
            {
                Query = "active:'true' AND metadata['order_id']:'6735'",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Prices;
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/prices/search",
                "query=active%3A%27true%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestProductsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Products;
            service.Delete("prod_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/products/prod_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestProductsGet()
        {
            var options = new ProductListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Products;
            StripeList<Product> products = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/products", "limit=3");
        }

        [Fact]
        public void TestProductsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Products;
            service.Get("prod_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/products/prod_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestProductsPost()
        {
            var options = new ProductCreateOptions { Name = "Gold Special" };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Products;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/products");
        }

        [Fact]
        public void TestProductsPost2()
        {
            var options = new ProductUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Products;
            service.Update("prod_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/products/prod_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestProductsSearchGet()
        {
            var options = new ProductSearchOptions
            {
                Query = "active:'true' AND metadata['order_id']:'6735'",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Products;
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/products/search",
                "query=active%3A%27true%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestPromotionCodesGet()
        {
            var options = new PromotionCodeListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PromotionCodes;
            StripeList<PromotionCode> promotionCodes = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/promotion_codes",
                "limit=3");
        }

        [Fact]
        public void TestPromotionCodesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PromotionCodes;
            service.Get("promo_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/promotion_codes/promo_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestPromotionCodesPost()
        {
            var options = new PromotionCodeCreateOptions
            {
                Coupon = "Z4OV52SU",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PromotionCodes;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/promotion_codes");
        }

        [Fact]
        public void TestPromotionCodesPost2()
        {
            var options = new PromotionCodeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.PromotionCodes;
            service.Update("promo_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/promotion_codes/promo_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestQuotesAcceptPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Quotes;
            service.Accept("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/quotes/qt_xxxxxxxxxxxxx/accept");
        }

        [Fact]
        public void TestQuotesCancelPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Quotes;
            service.Cancel("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/quotes/qt_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestQuotesFinalizePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Quotes;
            service.FinalizeQuote("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/quotes/qt_xxxxxxxxxxxxx/finalize");
        }

        [Fact]
        public void TestQuotesGet()
        {
            var options = new QuoteListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Quotes;
            StripeList<Quote> quotes = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes", "limit=3");
        }

        [Fact]
        public void TestQuotesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Quotes;
            service.Get("qt_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/quotes/qt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestQuotesLineItemsGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Quotes.LineItems;
            StripeList<LineItem> lineItems = service.List("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/quotes/qt_xxxxxxxxxxxxx/line_items");
        }

        [Fact]
        public void TestQuotesPdfGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Quotes;
            service.Pdf("qt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/quotes/qt_xxxxxxxxxxxxx/pdf");
        }

        [Fact]
        public void TestQuotesPost()
        {
            var options = new QuoteCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                LineItems = new List<QuoteLineItemOptions>
                {
                    new QuoteLineItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                        Quantity = 2,
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Quotes;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes");
        }

        [Fact]
        public void TestQuotesPost2()
        {
            var options = new QuoteUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Quotes;
            service.Update("qt_xxxxxxxxxxxxx", options);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarEarlyFraudWarningsGet()
        {
            var options = new Stripe.Radar.EarlyFraudWarningListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Radar.EarlyFraudWarnings;
            StripeList<Stripe.Radar.EarlyFraudWarning> earlyFraudWarnings = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/early_fraud_warnings",
                "limit=3");
        }

        [Fact]
        public void TestRadarEarlyFraudWarningsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Radar.EarlyFraudWarnings;
            service.Get("issfr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/early_fraud_warnings/issfr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListItemsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Radar.ValueListItems;
            service.Delete("rsli_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/radar/value_list_items/rsli_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListItemsGet()
        {
            var options = new Stripe.Radar.ValueListItemListOptions
            {
                Limit = 3,
                ValueList = "rsl_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Radar.ValueListItems;
            StripeList<Stripe.Radar.ValueListItem> valueListItems = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_list_items",
                "limit=3&value_list=rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListItemsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Radar.ValueListItems;
            service.Get("rsli_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_list_items/rsli_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListItemsPost()
        {
            var options = new Stripe.Radar.ValueListItemCreateOptions
            {
                ValueList = "rsl_xxxxxxxxxxxxx",
                Value = "1.2.3.4",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Radar.ValueListItems;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_list_items");
        }

        [Fact]
        public void TestRadarValueListsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Radar.ValueLists;
            service.Delete("rsl_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/radar/value_lists/rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListsGet()
        {
            var options = new Stripe.Radar.ValueListListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Radar.ValueLists;
            StripeList<Stripe.Radar.ValueList> valueLists = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_lists",
                "limit=3");
        }

        [Fact]
        public void TestRadarValueListsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Radar.ValueLists;
            service.Get("rsl_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/radar/value_lists/rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRadarValueListsPost()
        {
            var options = new Stripe.Radar.ValueListCreateOptions
            {
                Alias = "custom_ip_xxxxxxxxxxxxx",
                Name = "Custom IP Blocklist",
                ItemType = "ip_address",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Radar.ValueLists;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/radar/value_lists");
        }

        [Fact]
        public void TestRadarValueListsPost2()
        {
            var options = new Stripe.Radar.ValueListUpdateOptions
            {
                Name = "Updated IP Block List",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Radar.ValueLists;
            service.Update("rsl_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/radar/value_lists/rsl_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRefundsCancelPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Refunds;
            service.Cancel("re_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/refunds/re_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestRefundsGet()
        {
            var options = new RefundListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Refunds;
            StripeList<Refund> refunds = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/refunds", "limit=3");
        }

        [Fact]
        public void TestRefundsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Refunds;
            service.Get("re_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/refunds/re_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestRefundsPost()
        {
            var options = new RefundCreateOptions
            {
                Charge = "ch_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Refunds;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/refunds");
        }

        [Fact]
        public void TestRefundsPost2()
        {
            var options = new RefundUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Refunds;
            service.Update("re_xxxxxxxxxxxxx", options);
            this.AssertRequest(HttpMethod.Post, "/v1/refunds/re_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestReportingReportRunsGet()
        {
            var options = new Stripe.Reporting.ReportRunListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Reporting.ReportRuns;
            StripeList<Stripe.Reporting.ReportRun> reportRuns = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/reporting/report_runs",
                "limit=3");
        }

        [Fact]
        public void TestReportingReportRunsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Reporting.ReportRuns;
            service.Get("frr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/reporting/report_runs/frr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestReportingReportRunsPost()
        {
            var options = new Stripe.Reporting.ReportRunCreateOptions
            {
                ReportType = "balance.summary.1",
                Parameters = new Stripe.Reporting.ReportRunParametersOptions
                {
                    IntervalStart = DateTimeOffset.FromUnixTimeSeconds(
                        1522540800)
                        .UtcDateTime,
                    IntervalEnd = DateTimeOffset.FromUnixTimeSeconds(1525132800)
                        .UtcDateTime,
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Reporting.ReportRuns;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/reporting/report_runs");
        }

        [Fact]
        public void TestReportingReportTypesGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Reporting.ReportTypes;
            StripeList<Stripe.Reporting.ReportType> reportTypes = service
                .List();
            this.AssertRequest(HttpMethod.Get, "/v1/reporting/report_types");
        }

        [Fact]
        public void TestReportingReportTypesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Reporting.ReportTypes;
            service.Get("balance.summary.1");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/reporting/report_types/balance.summary.1");
        }

        [Fact]
        public void TestReviewsApprovePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Reviews;
            service.Approve("prv_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/reviews/prv_xxxxxxxxxxxxx/approve");
        }

        [Fact]
        public void TestReviewsGet()
        {
            var options = new ReviewListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Reviews;
            StripeList<Review> reviews = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/reviews", "limit=3");
        }

        [Fact]
        public void TestReviewsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Reviews;
            service.Get("prv_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/reviews/prv_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSetupAttemptsGet()
        {
            var options = new SetupAttemptListOptions
            {
                Limit = 3,
                SetupIntent = "si_xyz",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SetupAttempts;
            StripeList<SetupAttempt> setupAttempts = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/setup_attempts",
                "limit=3&setup_intent=si_xyz");
        }

        [Fact]
        public void TestSetupIntentsCancelPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SetupIntents;
            service.Cancel("seti_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestSetupIntentsConfirmPost()
        {
            var options = new SetupIntentConfirmOptions
            {
                PaymentMethod = "pm_card_visa",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SetupIntents;
            service.Confirm("seti_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx/confirm");
        }

        [Fact]
        public void TestSetupIntentsGet()
        {
            var options = new SetupIntentListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SetupIntents;
            StripeList<SetupIntent> setupIntents = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/setup_intents", "limit=3");
        }

        [Fact]
        public void TestSetupIntentsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SetupIntents;
            service.Get("seti_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSetupIntentsPost()
        {
            var options = new SetupIntentCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SetupIntents;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/setup_intents");
        }

        [Fact]
        public void TestSetupIntentsPost2()
        {
            var options = new SetupIntentUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "user_id", "3435453" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SetupIntents;
            service.Update("seti_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSetupIntentsVerifyMicrodepositsPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SetupIntents;
            service.VerifyMicrodeposits("seti_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public void TestSetupIntentsVerifyMicrodepositsPost2()
        {
            var options = new SetupIntentVerifyMicrodepositsOptions
            {
                Amounts = new List<long?> { 32, 45 },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SetupIntents;
            service.VerifyMicrodeposits("seti_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/setup_intents/seti_xxxxxxxxxxxxx/verify_microdeposits");
        }

        [Fact]
        public void TestShippingRatesGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.ShippingRates;
            StripeList<ShippingRate> shippingRates = service.List();
            this.AssertRequest(HttpMethod.Get, "/v1/shipping_rates");
        }

        [Fact]
        public void TestShippingRatesGet2()
        {
            var options = new ShippingRateListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.ShippingRates;
            StripeList<ShippingRate> shippingRates = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/shipping_rates", "limit=3");
        }

        [Fact]
        public void TestShippingRatesGet3()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.ShippingRates;
            service.Get("shr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/shipping_rates/shr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestShippingRatesPost()
        {
            var options = new ShippingRateCreateOptions
            {
                DisplayName = "Sample Shipper",
                FixedAmount = new ShippingRateFixedAmountOptions
                {
                    Currency = "usd",
                    Amount = 400,
                },
                Type = "fixed_amount",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.ShippingRates;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/shipping_rates");
        }

        [Fact]
        public void TestShippingRatesPost2()
        {
            var options = new ShippingRateCreateOptions
            {
                DisplayName = "Ground shipping",
                Type = "fixed_amount",
                FixedAmount = new ShippingRateFixedAmountOptions
                {
                    Amount = 500,
                    Currency = "usd",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.ShippingRates;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/shipping_rates");
        }

        [Fact]
        public void TestShippingRatesPost3()
        {
            var options = new ShippingRateUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.ShippingRates;
            service.Update("shr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/shipping_rates/shr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSigmaScheduledQueryRunsGet()
        {
            var options = new Stripe.Sigma.ScheduledQueryRunListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Sigma.ScheduledQueryRuns;
            StripeList<Stripe.Sigma.ScheduledQueryRun> scheduledQueryRuns = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/sigma/scheduled_query_runs",
                "limit=3");
        }

        [Fact]
        public void TestSigmaScheduledQueryRunsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Sigma.ScheduledQueryRuns;
            service.Get("sqr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/sigma/scheduled_query_runs/sqr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSourcesGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Sources;
            service.Get("src_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSourcesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Sources;
            service.Get("src_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/sources/src_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSourcesPost()
        {
            var options = new SourceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Sources;
            service.Update("src_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/sources/src_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionItems;
            service.Delete("si_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/subscription_items/si_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemsGet()
        {
            var options = new SubscriptionItemListOptions
            {
                Subscription = "sub_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionItems;
            StripeList<SubscriptionItem> subscriptionItems = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_items",
                "subscription=sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionItems;
            service.Get("si_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_items/si_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemsPost()
        {
            var options = new SubscriptionItemCreateOptions
            {
                Subscription = "sub_xxxxxxxxxxxxx",
                Price = "price_xxxxxxxxxxxxx",
                Quantity = 2,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionItems;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_items");
        }

        [Fact]
        public void TestSubscriptionItemsPost2()
        {
            var options = new SubscriptionItemUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionItems;
            service.Update("si_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_items/si_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionItemsUsageRecordSummariesGet()
        {
            var options = new SubscriptionItemUsageRecordSummaryListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionItems.UsageRecordSummaries;
            StripeList<UsageRecordSummary> usageRecordSummaries = service.List(
                "si_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_items/si_xxxxxxxxxxxxx/usage_record_summaries",
                "limit=3");
        }

        [Fact]
        public void TestSubscriptionItemsUsageRecordsPost()
        {
            var options = new SubscriptionItemUsageRecordCreateOptions
            {
                Quantity = 100,
                Timestamp = DateTimeOffset.FromUnixTimeSeconds(1571252444)
                    .UtcDateTime,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionItems.UsageRecords;
            service.Create("si_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_items/si_xxxxxxxxxxxxx/usage_records");
        }

        [Fact]
        public void TestSubscriptionSchedulesCancelPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionSchedules;
            service.Cancel("sub_sched_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestSubscriptionSchedulesGet()
        {
            var options = new SubscriptionScheduleListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionSchedules;
            StripeList<SubscriptionSchedule> subscriptionSchedules = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_schedules",
                "limit=3");
        }

        [Fact]
        public void TestSubscriptionSchedulesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionSchedules;
            service.Get("sub_sched_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionSchedulesPost()
        {
            var options = new SubscriptionScheduleCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                StartDate = DateTimeOffset.FromUnixTimeSeconds(1676070661)
                    .UtcDateTime,
                EndBehavior = "release",
                Phases = new List<SubscriptionSchedulePhaseOptions>
                {
                    new SubscriptionSchedulePhaseOptions
                    {
                        Items = new List<SubscriptionSchedulePhaseItemOptions>
                        {
                            new SubscriptionSchedulePhaseItemOptions
                            {
                                Price = "price_xxxxxxxxxxxxx",
                                Quantity = 1,
                            },
                        },
                        Iterations = 12,
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionSchedules;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_schedules");
        }

        [Fact]
        public void TestSubscriptionSchedulesPost2()
        {
            var options = new SubscriptionScheduleUpdateOptions
            {
                EndBehavior = "release",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionSchedules;
            service.Update("sub_sched_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionSchedulesReleasePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.SubscriptionSchedules;
            service.Release("sub_sched_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscription_schedules/sub_sched_xxxxxxxxxxxxx/release");
        }

        [Fact]
        public void TestSubscriptionsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Subscriptions;
            service.Cancel("sub_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/subscriptions/sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionsDiscountDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Subscriptions;
            service.DeleteDiscount("sub_xyz");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/subscriptions/sub_xyz/discount");
        }

        [Fact]
        public void TestSubscriptionsGet()
        {
            var options = new SubscriptionListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Subscriptions;
            StripeList<Subscription> subscriptions = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/subscriptions", "limit=3");
        }

        [Fact]
        public void TestSubscriptionsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Subscriptions;
            service.Get("sub_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscriptions/sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionsPost()
        {
            var options = new SubscriptionCreateOptions
            {
                Customer = "cus_xxxxxxxxxxxxx",
                Items = new List<SubscriptionItemOptions>
                {
                    new SubscriptionItemOptions
                    {
                        Price = "price_xxxxxxxxxxxxx",
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Subscriptions;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/subscriptions");
        }

        [Fact]
        public void TestSubscriptionsPost2()
        {
            var options = new SubscriptionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Subscriptions;
            service.Update("sub_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/subscriptions/sub_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestSubscriptionsSearchGet()
        {
            var options = new SubscriptionSearchOptions
            {
                Query = "status:'active' AND metadata['order_id']:'6735'",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Subscriptions;
            service.Search(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/subscriptions/search",
                "query=status%3A%27active%27%20AND%20metadata%5B%27order_id%27%5D%3A%276735%27");
        }

        [Fact]
        public void TestTaxCalculationsLineItemsGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tax.Calculations.LineItems;
            StripeList<Stripe.Tax.CalculationLineItem> calculationLineItems = service
                .List("xxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax/calculations/xxx/line_items");
        }

        [Fact]
        public void TestTaxCalculationsPost()
        {
            var options = new Stripe.Tax.CalculationCreateOptions
            {
                Currency = "usd",
                LineItems = new List<Stripe.Tax.CalculationLineItemOptions>
                {
                    new Stripe.Tax.CalculationLineItemOptions
                    {
                        Amount = 1000,
                        Reference = "L1",
                    },
                },
                CustomerDetails = new Stripe.Tax.CalculationCustomerDetailsOptions
                {
                    Address = new AddressOptions
                    {
                        Line1 = "354 Oyster Point Blvd",
                        City = "South San Francisco",
                        State = "CA",
                        PostalCode = "94080",
                        Country = "US",
                    },
                    AddressSource = "shipping",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tax.Calculations;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax/calculations");
        }

        [Fact]
        public void TestTaxCodesGet()
        {
            var options = new TaxCodeListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TaxCodes;
            StripeList<TaxCode> taxCodes = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/tax_codes", "limit=3");
        }

        [Fact]
        public void TestTaxCodesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TaxCodes;
            service.Get("txcd_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax_codes/txcd_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxIdsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TaxIds;
            service.Delete("taxid_123");
            this.AssertRequest(HttpMethod.Delete, "/v1/tax_ids/taxid_123");
        }

        [Fact]
        public void TestTaxIdsGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TaxIds;
            StripeList<TaxId> taxIds = service.List();
            this.AssertRequest(HttpMethod.Get, "/v1/tax_ids");
        }

        [Fact]
        public void TestTaxIdsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TaxIds;
            service.Get("taxid_123");
            this.AssertRequest(HttpMethod.Get, "/v1/tax_ids/taxid_123");
        }

        [Fact]
        public void TestTaxIdsPost()
        {
            var options = new TaxIdCreateOptions
            {
                Type = "eu_vat",
                Value = "123",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TaxIds;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax_ids");
        }

        [Fact]
        public void TestTaxRatesGet()
        {
            var options = new TaxRateListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TaxRates;
            StripeList<TaxRate> taxRates = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/tax_rates", "limit=3");
        }

        [Fact]
        public void TestTaxRatesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TaxRates;
            service.Get("txr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax_rates/txr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxRatesPost()
        {
            var options = new TaxRateCreateOptions
            {
                DisplayName = "VAT",
                Description = "VAT Germany",
                Jurisdiction = "DE",
                Percentage = 16M,
                Inclusive = false,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TaxRates;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax_rates");
        }

        [Fact]
        public void TestTaxRatesPost2()
        {
            var options = new TaxRateUpdateOptions { Active = false };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TaxRates;
            service.Update("txr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/tax_rates/txr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxRegistrationsGet()
        {
            var options = new Stripe.Tax.RegistrationListOptions
            {
                Status = "all",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tax.Registrations;
            StripeList<Stripe.Tax.Registration> registrations = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/tax/registrations",
                "status=all");
        }

        [Fact]
        public void TestTaxRegistrationsPost()
        {
            var options = new Stripe.Tax.RegistrationCreateOptions
            {
                Country = "IE",
                CountryOptions = new Stripe.Tax.RegistrationCountryOptionsOptions
                {
                    Ie = new Stripe.Tax.RegistrationCountryOptionsIeOptions
                    {
                        Type = "oss_union",
                    },
                },
                ActiveFrom = Stripe.Tax.RegistrationActiveFrom.Now,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tax.Registrations;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax/registrations");
        }

        [Fact]
        public void TestTaxRegistrationsPost2()
        {
            var options = new Stripe.Tax.RegistrationUpdateOptions
            {
                ExpiresAt = Stripe.Tax.RegistrationExpiresAt.Now,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tax.Registrations;
            service.Update("taxreg_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/tax/registrations/taxreg_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTaxSettingsGet()
        {
            var options = new Stripe.Tax.SettingsGetOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tax.Settings;
            service.Get(options);
            this.AssertRequest(HttpMethod.Get, "/v1/tax/settings");
        }

        [Fact]
        public void TestTaxSettingsPost()
        {
            var options = new Stripe.Tax.SettingsUpdateOptions
            {
                Defaults = new Stripe.Tax.SettingsDefaultsOptions
                {
                    TaxCode = "txcd_10000000",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tax.Settings;
            service.Update(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tax/settings");
        }

        [Fact]
        public void TestTaxTransactionsCreateFromCalculationPost()
        {
            var options = new Stripe.Tax.TransactionCreateFromCalculationOptions
            {
                Calculation = "xxx",
                Reference = "yyy",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tax.Transactions;
            service.CreateFromCalculation(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/tax/transactions/create_from_calculation");
        }

        [Fact]
        public void TestTerminalConfigurationsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Configurations;
            service.Delete("uc_123");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/configurations/uc_123");
        }

        [Fact]
        public void TestTerminalConfigurationsDelete2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Configurations;
            service.Delete("tmc_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/configurations/tmc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalConfigurationsGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Configurations;
            StripeList<Stripe.Terminal.Configuration> configurations = service
                .List();
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/configurations");
        }

        [Fact]
        public void TestTerminalConfigurationsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Configurations;
            service.Get("uc_123");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/configurations/uc_123");
        }

        [Fact]
        public void TestTerminalConfigurationsGet3()
        {
            var options = new Stripe.Terminal.ConfigurationListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Configurations;
            StripeList<Stripe.Terminal.Configuration> configurations = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/configurations",
                "limit=3");
        }

        [Fact]
        public void TestTerminalConfigurationsGet4()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Configurations;
            service.Get("tmc_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/configurations/tmc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalConfigurationsPost()
        {
            var options = new Stripe.Terminal.ConfigurationCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Configurations;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/configurations");
        }

        [Fact]
        public void TestTerminalConfigurationsPost2()
        {
            var options = new Stripe.Terminal.ConfigurationUpdateOptions
            {
                Tipping = new Stripe.Terminal.ConfigurationTippingOptions
                {
                    Usd = new Stripe.Terminal.ConfigurationTippingUsdOptions
                    {
                        FixedAmounts = new List<long?> { 10 },
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Configurations;
            service.Update("uc_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/configurations/uc_123");
        }

        [Fact]
        public void TestTerminalConfigurationsPost3()
        {
            var options = new Stripe.Terminal.ConfigurationCreateOptions
            {
                BbposWiseposE = new Stripe.Terminal.ConfigurationBbposWiseposEOptions
                {
                    Splashscreen = "file_xxxxxxxxxxxxx",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Configurations;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/configurations");
        }

        [Fact]
        public void TestTerminalConfigurationsPost4()
        {
            var options = new Stripe.Terminal.ConfigurationUpdateOptions
            {
                BbposWiseposE = new Stripe.Terminal.ConfigurationBbposWiseposEOptions
                {
                    Splashscreen = "file_xxxxxxxxxxxxx",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Configurations;
            service.Update("tmc_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/configurations/tmc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalConnectionTokensPost()
        {
            var options = new Stripe.Terminal.ConnectionTokenCreateOptions();
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.ConnectionTokens;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/connection_tokens");
        }

        [Fact]
        public void TestTerminalLocationsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Locations;
            service.Delete("tml_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/locations/tml_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalLocationsGet()
        {
            var options = new Stripe.Terminal.LocationListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Locations;
            StripeList<Stripe.Terminal.Location> locations = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/locations",
                "limit=3");
        }

        [Fact]
        public void TestTerminalLocationsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Locations;
            service.Get("tml_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/locations/tml_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalLocationsPost()
        {
            var options = new Stripe.Terminal.LocationCreateOptions
            {
                DisplayName = "My First Store",
                Address = new AddressOptions
                {
                    Line1 = "1234 Main Street",
                    City = "San Francisco",
                    PostalCode = "94111",
                    State = "CA",
                    Country = "US",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Locations;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/locations");
        }

        [Fact]
        public void TestTerminalLocationsPost2()
        {
            var options = new Stripe.Terminal.LocationUpdateOptions
            {
                DisplayName = "My First Store",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Locations;
            service.Update("tml_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/locations/tml_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalReadersCancelActionPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Readers;
            service.CancelAction("tmr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx/cancel_action");
        }

        [Fact]
        public void TestTerminalReadersDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Readers;
            service.Delete("tmr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalReadersGet()
        {
            var options = new Stripe.Terminal.ReaderListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Readers;
            StripeList<Stripe.Terminal.Reader> readers = service.List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/readers",
                "limit=3");
        }

        [Fact]
        public void TestTerminalReadersGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Readers;
            service.Get("tmr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalReadersPost()
        {
            var options = new Stripe.Terminal.ReaderCreateOptions
            {
                RegistrationCode = "puppies-plug-could",
                Label = "Blue Rabbit",
                Location = "tml_1234",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Readers;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/readers");
        }

        [Fact]
        public void TestTerminalReadersPost2()
        {
            var options = new Stripe.Terminal.ReaderUpdateOptions
            {
                Label = "Blue Rabbit",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Readers;
            service.Update("tmr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTerminalReadersProcessPaymentIntentPost()
        {
            var options = new Stripe.Terminal.ReaderProcessPaymentIntentOptions
            {
                PaymentIntent = "pi_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Readers;
            service.ProcessPaymentIntent("tmr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx/process_payment_intent");
        }

        [Fact]
        public void TestTerminalReadersProcessSetupIntentPost()
        {
            var options = new Stripe.Terminal.ReaderProcessSetupIntentOptions
            {
                SetupIntent = "seti_xxxxxxxxxxxxx",
                CustomerConsentCollected = true,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Terminal.Readers;
            service.ProcessSetupIntent("tmr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/terminal/readers/tmr_xxxxxxxxxxxxx/process_setup_intent");
        }

        [Fact]
        public void TestTestHelpersCustomersFundCashBalancePost()
        {
            var options = new Stripe.TestHelpers.CustomerFundCashBalanceOptions
            {
                Amount = 30,
                Currency = "eur",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Customers;
            service.FundCashBalance("cus_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/customers/cus_123/fund_cash_balance");
        }

        [Fact]
        public void TestTestHelpersIssuingAuthorizationsCapturePost()
        {
            var options = new Stripe.TestHelpers.Issuing.AuthorizationCaptureOptions
            {
                CaptureAmount = 100,
                CloseAuthorization = true,
                PurchaseDetails = new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsOptions
                {
                    Flight = new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsFlightOptions
                    {
                        DepartureAt = DateTimeOffset.FromUnixTimeSeconds(
                            1633651200)
                            .UtcDateTime,
                        PassengerName = "John Doe",
                        Refundable = true,
                        Segments = new List<Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsFlightSegmentOptions>
                        {
                            new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsFlightSegmentOptions
                            {
                                ArrivalAirportCode = "SFO",
                                Carrier = "Delta",
                                DepartureAirportCode = "LAX",
                                FlightNumber = "DL100",
                                ServiceClass = "Economy",
                                StopoverAllowed = true,
                            },
                        },
                        TravelAgency = "Orbitz",
                    },
                    Fuel = new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsFuelOptions
                    {
                        Type = "diesel",
                        Unit = "liter",
                        UnitCostDecimal = 3.5M,
                        QuantityDecimal = 10M,
                    },
                    Lodging = new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsLodgingOptions
                    {
                        CheckInAt = DateTimeOffset.FromUnixTimeSeconds(
                            1633651200)
                            .UtcDateTime,
                        Nights = 2,
                    },
                    Receipt = new List<Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsReceiptOptions>
                    {
                        new Stripe.TestHelpers.Issuing.AuthorizationPurchaseDetailsReceiptOptions
                        {
                            Description = "Room charge",
                            Quantity = 1M,
                            Total = 200,
                            UnitCost = 200,
                        },
                    },
                    Reference = "foo",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.Authorizations;
            service.Capture("example_authorization", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/capture");
        }

        [Fact]
        public void TestTestHelpersIssuingAuthorizationsExpirePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.Authorizations;
            service.Expire("example_authorization");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/expire");
        }

        [Fact]
        public void TestTestHelpersIssuingAuthorizationsIncrementPost()
        {
            var options = new Stripe.TestHelpers.Issuing.AuthorizationIncrementOptions
            {
                IncrementAmount = 50,
                IsAmountControllable = true,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.Authorizations;
            service.Increment("example_authorization", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/increment");
        }

        [Fact]
        public void TestTestHelpersIssuingAuthorizationsPost()
        {
            var options = new Stripe.TestHelpers.Issuing.AuthorizationCreateOptions
            {
                Amount = 100,
                AmountDetails = new Stripe.TestHelpers.Issuing.AuthorizationAmountDetailsOptions
                {
                    AtmFee = 10,
                    CashbackAmount = 5,
                },
                AuthorizationMethod = "chip",
                Card = "foo",
                Currency = "usd",
                IsAmountControllable = true,
                MerchantData = new Stripe.TestHelpers.Issuing.AuthorizationMerchantDataOptions
                {
                    Category = "ac_refrigeration_repair",
                    City = "foo",
                    Country = "bar",
                    Name = "foo",
                    NetworkId = "bar",
                    PostalCode = "foo",
                    State = "bar",
                    TerminalId = "foo",
                },
                NetworkData = new Stripe.TestHelpers.Issuing.AuthorizationNetworkDataOptions
                {
                    AcquiringInstitutionId = "foo",
                },
                VerificationData = new Stripe.TestHelpers.Issuing.AuthorizationVerificationDataOptions
                {
                    AddressLine1Check = "mismatch",
                    AddressPostalCodeCheck = "match",
                    CvcCheck = "match",
                    ExpiryCheck = "mismatch",
                },
                Wallet = "apple_pay",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.Authorizations;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations");
        }

        [Fact]
        public void TestTestHelpersIssuingAuthorizationsReversePost()
        {
            var options = new Stripe.TestHelpers.Issuing.AuthorizationReverseOptions
            {
                ReverseAmount = 20,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.Authorizations;
            service.Reverse("example_authorization", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/authorizations/example_authorization/reverse");
        }

        [Fact]
        public void TestTestHelpersIssuingCardsShippingDeliverPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.Cards;
            service.DeliverCard("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/deliver");
        }

        [Fact]
        public void TestTestHelpersIssuingCardsShippingFailPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.Cards;
            service.FailCard("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/fail");
        }

        [Fact]
        public void TestTestHelpersIssuingCardsShippingReturnPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.Cards;
            service.ReturnCard("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/return");
        }

        [Fact]
        public void TestTestHelpersIssuingCardsShippingShipPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.Cards;
            service.ShipCard("card_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/cards/card_123/shipping/ship");
        }

        [Fact]
        public void TestTestHelpersIssuingPersonalizationDesignsActivatePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.PersonalizationDesigns;
            service.Activate("pd_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/personalization_designs/pd_xyz/activate");
        }

        [Fact]
        public void TestTestHelpersIssuingPersonalizationDesignsDeactivatePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.PersonalizationDesigns;
            service.Deactivate("pd_xyz");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/personalization_designs/pd_xyz/deactivate");
        }

        [Fact]
        public void TestTestHelpersIssuingPersonalizationDesignsRejectPost()
        {
            var options = new Stripe.TestHelpers.Issuing.PersonalizationDesignRejectOptions
            {
                RejectionReasons = new Stripe.TestHelpers.Issuing.PersonalizationDesignRejectionReasonsOptions
                {
                    CardLogo = new List<string> { "geographic_location" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.PersonalizationDesigns;
            service.Reject("pd_xyz", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/personalization_designs/pd_xyz/reject");
        }

        [Fact]
        public void TestTestHelpersIssuingTransactionsCreateForceCapturePost()
        {
            var options = new Stripe.TestHelpers.Issuing.TransactionCreateForceCaptureOptions
            {
                Amount = 100,
                Card = "foo",
                Currency = "usd",
                MerchantData = new Stripe.TestHelpers.Issuing.TransactionMerchantDataOptions
                {
                    Category = "ac_refrigeration_repair",
                    City = "foo",
                    Country = "US",
                    Name = "foo",
                    NetworkId = "bar",
                    PostalCode = "10001",
                    State = "NY",
                    TerminalId = "foo",
                },
                PurchaseDetails = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsOptions
                {
                    Flight = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightOptions
                    {
                        DepartureAt = DateTimeOffset.FromUnixTimeSeconds(
                            1633651200)
                            .UtcDateTime,
                        PassengerName = "John Doe",
                        Refundable = true,
                        Segments = new List<Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightSegmentOptions>
                        {
                            new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightSegmentOptions
                            {
                                ArrivalAirportCode = "SFO",
                                Carrier = "Delta",
                                DepartureAirportCode = "LAX",
                                FlightNumber = "DL100",
                                ServiceClass = "Economy",
                                StopoverAllowed = true,
                            },
                        },
                        TravelAgency = "Orbitz",
                    },
                    Fuel = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFuelOptions
                    {
                        Type = "diesel",
                        Unit = "liter",
                        UnitCostDecimal = 3.5M,
                        QuantityDecimal = 10M,
                    },
                    Lodging = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsLodgingOptions
                    {
                        CheckInAt = DateTimeOffset.FromUnixTimeSeconds(
                            1533651200)
                            .UtcDateTime,
                        Nights = 2,
                    },
                    Receipt = new List<Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsReceiptOptions>
                    {
                        new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsReceiptOptions
                        {
                            Description = "Room charge",
                            Quantity = 1M,
                            Total = 200,
                            UnitCost = 200,
                        },
                    },
                    Reference = "foo",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.Transactions;
            service.CreateForceCapture(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/transactions/create_force_capture");
        }

        [Fact]
        public void TestTestHelpersIssuingTransactionsCreateUnlinkedRefundPost()
        {
            var options = new Stripe.TestHelpers.Issuing.TransactionCreateUnlinkedRefundOptions
            {
                Amount = 100,
                Card = "foo",
                Currency = "usd",
                MerchantData = new Stripe.TestHelpers.Issuing.TransactionMerchantDataOptions
                {
                    Category = "ac_refrigeration_repair",
                    City = "foo",
                    Country = "bar",
                    Name = "foo",
                    NetworkId = "bar",
                    PostalCode = "foo",
                    State = "bar",
                    TerminalId = "foo",
                },
                PurchaseDetails = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsOptions
                {
                    Flight = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightOptions
                    {
                        DepartureAt = DateTimeOffset.FromUnixTimeSeconds(
                            1533651200)
                            .UtcDateTime,
                        PassengerName = "John Doe",
                        Refundable = true,
                        Segments = new List<Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightSegmentOptions>
                        {
                            new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFlightSegmentOptions
                            {
                                ArrivalAirportCode = "SFO",
                                Carrier = "Delta",
                                DepartureAirportCode = "LAX",
                                FlightNumber = "DL100",
                                ServiceClass = "Economy",
                                StopoverAllowed = true,
                            },
                        },
                        TravelAgency = "Orbitz",
                    },
                    Fuel = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsFuelOptions
                    {
                        Type = "diesel",
                        Unit = "liter",
                        UnitCostDecimal = 3.5M,
                        QuantityDecimal = 10M,
                    },
                    Lodging = new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsLodgingOptions
                    {
                        CheckInAt = DateTimeOffset.FromUnixTimeSeconds(
                            1533651200)
                            .UtcDateTime,
                        Nights = 2,
                    },
                    Receipt = new List<Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsReceiptOptions>
                    {
                        new Stripe.TestHelpers.Issuing.TransactionPurchaseDetailsReceiptOptions
                        {
                            Description = "Room charge",
                            Quantity = 1M,
                            Total = 200,
                            UnitCost = 200,
                        },
                    },
                    Reference = "foo",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.Transactions;
            service.CreateUnlinkedRefund(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/transactions/create_unlinked_refund");
        }

        [Fact]
        public void TestTestHelpersIssuingTransactionsRefundPost()
        {
            var options = new Stripe.TestHelpers.Issuing.TransactionRefundOptions
            {
                RefundAmount = 50,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Issuing.Transactions;
            service.Refund("example_transaction", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/issuing/transactions/example_transaction/refund");
        }

        [Fact]
        public void TestTestHelpersRefundsExpirePost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Refunds;
            service.Expire("re_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/refunds/re_123/expire");
        }

        [Fact]
        public void TestTestHelpersTestClocksAdvancePost()
        {
            var options = new Stripe.TestHelpers.TestClockAdvanceOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(142)
                    .UtcDateTime,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.TestClocks;
            service.Advance("clock_xyz", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/test_clocks/clock_xyz/advance");
        }

        [Fact]
        public void TestTestHelpersTestClocksAdvancePost2()
        {
            var options = new Stripe.TestHelpers.TestClockAdvanceOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(1675552261)
                    .UtcDateTime,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.TestClocks;
            service.Advance("clock_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/test_clocks/clock_xxxxxxxxxxxxx/advance");
        }

        [Fact]
        public void TestTestHelpersTestClocksDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.TestClocks;
            service.Delete("clock_xyz");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/test_helpers/test_clocks/clock_xyz");
        }

        [Fact]
        public void TestTestHelpersTestClocksDelete2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.TestClocks;
            service.Delete("clock_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/test_helpers/test_clocks/clock_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTestHelpersTestClocksGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.TestClocks;
            StripeList<Stripe.TestHelpers.TestClock> testClocks = service
                .List();
            this.AssertRequest(HttpMethod.Get, "/v1/test_helpers/test_clocks");
        }

        [Fact]
        public void TestTestHelpersTestClocksGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.TestClocks;
            service.Get("clock_xyz");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/test_helpers/test_clocks/clock_xyz");
        }

        [Fact]
        public void TestTestHelpersTestClocksGet3()
        {
            var options = new Stripe.TestHelpers.TestClockListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.TestClocks;
            StripeList<Stripe.TestHelpers.TestClock> testClocks = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/test_helpers/test_clocks",
                "limit=3");
        }

        [Fact]
        public void TestTestHelpersTestClocksGet4()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.TestClocks;
            service.Get("clock_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/test_helpers/test_clocks/clock_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTestHelpersTestClocksPost()
        {
            var options = new Stripe.TestHelpers.TestClockCreateOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(123)
                    .UtcDateTime,
                Name = "cogsworth",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.TestClocks;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/test_helpers/test_clocks");
        }

        [Fact]
        public void TestTestHelpersTestClocksPost2()
        {
            var options = new Stripe.TestHelpers.TestClockCreateOptions
            {
                FrozenTime = DateTimeOffset.FromUnixTimeSeconds(1577836800)
                    .UtcDateTime,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.TestClocks;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/test_helpers/test_clocks");
        }

        [Fact]
        public void TestTestHelpersTreasuryInboundTransfersFailPost()
        {
            var options = new Stripe.TestHelpers.Treasury.InboundTransferFailOptions
            {
                FailureDetails = new Stripe.TestHelpers.Treasury.InboundTransferFailureDetailsOptions
                {
                    Code = "account_closed",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Treasury.InboundTransfers;
            service.Fail("ibt_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/inbound_transfers/ibt_123/fail");
        }

        [Fact]
        public void TestTestHelpersTreasuryInboundTransfersReturnPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Treasury.InboundTransfers;
            service.ReturnInboundTransfer("ibt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/inbound_transfers/ibt_123/return");
        }

        [Fact]
        public void TestTestHelpersTreasuryInboundTransfersSucceedPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Treasury.InboundTransfers;
            service.Succeed("ibt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/inbound_transfers/ibt_123/succeed");
        }

        [Fact]
        public void TestTestHelpersTreasuryOutboundTransfersFailPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Treasury.OutboundTransfers;
            service.Fail("obt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/outbound_transfers/obt_123/fail");
        }

        [Fact]
        public void TestTestHelpersTreasuryOutboundTransfersPostPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Treasury.OutboundTransfers;
            service.Post("obt_123");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/outbound_transfers/obt_123/post");
        }

        [Fact]
        public void TestTestHelpersTreasuryOutboundTransfersReturnPost()
        {
            var options = new Stripe.TestHelpers.Treasury.OutboundTransferReturnOutboundTransferOptions
            {
                ReturnedDetails = new Stripe.TestHelpers.Treasury.OutboundTransferReturnedDetailsOptions
                {
                    Code = "account_closed",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Treasury.OutboundTransfers;
            service.ReturnOutboundTransfer("obt_123", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/outbound_transfers/obt_123/return");
        }

        [Fact]
        public void TestTestHelpersTreasuryReceivedCreditsPost()
        {
            var options = new Stripe.TestHelpers.Treasury.ReceivedCreditCreateOptions
            {
                FinancialAccount = "fa_123",
                Network = "ach",
                Amount = 1234,
                Currency = "usd",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Treasury.ReceivedCredits;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/received_credits");
        }

        [Fact]
        public void TestTestHelpersTreasuryReceivedDebitsPost()
        {
            var options = new Stripe.TestHelpers.Treasury.ReceivedDebitCreateOptions
            {
                FinancialAccount = "fa_123",
                Network = "ach",
                Amount = 1234,
                Currency = "usd",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.TestHelpers.Treasury.ReceivedDebits;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/test_helpers/treasury/received_debits");
        }

        [Fact]
        public void TestTokensGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tokens;
            service.Get("tok_xxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/tokens/tok_xxxx");
        }

        [Fact]
        public void TestTokensPost()
        {
            var options = new TokenCreateOptions
            {
                Card = new TokenCardOptions
                {
                    Number = "4242424242424242",
                    ExpMonth = "5",
                    ExpYear = "2023",
                    Cvc = "314",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tokens;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTokensPost2()
        {
            var options = new TokenCreateOptions
            {
                BankAccount = new TokenBankAccountOptions
                {
                    Country = "US",
                    Currency = "usd",
                    AccountHolderName = "Jenny Rosen",
                    AccountHolderType = "individual",
                    RoutingNumber = "110000000",
                    AccountNumber = "000123456789",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tokens;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTokensPost3()
        {
            var options = new TokenCreateOptions
            {
                Pii = new TokenPiiOptions { IdNumber = "000000000" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tokens;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTokensPost4()
        {
            var options = new TokenCreateOptions
            {
                Account = new TokenAccountOptions
                {
                    Individual = new TokenAccountIndividualOptions
                    {
                        FirstName = "Jane",
                        LastName = "Doe",
                    },
                    TosShownAndAccepted = true,
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tokens;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTokensPost5()
        {
            var options = new TokenCreateOptions
            {
                Person = new TokenPersonOptions
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Relationship = new TokenPersonRelationshipOptions
                    {
                        Owner = true,
                    },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tokens;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTokensPost6()
        {
            var options = new TokenCreateOptions
            {
                CvcUpdate = new TokenCvcUpdateOptions { Cvc = "123" },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Tokens;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/tokens");
        }

        [Fact]
        public void TestTopupsCancelPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Topups;
            service.Cancel("tu_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/topups/tu_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestTopupsGet()
        {
            var options = new TopupListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Topups;
            StripeList<Topup> topups = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/topups", "limit=3");
        }

        [Fact]
        public void TestTopupsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Topups;
            service.Get("tu_xxxxxxxxxxxxx");
            this.AssertRequest(HttpMethod.Get, "/v1/topups/tu_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTopupsPost()
        {
            var options = new TopupCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Description = "Top-up for Jenny Rosen",
                StatementDescriptor = "Top-up",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Topups;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/topups");
        }

        [Fact]
        public void TestTopupsPost2()
        {
            var options = new TopupUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Topups;
            service.Update("tu_xxxxxxxxxxxxx", options);
            this.AssertRequest(HttpMethod.Post, "/v1/topups/tu_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTransfersGet()
        {
            var options = new TransferListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Transfers;
            StripeList<Transfer> transfers = service.List(options);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers", "limit=3");
        }

        [Fact]
        public void TestTransfersGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Transfers;
            service.Get("tr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/transfers/tr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTransfersPost()
        {
            var options = new TransferCreateOptions
            {
                Amount = 400,
                Currency = "usd",
                Destination = "acct_xxxxxxxxxxxxx",
                TransferGroup = "ORDER_95",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Transfers;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/transfers");
        }

        [Fact]
        public void TestTransfersPost2()
        {
            var options = new TransferUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Transfers;
            service.Update("tr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/transfers/tr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTransfersReversalsGet()
        {
            var options = new TransferReversalListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Transfers.Reversals;
            StripeList<TransferReversal> transferReversals = service.List(
                "tr_xxxxxxxxxxxxx",
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals",
                "limit=3");
        }

        [Fact]
        public void TestTransfersReversalsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Transfers.Reversals;
            service.Get("tr_xxxxxxxxxxxxx", "trr_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals/trr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTransfersReversalsPost()
        {
            var options = new TransferReversalCreateOptions { Amount = 100 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Transfers.Reversals;
            service.Create("tr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals");
        }

        [Fact]
        public void TestTransfersReversalsPost2()
        {
            var options = new TransferReversalUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Transfers.Reversals;
            service.Update("tr_xxxxxxxxxxxxx", "trr_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/transfers/tr_xxxxxxxxxxxxx/reversals/trr_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryCreditReversalsGet()
        {
            var options = new Stripe.Treasury.CreditReversalListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.CreditReversals;
            StripeList<Stripe.Treasury.CreditReversal> creditReversals = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/credit_reversals",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryCreditReversalsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.CreditReversals;
            service.Get("credrev_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/credit_reversals/credrev_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryCreditReversalsPost()
        {
            var options = new Stripe.Treasury.CreditReversalCreateOptions
            {
                ReceivedCredit = "rc_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.CreditReversals;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/credit_reversals");
        }

        [Fact]
        public void TestTreasuryDebitReversalsGet()
        {
            var options = new Stripe.Treasury.DebitReversalListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.DebitReversals;
            StripeList<Stripe.Treasury.DebitReversal> debitReversals = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/debit_reversals",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryDebitReversalsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.DebitReversals;
            service.Get("debrev_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/debit_reversals/debrev_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryDebitReversalsPost()
        {
            var options = new Stripe.Treasury.DebitReversalCreateOptions
            {
                ReceivedDebit = "rd_xxxxxxxxxxxxx",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.DebitReversals;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/treasury/debit_reversals");
        }

        [Fact]
        public void TestTreasuryFinancialAccountsFeaturesGet()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.FinancialAccounts.Features;
            service.Get("fa_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/financial_accounts/fa_xxxxxxxxxxxxx/features");
        }

        [Fact]
        public void TestTreasuryFinancialAccountsGet()
        {
            var options = new Stripe.Treasury.FinancialAccountListOptions
            {
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.FinancialAccounts;
            StripeList<Stripe.Treasury.FinancialAccount> financialAccounts = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/financial_accounts",
                "limit=3");
        }

        [Fact]
        public void TestTreasuryFinancialAccountsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.FinancialAccounts;
            service.Get("fa_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/financial_accounts/fa_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryFinancialAccountsPost()
        {
            var options = new Stripe.Treasury.FinancialAccountCreateOptions
            {
                SupportedCurrencies = new List<string> { "usd" },
                Features = new Stripe.Treasury.FinancialAccountFeaturesOptions(),
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.FinancialAccounts;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/financial_accounts");
        }

        [Fact]
        public void TestTreasuryFinancialAccountsPost2()
        {
            var options = new Stripe.Treasury.FinancialAccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "order_id", "6735" },
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.FinancialAccounts;
            service.Update("fa_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/financial_accounts/fa_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryInboundTransfersCancelPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.InboundTransfers;
            service.Cancel("ibt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/inbound_transfers/ibt_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestTreasuryInboundTransfersGet()
        {
            var options = new Stripe.Treasury.InboundTransferListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.InboundTransfers;
            StripeList<Stripe.Treasury.InboundTransfer> inboundTransfers = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/inbound_transfers",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryInboundTransfersGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.InboundTransfers;
            service.Get("ibt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/inbound_transfers/ibt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryInboundTransfersPost()
        {
            var options = new Stripe.Treasury.InboundTransferCreateOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Amount = 10000,
                Currency = "usd",
                OriginPaymentMethod = "pm_xxxxxxxxxxxxx",
                Description = "InboundTransfer from my bank account",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.InboundTransfers;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/inbound_transfers");
        }

        [Fact]
        public void TestTreasuryOutboundPaymentsCancelPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.OutboundPayments;
            service.Cancel("bot_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_payments/bot_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestTreasuryOutboundPaymentsGet()
        {
            var options = new Stripe.Treasury.OutboundPaymentListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.OutboundPayments;
            StripeList<Stripe.Treasury.OutboundPayment> outboundPayments = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_payments",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryOutboundPaymentsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.OutboundPayments;
            service.Get("bot_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_payments/bot_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryOutboundPaymentsPost()
        {
            var options = new Stripe.Treasury.OutboundPaymentCreateOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Amount = 10000,
                Currency = "usd",
                Customer = "cus_xxxxxxxxxxxxx",
                DestinationPaymentMethod = "pm_xxxxxxxxxxxxx",
                Description = "OutboundPayment to a 3rd party",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.OutboundPayments;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_payments");
        }

        [Fact]
        public void TestTreasuryOutboundTransfersCancelPost()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.OutboundTransfers;
            service.Cancel("obt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_transfers/obt_xxxxxxxxxxxxx/cancel");
        }

        [Fact]
        public void TestTreasuryOutboundTransfersGet()
        {
            var options = new Stripe.Treasury.OutboundTransferListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.OutboundTransfers;
            StripeList<Stripe.Treasury.OutboundTransfer> outboundTransfers = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_transfers",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryOutboundTransfersGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.OutboundTransfers;
            service.Get("obt_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/outbound_transfers/obt_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryOutboundTransfersPost()
        {
            var options = new Stripe.Treasury.OutboundTransferCreateOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                DestinationPaymentMethod = "pm_xxxxxxxxxxxxx",
                Amount = 500,
                Currency = "usd",
                Description = "OutboundTransfer to my external bank account",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.OutboundTransfers;
            service.Create(options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/treasury/outbound_transfers");
        }

        [Fact]
        public void TestTreasuryReceivedCreditsGet()
        {
            var options = new Stripe.Treasury.ReceivedCreditListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.ReceivedCredits;
            StripeList<Stripe.Treasury.ReceivedCredit> receivedCredits = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_credits",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryReceivedCreditsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.ReceivedCredits;
            service.Get("rc_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_credits/rc_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryReceivedDebitsGet()
        {
            var options = new Stripe.Treasury.ReceivedDebitListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.ReceivedDebits;
            StripeList<Stripe.Treasury.ReceivedDebit> receivedDebits = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_debits",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryReceivedDebitsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.ReceivedDebits;
            service.Get("rd_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/received_debits/rd_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryTransactionEntriesGet()
        {
            var options = new Stripe.Treasury.TransactionEntryListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.TransactionEntries;
            StripeList<Stripe.Treasury.TransactionEntry> transactionEntries = service
                .List(options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transaction_entries",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryTransactionEntriesGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.TransactionEntries;
            service.Get("trxne_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transaction_entries/trxne_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestTreasuryTransactionsGet()
        {
            var options = new Stripe.Treasury.TransactionListOptions
            {
                FinancialAccount = "fa_xxxxxxxxxxxxx",
                Limit = 3,
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.Transactions;
            StripeList<Stripe.Treasury.Transaction> transactions = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transactions",
                "financial_account=fa_xxxxxxxxxxxxx&limit=3");
        }

        [Fact]
        public void TestTreasuryTransactionsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.Treasury.Transactions;
            service.Get("trxn_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/treasury/transactions/trxn_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestWebhookEndpointsDelete()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.WebhookEndpoints;
            service.Delete("we_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Delete,
                "/v1/webhook_endpoints/we_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestWebhookEndpointsGet()
        {
            var options = new WebhookEndpointListOptions { Limit = 3 };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.WebhookEndpoints;
            StripeList<WebhookEndpoint> webhookEndpoints = service.List(
                options);
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/webhook_endpoints",
                "limit=3");
        }

        [Fact]
        public void TestWebhookEndpointsGet2()
        {
            var client = new StripeClient(this.Requestor);
            var service = client.V1.WebhookEndpoints;
            service.Get("we_xxxxxxxxxxxxx");
            this.AssertRequest(
                HttpMethod.Get,
                "/v1/webhook_endpoints/we_xxxxxxxxxxxxx");
        }

        [Fact]
        public void TestWebhookEndpointsPost()
        {
            var options = new WebhookEndpointCreateOptions
            {
                Url = "https://example.com/my/webhook/endpoint",
                EnabledEvents = new List<string>
                {
                    "charge.failed",
                    "charge.succeeded",
                },
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.WebhookEndpoints;
            service.Create(options);
            this.AssertRequest(HttpMethod.Post, "/v1/webhook_endpoints");
        }

        [Fact]
        public void TestWebhookEndpointsPost2()
        {
            var options = new WebhookEndpointUpdateOptions
            {
                Url = "https://example.com/new_endpoint",
            };
            var client = new StripeClient(this.Requestor);
            var service = client.V1.WebhookEndpoints;
            service.Update("we_xxxxxxxxxxxxx", options);
            this.AssertRequest(
                HttpMethod.Post,
                "/v1/webhook_endpoints/we_xxxxxxxxxxxxx");
        }
    }
}
