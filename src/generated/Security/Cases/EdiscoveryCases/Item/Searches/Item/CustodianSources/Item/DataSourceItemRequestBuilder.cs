// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models.Security;
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
namespace ApiSdk.Security.Cases.EdiscoveryCases.Item.Searches.Item.CustodianSources.Item {
    /// <summary>
    /// Provides operations to manage the custodianSources property of the microsoft.graph.security.ediscoverySearch entity.
    /// </summary>
    public class DataSourceItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Custodian sources that are included in the eDiscovery search.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Custodian sources that are included in the eDiscovery search.";
            var ediscoveryCaseIdOption = new Option<string>("--ediscovery-case-id", description: "The unique identifier of ediscoveryCase") {
            };
            ediscoveryCaseIdOption.IsRequired = true;
            command.AddOption(ediscoveryCaseIdOption);
            var ediscoverySearchIdOption = new Option<string>("--ediscovery-search-id", description: "The unique identifier of ediscoverySearch") {
            };
            ediscoverySearchIdOption.IsRequired = true;
            command.AddOption(ediscoverySearchIdOption);
            var dataSourceIdOption = new Option<string>("--data-source-id", description: "The unique identifier of dataSource") {
            };
            dataSourceIdOption.IsRequired = true;
            command.AddOption(dataSourceIdOption);
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
                var ediscoveryCaseId = invocationContext.ParseResult.GetValueForOption(ediscoveryCaseIdOption);
                var ediscoverySearchId = invocationContext.ParseResult.GetValueForOption(ediscoverySearchIdOption);
                var dataSourceId = invocationContext.ParseResult.GetValueForOption(dataSourceIdOption);
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
                if (ediscoveryCaseId is not null) requestInfo.PathParameters.Add("ediscoveryCase%2Did", ediscoveryCaseId);
                if (ediscoverySearchId is not null) requestInfo.PathParameters.Add("ediscoverySearch%2Did", ediscoverySearchId);
                if (dataSourceId is not null) requestInfo.PathParameters.Add("dataSource%2Did", dataSourceId);
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
        /// Instantiates a new <see cref="DataSourceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DataSourceItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/searches/{ediscoverySearch%2Did}/custodianSources/{dataSource%2Did}{?%24expand,%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="DataSourceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DataSourceItemRequestBuilder(string rawUrl) : base("{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/searches/{ediscoverySearch%2Did}/custodianSources/{dataSource%2Did}{?%24expand,%24select}", rawUrl) {
        }
        /// <summary>
        /// Custodian sources that are included in the eDiscovery search.
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DataSourceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DataSourceItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Custodian sources that are included in the eDiscovery search.
        /// </summary>
        public class DataSourceItemRequestBuilderGetQueryParameters {
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
