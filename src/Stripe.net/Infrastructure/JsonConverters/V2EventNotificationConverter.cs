namespace Stripe.Infrastructure
{
    using System;

    /// <summary>
    /// This converter deserializes Stripe thin events, which are polymorphic and discriminated by the value
    /// of a property named "type".
    /// </summary>
    internal class V2EventNotificationConverter : V2EventConverter
    {
        private Type GetCongreteType(string typeValue)
        {
            return StripeTypeRegistry.GetConcreteV2EventNotificationType(typeValue) ?? typeof(V2.EventNotification);
        }
    }
}
