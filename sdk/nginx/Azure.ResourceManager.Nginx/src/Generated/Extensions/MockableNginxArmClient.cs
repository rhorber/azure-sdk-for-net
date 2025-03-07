// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Nginx.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableNginxArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableNginxArmClient"/> class for mocking. </summary>
        protected MockableNginxArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableNginxArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableNginxArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableNginxArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="NginxDeploymentApiKeyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NginxDeploymentApiKeyResource.CreateResourceIdentifier" /> to create a <see cref="NginxDeploymentApiKeyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NginxDeploymentApiKeyResource"/> object. </returns>
        public virtual NginxDeploymentApiKeyResource GetNginxDeploymentApiKeyResource(ResourceIdentifier id)
        {
            NginxDeploymentApiKeyResource.ValidateResourceId(id);
            return new NginxDeploymentApiKeyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NginxCertificateResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NginxCertificateResource.CreateResourceIdentifier" /> to create a <see cref="NginxCertificateResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NginxCertificateResource"/> object. </returns>
        public virtual NginxCertificateResource GetNginxCertificateResource(ResourceIdentifier id)
        {
            NginxCertificateResource.ValidateResourceId(id);
            return new NginxCertificateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NginxConfigurationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NginxConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="NginxConfigurationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NginxConfigurationResource"/> object. </returns>
        public virtual NginxConfigurationResource GetNginxConfigurationResource(ResourceIdentifier id)
        {
            NginxConfigurationResource.ValidateResourceId(id);
            return new NginxConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="NginxDeploymentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NginxDeploymentResource.CreateResourceIdentifier" /> to create a <see cref="NginxDeploymentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NginxDeploymentResource"/> object. </returns>
        public virtual NginxDeploymentResource GetNginxDeploymentResource(ResourceIdentifier id)
        {
            NginxDeploymentResource.ValidateResourceId(id);
            return new NginxDeploymentResource(Client, id);
        }
    }
}
