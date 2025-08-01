// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Security.KeyVault.Administration.Models;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary>
    /// The KeyVaultAccessControlClient provides synchronous and asynchronous methods to view and manage Role Based Access for the Azure Key Vault.
    /// The client supports creating, listing, updating, and deleting <see cref="KeyVaultRoleAssignment"/> and <see cref="KeyVaultRoleDefinition" />.
    /// </summary>
    [CodeGenType("KeyVaultAccessControlRestClient")]
    public partial class KeyVaultAccessControlClient
    {
        private readonly ClientDiagnostics _diagnostics;

        /// <summary>
        /// Gets the vault URI.
        /// </summary>
        /// <value>The vault URI.</value>
        public virtual Uri VaultUri => _endpoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyVaultAccessControlClient"/> class for mocking.
        /// </summary>
        protected KeyVaultAccessControlClient()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyVaultAccessControlClient"/> class for the specified vault.
        /// </summary>
        /// <param name="vaultUri">A <see cref="Uri"/> to the vault on which the client operates. Appears as "DNS Name" in the Azure portal. You should validate that this URI references a valid Key Vault or Managed HSM resource. See <see href="https://aka.ms/azsdk/blog/vault-uri"/> for details.</param>
        /// <param name="credential">A <see cref="TokenCredential"/> used to authenticate requests to the vault, such as DefaultAzureCredential.</param>
        /// <exception cref="ArgumentNullException"><paramref name="vaultUri"/> or <paramref name="credential"/> is null.</exception>
        public KeyVaultAccessControlClient(Uri vaultUri, TokenCredential credential)
            : this(vaultUri, credential, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyVaultAccessControlClient"/> class for the specified vault.
        /// </summary>
        /// <param name="vaultUri">A <see cref="Uri"/> to the vault on which the client operates. Appears as "DNS Name" in the Azure portal. You should validate that this URI references a valid Key Vault or Managed HSM resource. See <see href="https://aka.ms/azsdk/blog/vault-uri"/> for details.</param>
        /// <param name="credential">A <see cref="TokenCredential"/> used to authenticate requests to the vault, such as DefaultAzureCredential.</param>
        /// <param name="options"><see cref="KeyVaultAdministrationClientOptions"/> that allow to configure the management of the request sent to Key Vault.</param>
        /// <exception cref="ArgumentNullException"><paramref name="vaultUri"/> or <paramref name="credential"/> is null.</exception>
        public KeyVaultAccessControlClient(Uri vaultUri, TokenCredential credential, KeyVaultAdministrationClientOptions options)
        {
            Argument.AssertNotNull(vaultUri, nameof(vaultUri));
            Argument.AssertNotNull(credential, nameof(credential));

            _endpoint = vaultUri;

            options ??= new KeyVaultAdministrationClientOptions();
            string apiVersion = options.GetVersionString();

            HttpPipeline pipeline = HttpPipelineBuilder.Build(options,
                    new ChallengeBasedAuthenticationPolicy(credential, options.DisableChallengeResourceVerification));

            _diagnostics = new ClientDiagnostics(options, true);
            ClientDiagnostics = _diagnostics;
            Pipeline = pipeline;
            _tokenCredential = credential;
            _endpoint = vaultUri;
            _apiVersion = apiVersion;
        }

        /// <summary>
        /// Get all role definitions that are applicable at scope and above.
        /// </summary>
        /// <param name="roleScope"> The scope of the role definitions. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="roleScope"/> is null.</exception>
        public virtual Pageable<KeyVaultRoleDefinition> GetRoleDefinitions(KeyVaultRoleScope roleScope, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(GetRoleDefinitions)}");
            scope.Start();
            try
            {
                return GetRoleDefinitions(roleScope.ToString(), cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Get all role definitions that are applicable at scope and above.
        /// </summary>
        /// <param name="roleScope"> The scope of the role definitions. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="roleScope"/> is null.</exception>
        public virtual AsyncPageable<KeyVaultRoleDefinition> GetRoleDefinitionsAsync(KeyVaultRoleScope roleScope, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(GetRoleDefinitions)}");
            scope.Start();
            try
            {
                return GetRoleDefinitionsAsync(roleScope.ToString(), cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Get a specific role definition.
        /// </summary>
        /// <param name="roleScope"> The scope of the role definition. </param>
        /// <param name="roleDefinitionName">The role definition name.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="roleScope"/> is null.</exception>
        public virtual Response<KeyVaultRoleDefinition> GetRoleDefinition(KeyVaultRoleScope roleScope, Guid roleDefinitionName, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(GetRoleDefinition)}");
            scope.Start();
            try
            {
                return GetRoleDefinition(scope: roleScope.ToString(), roleDefinitionName: roleDefinitionName.ToString(), cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Get a specific role definition.
        /// </summary>
        /// <param name="roleScope"> The scope of the role definition. </param>
        /// <param name="roleDefinitionName">The role definition name.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="roleScope"/> is null.</exception>
        public virtual async Task<Response<KeyVaultRoleDefinition>> GetRoleDefinitionAsync(KeyVaultRoleScope roleScope, Guid roleDefinitionName, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(GetRoleDefinition)}");
            scope.Start();
            try
            {
                return await GetRoleDefinitionAsync(scope: roleScope.ToString(), roleDefinitionName: roleDefinitionName.ToString(), cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a role definition. If the named role definition is already defined it will be updated.
        /// </summary>
        /// <param name="roleScope">The <see cref="KeyVaultRoleScope"/> to which the definition applies.</param>
        /// <param name="roleDefinitionName">The unique role definition name. If null a unique role definition name will be generated.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual Task<Response<KeyVaultRoleDefinition>> CreateOrUpdateRoleDefinitionAsync(KeyVaultRoleScope roleScope, Guid? roleDefinitionName = null, CancellationToken cancellationToken = default) =>
            CreateOrUpdateRoleDefinitionAsync(new CreateOrUpdateRoleDefinitionOptions(roleScope, roleDefinitionName ?? Guid.NewGuid()), cancellationToken);

        /// <summary>
        /// Creates or updates a role definition. If the named role definition is already defined it will be updated.
        /// </summary>
        /// <param name="roleScope">The <see cref="KeyVaultRoleScope"/> to which the definition applies.</param>
        /// <param name="roleDefinitionName">The unique role definition name. If null a unique role definition name will be generated.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual Response<KeyVaultRoleDefinition> CreateOrUpdateRoleDefinition(KeyVaultRoleScope roleScope, Guid? roleDefinitionName = null, CancellationToken cancellationToken = default) =>
            CreateOrUpdateRoleDefinition(new CreateOrUpdateRoleDefinitionOptions(roleScope, roleDefinitionName ?? Guid.NewGuid()), cancellationToken);

        /// <summary>
        /// Creates or updates a role definition.
        /// </summary>
        /// <param name="options">An instance of <see cref="CreateOrUpdateRoleDefinitionOptions"/> that define parameters for creating a role definition.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="options"/> is null.</exception>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual async Task<Response<KeyVaultRoleDefinition>> CreateOrUpdateRoleDefinitionAsync(CreateOrUpdateRoleDefinitionOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(CreateOrUpdateRoleDefinition)}");
            scope.Start();
            try
            {
                RoleDefinitionCreateParameters parameters = options.ToParameters(KeyVaultRoleType.CustomRole);

                return await CreateOrUpdateRoleDefinitionAsync(
                    scope: options.RoleScope != default ? options.RoleScope.ToString() : KeyVaultRoleScope.Global.ToString(),
                    roleDefinitionName: options.RoleDefinitionName.ToString(),
                    parameters: parameters,
                    cancellationToken: cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a role definition.
        /// </summary>
        /// <param name="options">An instance of <see cref="CreateOrUpdateRoleDefinitionOptions"/> that define parameters for creating a role definition.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="options"/> is null.</exception>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual Response<KeyVaultRoleDefinition> CreateOrUpdateRoleDefinition(CreateOrUpdateRoleDefinitionOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(CreateOrUpdateRoleDefinition)}");
            scope.Start();
            try
            {
                RoleDefinitionCreateParameters parameters = options.ToParameters(KeyVaultRoleType.CustomRole);

                return CreateOrUpdateRoleDefinition(
                    scope: options.RoleScope != default ? options.RoleScope.ToString() : KeyVaultRoleScope.Global.ToString(),
                    roleDefinitionName: options.RoleDefinitionName.ToString(),
                    parameters: parameters,
                    cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Deletes a role definition.
        /// </summary>
        /// <param name="roleScope">The scope of the role to delete.</param>
        /// <param name="roleDefinitionName">The name of the role definition to delete.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual async Task<Response> DeleteRoleDefinitionAsync(KeyVaultRoleScope roleScope, Guid roleDefinitionName, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(DeleteRoleDefinition)}");
            scope.Start();
            try
            {
                return (await DeleteRoleDefinitionAsync(scope: roleScope.ToString(), roleDefinitionName: roleDefinitionName.ToString(), cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (RequestFailedException ex) when (ex.Status == 404)
            {
                scope.Failed(ex);
                return ex.GetRawResponse();
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Deletes a role definition.
        /// </summary>
        /// <param name="roleScope">The scope of the role to delete.</param>
        /// <param name="roleDefinitionName">The name of the role definition to delete.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A <see cref="Response{TResult}"/> containing the result of the operation.</returns>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual Response DeleteRoleDefinition(KeyVaultRoleScope roleScope, Guid roleDefinitionName, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(DeleteRoleDefinition)}");
            scope.Start();
            try
            {
                Response<KeyVaultRoleDefinition> response = DeleteRoleDefinition(scope: roleScope.ToString(), roleDefinitionName: roleDefinitionName.ToString(), cancellationToken);
                return response.GetRawResponse();
            }
            catch (RequestFailedException ex) when (ex.Status == 404)
            {
                scope.Failed(ex);
                return ex.GetRawResponse();
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the role assignments for a scope.
        /// </summary>
        /// <param name="roleScope"> The scope of the role assignments. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="roleScope"/> is null.</exception>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual Pageable<KeyVaultRoleAssignment> GetRoleAssignments(KeyVaultRoleScope roleScope, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(GetRoleAssignments)}");
            scope.Start();
            try
            {
                return GetRoleAssignments(scope: roleScope.ToString(), cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets the role assignments for a scope.
        /// </summary>
        /// <param name="roleScope"> The scope of the role assignments. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="roleScope"/> is null.</exception>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual AsyncPageable<KeyVaultRoleAssignment> GetRoleAssignmentsAsync(KeyVaultRoleScope roleScope, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(GetRoleAssignmentsAsync)}");
            scope.Start();
            try
            {
                return GetRoleAssignmentsAsync(scope: roleScope.ToString(), cancellationToken: cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates a role assignment.
        /// </summary>
        /// <param name="roleScope">The scope of the role assignment to create.</param>
        /// <param name="roleDefinitionId">The role definition ID used in the role assignment.</param>
        /// <param name="principalId">The principal ID assigned to the role. This maps to the ID inside the Active Directory. It can point to a user, service principal, or security group.</param>
        /// <param name="roleAssignmentName">Optional name used to create the role assignment. A new <see cref="Guid"/> will be generated if not specified.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="roleDefinitionId"/> or <paramref name="principalId"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="roleDefinitionId"/> or <paramref name="principalId"/> is empty.</exception>
        /// <returns>A <see cref="Response{TResult}"/> containing the result of the operation.</returns>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual Response<KeyVaultRoleAssignment> CreateRoleAssignment(KeyVaultRoleScope roleScope, string roleDefinitionId, string principalId, Guid? roleAssignmentName = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionId, nameof(roleDefinitionId));
            Argument.AssertNotNullOrEmpty(principalId, nameof(principalId));

            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(CreateRoleAssignment)}");
            scope.Start();
            try
            {
                var _name = (roleAssignmentName ?? Guid.NewGuid()).ToString();
                var properties = new RoleAssignmentProperties(roleDefinitionId, principalId);

                var response = CreateRoleAssignment(roleScope.ToString(), _name, new RoleAssignmentCreateParameters(properties), cancellationToken);
                return Response.FromValue((KeyVaultRoleAssignment)(object)response.Value, response.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Creates a role assignment.
        /// </summary>
        /// <param name="roleScope">The scope of the role assignment to create.</param>
        /// <param name="roleDefinitionId">The role definition ID used in the role assignment.</param>
        /// <param name="principalId">The principal ID assigned to the role. This maps to the ID inside the Active Directory. It can point to a user, service principal, or security group.</param>
        /// <param name="roleAssignmentName">Optional name used to create the role assignment. A new <see cref="Guid"/> will be generated if not specified.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="roleDefinitionId"/> or <paramref name="principalId"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="roleDefinitionId"/> or <paramref name="principalId"/> is empty.</exception>
        /// <returns>A <see cref="Task{TResult}"/> containing the result of the asynchronous operation.</returns>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual async Task<Response<KeyVaultRoleAssignment>> CreateRoleAssignmentAsync(KeyVaultRoleScope roleScope, string roleDefinitionId, string principalId, Guid? roleAssignmentName = default, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleDefinitionId, nameof(roleDefinitionId));
            Argument.AssertNotNullOrEmpty(principalId, nameof(principalId));

            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(CreateRoleAssignment)}");
            scope.Start();
            try
            {
                var _name = (roleAssignmentName ?? Guid.NewGuid()).ToString();
                var properties = new RoleAssignmentProperties(roleDefinitionId, principalId);

                var response = await CreateRoleAssignmentAsync(roleScope.ToString(), _name, new RoleAssignmentCreateParameters(properties), cancellationToken)
                .ConfigureAwait(false);
                return Response.FromValue((KeyVaultRoleAssignment)(object)response.Value, response.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role assignment.
        /// </summary>
        /// <param name="roleScope"> The scope of the role assignment. </param>
        /// <param name="roleAssignmentName"> The name of the role assignment to get. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="roleAssignmentName"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="roleAssignmentName"/> is empty.</exception>
        /// <returns>A <see cref="Response{TResult}"/> containing the result of the operation.</returns>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual Response<KeyVaultRoleAssignment> GetRoleAssignment(KeyVaultRoleScope roleScope, string roleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentName, nameof(roleAssignmentName));

            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(GetRoleAssignment)}");
            scope.Start();
            try
            {
                return GetRoleAssignment(roleScope.ToString(), roleAssignmentName, cancellationToken);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role assignment.
        /// </summary>
        /// <param name="roleScope"> The scope of the role assignment. </param>
        /// <param name="roleAssignmentName"> The name of the role assignment to get. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="roleAssignmentName"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="roleAssignmentName"/> is empty.</exception>
        /// <returns>A <see cref="Task{TResult}"/> containing the result of the asynchronous operation.</returns>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual async Task<Response<KeyVaultRoleAssignment>> GetRoleAssignmentAsync(KeyVaultRoleScope roleScope, string roleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentName, nameof(roleAssignmentName));

            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(GetRoleAssignment)}");
            scope.Start();
            try
            {
                return await GetRoleAssignmentAsync(roleScope.ToString(), roleAssignmentName, cancellationToken)
                .ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Delete the specified role assignment.
        /// </summary>
        /// <param name="roleScope"> The scope of the role assignment. </param>
        /// <param name="roleAssignmentName"> The name of the role assignment to get. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="roleAssignmentName"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="roleAssignmentName"/> is empty.</exception>
        /// <returns>A <see cref="Response{TResult}"/> containing the result of the operation.</returns>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual Response DeleteRoleAssignment(KeyVaultRoleScope roleScope, string roleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentName, nameof(roleAssignmentName));

            using DiagnosticScope scope = _diagnostics.CreateScope($"{nameof(KeyVaultAccessControlClient)}.{nameof(DeleteRoleAssignment)}");
            scope.Start();
            try
            {
                Response<KeyVaultRoleAssignment> response = DeleteRoleAssignment(roleScope.ToString(), roleAssignmentName, cancellationToken);
                return response.GetRawResponse();
            }
            catch (RequestFailedException ex) when (ex.Status == 404)
            {
                scope.Failed(ex);
                return ex.GetRawResponse();
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Delete the specified role assignment.
        /// </summary>
        /// <param name="roleScope"> The scope of the role assignment. </param>
        /// <param name="roleAssignmentName"> The name of the role assignment to get. </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="roleAssignmentName"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="roleAssignmentName"/> is empty.</exception>
        /// <returns>A <see cref="Task{TResult}"/> containing the result of the asynchronous operation.</returns>
        [CallerShouldAudit(KeyVaultAdministrationClientOptions.CallerShouldAuditReason)]
        public virtual async Task<Response> DeleteRoleAssignmentAsync(KeyVaultRoleScope roleScope, string roleAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleAssignmentName, nameof(roleAssignmentName));

            using DiagnosticScope scope = _diagnostics.CreateScope(
                $"{nameof(KeyVaultAccessControlClient)}.{nameof(DeleteRoleAssignment)}");
            scope.Start();
            try
            {
                Response<KeyVaultRoleAssignment> response = await DeleteRoleAssignmentAsync(roleScope.ToString(), roleAssignmentName, cancellationToken)
                .ConfigureAwait(false);
                return response.GetRawResponse();
            }
            catch (RequestFailedException ex) when (ex.Status == 404)
            {
                scope.Failed(ex);
                return ex.GetRawResponse();
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }
    }
}
