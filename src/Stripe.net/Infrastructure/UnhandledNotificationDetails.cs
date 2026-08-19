namespace Stripe
{
    /// <summary>
    /// EventArgs for Stripe webhook event notifications.
    /// Contains the strongly-typed EventNotification and the StripeClient instance.
    /// </summary>
    public class UnhandledNotificationDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledNotificationDetails"/> class.
        /// </summary>
        public UnhandledNotificationDetails(bool isKnownEventType)
        {
            this.IsKnownEventType = isKnownEventType;
        }

        /// <summary>
        /// Gets the StripeClient instance that can be used to make API requests.
        /// </summary>
        public bool IsKnownEventType { get; }
    }
}
