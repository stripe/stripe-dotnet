// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OnrampSessionCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The IP address of the customer the platform intends to onramp.
        ///
        /// If the user's IP is in a region we can't support, we return an <c>HTTP 400</c> with an
        /// appropriate error code.
        ///
        /// We support IPv4 and IPv6 addresses. Geographic supportability is checked again later in
        /// the onramp flow, which provides a way to hide the onramp option from ineligible users
        /// for a better user experience.
        /// </summary>
        [JsonProperty("customer_ip_address")]
        [STJS.JsonPropertyName("customer_ip_address")]
        public string CustomerIpAddress { get; set; }

        /// <summary>
        /// The default amount of crypto to exchange into.
        ///
        /// * When left null, a default value is computed if <c>source_amount</c>,
        /// <c>destination_currency</c>, and <c>destination_network</c> are set. * When set, both
        /// <c>destination_currency</c> and <c>destination_network</c> must also be set. All
        /// cryptocurrencies are supported to their full precisions (for example, 18 decimal places
        /// for <c>eth</c>). We validate and generate an error if the amount exceeds the supported
        /// precision based on the exchange currency. Setting <c>source_amount</c> is mutually
        /// exclusive with setting <c>destination_amount</c> (only one or the other is supported).
        /// Users can update the amount in the onramp UI.
        /// </summary>
        [JsonProperty("destination_amount")]
        [STJS.JsonPropertyName("destination_amount")]
        public string DestinationAmount { get; set; }

        /// <summary>
        /// The list of destination cryptocurrencies a user can choose from.
        ///
        /// * When left null, all supported cryptocurrencies are shown in the onramp UI subject to
        /// <c>destination_networks</c> if set. * When set, it must be a non-empty array where all
        /// values in the array are valid cryptocurrencies. You can use it to lock users to a
        /// specific cryptocurrency by passing a single value array. Users <strong>cannot</strong>
        /// override this parameter.
        /// One of: <c>avax</c>, <c>btc</c>, <c>eth</c>, <c>matic</c>, <c>sol</c>, <c>usdc</c>,
        /// <c>wld</c>, or <c>xlm</c>.
        /// </summary>
        [JsonProperty("destination_currencies")]
        [STJS.JsonPropertyName("destination_currencies")]
        public List<string> DestinationCurrencies { get; set; }

        /// <summary>
        /// The default destination cryptocurrency.
        ///
        /// * When left null, the first value of <c>destination_currencies</c> is selected. * When
        /// set, if <c>destination_currencies</c> is also set, the value of
        /// <c>destination_currency</c> must be present in that array. To lock a
        /// <c>destination_currency</c>, specify that value as the single value for
        /// <c>destination_currencies</c>. Users can select a different cryptocurrency in the onramp
        /// UI subject to <c>destination_currencies</c> if set.
        /// One of: <c>avax</c>, <c>btc</c>, <c>eth</c>, <c>matic</c>, <c>sol</c>, <c>usdc</c>,
        /// <c>wld</c>, or <c>xlm</c>.
        /// </summary>
        [JsonProperty("destination_currency")]
        [STJS.JsonPropertyName("destination_currency")]
        public string DestinationCurrency { get; set; }

        /// <summary>
        /// The default destination crypto network.
        ///
        /// * When left null, the first value of <c>destination_networks</c> is selected. * When
        /// set, if <c>destination_networks</c> is also set, the value of <c>destination_network</c>
        /// must be present in that array. To lock a <c>destination_network</c>, specify that value
        /// as the single value for <c>destination_networks</c>. Users can select a different
        /// network in the onramp UI subject to <c>destination_networks</c> if set.
        /// One of: <c>avalanche</c>, <c>base</c>, <c>bitcoin</c>, <c>ethereum</c>, <c>optimism</c>,
        /// <c>polygon</c>, <c>solana</c>, <c>stellar</c>, <c>sui</c>, or <c>worldchain</c>.
        /// </summary>
        [JsonProperty("destination_network")]
        [STJS.JsonPropertyName("destination_network")]
        public string DestinationNetwork { get; set; }

        /// <summary>
        /// The list of destination crypto networks user can choose from.
        ///
        /// * When left null, all supported crypto networks are shown in the onramp UI. * When set,
        /// it must be a non-empty array where values in the array are each a valid crypto network.
        /// It can be used to lock users to a specific network by passing a single value array.
        /// Users <strong>cannot</strong> override this parameter.
        /// One of: <c>avalanche</c>, <c>base</c>, <c>bitcoin</c>, <c>ethereum</c>, <c>optimism</c>,
        /// <c>polygon</c>, <c>solana</c>, <c>stellar</c>, <c>sui</c>, or <c>worldchain</c>.
        /// </summary>
        [JsonProperty("destination_networks")]
        [STJS.JsonPropertyName("destination_networks")]
        public List<string> DestinationNetworks { get; set; }

        /// <summary>
        /// Pre-populate some of the required KYC information for the user if you've already
        /// collected it within your application.
        ///
        /// Related guide: <a
        /// href="https://docs.stripe.com/crypto/using-the-api#how-to-pre-populate-customer-information">Using
        /// the API</a>.
        /// </summary>
        [JsonProperty("kyc_details")]
        [STJS.JsonPropertyName("kyc_details")]
        public OnrampSessionKycDetailsOptions KycDetails { get; set; }

        /// <summary>
        /// Whether or not to lock the suggested wallet address. If destination tags are provided,
        /// this will also lock the destination tags.
        /// </summary>
        [JsonProperty("lock_wallet_address")]
        [STJS.JsonPropertyName("lock_wallet_address")]
        public bool? LockWalletAddress { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Speed at which the cryptocurrency is delivered to the wallet One of: <c>instant</c>
        /// (default): crypto is delivered when payment is confirmed <c>standard</c>: crypto is
        /// delivered when payment settles.
        /// One of: <c>instant</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("settlement_speed")]
        [STJS.JsonPropertyName("settlement_speed")]
        public string SettlementSpeed { get; set; }

        /// <summary>
        /// The default amount of fiat (in decimal) to exchange into crypto.
        ///
        /// * When left null, a default value is computed if <c>destination_amount</c> is set. *
        /// When set, setting <c>source_amount</c> is mutually exclusive with setting
        /// <c>destination_amount</c> (only one or the other is supported). We don't support
        /// fractional pennies. If fractional minor units of a currency are passed in, it generates
        /// an error. Users can update the value in the onramp UI.
        /// </summary>
        [JsonProperty("source_amount")]
        [STJS.JsonPropertyName("source_amount")]
        public string SourceAmount { get; set; }

        /// <summary>
        /// The default source fiat currency for the onramp session.
        ///
        /// * When left null, a default currency is selected based on user locale. * When set, it
        /// must be one of the fiat currencies supported by onramp. Users can still select a
        /// different currency in the onramp UI.
        /// One of: <c>eur</c>, <c>gbp</c>, or <c>usd</c>.
        /// </summary>
        [JsonProperty("source_currency")]
        [STJS.JsonPropertyName("source_currency")]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// The end customer's crypto wallet address (for each network) to use for this transaction.
        ///
        /// * When left null, the user enters their wallet in the onramp UI. * When set, the
        /// platform must set either <c>destination_networks</c> or <c>destination_network</c> and
        /// we perform address validation. Users can still select a different wallet in the onramp
        /// UI.
        /// </summary>
        [JsonProperty("wallet_addresses")]
        [STJS.JsonPropertyName("wallet_addresses")]
        public OnrampSessionWalletAddressesOptions WalletAddresses { get; set; }
    }
}
