using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Stripe
{
    /// <summary>
    /// An enum describing the reason for a failed redirect.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StripeRedirectFailureReason
    {
        /// <summary>
        /// Indicates that the authentication failed or the transaction was declined.
        /// </summary>
        [EnumMember(Value = "declined")]
        Declined,

        /// <summary>
        /// Indicates that the redirect failed due to a technical error.
        /// </summary>
        [EnumMember(Value = "processing_error")]
        ProcessingError,

        /// <summary>
        /// Indicates that the user aborted or dropped out of the redirect flow.
        /// </summary>
        [EnumMember(Value = "user_abort")]
        UserAbort,
    }
}
