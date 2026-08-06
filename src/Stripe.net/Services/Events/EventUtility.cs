namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using Stripe.Infrastructure;

    /// <summary>
    /// This class contains utility methods to process event objects in Stripe's webhooks.
    /// </summary>
    public static class EventUtility
    {
        internal static readonly UTF8Encoding SafeUTF8
            = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        public const int DefaultTimeTolerance = 300;

        public static bool IsCompatibleApiVersion(string sdkApiVersion, string eventApiVersion)
        {
            // If the event api version is from before we started adding
            // a release train, there's no way its compatible with this
            // version
            if (!eventApiVersion.Contains("."))
            {
                return false;
            }

            // versions are yyyy-MM-dd.train
            var currentReleaseTrain = sdkApiVersion.Split('.')[1];

            // Beta SDKs should match event versions exactly when deserializing
            if (currentReleaseTrain == "preview")
            {
                return eventApiVersion == sdkApiVersion;
            }

            var eventReleaseTrain = eventApiVersion.Split('.')[1];
            return eventReleaseTrain == currentReleaseTrain;
        }

        public static bool IsCompatibleApiVersion(string eventApiVersion)
        {
            return IsCompatibleApiVersion(ApiVersion.Current, eventApiVersion);
        }

        /// <summary>
        /// Parses a JSON string from a Stripe webhook into a <see cref="Event"/> object.
        /// </summary>
        /// <param name="json">The JSON string to parse.</param>
        /// <param name="throwOnApiVersionMismatch">
        /// If <c>true</c> (default), the method will throw a <see cref="StripeException"/> if the
        /// API version of the event doesn't match Stripe.net's default API version (see
        /// <see cref="ApiVersion.Current"/>).
        /// </param>
        /// <returns>The deserialized <see cref="Event"/>.</returns>
        /// <exception cref="StripeException">
        /// Thrown if the API version of the event doesn't match Stripe.net's default API version.
        /// </exception>
        /// <remarks>
        /// This method doesn't verify <a href="https://stripe.com/docs/webhooks/signatures">webhook
        /// signatures</a>. It's recommended that you use
        /// <see cref="ConstructEvent(string, string, string, long, bool)"/> instead.
        /// </remarks>
        public static Event ParseEvent(string json, bool throwOnApiVersionMismatch = true)
        {
            return ValidateEvent(DeserializeEvent(json), throwOnApiVersionMismatch);
        }

        private static Event ParseEvent(System.Text.Json.JsonElement inner, bool throwOnApiVersionMismatch = true)
        {
            return ValidateEvent(DeserializeEvent(inner), throwOnApiVersionMismatch);
        }

        private static Event ValidateEvent(Event stripeEvent, bool throwOnApiVersionMismatch = true)
        {
            if (throwOnApiVersionMismatch &&
                !IsCompatibleApiVersion(stripeEvent.ApiVersion))
            {
                throw new StripeException(
                    $"Received event with API version {stripeEvent.ApiVersion}, but Stripe.net "
                    + $"{StripeConfiguration.StripeNetVersion} expects API version "
                    + $"{ApiVersion.Current}. We recommend that you create a "
                    + "WebhookEndpoint with this API version. Otherwise, you can disable this "
                    + "exception by passing `throwOnApiVersionMismatch: false` to "
                    + "`Stripe.EventUtility.ParseEvent` or `Stripe.EventUtility.ConstructEvent`, "
                    + "but be wary that objects may be incorrectly deserialized.");
            }

            return stripeEvent;
        }

        /// <summary>
        /// Constructs an a <see cref="Event"/>
        /// from an incoming <see href="https://docs.stripe.com/event-destinations#snapshot-payload">webhook</see> after verifying its authenticity. To work with a webhook that
        /// has already been verified (i.e. one from a cloud provider, an asynchronous queue, or
        /// during testing), see <see cref="ConstructEventWithoutVerification"/>.
        /// </summary>
        /// <param name="json">The JSON string to parse.</param>
        /// <param name="stripeSignatureHeader">
        /// The value of the <c>Stripe-Signature</c> header from the webhook request.
        /// </param>
        /// <param name="secret">The webhook endpoint's signing secret.</param>
        /// <param name="tolerance">The time tolerance, in seconds (default 300).</param>
        /// <param name="throwOnApiVersionMismatch">
        /// If <c>true</c> (default), the method will throw a <see cref="StripeException"/> if the
        /// API version of the event doesn't match Stripe.net's default API version (see
        /// <see cref="ApiVersion.Current"/>).
        /// </param>
        /// <returns>The deserialized <see cref="Event"/>.</returns>
        /// <exception cref="StripeException">
        /// Thrown if the signature verification fails for any reason, of if the API version of the
        /// event doesn't match Stripe.net's default API version.
        /// </exception>
        public static Event ConstructEvent(
            string json,
            string stripeSignatureHeader,
            string secret,
            long tolerance = DefaultTimeTolerance,
            bool throwOnApiVersionMismatch = true)
        {
            return ConstructEvent(
                json,
                stripeSignatureHeader,
                secret,
                tolerance,
                DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                throwOnApiVersionMismatch);
        }

        /// <summary>
        /// Constructs a <see href="https://docs.stripe.com/event-destinations#snapshot-payload">snapshot event</see>
        /// from an incoming webhook after verifying its authenticity. To work with a webhook that
        /// has already been verified (i.e. one from a cloud provider, an asynchronous queue, or
        /// during testing), see <see cref="ConstructEventWithoutVerification"/>.
        /// </summary>
        /// <param name="json">The JSON string to parse.</param>
        /// <param name="stripeSignatureHeader">
        /// The value of the <c>Stripe-Signature</c> header from the webhook request.
        /// </param>
        /// <param name="secret">The webhook endpoint's signing secret.</param>
        /// <param name="tolerance">The time tolerance, in seconds.</param>
        /// <param name="utcNow">The timestamp to use for the current time.</param>
        /// <param name="throwOnApiVersionMismatch">
        /// If <c>true</c> (default), the method will throw a <see cref="StripeException"/> if the
        /// API version of the event doesn't match Stripe.net's default API version (see
        /// <see cref="ApiVersion.Current"/>).
        /// </param>
        /// <returns>The deserialized <see cref="Event"/>.</returns>
        /// <exception cref="StripeException">
        /// Thrown if the signature verification fails for any reason, of if the API version of the
        /// event doesn't match Stripe.net's default API version.
        /// </exception>
        public static Event ConstructEvent(
            string json,
            string stripeSignatureHeader,
            string secret,
            long tolerance,
            long utcNow,
            bool throwOnApiVersionMismatch = true)
        {
            ValidateSignature(json, stripeSignatureHeader, secret, tolerance, utcNow);
            return ParseEvent(json, throwOnApiVersionMismatch);
        }

        /// <summary>
        /// Verifies the authenticity (and recency) of a webhook, throwing a
        /// <see cref="StripeException"/> if there's a mismatch. Useful for quickly validating
        /// incoming webhooks before storing them for later processing (at which time you can use
        /// the <c>*WithoutVerification</c> methods for parsing).
        /// </summary>
        public static void ValidateSignature(string json, string stripeSignatureHeader, string secret, long tolerance = DefaultTimeTolerance)
        {
            ValidateSignature(json, stripeSignatureHeader, secret, tolerance, DateTimeOffset.UtcNow.ToUnixTimeSeconds());
        }

        /// <summary>
        /// Verifies the authenticity (and recency) of a webhook, throwing a
        /// <see cref="StripeException"/> if there's a mismatch. Useful for quickly validating
        /// incoming webhooks before storing them for later processing (at which time you can use
        /// the <c>*WithoutVerification</c> methods for parsing).
        /// </summary>
        public static void ValidateSignature(string json, string stripeSignatureHeader, string secret, long tolerance, long utcNow)
        {
            var signatureItems = ParseStripeSignature(stripeSignatureHeader);
            var signature = string.Empty;

            try
            {
                signature = ComputeSignature(secret, signatureItems["t"].FirstOrDefault(), json);
            }
            catch (EncoderFallbackException ex)
            {
                throw new StripeException(
                    "The webhook cannot be processed because the signature cannot be safely calculated.",
                    ex);
            }

            if (!IsSignaturePresent(signature, signatureItems["v1"]))
            {
                throw new StripeException(
                    "The expected signature was not found in the Stripe-Signature header. " +
                    "Make sure you're using the correct webhook secret (whsec_) and confirm the incoming request came from Stripe.");
            }

            var webhookUtc = Convert.ToInt32(signatureItems["t"].FirstOrDefault());

            if (Math.Abs(utcNow - webhookUtc) > tolerance)
            {
                throw new StripeException(
                    "The webhook cannot be processed because the current timestamp is outside of the allowed tolerance.");
            }
        }

        private static ILookup<string, string> ParseStripeSignature(string stripeSignatureHeader)
        {
            (string Key, string Value) ParseItem(string item)
            {
                string[] parts = item.Trim().Split(new[] { '=' }, 2);
                if (parts.Length != 2)
                {
                    throw new StripeException(
                        "The signature header format is unexpected.");
                }

                return (parts[0], parts[1]);
            }

            return stripeSignatureHeader.Trim()
                .Split(',')
                .Select(item => ParseItem(item))
                .ToLookup(item => item.Key, item => item.Value);
        }

        private static bool IsSignaturePresent(string signature, IEnumerable<string> signatures)
        {
            return signatures.Any(key => StringUtils.SecureEquals(key, signature));
        }

        internal static System.Text.Json.JsonElement MaybeExtractFromCloudProviderEnvelope(string json)
        {
            var doc = System.Text.Json.JsonDocument.Parse(json);
            var root = doc.RootElement;

            // Could add as many checks as we want here, but we'll start simple
            if (root.TryGetProperty("detail", out var detailProp))
            {
                // AWS
                // https://docs.stripe.com/event-destinations/eventbridge#event-structure
                return detailProp.Clone();
            }

            if (root.TryGetProperty("specversion", out _) &&
                root.TryGetProperty("data", out var dataProp))
            {
                // Azure
                // https://docs.stripe.com/event-destinations/eventgrid#event-structure
                return dataProp.Clone();
            }

            if (root.TryGetProperty("object", out var objProp) &&
               (objProp.GetString() == "event" || objProp.GetString() == "v2.core.event"))
            {
                return root.Clone();
            }

            throw new ArgumentException(
                "Unrecognized event format. The payload must be an "
                + "AWS EventBridge/Azure Event Grid event envelope or a Stripe webhook (thin event notification or snapshot).");
        }

        /// <summary>
        /// Constructs a <see href="https://docs.stripe.com/event-destinations#snapshot-payload">snapshot event</see>
        /// from an incoming webhook without first verifying its authenticity. Should be used after
        /// calling <see cref="ValidateSignature(string, string, string, long)"/> or with input from a trusted source (such as
        /// <see href="https://docs.stripe.com/event-destinations/eventbridge">AWS EventBridge</see>,
        /// or <see href="https://docs.stripe.com/event-destinations/eventgrid">Azure Event Grid</see>
        /// payload). Or, to verify &amp; construct in a single call, use
        /// <see cref="ConstructEvent(string, string, string, long, bool)"/> instead.
        /// </summary>
        /// <param name="json">The JSON string to parse.</param>
        /// <param name="throwOnApiVersionMismatch">
        /// If <c>true</c>, the method will throw a <see cref="StripeException"/> if the
        /// API version of the event doesn't match Stripe.net's default API version.
        /// Defaults to <c>false</c> since cloud provider payloads may not match the SDK version.
        /// </param>
        public static Event ConstructEventWithoutVerification(string json, bool throwOnApiVersionMismatch = false)
        {
            return ParseEvent(MaybeExtractFromCloudProviderEnvelope(json), throwOnApiVersionMismatch);
        }

        internal static Event DeserializeEvent(string json)
        {
            using (var doc = System.Text.Json.JsonDocument.Parse(json))
            {
                return DeserializeEvent(doc.RootElement);
            }
        }

        internal static Event DeserializeEvent(System.Text.Json.JsonElement element)
        {
            if (element.TryGetProperty("object", out var objectProp) &&
                objectProp.GetString() == "v2.core.event")
            {
                throw new ArgumentException(
                    "You passed a thin event notification to a function that expects a webhook body. Use the corresponding EventNotification method instead.");
            }

            return System.Text.Json.JsonSerializer.Deserialize<Event>(
                element.GetRawText(),
                StripeConfiguration.SerializerOptions);
        }

        /// <summary>
        /// Computes the signature for a given payload.
        /// </summary>
        /// <param name="secret">The webhook endpoint's signing secret.</param>
        /// <param name="timestamp">The timestamp of the payload.</param>
        /// <param name="payload">The payload to compute the signature for.</param>
        /// <returns>The computed signature.</returns>
        public static string ComputeSignature(string secret, string timestamp, string payload)
        {
            var secretBytes = SafeUTF8.GetBytes(secret);
            var payloadBytes = SafeUTF8.GetBytes($"{timestamp}.{payload}");

            using (var cryptographer = new HMACSHA256(secretBytes))
            {
                var hash = cryptographer.ComputeHash(payloadBytes);
                return BitConverter.ToString(hash).Replace("-", string.Empty).ToLowerInvariant();
            }
        }

        /// <summary>
        /// Compute the <c>Stripe-Signature</c> header for a given webhook body &amp; secret.
        /// Useful for signing payloads in unit tests.
        /// </summary>
        public static string GenerateSignatureHeader(string payload, string secret, long? timestamp = null)
        {
            var ts = timestamp ?? DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var signature = ComputeSignature(secret, ts.ToString(), payload);
            return $"t={ts},v1={signature}";
        }
    }
}
