namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>Represents a generic expandable field.</summary>
    /// <typeparam name="T">Type of the field when expanded.</typeparam>
    public class ExpandableField<T> : IExpandableField<T>
        where T : IHasId
    {
        private string id;
        private T expandedObject;

        /// <summary>Gets or sets the ID.</summary>
        /// <value>The ID.</value>
        /// <exception cref="InvalidOperationException">
        /// Trying to set <see cref="Id"/> when <see cref="ExpandedObject"/> is already set.
        /// </exception>
        public string Id
        {
            get => this.ExpandedObject?.Id ?? this.id;
            set
            {
                if (this.ExpandedObject != null)
                {
                    throw new InvalidOperationException("Cannot set Id when ExpandedObject is already set.");
                }

                this.id = value;
            }
        }

        /// <summary>Gets or sets the expanded object.</summary>
        /// <value>The expanded object.</value>
        public T ExpandedObject
        {
            get => this.expandedObject;
            set => this.expandedObject = value;
        }

        object IExpandableField.ExpandedObject
        {
            get => this.ExpandedObject;
            set => this.ExpandedObject = (T)value;
        }

        bool IExpandableField.IsExpanded => this.expandedObject != null;
    }
}
