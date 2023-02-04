using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Sites.Item.Analytics;
using ApiSdk.Sites.Item.Columns;
using ApiSdk.Sites.Item.ContentTypes;
using ApiSdk.Sites.Item.Drive;
using ApiSdk.Sites.Item.Drives;
using ApiSdk.Sites.Item.ExternalColumns;
using ApiSdk.Sites.Item.Items;
using ApiSdk.Sites.Item.Lists;
using ApiSdk.Sites.Item.MicrosoftGraphGetActivitiesByInterval;
using ApiSdk.Sites.Item.MicrosoftGraphGetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using ApiSdk.Sites.Item.MicrosoftGraphGetApplicableContentTypesForListWithListId;
using ApiSdk.Sites.Item.MicrosoftGraphGetByPathWithPath;
using ApiSdk.Sites.Item.Onenote;
using ApiSdk.Sites.Item.Operations;
using ApiSdk.Sites.Item.Permissions;
using ApiSdk.Sites.Item.Sites;
using ApiSdk.Sites.Item.TermStore;
using ApiSdk.Sites.Item.TermStores;
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
namespace ApiSdk.Sites.Item {
    /// <summary>
    /// Provides operations to manage the collection of site entities.
    /// </summary>
    public class SiteItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the analytics property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildAnalyticsCommand() {
            var command = new Command("analytics");
            command.Description = "Provides operations to manage the analytics property of the microsoft.graph.site entity.";
            var builder = new AnalyticsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the columns property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildColumnsCommand() {
            var command = new Command("columns");
            command.Description = "Provides operations to manage the columns property of the microsoft.graph.site entity.";
            var builder = new ColumnsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the contentTypes property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildContentTypesCommand() {
            var command = new Command("content-types");
            command.Description = "Provides operations to manage the contentTypes property of the microsoft.graph.site entity.";
            var builder = new ContentTypesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAddCopyCommand());
            command.AddCommand(builder.BuildMicrosoftGraphAddCopyFromContentTypeHubCommand());
            command.AddCommand(builder.BuildMicrosoftGraphGetCompatibleHubContentTypesCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the drive property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildDriveCommand() {
            var command = new Command("drive");
            command.Description = "Provides operations to manage the drive property of the microsoft.graph.site entity.";
            var builder = new DriveRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the drives property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildDrivesCommand() {
            var command = new Command("drives");
            command.Description = "Provides operations to manage the drives property of the microsoft.graph.site entity.";
            var builder = new DrivesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the externalColumns property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildExternalColumnsCommand() {
            var command = new Command("external-columns");
            command.Description = "Provides operations to manage the externalColumns property of the microsoft.graph.site entity.";
            var builder = new ExternalColumnsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Retrieve properties and relationships for a [site][] resource.A **site** resource represents a team site in SharePoint.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/site-get?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Retrieve properties and relationships for a [site][] resource.A **site** resource represents a team site in SharePoint.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/site-get?view=graph-rest-1.0";
            // Create options for all the parameters
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
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
            command.SetHandler(async (invocationContext) => {
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the items property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildItemsCommand() {
            var command = new Command("items");
            command.Description = "Provides operations to manage the items property of the microsoft.graph.site entity.";
            var builder = new ItemsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the lists property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildListsCommand() {
            var command = new Command("lists");
            command.Description = "Provides operations to manage the lists property of the microsoft.graph.site entity.";
            var builder = new ListsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        public Command BuildMicrosoftGraphGetActivitiesByIntervalCommand() {
            var command = new Command("microsoft-graph-get-activities-by-interval");
            command.Description = "Provides operations to call the getActivitiesByInterval method.";
            var builder = new GetActivitiesByIntervalRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the onenote property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildOnenoteCommand() {
            var command = new Command("onenote");
            command.Description = "Provides operations to manage the onenote property of the microsoft.graph.site entity.";
            var builder = new OnenoteRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildNotebooksCommand());
            command.AddCommand(builder.BuildOperationsCommand());
            command.AddCommand(builder.BuildPagesCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildResourcesCommand());
            command.AddCommand(builder.BuildSectionGroupsCommand());
            command.AddCommand(builder.BuildSectionsCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the operations property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildOperationsCommand() {
            var command = new Command("operations");
            command.Description = "Provides operations to manage the operations property of the microsoft.graph.site entity.";
            var builder = new OperationsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update entity in sites
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update entity in sites";
            // Create options for all the parameters
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
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
            command.SetHandler(async (invocationContext) => {
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Models.Site>(ApiSdk.Models.Site.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the permissions property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildPermissionsCommand() {
            var command = new Command("permissions");
            command.Description = "Provides operations to manage the permissions property of the microsoft.graph.site entity.";
            var builder = new PermissionsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the sites property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildSitesCommand() {
            var command = new Command("sites");
            command.Description = "Provides operations to manage the sites property of the microsoft.graph.site entity.";
            var builder = new ApiSdk.Sites.Item.Sites.SitesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the termStore property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildTermStoreCommand() {
            var command = new Command("term-store");
            command.Description = "Provides operations to manage the termStore property of the microsoft.graph.site entity.";
            var builder = new TermStoreRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildDeleteCommand());
            command.AddCommand(builder.BuildGetCommand());
            command.AddCommand(builder.BuildGroupsCommand());
            command.AddCommand(builder.BuildPatchCommand());
            command.AddCommand(builder.BuildSetsCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the termStores property of the microsoft.graph.site entity.
        /// </summary>
        public Command BuildTermStoresCommand() {
            var command = new Command("term-stores");
            command.Description = "Provides operations to manage the termStores property of the microsoft.graph.site entity.";
            var builder = new TermStoresRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new SiteItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SiteItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/sites/{site%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="interval">Usage: interval=&apos;{interval}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        public GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder MicrosoftGraphGetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval(string endDateTime, string interval, string startDateTime) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(interval)) throw new ArgumentNullException(nameof(interval));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters, RequestAdapter, endDateTime, interval, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getApplicableContentTypesForList method.
        /// </summary>
        /// <param name="listId">Usage: listId=&apos;{listId}&apos;</param>
        public GetApplicableContentTypesForListWithListIdRequestBuilder MicrosoftGraphGetApplicableContentTypesForListWithListId(string listId) {
            if(string.IsNullOrEmpty(listId)) throw new ArgumentNullException(nameof(listId));
            return new GetApplicableContentTypesForListWithListIdRequestBuilder(PathParameters, RequestAdapter, listId);
        }
        /// <summary>
        /// Provides operations to call the getByPath method.
        /// </summary>
        /// <param name="path">Usage: path=&apos;{path}&apos;</param>
        public GetByPathWithPathRequestBuilder MicrosoftGraphGetByPathWithPath(string path) {
            if(string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));
            return new GetByPathWithPathRequestBuilder(PathParameters, RequestAdapter, path);
        }
        /// <summary>
        /// Retrieve properties and relationships for a [site][] resource.A **site** resource represents a team site in SharePoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<SiteItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<SiteItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new SiteItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update entity in sites
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Site body, Action<SiteItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Site body, Action<SiteItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new SiteItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Retrieve properties and relationships for a [site][] resource.A **site** resource represents a team site in SharePoint.
        /// </summary>
        public class SiteItemRequestBuilderGetQueryParameters {
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
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SiteItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public SiteItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new SiteItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new SiteItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public SiteItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SiteItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new SiteItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public SiteItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
