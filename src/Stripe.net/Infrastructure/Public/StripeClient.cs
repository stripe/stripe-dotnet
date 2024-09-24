namespace Stripe
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Stripe client, used to issue requests to Stripe's API and deserialize responses.
    /// </summary>
    public class StripeClient : IStripeClient
    {
        private JsonSerializerSettings jsonSerializerSettings;

        // Fields: The beginning of the section generated from our OpenAPI spec
        private AccountService accounts;
        private AccountLinkService accountLinks;
        private AccountSessionService accountSessions;
        private ApplePayDomainService applePayDomains;
        private ApplicationFeeService applicationFees;
        private AppsService apps;
        private BalanceService balance;
        private BalanceTransactionService balanceTransactions;
        private BankAccountService bankAccounts;
        private BillingService billing;
        private BillingPortalService billingPortal;
        private CardService cards;
        private ChargeService charges;
        private CheckoutService checkout;
        private ClimateService climate;
        private ConfirmationTokenService confirmationTokens;
        private TestHelpersService testHelpers;
        private CountrySpecService countrySpecs;
        private CouponService coupons;
        private CreditNoteService creditNotes;
        private CustomerService customers;
        private CustomerSessionService customerSessions;
        private DisputeService disputes;
        private EntitlementsService entitlements;
        private EphemeralKeyService ephemeralKeys;
        private EventService events;
        private FileService files;
        private FileLinkService fileLinks;
        private FinancialConnectionsService financialConnections;
        private ForwardingService forwarding;
        private IdentityService identity;
        private InvoiceService invoices;
        private InvoiceItemService invoiceItems;
        private IssuingService issuing;
        private MandateService mandates;
        private PaymentIntentService paymentIntents;
        private PaymentLinkService paymentLinks;
        private PaymentMethodService paymentMethods;
        private PaymentMethodConfigurationService paymentMethodConfigurations;
        private PaymentMethodDomainService paymentMethodDomains;
        private PayoutService payouts;
        private PlanService plans;
        private PriceService prices;
        private ProductService products;
        private PromotionCodeService promotionCodes;
        private QuoteService quotes;
        private RadarService radar;
        private RefundService refunds;
        private ReportingService reporting;
        private ReviewService reviews;
        private SigmaService sigma;
        private SetupAttemptService setupAttempts;
        private SetupIntentService setupIntents;
        private ShippingRateService shippingRates;
        private SourceService sources;
        private SubscriptionService subscriptions;
        private SubscriptionItemService subscriptionItems;
        private SubscriptionScheduleService subscriptionSchedules;
        private TaxService tax;
        private TaxCodeService taxCodes;
        private TaxIdService taxIds;
        private TaxRateService taxRates;
        private TerminalService terminal;
        private TokenService tokens;
        private TopupService topups;
        private TransferService transfers;
        private TreasuryService treasury;
        private WebhookEndpointService webhookEndpoints;

        // Fields: The end of the section generated from our OpenAPI spec
        internal StripeClient(ApiRequestor requestor)
        {
            this.Requestor = requestor;
            this.jsonSerializerSettings = StripeConfiguration.DefaultSerializerSettings(requestor);
        }

        /// <summary>Initializes a new instance of the <see cref="StripeClient"/> class.</summary>
        /// <param name="apiKey">The API key used by the client to make requests.</param>
        /// <param name="clientId">The client ID used by the client in OAuth requests.</param>
        /// <param name="httpClient">
        /// The <see cref="IHttpClient"/> client to use. If <c>null</c>, an HTTP client will be
        /// created with default parameters.
        /// </param>
        /// <param name="apiBase">
        /// The base URL for Stripe's API. Defaults to <see cref="DefaultApiBase"/>.
        /// </param>
        /// <param name="connectBase">
        /// The base URL for Stripe's OAuth API. Defaults to <see cref="DefaultConnectBase"/>.
        /// </param>
        /// <param name="filesBase">
        /// The base URL for Stripe's Files API. Defaults to <see cref="DefaultFilesBase"/>.
        /// </param>
        /// <param name="eventsBase">
        /// The base URL for Stripe's Events API. Defaults to <see cref="DefaultEventsBase"/>.
        /// </param>
        /// <exception cref="ArgumentNullException">if <c>apiKey</c> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">
        /// if <c>apiKey</c> is empty or contains whitespace.
        /// </exception>
        public StripeClient(
            string apiKey = null,
            string clientId = null,
            IHttpClient httpClient = null,
            string apiBase = null,
            string connectBase = null,
            string filesBase = null,
            string eventsBase = null)
            : this(new LiveApiRequestor(apiKey, clientId, httpClient, apiBase, connectBase, filesBase, eventsBase))
        {
        }

        /// <summary>Default base URL for Stripe's API.</summary>
        public static string DefaultApiBase => "https://api.stripe.com";

        /// <summary>Default base URL for Stripe's OAuth API.</summary>
        public static string DefaultConnectBase => "https://connect.stripe.com";

        /// <summary>Default base URL for Stripe's Files API.</summary>
        public static string DefaultFilesBase => "https://files.stripe.com";

        /// <summary>Default base URL for Stripe's Events API.</summary>
        public static string DefaultEventsBase => "https://events.stripe.com";

        internal ApiRequestor Requestor { get; }

        /// <summary>Gets the base URL for Stripe's API.</summary>
        /// <value>The base URL for Stripe's API.</value>
        public string ApiBase => this.Requestor?.ApiBase;

        /// <summary>Gets the API key used by the client to send requests.</summary>
        /// <value>The API key used by the client to send requests.</value>
        public string ApiKey => this.Requestor?.ApiKey;

        /// <summary>Gets the client ID used by the client in OAuth requests.</summary>
        /// <value>The client ID used by the client in OAuth requests.</value>
        public string ClientId => this.Requestor?.ClientId;

        /// <summary>Gets the base URL for Stripe's OAuth API.</summary>
        /// <value>The base URL for Stripe's OAuth API.</value>
        public string ConnectBase => this.Requestor?.ConnectBase;

        /// <summary>Gets the base URL for Stripe's Files API.</summary>
        /// <value>The base URL for Stripe's Files API.</value>
        public string FilesBase => this.Requestor?.FilesBase;

        /// <summary>Gets the base URL for Stripe's Events API.</summary>
        /// <value>The base URL for Stripe's Events API.</value>
        public string EventsBase => this.Requestor?.EventsBase;

        /// <summary>Gets the <see cref="IHttpClient"/> used to send HTTP requests.</summary>
        /// <value>The <see cref="IHttpClient"/> used to send HTTP requests.</value>
        public IHttpClient HttpClient => this.Requestor?.HttpClient;

        // Properties: The beginning of the section generated from our OpenAPI spec
        public virtual AccountService Accounts => this.accounts ??= new AccountService(
            this.Requestor);

        public virtual AccountLinkService AccountLinks => this.accountLinks ??= new AccountLinkService(
            this.Requestor);

        public virtual AccountSessionService AccountSessions => this.accountSessions ??= new AccountSessionService(
            this.Requestor);

        public virtual ApplePayDomainService ApplePayDomains => this.applePayDomains ??= new ApplePayDomainService(
            this.Requestor);

        public virtual ApplicationFeeService ApplicationFees => this.applicationFees ??= new ApplicationFeeService(
            this.Requestor);

        public virtual AppsService Apps => this.apps ??= new AppsService(
            this.Requestor);

        public virtual BalanceService Balance => this.balance ??= new BalanceService(
            this.Requestor);

        public virtual BalanceTransactionService BalanceTransactions => this.balanceTransactions ??= new BalanceTransactionService(
            this.Requestor);

        public virtual BankAccountService BankAccounts => this.bankAccounts ??= new BankAccountService(
            this.Requestor);

        public virtual BillingService Billing => this.billing ??= new BillingService(
            this.Requestor);

        public virtual BillingPortalService BillingPortal => this.billingPortal ??= new BillingPortalService(
            this.Requestor);

        public virtual CardService Cards => this.cards ??= new CardService(
            this.Requestor);

        public virtual ChargeService Charges => this.charges ??= new ChargeService(
            this.Requestor);

        public virtual CheckoutService Checkout => this.checkout ??= new CheckoutService(
            this.Requestor);

        public virtual ClimateService Climate => this.climate ??= new ClimateService(
            this.Requestor);

        public virtual ConfirmationTokenService ConfirmationTokens => this.confirmationTokens ??= new ConfirmationTokenService(
            this.Requestor);

        public virtual TestHelpersService TestHelpers => this.testHelpers ??= new TestHelpersService(
            this.Requestor);

        public virtual CountrySpecService CountrySpecs => this.countrySpecs ??= new CountrySpecService(
            this.Requestor);

        public virtual CouponService Coupons => this.coupons ??= new CouponService(
            this.Requestor);

        public virtual CreditNoteService CreditNotes => this.creditNotes ??= new CreditNoteService(
            this.Requestor);

        public virtual CustomerService Customers => this.customers ??= new CustomerService(
            this.Requestor);

        public virtual CustomerSessionService CustomerSessions => this.customerSessions ??= new CustomerSessionService(
            this.Requestor);

        public virtual DisputeService Disputes => this.disputes ??= new DisputeService(
            this.Requestor);

        public virtual EntitlementsService Entitlements => this.entitlements ??= new EntitlementsService(
            this.Requestor);

        public virtual EphemeralKeyService EphemeralKeys => this.ephemeralKeys ??= new EphemeralKeyService(
            this.Requestor);

        public virtual EventService Events => this.events ??= new EventService(
            this.Requestor);

        public virtual FileService Files => this.files ??= new FileService(
            this.Requestor);

        public virtual FileLinkService FileLinks => this.fileLinks ??= new FileLinkService(
            this.Requestor);

        public virtual FinancialConnectionsService FinancialConnections => this.financialConnections ??= new FinancialConnectionsService(
            this.Requestor);

        public virtual ForwardingService Forwarding => this.forwarding ??= new ForwardingService(
            this.Requestor);

        public virtual IdentityService Identity => this.identity ??= new IdentityService(
            this.Requestor);

        public virtual InvoiceService Invoices => this.invoices ??= new InvoiceService(
            this.Requestor);

        public virtual InvoiceItemService InvoiceItems => this.invoiceItems ??= new InvoiceItemService(
            this.Requestor);

        public virtual IssuingService Issuing => this.issuing ??= new IssuingService(
            this.Requestor);

        public virtual MandateService Mandates => this.mandates ??= new MandateService(
            this.Requestor);

        public virtual PaymentIntentService PaymentIntents => this.paymentIntents ??= new PaymentIntentService(
            this.Requestor);

        public virtual PaymentLinkService PaymentLinks => this.paymentLinks ??= new PaymentLinkService(
            this.Requestor);

        public virtual PaymentMethodService PaymentMethods => this.paymentMethods ??= new PaymentMethodService(
            this.Requestor);

        public virtual PaymentMethodConfigurationService PaymentMethodConfigurations => this.paymentMethodConfigurations ??= new PaymentMethodConfigurationService(
            this.Requestor);

        public virtual PaymentMethodDomainService PaymentMethodDomains => this.paymentMethodDomains ??= new PaymentMethodDomainService(
            this.Requestor);

        public virtual PayoutService Payouts => this.payouts ??= new PayoutService(
            this.Requestor);

        public virtual PlanService Plans => this.plans ??= new PlanService(
            this.Requestor);

        public virtual PriceService Prices => this.prices ??= new PriceService(
            this.Requestor);

        public virtual ProductService Products => this.products ??= new ProductService(
            this.Requestor);

        public virtual PromotionCodeService PromotionCodes => this.promotionCodes ??= new PromotionCodeService(
            this.Requestor);

        public virtual QuoteService Quotes => this.quotes ??= new QuoteService(
            this.Requestor);

        public virtual RadarService Radar => this.radar ??= new RadarService(
            this.Requestor);

        public virtual RefundService Refunds => this.refunds ??= new RefundService(
            this.Requestor);

        public virtual ReportingService Reporting => this.reporting ??= new ReportingService(
            this.Requestor);

        public virtual ReviewService Reviews => this.reviews ??= new ReviewService(
            this.Requestor);

        public virtual SigmaService Sigma => this.sigma ??= new SigmaService(
            this.Requestor);

        public virtual SetupAttemptService SetupAttempts => this.setupAttempts ??= new SetupAttemptService(
            this.Requestor);

        public virtual SetupIntentService SetupIntents => this.setupIntents ??= new SetupIntentService(
            this.Requestor);

        public virtual ShippingRateService ShippingRates => this.shippingRates ??= new ShippingRateService(
            this.Requestor);

        public virtual SourceService Sources => this.sources ??= new SourceService(
            this.Requestor);

        public virtual SubscriptionService Subscriptions => this.subscriptions ??= new SubscriptionService(
            this.Requestor);

        public virtual SubscriptionItemService SubscriptionItems => this.subscriptionItems ??= new SubscriptionItemService(
            this.Requestor);

        public virtual SubscriptionScheduleService SubscriptionSchedules => this.subscriptionSchedules ??= new SubscriptionScheduleService(
            this.Requestor);

        public virtual TaxService Tax => this.tax ??= new TaxService(this.Requestor);

        public virtual TaxCodeService TaxCodes => this.taxCodes ??= new TaxCodeService(
            this.Requestor);

        public virtual TaxIdService TaxIds => this.taxIds ??= new TaxIdService(
            this.Requestor);

        public virtual TaxRateService TaxRates => this.taxRates ??= new TaxRateService(
            this.Requestor);

        public virtual TerminalService Terminal => this.terminal ??= new TerminalService(
            this.Requestor);

        public virtual TokenService Tokens => this.tokens ??= new TokenService(
            this.Requestor);

        public virtual TopupService Topups => this.topups ??= new TopupService(
            this.Requestor);

        public virtual TransferService Transfers => this.transfers ??= new TransferService(
            this.Requestor);

        public virtual TreasuryService Treasury => this.treasury ??= new TreasuryService(
            this.Requestor);

        public virtual WebhookEndpointService WebhookEndpoints => this.webhookEndpoints ??= new WebhookEndpointService(
            this.Requestor);

        // Properties: The end of the section generated from our OpenAPI spec

        /// <summary>Deserializes a JSON string into a Stripe object.</summary>
        /// <typeparam name="T">The type of the Stripe object to deserialize to.</typeparam>
        /// <param name="response">The HTTP response as a StripeResponse.</param>
        /// <returns>The deserialized Stripe object from the JSON string.</returns>
        public T Deserialize<T>(string response)
            where T : IStripeEntity
        {
            return StripeEntity.FromJson<T>(response);
        }

        /// <summary>Sends a request to Stripe's API as an asynchronous operation.</summary>
        /// <typeparam name="T">Type of the Stripe entity returned by the API.</typeparam>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="options">The parameters of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="StripeException">Thrown if the request fails.</exception>
        public async Task<T> RequestAsync<T>(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
            where T : IStripeEntity
        {
            return await this.Requestor.RequestAsync<T>(BaseAddress.Api, method, path, options, requestOptions, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<Stream> RequestStreamingAsync(
            HttpMethod method,
            string path,
            BaseOptions options,
            RequestOptions requestOptions,
            CancellationToken cancellationToken = default)
        {
            return await this.Requestor.RequestStreamingAsync(BaseAddress.Api, method, path, options, requestOptions, cancellationToken);
        }

        /// <summary>Sends a request to Stripe's API as a synchronous operation.</summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="content">The body of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The response as a StripeResponse.</returns>
        /// <exception cref="StripeException">Thrown if the request fails.</exception>
        public StripeResponse RawRequest(
            HttpMethod method,
            string path,
            string content = null,
            RawRequestOptions requestOptions = null,
            CancellationToken cancellationToken = default)
        {
            return this.Requestor.RawRequest(method, path, content, requestOptions, cancellationToken);
        }

        /// <summary>Sends a request to Stripe's API as an asynchronous operation.</summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The path of the request.</param>
        /// <param name="content">The body of the request.</param>
        /// <param name="requestOptions">The special modifiers of the request.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="StripeException">Thrown if the request fails.</exception>
        public async Task<StripeResponse> RawRequestAsync(
            HttpMethod method,
            string path,
            string content = null,
            RawRequestOptions requestOptions = null,
            CancellationToken cancellationToken = default)
        {
            return await this.Requestor.RawRequestAsync(method, path, content, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Parses a JSON string from a Stripe webhook into a <see cref="ThinEvent"/> object, while
        /// verifying the <a href="https://stripe.com/docs/webhooks/signatures">webhook's
        /// signature</a>.
        /// </summary>
        /// <param name="json">The JSON string to parse.</param>
        /// <param name="stripeSignatureHeader">
        /// The value of the <c>Stripe-Signature</c> header from the webhook request.
        /// </param>
        /// <param name="secret">The webhook endpoint's signing secret.</param>
        /// <param name="tolerance">The time tolerance, in seconds (default 300).</param>
        /// <returns>The deserialized <see cref="ThinEvent"/>.</returns>
        /// <exception cref="StripeException">
        /// Thrown if the signature verification fails for any reason, of if the API version of the
        /// event doesn't match Stripe.net's default API version.
        /// </exception>
        public ThinEvent ParseThinEvent(
            string json,
            string stripeSignatureHeader,
            string secret,
            long tolerance = EventUtility.DefaultTimeTolerance)
        {
            EventUtility.ValidateSignature(json, stripeSignatureHeader, secret, tolerance, DateTimeOffset.UtcNow.ToUnixTimeSeconds());

            var thinEvent = JsonUtils.DeserializeObject<ThinEvent>(json, this.jsonSerializerSettings);

            return thinEvent;
        }

        /// <summary>
        /// Parses a JSON string from a Stripe webhook into a <see cref="Event"/> object, while
        /// verifying the <a href="https://stripe.com/docs/webhooks/signatures">webhook's
        /// signature</a>.
        /// </summary>
        /// <param name="json">The JSON string to parse.</param>
        /// <param name="stripeSignatureHeader">
        /// The value of the <c>Stripe-Signature</c> header from the webhook request.
        /// </param>
        /// <param name="secret">The webhook endpoint's signing secret.</param>
        /// <param name="tolerance">The time tolerance, in seconds (default 300).</param>
        /// <returns>The deserialized <see cref="Event"/>.</returns>
        /// <exception cref="StripeException">
        /// Thrown if the signature verification fails for any reason, of if the API version of the
        /// event doesn't match Stripe.net's default API version.
        /// </exception>
        public Event ParseSnapshotEvent(
            string json,
            string stripeSignatureHeader,
            string secret,
            long tolerance = EventUtility.DefaultTimeTolerance)
        {
            EventUtility.ValidateSignature(json, stripeSignatureHeader, secret, tolerance, DateTimeOffset.UtcNow.ToUnixTimeSeconds());

            var stripeEvent = JsonUtils.DeserializeObject<Event>(
                json,
                StripeConfiguration.SerializerSettings);

            return stripeEvent;
        }
    }
}
