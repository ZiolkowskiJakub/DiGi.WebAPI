using DiGi.WebAPI.Classes;
using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace DiGi.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a new <see cref="SystemInformation"/> instance containing host runtime, memory, and thread pool telemetry.
        /// </summary>
        /// <param name="hostEnvironment">Optional ASP.NET Core host environment.</param>
        /// <returns>A new <see cref="SystemInformation"/> instance.</returns>
        public static SystemInformation SystemInformation(IHostEnvironment? hostEnvironment = null)
        {
            string environmentName = hostEnvironment?.EnvironmentName ?? Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";
            string osVersion = RuntimeInformation.OSDescription;
            string processArchitecture = RuntimeInformation.ProcessArchitecture.ToString();
            int processorCount = Environment.ProcessorCount;

            long memoryWorkingSetBytes;
            long memoryPrivateBytes;

            try
            {
                using Process process = Process.GetCurrentProcess();
                memoryWorkingSetBytes = process.WorkingSet64;
                memoryPrivateBytes = process.PrivateMemorySize64;
            }
            catch
            {
                memoryWorkingSetBytes = Environment.WorkingSet;
                memoryPrivateBytes = 0;
            }

            long gcTotalMemoryBytes = GC.GetTotalMemory(false);
            int gcCollectionsGen0 = GC.CollectionCount(0);
            int gcCollectionsGen1 = GC.CollectionCount(1);
            int gcCollectionsGen2 = GC.CollectionCount(2);

            ThreadPool.GetAvailableThreads(out int workerThreads, out int completionPortThreads);

            return new SystemInformation(environmentName, osVersion, processArchitecture, processorCount, memoryWorkingSetBytes, memoryPrivateBytes, gcTotalMemoryBytes, gcCollectionsGen0, gcCollectionsGen1, gcCollectionsGen2, workerThreads, completionPortThreads);
        }
    }
}
