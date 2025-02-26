// <auto-generated/>
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.Analytics;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.Columns;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.ContentTypes;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.CreatedByUser;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.Drive;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.Drives;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.ExternalColumns;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.GetActivitiesByInterval;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.GetApplicableContentTypesForListWithListId;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.Items;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.LastModifiedByUser;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.Lists;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.Onenote;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.Operations;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.Permissions;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.Sites;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.TermStore;
using ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.TermStores;
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
namespace ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath {
    /// <summary>
    /// Provides operations to call the getByPath method.
    /// </summary>
    public class GetByPathWithPathRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the analytics property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildAnalyticsNavCommand() {
            var command = new Command("analytics");
            command.Description = "Provides operations to manage the analytics property of the microsoft.graph.site entity.";
            var builder = new AnalyticsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the columns property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildColumnsNavCommand() {
            var command = new Command("columns");
            command.Description = "Provides operations to manage the columns property of the microsoft.graph.site entity.";
            var builder = new ColumnsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the contentTypes property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildContentTypesNavCommand() {
            var command = new Command("content-types");
            command.Description = "Provides operations to manage the contentTypes property of the microsoft.graph.site entity.";
            var builder = new ContentTypesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildCreatedByUserNavCommand() {
            var command = new Command("created-by-user");
            command.Description = "Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.";
            var builder = new CreatedByUserRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the drive property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildDriveNavCommand() {
            var command = new Command("drive");
            command.Description = "Provides operations to manage the drive property of the microsoft.graph.site entity.";
            var builder = new DriveRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the drives property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildDrivesNavCommand() {
            var command = new Command("drives");
            command.Description = "Provides operations to manage the drives property of the microsoft.graph.site entity.";
            var builder = new DrivesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the externalColumns property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildExternalColumnsNavCommand() {
            var command = new Command("external-columns");
            command.Description = "Provides operations to manage the externalColumns property of the microsoft.graph.site entity.";
            var builder = new ExternalColumnsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetActivitiesByIntervalNavCommand() {
            var command = new Command("get-activities-by-interval");
            command.Description = "Provides operations to call the getActivitiesByInterval method.";
            var builder = new GetActivitiesByIntervalRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRbCommand() {
            var command = new Command("get-activities-by-interval-with-start-date-time-with-end-date-time-with-interval");
            command.Description = "Provides operations to call the getActivitiesByInterval method.";
            var builder = new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getApplicableContentTypesForList method.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetApplicableContentTypesForListWithListIdRbCommand() {
            var command = new Command("get-applicable-content-types-for-list-with-list-id");
            command.Description = "Provides operations to call the getApplicableContentTypesForList method.";
            var builder = new GetApplicableContentTypesForListWithListIdRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getByPath method.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetByPathWithPath1RbCommand() {
            var command = new Command("get-by-path-with-path1");
            command.Description = "Provides operations to call the getByPath method.";
            var builder = new GetByPathWithPath1RequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAnalyticsNavCommand());
            nonExecCommands.Add(builder.BuildColumnsNavCommand());
            nonExecCommands.Add(builder.BuildContentTypesNavCommand());
            nonExecCommands.Add(builder.BuildCreatedByUserNavCommand());
            nonExecCommands.Add(builder.BuildDriveNavCommand());
            nonExecCommands.Add(builder.BuildDrivesNavCommand());
            nonExecCommands.Add(builder.BuildExternalColumnsNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildItemsNavCommand());
            nonExecCommands.Add(builder.BuildLastModifiedByUserNavCommand());
            nonExecCommands.Add(builder.BuildListsNavCommand());
            nonExecCommands.Add(builder.BuildOnenoteNavCommand());
            nonExecCommands.Add(builder.BuildOperationsNavCommand());
            nonExecCommands.Add(builder.BuildPermissionsNavCommand());
            nonExecCommands.Add(builder.BuildSitesNavCommand());
            nonExecCommands.Add(builder.BuildTermStoreNavCommand());
            nonExecCommands.Add(builder.BuildTermStoresNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Invoke function getByPath
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function getByPath";
            var groupIdOption = new Option<string>("--group-id", description: "The unique identifier of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var siteIdOption = new Option<string>("--site-id", description: "The unique identifier of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var pathOption = new Option<string>("--path", description: "Usage: path='{path}'") {
            };
            pathOption.IsRequired = true;
            command.AddOption(pathOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var groupId = invocationContext.ParseResult.GetValueForOption(groupIdOption);
                var siteId = invocationContext.ParseResult.GetValueForOption(siteIdOption);
                var path = invocationContext.ParseResult.GetValueForOption(pathOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (groupId is not null) requestInfo.PathParameters.Add("group%2Did", groupId);
                if (siteId is not null) requestInfo.PathParameters.Add("site%2Did", siteId);
                if (path is not null) requestInfo.PathParameters.Add("path", path);
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
        /// Provides operations to manage the items property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildItemsNavCommand() {
            var command = new Command("items");
            command.Description = "Provides operations to manage the items property of the microsoft.graph.site entity.";
            var builder = new ItemsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildLastModifiedByUserNavCommand() {
            var command = new Command("last-modified-by-user");
            command.Description = "Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.";
            var builder = new LastModifiedByUserRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the lists property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildListsNavCommand() {
            var command = new Command("lists");
            command.Description = "Provides operations to manage the lists property of the microsoft.graph.site entity.";
            var builder = new ListsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the onenote property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildOnenoteNavCommand() {
            var command = new Command("onenote");
            command.Description = "Provides operations to manage the onenote property of the microsoft.graph.site entity.";
            var builder = new OnenoteRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the operations property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildOperationsNavCommand() {
            var command = new Command("operations");
            command.Description = "Provides operations to manage the operations property of the microsoft.graph.site entity.";
            var builder = new OperationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the permissions property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildPermissionsNavCommand() {
            var command = new Command("permissions");
            command.Description = "Provides operations to manage the permissions property of the microsoft.graph.site entity.";
            var builder = new PermissionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the sites property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildSitesNavCommand() {
            var command = new Command("sites");
            command.Description = "Provides operations to manage the sites property of the microsoft.graph.site entity.";
            var builder = new ApiSdk.Groups.Item.Sites.Item.GetByPathWithPath.Sites.SitesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the termStore property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildTermStoreNavCommand() {
            var command = new Command("term-store");
            command.Description = "Provides operations to manage the termStore property of the microsoft.graph.site entity.";
            var builder = new TermStoreRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the termStores property of the microsoft.graph.site entity.
        /// </summary>
        /// <returns>A <cref="Command"></returns>
        public Command BuildTermStoresNavCommand() {
            var command = new Command("term-stores");
            command.Description = "Provides operations to manage the termStores property of the microsoft.graph.site entity.";
            var builder = new TermStoresRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new <see cref="GetByPathWithPathRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public GetByPathWithPathRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/getByPath(path='{path}')", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="GetByPathWithPathRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GetByPathWithPathRequestBuilder(string rawUrl) : base("{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/getByPath(path='{path}')", rawUrl) {
        }
        /// <summary>
        /// Invoke function getByPath
        /// </summary>
        /// <returns>A <cref="RequestInformation"></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
