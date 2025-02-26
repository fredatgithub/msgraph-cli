// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class IntelligenceProfileIndicator : Indicator, IParsable {
        /// <summary>Designate when an artifact was first used actively in an attack, when a particular sample was compiled, or if neither of those could be ascertained when the file was first seen in public repositories (for example, VirusTotal, ANY.RUN, Hybrid Analysis) or reported publicly.</summary>
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        /// <summary>Designate when an artifact was most recently used actively in an attack, when a particular sample was compiled, or if neither of those could be ascertained when the file was first seen in public repositories (for example, VirusTotal, ANY.RUN, Hybrid Analysis) or reported publicly.</summary>
        public DateTimeOffset? LastSeenDateTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="IntelligenceProfileIndicator"/> and sets the default values.
        /// </summary>
        public IntelligenceProfileIndicator() : base() {
            OdataType = "#microsoft.graph.security.intelligenceProfileIndicator";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="IntelligenceProfileIndicator"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IntelligenceProfileIndicator CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IntelligenceProfileIndicator();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
        }
    }
}
