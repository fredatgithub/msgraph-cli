using ApiSdk.Models.ODataErrors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Me.ManagedDevices.Item.DisableLostMode {
    /// <summary>
    /// Provides operations to call the disableLostMode method.
    /// </summary>
    public class DisableLostModeRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Disable lost mode
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Disable lost mode";
            // Create options for all the parameters
            var managedDeviceIdOption = new Option<string>("--managed-device-id", description: "The unique identifier of managedDevice") {
            };
            managedDeviceIdOption.IsRequired = true;
            command.AddOption(managedDeviceIdOption);
            command.SetHandler(async (invocationContext) => {
                var managedDeviceId = invocationContext.ParseResult.GetValueForOption(managedDeviceIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (managedDeviceId is not null) requestInfo.PathParameters.Add("managedDevice%2Did", managedDeviceId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new DisableLostModeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DisableLostModeRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/me/managedDevices/{managedDevice%2Did}/disableLostMode";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Disable lost mode
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<DisableLostModeRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<DisableLostModeRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new DisableLostModeRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DisableLostModeRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new disableLostModeRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public DisableLostModeRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
