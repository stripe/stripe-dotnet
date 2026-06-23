namespace Stripe
{
    internal enum BaseAddress
    {
        /// <summary>
        /// Send the request to the API host, for example, api.stripe.com.
        /// </summary>
        Api,

        /// <summary>
        /// Send the request to the files host, for example, files.stripe.com.
        /// </summary>
        Files,

        /// <summary>
        /// Send the request to the connect host, for example, connect.stripe.com.
        /// </summary>
        Connect,

        /// <summary>
        /// Send the request to the meter events host, for example, meter-events.stripe.com.
        /// </summary>
        MeterEvents,
    }
}
