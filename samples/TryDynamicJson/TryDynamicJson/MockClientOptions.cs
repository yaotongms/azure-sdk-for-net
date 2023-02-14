using Azure.Core;

namespace TryDynamicJson
{
    /// <summary> Client options for MockClient. </summary>
    public partial class MockClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V1_0;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "1.0". </summary>
            V1_0 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of MockClientOptions. </summary>
        public MockClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V1_0 => "1.0",
                _ => throw new NotSupportedException()
            };
        }
    }
}
