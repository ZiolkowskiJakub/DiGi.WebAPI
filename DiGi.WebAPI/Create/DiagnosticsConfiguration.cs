using DiGi.Core.Classes;
using DiGi.WebAPI.Classes;
using System;

namespace DiGi.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a new <see cref="DiagnosticsConfiguration"/> instance by loading settings from a configuration file or environment variables.
        /// <para>Fails closed: when no configuration can be resolved the returned instance carries no key and denies every protected request.</para>
        /// </summary>
        /// <param name="path">Optional explicit path to the configuration file.</param>
        /// <returns>A configured <see cref="DiagnosticsConfiguration"/> instance.</returns>
        public static DiagnosticsConfiguration DiagnosticsConfiguration(string? path = null)
        {
            string? resolvedPath = null;

            if (!string.IsNullOrWhiteSpace(path) && System.IO.File.Exists(path))
            {
                resolvedPath = path;
            }
            else
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                string candidatePath1 = System.IO.Path.Combine(baseDirectory, Constants.FileName.WebAPI_Diagnostics);
                string candidatePath2 = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), Constants.FileName.WebAPI_Diagnostics);

                if (System.IO.File.Exists(candidatePath1))
                {
                    resolvedPath = candidatePath1;
                }
                else if (System.IO.File.Exists(candidatePath2))
                {
                    resolvedPath = candidatePath2;
                }
            }

            if (!string.IsNullOrWhiteSpace(resolvedPath) && System.IO.File.Exists(resolvedPath))
            {
                ConfigurationFile configurationFile = new();
                if (configurationFile.Read(resolvedPath))
                {
                    string? key = configurationFile.GetValue<string>(nameof(Classes.DiagnosticsConfiguration.Key));
                    bool enabled = configurationFile.GetValue<bool>(nameof(Classes.DiagnosticsConfiguration.Enabled), defaultValue: !string.IsNullOrWhiteSpace(key));
                    bool open = configurationFile.GetValue<bool>(nameof(Classes.DiagnosticsConfiguration.Open), defaultValue: false);

                    if (open)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Diagnostics: {FileName} sets Open=true - protected diagnostic endpoints are reachable WITHOUT a key. Never use this on a deployed host.", Constants.FileName.WebAPI_Diagnostics);
                    }
                    else if (!enabled || string.IsNullOrWhiteSpace(key))
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Diagnostics: {FileName} carries no usable key (Enabled={Enabled}) - protected diagnostic endpoints will answer 401.", Constants.FileName.WebAPI_Diagnostics, enabled);
                    }

                    return new DiagnosticsConfiguration(key, enabled, open);
                }

                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Diagnostics: {Path} could not be read - protected diagnostic endpoints will answer 401.", resolvedPath);
            }

            string? envKey = Environment.GetEnvironmentVariable("DIGI_DIAGNOSTICS_KEY");
            if (!string.IsNullOrWhiteSpace(envKey))
            {
                return new DiagnosticsConfiguration(envKey, enabled: true);
            }

            Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "Diagnostics: no {FileName} and no DIGI_DIAGNOSTICS_KEY found - protected diagnostic endpoints will answer 401.", Constants.FileName.WebAPI_Diagnostics);

            return new DiagnosticsConfiguration(null, enabled: true);
        }
    }
}
