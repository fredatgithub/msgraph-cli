// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// Represents an icon for an app on the Home Screen
    /// </summary>
    public class IosHomeScreenApp : IosHomeScreenItem, IParsable {
        /// <summary>BundleID of the app if isWebClip is false or the URL of a web clip if isWebClip is true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BundleID { get; set; }
#nullable restore
#else
        public string BundleID { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="IosHomeScreenApp"/> and sets the default values.
        /// </summary>
        public IosHomeScreenApp() : base() {
            OdataType = "#microsoft.graph.iosHomeScreenApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="IosHomeScreenApp"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosHomeScreenApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosHomeScreenApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bundleID", n => { BundleID = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("bundleID", BundleID);
        }
    }
}
