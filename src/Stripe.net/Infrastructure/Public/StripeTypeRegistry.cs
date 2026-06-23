namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Reflection;

    public static class StripeTypeRegistry
    {
        /// <summary>
        /// Dictionary mapping the values contained in the `object` key of JSON payloads returned
        /// by Stripe's API to concrete types of model classes.
        /// </summary>
        public static readonly IReadOnlyDictionary<string, Type> ObjectsToTypes = new ReadOnlyDictionary<string, Type>(
            new Dictionary<string, Type>
            {
                // ObjectsToTypes: The beginning of the section generated from our OpenAPI spec
                // ObjectsToTypes: The end of the section generated from our OpenAPI spec
            });

        internal static readonly IReadOnlyDictionary<string, Type> V2ObjectsToTypes = new ReadOnlyDictionary<string, Type>(
            new Dictionary<string, Type>
            {
                // V2ObjectsToTypes: The beginning of the section generated from our OpenAPI spec
                // V2ObjectsToTypes: The end of the section generated from our OpenAPI spec
            });

        internal static readonly IReadOnlyDictionary<string, Type> V2EventsToTypes = new ReadOnlyDictionary<string, Type>(
            new Dictionary<string, Type>
            {
                // V2EventsToTypes: The beginning of the section generated from our OpenAPI spec
                // V2EventsToTypes: The end of the section generated from our OpenAPI spec
            });

        internal static readonly IReadOnlyDictionary<string, Type> V2EventNotificationsToTypes = new ReadOnlyDictionary<string, Type>(
            new Dictionary<string, Type>
            {
                // V2EventNotificationsToTypes: The beginning of the section generated from our OpenAPI spec
                // V2EventNotificationsToTypes: The end of the section generated from our OpenAPI spec
            });

        /// <summary>
        /// Returns the concrete type to use, given a potential type and the value of the `object`
        /// key in a JSON payload.
        /// </summary>
        /// <param name="potentialType">Potential type. Can be a concrete type or an interface.</param>
        /// <param name="objectValue">Value of the `object` key in the JSON payload.</param>
        /// <returns>The concrete type to use, or `null`.</returns>
        public static Type GetConcreteType(Type potentialType, string objectValue)
        {
            if (potentialType != null && !potentialType.GetTypeInfo().IsInterface)
            {
                // Potential type is already a concrete type, return it.
                return potentialType;
            }

            Type concreteType = null;

            if (!string.IsNullOrEmpty(objectValue) &&
                ObjectsToTypes.TryGetValue(objectValue, out concreteType))
            {
                // Found a concrete type matching the value of the `object` key, check if it's
                // compatible with the interface.
                if (potentialType.GetTypeInfo().IsAssignableFrom(concreteType.GetTypeInfo()))
                {
                    return concreteType;
                }
            }

            return null;
        }

        public static Type GetConcreteV2EventType(string typeValue)
        {
            Type concreteType = null;
            if (!string.IsNullOrEmpty(typeValue))
            {
                V2EventsToTypes.TryGetValue(typeValue, out concreteType);
            }

            return concreteType;
        }

        public static Type GetConcreteV2EventNotificationType(string typeValue)
        {
            Type concreteType = null;
            if (!string.IsNullOrEmpty(typeValue))
            {
                V2EventNotificationsToTypes.TryGetValue(typeValue, out concreteType);
            }

            return concreteType;
        }
    }
}
