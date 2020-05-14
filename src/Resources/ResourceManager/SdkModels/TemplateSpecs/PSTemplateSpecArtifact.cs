﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.ResourceManager.Models;

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.SdkModels
{
    public class PSTemplateSpecArtifact
    {
        public string Path { get; set; }

        protected PSTemplateSpecArtifact(TemplateSpecArtifact artifact)
        {
            this.Path = artifact.Path;
        }
    }

    public class PSTemplateSpecTemplateArtifact : PSTemplateSpecArtifact
    {
        public object Template { get; set; }

        protected PSTemplateSpecTemplateArtifact(
            TemplateSpecTemplateArtifact artifact
            ) : base(artifact)
        {
            this.Template = artifact.Template;
        }

        internal static PSTemplateSpecTemplateArtifact FromAzureSDKTemplateSpecTemplateArtifact(
            TemplateSpecTemplateArtifact artifact)
        {
            return artifact != null 
                ? new PSTemplateSpecTemplateArtifact(artifact)
                : null;
        }
    }
}
