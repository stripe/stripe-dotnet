namespace Stripe
{
    using System;

    public class ExpandableField<T> : IExpandableField<T>
        where T : IHasId
    {
        private string id;

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

        public T ExpandedObject { get; set; }

        object IExpandableField.ExpandedObject
        {
            get => this.ExpandedObject;
            set => this.ExpandedObject = (T)value;
        }

        bool IExpandableField.IsExpanded => this.ExpandedObject != null;
    }
}
