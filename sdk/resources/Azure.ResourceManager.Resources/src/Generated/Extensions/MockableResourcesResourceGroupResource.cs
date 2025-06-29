// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableResourcesResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableResourcesResourceGroupResource"/> class for mocking. </summary>
        protected MockableResourcesResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableResourcesResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableResourcesResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of TemplateSpecResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of TemplateSpecResources and their operations over a TemplateSpecResource. </returns>
        public virtual TemplateSpecCollection GetTemplateSpecs()
        {
            return GetCachedClient(client => new TemplateSpecCollection(client, Id));
        }

        /// <summary>
        /// Gets a Template Spec with a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Resources/templateSpecs/{templateSpecName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TemplateSpecResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="expand"> Allows for expansion of additional Template Spec details in the response. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="templateSpecName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TemplateSpecResource>> GetTemplateSpecAsync(string templateSpecName, TemplateSpecExpandKind? expand = null, CancellationToken cancellationToken = default)
        {
            return await GetTemplateSpecs().GetAsync(templateSpecName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Template Spec with a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Resources/templateSpecs/{templateSpecName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TemplateSpecResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="expand"> Allows for expansion of additional Template Spec details in the response. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="templateSpecName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="templateSpecName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TemplateSpecResource> GetTemplateSpec(string templateSpecName, TemplateSpecExpandKind? expand = null, CancellationToken cancellationToken = default)
        {
            return GetTemplateSpecs().Get(templateSpecName, expand, cancellationToken);
        }

        /// <summary> Gets a collection of ArmDeploymentScriptResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ArmDeploymentScriptResources and their operations over a ArmDeploymentScriptResource. </returns>
        public virtual ArmDeploymentScriptCollection GetArmDeploymentScripts()
        {
            return GetCachedClient(client => new ArmDeploymentScriptCollection(client, Id));
        }

        /// <summary>
        /// Gets a deployment script with a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts/{scriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentScripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ArmDeploymentScriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ArmDeploymentScriptResource>> GetArmDeploymentScriptAsync(string scriptName, CancellationToken cancellationToken = default)
        {
            return await GetArmDeploymentScripts().GetAsync(scriptName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a deployment script with a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Resources/deploymentScripts/{scriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentScripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ArmDeploymentScriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="scriptName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ArmDeploymentScriptResource> GetArmDeploymentScript(string scriptName, CancellationToken cancellationToken = default)
        {
            return GetArmDeploymentScripts().Get(scriptName, cancellationToken);
        }

        /// <summary> Gets a collection of ArmDeploymentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ArmDeploymentResources and their operations over a ArmDeploymentResource. </returns>
        public virtual ArmDeploymentCollection GetArmDeployments()
        {
            return GetCachedClient(client => new ArmDeploymentCollection(client, Id));
        }

        /// <summary>
        /// Gets a deployment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Resources/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_GetAtScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ArmDeploymentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ArmDeploymentResource>> GetArmDeploymentAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            return await GetArmDeployments().GetAsync(deploymentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a deployment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Resources/deployments/{deploymentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_GetAtScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ArmDeploymentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ArmDeploymentResource> GetArmDeployment(string deploymentName, CancellationToken cancellationToken = default)
        {
            return GetArmDeployments().Get(deploymentName, cancellationToken);
        }

        /// <summary> Gets a collection of ArmApplicationResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ArmApplicationResources and their operations over a ArmApplicationResource. </returns>
        public virtual ArmApplicationCollection GetArmApplications()
        {
            return GetCachedClient(client => new ArmApplicationCollection(client, Id));
        }

        /// <summary>
        /// Gets the managed application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ArmApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ArmApplicationResource>> GetArmApplicationAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            return await GetArmApplications().GetAsync(applicationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the managed application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ArmApplicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="applicationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ArmApplicationResource> GetArmApplication(string applicationName, CancellationToken cancellationToken = default)
        {
            return GetArmApplications().Get(applicationName, cancellationToken);
        }

        /// <summary> Gets a collection of ArmApplicationDefinitionResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ArmApplicationDefinitionResources and their operations over a ArmApplicationDefinitionResource. </returns>
        public virtual ArmApplicationDefinitionCollection GetArmApplicationDefinitions()
        {
            return GetCachedClient(client => new ArmApplicationDefinitionCollection(client, Id));
        }

        /// <summary>
        /// Gets the managed application definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applicationDefinitions/{applicationDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ArmApplicationDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationDefinitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="applicationDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ArmApplicationDefinitionResource>> GetArmApplicationDefinitionAsync(string applicationDefinitionName, CancellationToken cancellationToken = default)
        {
            return await GetArmApplicationDefinitions().GetAsync(applicationDefinitionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the managed application definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/applicationDefinitions/{applicationDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ArmApplicationDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationDefinitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="applicationDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ArmApplicationDefinitionResource> GetArmApplicationDefinition(string applicationDefinitionName, CancellationToken cancellationToken = default)
        {
            return GetArmApplicationDefinitions().Get(applicationDefinitionName, cancellationToken);
        }

        /// <summary> Gets a collection of JitRequestResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of JitRequestResources and their operations over a JitRequestResource. </returns>
        public virtual JitRequestCollection GetJitRequests()
        {
            return GetCachedClient(client => new JitRequestCollection(client, Id));
        }

        /// <summary>
        /// Gets the JIT request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JitRequests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JitRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<JitRequestResource>> GetJitRequestAsync(string jitRequestName, CancellationToken cancellationToken = default)
        {
            return await GetJitRequests().GetAsync(jitRequestName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the JIT request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Solutions/jitRequests/{jitRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JitRequests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="JitRequestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jitRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<JitRequestResource> GetJitRequest(string jitRequestName, CancellationToken cancellationToken = default)
        {
            return GetJitRequests().Get(jitRequestName, cancellationToken);
        }

        /// <summary> Gets a collection of DeploymentStackResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DeploymentStackResources and their operations over a DeploymentStackResource. </returns>
        public virtual DeploymentStackCollection GetDeploymentStacks()
        {
            return GetCachedClient(client => new DeploymentStackCollection(client, Id));
        }

        /// <summary>
        /// Gets a Deployment stack with a given name at specific scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Resources/deploymentStacks/{deploymentStackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentStacks_GetAtScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeploymentStackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentStackName"> Name of the deployment stack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentStackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentStackName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DeploymentStackResource>> GetDeploymentStackAsync(string deploymentStackName, CancellationToken cancellationToken = default)
        {
            return await GetDeploymentStacks().GetAsync(deploymentStackName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Deployment stack with a given name at specific scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Resources/deploymentStacks/{deploymentStackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentStacks_GetAtScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeploymentStackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentStackName"> Name of the deployment stack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentStackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="deploymentStackName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DeploymentStackResource> GetDeploymentStack(string deploymentStackName, CancellationToken cancellationToken = default)
        {
            return GetDeploymentStacks().Get(deploymentStackName, cancellationToken);
        }
    }
}
