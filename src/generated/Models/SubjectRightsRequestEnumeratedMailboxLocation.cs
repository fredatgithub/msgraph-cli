// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SubjectRightsRequestEnumeratedMailboxLocation : SubjectRightsRequestMailboxLocation, IParsable {
        /// <summary>Collection of mailboxes that should be included in the search. Includes the user principal name (UPN) of each mailbox, for example, Monica.Thompson@contoso.com.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UserPrincipalNames { get; set; }
#nullable restore
#else
        public List<string> UserPrincipalNames { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SubjectRightsRequestEnumeratedMailboxLocation"/> and sets the default values.
        /// </summary>
        public SubjectRightsRequestEnumeratedMailboxLocation() : base() {
            OdataType = "#microsoft.graph.subjectRightsRequestEnumeratedMailboxLocation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="SubjectRightsRequestEnumeratedMailboxLocation"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SubjectRightsRequestEnumeratedMailboxLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequestEnumeratedMailboxLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"userPrincipalNames", n => { UserPrincipalNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("userPrincipalNames", UserPrincipalNames);
        }
    }
}
