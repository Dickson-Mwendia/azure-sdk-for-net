// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A Class representing a DisasterRecovery along with the instance operations that can be performed on it. </summary>
    public partial class DisasterRecovery : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DisasterRecovery"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string alias)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _disasterRecoveryConfigsRestClient;
        private readonly DisasterRecoveryData _data;

        /// <summary> Initializes a new instance of the <see cref="DisasterRecovery"/> class for mocking. </summary>
        protected DisasterRecovery()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DisasterRecovery"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DisasterRecovery(ArmResource options, DisasterRecoveryData data) : base(options, data.Id)
        {
            HasData = true;
            _data = data;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _disasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="DisasterRecovery"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DisasterRecovery(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _disasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="DisasterRecovery"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DisasterRecovery(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _disasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DisasterRecoveryData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DisasterRecovery>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DisasterRecovery.Get");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DisasterRecovery(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DisasterRecovery> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DisasterRecovery.Get");
            scope.Start();
            try
            {
                var response = _disasterRecoveryConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DisasterRecovery(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DisasterRecovery.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DisasterRecovery.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an Alias(Disaster Recovery configuration). </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<DisasterRecoveryConfigDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DisasterRecovery.Delete");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryConfigsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DisasterRecoveryConfigDeleteOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an Alias(Disaster Recovery configuration). </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DisasterRecoveryConfigDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DisasterRecovery.Delete");
            scope.Start();
            try
            {
                var response = _disasterRecoveryConfigsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DisasterRecoveryConfigDeleteOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation disables the Disaster Recovery and stops replicating changes from primary to secondary namespaces. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> BreakPairingAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DisasterRecovery.BreakPairing");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryConfigsRestClient.BreakPairingAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation disables the Disaster Recovery and stops replicating changes from primary to secondary namespaces. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response BreakPairing(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DisasterRecovery.BreakPairing");
            scope.Start();
            try
            {
                var response = _disasterRecoveryConfigsRestClient.BreakPairing(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Invokes GEO DR failover and reconfigure the alias to point to the secondary namespace. </summary>
        /// <param name="parameters"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> FailOverAsync(FailoverProperties parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DisasterRecovery.FailOver");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryConfigsRestClient.FailOverAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Invokes GEO DR failover and reconfigure the alias to point to the secondary namespace. </summary>
        /// <param name="parameters"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response FailOver(FailoverProperties parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DisasterRecovery.FailOver");
            scope.Start();
            try
            {
                var response = _disasterRecoveryConfigsRestClient.FailOver(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #region NamespaceDisasterRecoveryConfigAuthorizationRule

        /// <summary> Gets a collection of NamespaceDisasterRecoveryConfigAuthorizationRules in the DisasterRecovery. </summary>
        /// <returns> An object representing collection of NamespaceDisasterRecoveryConfigAuthorizationRules and their operations over a DisasterRecovery. </returns>
        public virtual NamespaceDisasterRecoveryConfigAuthorizationRuleCollection GetNamespaceDisasterRecoveryConfigAuthorizationRules()
        {
            return new NamespaceDisasterRecoveryConfigAuthorizationRuleCollection(this);
        }
        #endregion
    }
}
