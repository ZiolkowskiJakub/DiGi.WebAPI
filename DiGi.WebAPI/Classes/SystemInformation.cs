using DiGi.WebAPI.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.WebAPI.Classes
{
    /// <summary>
    /// Holds host system, environment, memory, and thread pool diagnostic information.
    /// </summary>
    public class SystemInformation : Core.Classes.SerializableObject, IWebAPISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(EnvironmentName))]
        private readonly string? environmentName;

        [JsonInclude, JsonPropertyName(nameof(GCCollectionsGen0))]
        private readonly int gcCollectionsGen0;

        [JsonInclude, JsonPropertyName(nameof(GCCollectionsGen1))]
        private readonly int gcCollectionsGen1;

        [JsonInclude, JsonPropertyName(nameof(GCCollectionsGen2))]
        private readonly int gcCollectionsGen2;

        [JsonInclude, JsonPropertyName(nameof(GCTotalMemoryBytes))]
        private readonly long gcTotalMemoryBytes;

        [JsonInclude, JsonPropertyName(nameof(MemoryPrivateBytes))]
        private readonly long memoryPrivateBytes;

        [JsonInclude, JsonPropertyName(nameof(MemoryWorkingSetBytes))]
        private readonly long memoryWorkingSetBytes;

        [JsonInclude, JsonPropertyName(nameof(OSVersion))]
        private readonly string? osVersion;

        [JsonInclude, JsonPropertyName(nameof(ProcessArchitecture))]
        private readonly string? processArchitecture;

        [JsonInclude, JsonPropertyName(nameof(ProcessorCount))]
        private readonly int processorCount;

        [JsonInclude, JsonPropertyName(nameof(ThreadPoolAvailableCompletionPortThreads))]
        private readonly int threadPoolAvailableCompletionPortThreads;

        [JsonInclude, JsonPropertyName(nameof(ThreadPoolAvailableWorkerThreads))]
        private readonly int threadPoolAvailableWorkerThreads;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInformation"/> class.
        /// </summary>
        /// <param name="environmentName">The ASP.NET Core environment name.</param>
        /// <param name="osVersion">The host operating system description.</param>
        /// <param name="processArchitecture">The process architecture (e.g. X64, Arm64).</param>
        /// <param name="processorCount">The number of logical processors.</param>
        /// <param name="memoryWorkingSetBytes">The process working set in bytes.</param>
        /// <param name="memoryPrivateBytes">The private memory allocation in bytes.</param>
        /// <param name="gcTotalMemoryBytes">The GC allocated heap memory in bytes.</param>
        /// <param name="gcCollectionsGen0">The count of Gen 0 garbage collections.</param>
        /// <param name="gcCollectionsGen1">The count of Gen 1 garbage collections.</param>
        /// <param name="gcCollectionsGen2">The count of Gen 2 garbage collections.</param>
        /// <param name="threadPoolAvailableWorkerThreads">The count of available worker threads in the thread pool.</param>
        /// <param name="threadPoolAvailableCompletionPortThreads">The count of available asynchronous I/O completion threads in the thread pool.</param>
        public SystemInformation(string? environmentName, string? osVersion, string? processArchitecture, int processorCount, long memoryWorkingSetBytes, long memoryPrivateBytes, long gcTotalMemoryBytes, int gcCollectionsGen0, int gcCollectionsGen1, int gcCollectionsGen2, int threadPoolAvailableWorkerThreads, int threadPoolAvailableCompletionPortThreads)
            : base()
        {
            this.environmentName = environmentName;
            this.osVersion = osVersion;
            this.processArchitecture = processArchitecture;
            this.processorCount = processorCount;
            this.memoryWorkingSetBytes = memoryWorkingSetBytes;
            this.memoryPrivateBytes = memoryPrivateBytes;
            this.gcTotalMemoryBytes = gcTotalMemoryBytes;
            this.gcCollectionsGen0 = gcCollectionsGen0;
            this.gcCollectionsGen1 = gcCollectionsGen1;
            this.gcCollectionsGen2 = gcCollectionsGen2;
            this.threadPoolAvailableWorkerThreads = threadPoolAvailableWorkerThreads;
            this.threadPoolAvailableCompletionPortThreads = threadPoolAvailableCompletionPortThreads;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInformation"/> class by copying from another instance.
        /// </summary>
        /// <param name="systemInformation">The <see cref="SystemInformation"/> to copy from.</param>
        public SystemInformation(SystemInformation? systemInformation)
            : base(systemInformation)
        {
            if (systemInformation is not null)
            {
                environmentName = systemInformation.environmentName;
                osVersion = systemInformation.osVersion;
                processArchitecture = systemInformation.processArchitecture;
                processorCount = systemInformation.processorCount;
                memoryWorkingSetBytes = systemInformation.memoryWorkingSetBytes;
                memoryPrivateBytes = systemInformation.memoryPrivateBytes;
                gcTotalMemoryBytes = systemInformation.gcTotalMemoryBytes;
                gcCollectionsGen0 = systemInformation.gcCollectionsGen0;
                gcCollectionsGen1 = systemInformation.gcCollectionsGen1;
                gcCollectionsGen2 = systemInformation.gcCollectionsGen2;
                threadPoolAvailableWorkerThreads = systemInformation.threadPoolAvailableWorkerThreads;
                threadPoolAvailableCompletionPortThreads = systemInformation.threadPoolAvailableCompletionPortThreads;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInformation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from.</param>
        public SystemInformation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the ASP.NET Core environment name.
        /// </summary>
        [JsonIgnore]
        public string? EnvironmentName
        {
            get
            {
                return environmentName;
            }
        }

        /// <summary>
        /// Gets the count of Gen 0 garbage collections.
        /// </summary>
        [JsonIgnore]
        public int GCCollectionsGen0
        {
            get
            {
                return gcCollectionsGen0;
            }
        }

        /// <summary>
        /// Gets the count of Gen 1 garbage collections.
        /// </summary>
        [JsonIgnore]
        public int GCCollectionsGen1
        {
            get
            {
                return gcCollectionsGen1;
            }
        }

        /// <summary>
        /// Gets the count of Gen 2 garbage collections.
        /// </summary>
        [JsonIgnore]
        public int GCCollectionsGen2
        {
            get
            {
                return gcCollectionsGen2;
            }
        }

        /// <summary>
        /// Gets the GC allocated heap memory in bytes.
        /// </summary>
        [JsonIgnore]
        public long GCTotalMemoryBytes
        {
            get
            {
                return gcTotalMemoryBytes;
            }
        }

        /// <summary>
        /// Gets the private memory allocation in bytes.
        /// </summary>
        [JsonIgnore]
        public long MemoryPrivateBytes
        {
            get
            {
                return memoryPrivateBytes;
            }
        }

        /// <summary>
        /// Gets the process working set in bytes.
        /// </summary>
        [JsonIgnore]
        public long MemoryWorkingSetBytes
        {
            get
            {
                return memoryWorkingSetBytes;
            }
        }

        /// <summary>
        /// Gets the host operating system description.
        /// </summary>
        [JsonIgnore]
        public string? OSVersion
        {
            get
            {
                return osVersion;
            }
        }

        /// <summary>
        /// Gets the process architecture (e.g. X64, Arm64).
        /// </summary>
        [JsonIgnore]
        public string? ProcessArchitecture
        {
            get
            {
                return processArchitecture;
            }
        }

        /// <summary>
        /// Gets the number of logical processors.
        /// </summary>
        [JsonIgnore]
        public int ProcessorCount
        {
            get
            {
                return processorCount;
            }
        }

        /// <summary>
        /// Gets the count of available asynchronous I/O completion threads in the thread pool.
        /// </summary>
        [JsonIgnore]
        public int ThreadPoolAvailableCompletionPortThreads
        {
            get
            {
                return threadPoolAvailableCompletionPortThreads;
            }
        }

        /// <summary>
        /// Gets the count of available worker threads in the thread pool.
        /// </summary>
        [JsonIgnore]
        public int ThreadPoolAvailableWorkerThreads
        {
            get
            {
                return threadPoolAvailableWorkerThreads;
            }
        }
    }
}
