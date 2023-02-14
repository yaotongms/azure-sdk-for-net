using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace TryDynamicJson
{
    /// <summary> A mock client for trying DynamicJson. </summary>
    public partial class MockClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://example.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of MockClient. </summary>
        /// <param name="endpoint"> endpoint - server parameter. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public MockClient(Uri endpoint, TokenCredential credential, MockClientOptions options)
        {
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Get a value. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        public virtual async Task<Response> GetValueAsync(RequestContext context = null)
        {
            using HttpMessage message = CreateGetValueRequest(context);
            return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
        }

        /// <summary> Get a value. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        public virtual Response GetValue(RequestContext context = null)
        {
            using HttpMessage message = CreateGetValueRequest(context);
            return _pipeline.ProcessMessage(message, context);
        }

        /// <summary> Set a value. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        public virtual async Task<Response> SetValueAsync(RequestContent content, RequestContext context = null)
        {
            using HttpMessage message = CreateSetValueRequest(content, context);
            return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
        }

        /// <summary> Set a value. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        public virtual Response SetValue(RequestContent content, RequestContext context = null)
        {
            using HttpMessage message = CreateSetValueRequest(content, context);
            return _pipeline.ProcessMessage(message, context);
        }

        internal HttpMessage CreateGetValueRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            request.Uri = new RequestUriBuilder();
            request.Uri.Reset(_endpoint);
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateSetValueRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            request.Uri = new RequestUriBuilder();
            request.Uri.Reset(_endpoint);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
