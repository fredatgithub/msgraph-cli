// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ItemRetentionLabel : Entity, IParsable {
        /// <summary>Specifies whether the label is applied explicitly on the item. True indicates that the label is applied explicitly; otherwise, the label is inherited from its parent. Read-only.</summary>
        public bool? IsLabelAppliedExplicitly { get; set; }
        /// <summary>Identity of the user who applied the label. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LabelAppliedBy { get; set; }
#nullable restore
#else
        public IdentitySet LabelAppliedBy { get; set; }
#endif
        /// <summary>The date and time when the label was applied on the item. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? LabelAppliedDateTime { get; set; }
        /// <summary>The retention label on the document. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The retention settings enforced on the item. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RetentionLabelSettings? RetentionSettings { get; set; }
#nullable restore
#else
        public RetentionLabelSettings RetentionSettings { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="ItemRetentionLabel"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ItemRetentionLabel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemRetentionLabel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isLabelAppliedExplicitly", n => { IsLabelAppliedExplicitly = n.GetBoolValue(); } },
                {"labelAppliedBy", n => { LabelAppliedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"labelAppliedDateTime", n => { LabelAppliedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"retentionSettings", n => { RetentionSettings = n.GetObjectValue<RetentionLabelSettings>(RetentionLabelSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isLabelAppliedExplicitly", IsLabelAppliedExplicitly);
            writer.WriteObjectValue<IdentitySet>("labelAppliedBy", LabelAppliedBy);
            writer.WriteDateTimeOffsetValue("labelAppliedDateTime", LabelAppliedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<RetentionLabelSettings>("retentionSettings", RetentionSettings);
        }
    }
}
