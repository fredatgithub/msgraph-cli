// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.InformationProtection.Bitlocker.RecoveryKeys.Item {
    /// <summary>
    /// Provides operations to manage the recoveryKeys property of the microsoft.graph.bitlocker entity.
    /// </summary>
    public class BitlockerRecoveryKeyItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Retrieve the properties and relationships of a bitlockerRecoveryKey object.  By default, this operation doesn&apos;t return the key property that represents the actual recovery key. To include the key property in the response, use the $select OData query parameter. Including the $select query parameter triggers a Microsoft Entra audit of the operation and generates an audit log. For more information on audit logs for bitlocker recovery keys, see the KeyManagement category filter of Microsoft Entra audit logs.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/bitlockerrecoverykey-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Retrieve the properties and relationships of a bitlockerRecoveryKey object.  By default, this operation doesn't return the key property that represents the actual recovery key. To include the key property in the response, use the $select OData query parameter. Including the $select query parameter triggers a Microsoft Entra audit of the operation and generates an audit log. For more information on audit logs for bitlocker recovery keys, see the KeyManagement category filter of Microsoft Entra audit logs.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/bitlockerrecoverykey-get?view=graph-rest-1.0";
            var bitlockerRecoveryKeyIdOption = new Option<string>("--bitlocker-recovery-key-id", description: "The unique identifier of bitlockerRecoveryKey") {
            };
            bitlockerRecoveryKeyIdOption.IsRequired = true;
            command.AddOption(bitlockerRecoveryKeyIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var bitlockerRecoveryKeyId = invocationContext.ParseResult.GetValueForOption(bitlockerRecoveryKeyIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (bitlockerRecoveryKeyId is not null) requestInfo.PathParameters.Add("bitlockerRecoveryKey%2Did", bitlockerRecoveryKeyId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="BitlockerRecoveryKeyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public BitlockerRecoveryKeyItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/informationProtection/bitlocker/recoveryKeys/{bitlockerRecoveryKey%2Did}{?%24expand,%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="BitlockerRecoveryKeyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public BitlockerRecoveryKeyItemRequestBuilder(string rawUrl) : base("{+baseurl}/informationProtection/bitlocker/recoveryKeys/{bitlockerRecoveryKey%2Did}{?%24expand,%24select}", rawUrl) {
        }
        /// <summary>
        /// Retrieve the properties and relationships of a bitlockerRecoveryKey object.  By default, this operation doesn&apos;t return the key property that represents the actual recovery key. To include the key property in the response, use the $select OData query parameter. Including the $select query parameter triggers a Microsoft Entra audit of the operation and generates an audit log. For more information on audit logs for bitlocker recovery keys, see the KeyManagement category filter of Microsoft Entra audit logs.
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<BitlockerRecoveryKeyItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<BitlockerRecoveryKeyItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the properties and relationships of a bitlockerRecoveryKey object.  By default, this operation doesn&apos;t return the key property that represents the actual recovery key. To include the key property in the response, use the $select OData query parameter. Including the $select query parameter triggers a Microsoft Entra audit of the operation and generates an audit log. For more information on audit logs for bitlocker recovery keys, see the KeyManagement category filter of Microsoft Entra audit logs.
        /// </summary>
        public class BitlockerRecoveryKeyItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
    }
}
