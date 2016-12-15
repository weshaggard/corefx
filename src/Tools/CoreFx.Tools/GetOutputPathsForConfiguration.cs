// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Microsoft.DotNet.Build.Tasks
{
    public class GetOutputPathsForConfiguration : ConfigurationTask
    {
        [Required]
        public string[] BuildConfiguration { get; set; }

        [Required]
        public string[] ProjectBuildConfigurations { get; set; }

        [Required]
        public string ProjectConfigurationBuilding { get; set; }

        public string[] PropertiesToInclude { get; set; }

        public bool DoNotAllowCompatibleValues { get; set; }

        [Output]
        public string[] BuildConfigurationRelativePaths { get; set; }

        public override bool Execute()
        {
            LoadConfiguration();

            if (ProjectBuildConfigurations == null)
                ProjectBuildConfigurations = new string[0];

            var supportedProjectConfigurations = new HashSet<Configuration>(
                ProjectBuildConfigurations.Where(c => !string.IsNullOrWhiteSpace(c)).Select(c => ConfigurationFactory.ParseConfiguration(c)),
                Configuration.CompatibleComparer);

            List<string> outputPaths = new List<string>();

            var projectConfigurationBeingBuilt = ConfigurationFactory.ParseConfiguration(ProjectConfigurationBuilding);

            foreach (var buildConfig in BuildConfiguration)
            {
                var buildConfiguration = ConfigurationFactory.ParseConfiguration(buildConfig);

                var compatibleConfigurations = ConfigurationFactory.GetCompatibleConfigurations(buildConfiguration, DoNotAllowCompatibleValues);
                var bestConfiguration = compatibleConfigurations.FirstOrDefault(c => supportedProjectConfigurations.Contains(c));

                // If there are no supported configurations given assume it is compatible with all. 
                if (projectConfigurationBeingBuilt.Equals(bestConfiguration) || supportedProjectConfigurations.Count == 0)
                {
                    outputPaths.Add(buildConfiguration.GetConfigurationStringsForProperties(PropertiesToInclude));
                }
            }

            BuildConfigurationRelativePaths = outputPaths.ToArray();

            return !Log.HasLoggedErrors;
        }
    }
}

