using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using ApiSdk.ServicePrincipals.Item.OwnedObjects.Count;
using ApiSdk.ServicePrincipals.Item.OwnedObjects.Item;
using ApiSdk.ServicePrincipals.Item.OwnedObjects.MicrosoftGraphApplication;
using ApiSdk.ServicePrincipals.Item.OwnedObjects.MicrosoftGraphAppRoleAssignment;
using ApiSdk.ServicePrincipals.Item.OwnedObjects.MicrosoftGraphEndpoint;
using ApiSdk.ServicePrincipals.Item.OwnedObjects.MicrosoftGraphGroup;
using ApiSdk.ServicePrincipals.Item.OwnedObjects.MicrosoftGraphServicePrincipal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.ServicePrincipals.Item.OwnedObjects {
    /// <summary>
    /// Provides operations to manage the ownedObjects property of the microsoft.graph.servicePrincipal entity.
    /// </summary>
    public class OwnedObjectsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the ownedObjects property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        public Command BuildCommand() {
            var command = new Command("item");
            var builder = new DirectoryObjectItemRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildMicrosoftGraphApplicationCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAppRoleAssignmentCommand());
            command.AddCommand(builder.BuildMicrosoftGraphEndpointCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGroupCommand());
            command.AddCommand(builder.BuildMicrosoftGraphServicePrincipalCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to count the resources in the collection.
        /// </summary>
        public Command BuildCountCommand() {
            var command = new Command("count");
            command.Description = "Provides operations to count the resources in the collection.";
            var builder = new CountRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Directory objects that are owned by this service principal. Read-only. Nullable. Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).
        /// </summary>
        public Command BuildListCommand() {
            var command = new Command("list");
            command.Description = "Directory objects that are owned by this service principal. Read-only. Nullable. Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).";
            // Create options for all the parameters
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "key: id of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
            var topOption = new Option<int?>("--top", description: "Show only the first n items") {
            };
            topOption.IsRequired = false;
            command.AddOption(topOption);
            var skipOption = new Option<int?>("--skip", description: "Skip the first n items") {
            };
            skipOption.IsRequired = false;
            command.AddOption(skipOption);
            var searchOption = new Option<string>("--search", description: "Search items by search phrases") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values") {
            };
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            var countOption = new Option<bool?>("--count", description: "Include count of items") {
            };
            countOption.IsRequired = false;
            command.AddOption(countOption);
            var orderbyOption = new Option<string[]>("--orderby", description: "Order items by property values") {
                Arity = ArgumentArity.ZeroOrMore
            };
            orderbyOption.IsRequired = false;
            command.AddOption(orderbyOption);
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
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            var allOption = new Option<bool>("--all");
            command.AddOption(allOption);
            command.SetHandler(async (invocationContext) => {
                var servicePrincipalId = invocationContext.ParseResult.GetValueForOption(servicePrincipalIdOption);
                var top = invocationContext.ParseResult.GetValueForOption(topOption);
                var skip = invocationContext.ParseResult.GetValueForOption(skipOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var filter = invocationContext.ParseResult.GetValueForOption(filterOption);
                var count = invocationContext.ParseResult.GetValueForOption(countOption);
                var orderby = invocationContext.ParseResult.GetValueForOption(orderbyOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                var all = invocationContext.ParseResult.GetValueForOption(allOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                IPagingService pagingService = invocationContext.BindingContext.GetRequiredService<IPagingService>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Top = top;
                    q.QueryParameters.Skip = skip;
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    if (!string.IsNullOrEmpty(filter)) q.QueryParameters.Filter = filter;
                    q.QueryParameters.Count = count;
                    q.QueryParameters.Orderby = orderby;
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (servicePrincipalId is not null) requestInfo.PathParameters.Add("servicePrincipal%2Did", servicePrincipalId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var pagingData = new PageLinkData(requestInfo, null, itemName: "value", nextLinkName: "@odata.nextLink");
                var pageResponse = await pagingService.GetPagedDataAsync((info, token) => RequestAdapter.SendNoContentAsync(info, cancellationToken: token), pagingData, all, cancellationToken);
                var response = pageResponse?.Response;
                IOutputFormatterOptions? formatterOptions = null;
                IOutputFormatter? formatter = null;
                if (pageResponse?.StatusCode >= 200 && pageResponse?.StatusCode < 300) {
                    formatter = outputFormatterFactory.GetFormatter(output);
                    response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                    formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                } else {
                    formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                }
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Casts the previous resource to application.
        /// </summary>
        public Command BuildMicrosoftGraphApplicationCommand() {
            var command = new Command("microsoft-graph-application");
            command.Description = "Casts the previous resource to application.";
            var builder = new ApplicationRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to appRoleAssignment.
        /// </summary>
        public Command BuildMicrosoftGraphAppRoleAssignmentCommand() {
            var command = new Command("microsoft-graph-app-role-assignment");
            command.Description = "Casts the previous resource to appRoleAssignment.";
            var builder = new AppRoleAssignmentRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to endpoint.
        /// </summary>
        public Command BuildMicrosoftGraphEndpointCommand() {
            var command = new Command("microsoft-graph-endpoint");
            command.Description = "Casts the previous resource to endpoint.";
            var builder = new EndpointRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to group.
        /// </summary>
        public Command BuildMicrosoftGraphGroupCommand() {
            var command = new Command("microsoft-graph-group");
            command.Description = "Casts the previous resource to group.";
            var builder = new GroupRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Casts the previous resource to servicePrincipal.
        /// </summary>
        public Command BuildMicrosoftGraphServicePrincipalCommand() {
            var command = new Command("microsoft-graph-service-principal");
            command.Description = "Casts the previous resource to servicePrincipal.";
            var builder = new ServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new OwnedObjectsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OwnedObjectsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/ownedObjects{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Directory objects that are owned by this service principal. Read-only. Nullable. Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<OwnedObjectsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<OwnedObjectsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new OwnedObjectsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Directory objects that are owned by this service principal. Read-only. Nullable. Supports $expand and $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1).
        /// </summary>
        public class OwnedObjectsRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class OwnedObjectsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public OwnedObjectsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new OwnedObjectsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new ownedObjectsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public OwnedObjectsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
