// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class ThreatIntelligence : ApiSdk.Models.Entity, IParsable {
        /// <summary>Refers to indicators of threat or compromise highlighted in an article.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ArticleIndicator>? ArticleIndicators { get; set; }
#nullable restore
#else
        public List<ArticleIndicator> ArticleIndicators { get; set; }
#endif
        /// <summary>A list of article objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Article>? Articles { get; set; }
#nullable restore
#else
        public List<Article> Articles { get; set; }
#endif
        /// <summary>Retrieve details about hostComponent objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostComponent>? HostComponents { get; set; }
#nullable restore
#else
        public List<HostComponent> HostComponents { get; set; }
#endif
        /// <summary>Retrieve details about hostCookie objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostCookie>? HostCookies { get; set; }
#nullable restore
#else
        public List<HostCookie> HostCookies { get; set; }
#endif
        /// <summary>Retrieve details about hostTracker objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostPair>? HostPairs { get; set; }
#nullable restore
#else
        public List<HostPair> HostPairs { get; set; }
#endif
        /// <summary>Retrieve details about hostPort objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostPort>? HostPorts { get; set; }
#nullable restore
#else
        public List<HostPort> HostPorts { get; set; }
#endif
        /// <summary>Refers to host objects that Microsoft Threat Intelligence has observed.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Host>? Hosts { get; set; }
#nullable restore
#else
        public List<Host> Hosts { get; set; }
#endif
        /// <summary>Retrieve details about hostSslCertificate objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostSslCertificate>? HostSslCertificates { get; set; }
#nullable restore
#else
        public List<HostSslCertificate> HostSslCertificates { get; set; }
#endif
        /// <summary>Retrieve details about hostTracker objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostTracker>? HostTrackers { get; set; }
#nullable restore
#else
        public List<HostTracker> HostTrackers { get; set; }
#endif
        /// <summary>The intelligenceProfileIndicators property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IntelligenceProfileIndicator>? IntelligenceProfileIndicators { get; set; }
#nullable restore
#else
        public List<IntelligenceProfileIndicator> IntelligenceProfileIndicators { get; set; }
#endif
        /// <summary>A list of intelligenceProfile objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IntelligenceProfile>? IntelProfiles { get; set; }
#nullable restore
#else
        public List<IntelligenceProfile> IntelProfiles { get; set; }
#endif
        /// <summary>Retrieve details about passiveDnsRecord objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PassiveDnsRecord>? PassiveDnsRecords { get; set; }
#nullable restore
#else
        public List<PassiveDnsRecord> PassiveDnsRecords { get; set; }
#endif
        /// <summary>Retrieve details about sslCertificate objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SslCertificate>? SslCertificates { get; set; }
#nullable restore
#else
        public List<SslCertificate> SslCertificates { get; set; }
#endif
        /// <summary>Retrieve details about the subdomain.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Subdomain>? Subdomains { get; set; }
#nullable restore
#else
        public List<Subdomain> Subdomains { get; set; }
#endif
        /// <summary>Retrieve details about vulnerabilities.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Vulnerability>? Vulnerabilities { get; set; }
#nullable restore
#else
        public List<Vulnerability> Vulnerabilities { get; set; }
#endif
        /// <summary>Retrieve details about whoisHistoryRecord objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WhoisHistoryRecord>? WhoisHistoryRecords { get; set; }
#nullable restore
#else
        public List<WhoisHistoryRecord> WhoisHistoryRecords { get; set; }
#endif
        /// <summary>A list of whoisRecord objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WhoisRecord>? WhoisRecords { get; set; }
#nullable restore
#else
        public List<WhoisRecord> WhoisRecords { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <cref="ThreatIntelligence"></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ThreatIntelligence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ThreatIntelligence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A <cref="IDictionary<string, Action<IParseNode>>"></returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"articleIndicators", n => { ArticleIndicators = n.GetCollectionOfObjectValues<ArticleIndicator>(ArticleIndicator.CreateFromDiscriminatorValue)?.ToList(); } },
                {"articles", n => { Articles = n.GetCollectionOfObjectValues<Article>(Article.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostComponents", n => { HostComponents = n.GetCollectionOfObjectValues<HostComponent>(HostComponent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostCookies", n => { HostCookies = n.GetCollectionOfObjectValues<HostCookie>(HostCookie.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostPairs", n => { HostPairs = n.GetCollectionOfObjectValues<HostPair>(HostPair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostPorts", n => { HostPorts = n.GetCollectionOfObjectValues<HostPort>(HostPort.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostSslCertificates", n => { HostSslCertificates = n.GetCollectionOfObjectValues<HostSslCertificate>(HostSslCertificate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostTrackers", n => { HostTrackers = n.GetCollectionOfObjectValues<HostTracker>(HostTracker.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hosts", n => { Hosts = n.GetCollectionOfObjectValues<Host>(Host.CreateFromDiscriminatorValue)?.ToList(); } },
                {"intelProfiles", n => { IntelProfiles = n.GetCollectionOfObjectValues<IntelligenceProfile>(IntelligenceProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"intelligenceProfileIndicators", n => { IntelligenceProfileIndicators = n.GetCollectionOfObjectValues<IntelligenceProfileIndicator>(IntelligenceProfileIndicator.CreateFromDiscriminatorValue)?.ToList(); } },
                {"passiveDnsRecords", n => { PassiveDnsRecords = n.GetCollectionOfObjectValues<PassiveDnsRecord>(PassiveDnsRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sslCertificates", n => { SslCertificates = n.GetCollectionOfObjectValues<SslCertificate>(SslCertificate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"subdomains", n => { Subdomains = n.GetCollectionOfObjectValues<Subdomain>(Subdomain.CreateFromDiscriminatorValue)?.ToList(); } },
                {"vulnerabilities", n => { Vulnerabilities = n.GetCollectionOfObjectValues<Vulnerability>(Vulnerability.CreateFromDiscriminatorValue)?.ToList(); } },
                {"whoisHistoryRecords", n => { WhoisHistoryRecords = n.GetCollectionOfObjectValues<WhoisHistoryRecord>(WhoisHistoryRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                {"whoisRecords", n => { WhoisRecords = n.GetCollectionOfObjectValues<WhoisRecord>(WhoisRecord.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ArticleIndicator>("articleIndicators", ArticleIndicators);
            writer.WriteCollectionOfObjectValues<Article>("articles", Articles);
            writer.WriteCollectionOfObjectValues<HostComponent>("hostComponents", HostComponents);
            writer.WriteCollectionOfObjectValues<HostCookie>("hostCookies", HostCookies);
            writer.WriteCollectionOfObjectValues<HostPair>("hostPairs", HostPairs);
            writer.WriteCollectionOfObjectValues<HostPort>("hostPorts", HostPorts);
            writer.WriteCollectionOfObjectValues<Host>("hosts", Hosts);
            writer.WriteCollectionOfObjectValues<HostSslCertificate>("hostSslCertificates", HostSslCertificates);
            writer.WriteCollectionOfObjectValues<HostTracker>("hostTrackers", HostTrackers);
            writer.WriteCollectionOfObjectValues<IntelligenceProfileIndicator>("intelligenceProfileIndicators", IntelligenceProfileIndicators);
            writer.WriteCollectionOfObjectValues<IntelligenceProfile>("intelProfiles", IntelProfiles);
            writer.WriteCollectionOfObjectValues<PassiveDnsRecord>("passiveDnsRecords", PassiveDnsRecords);
            writer.WriteCollectionOfObjectValues<SslCertificate>("sslCertificates", SslCertificates);
            writer.WriteCollectionOfObjectValues<Subdomain>("subdomains", Subdomains);
            writer.WriteCollectionOfObjectValues<Vulnerability>("vulnerabilities", Vulnerabilities);
            writer.WriteCollectionOfObjectValues<WhoisHistoryRecord>("whoisHistoryRecords", WhoisHistoryRecords);
            writer.WriteCollectionOfObjectValues<WhoisRecord>("whoisRecords", WhoisRecords);
        }
    }
}
