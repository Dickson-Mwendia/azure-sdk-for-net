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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a StaticSiteCustomDomainOverviewARMResource along with the instance operations that can be performed on it. </summary>
    public partial class StaticSiteCustomDomainOverviewARMResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StaticSiteCustomDomainOverviewARMResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string domainName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly StaticSitesRestOperations _staticSitesRestClient;
        private readonly StaticSiteCustomDomainOverviewARMResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteCustomDomainOverviewARMResource"/> class for mocking. </summary>
        protected StaticSiteCustomDomainOverviewARMResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StaticSiteCustomDomainOverviewARMResource"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StaticSiteCustomDomainOverviewARMResource(ArmResource options, StaticSiteCustomDomainOverviewARMResourceData data) : base(options, data.Id)
        {
            HasData = true;
            _data = data;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _staticSitesRestClient = new StaticSitesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteCustomDomainOverviewARMResource"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StaticSiteCustomDomainOverviewARMResource(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _staticSitesRestClient = new StaticSitesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteCustomDomainOverviewARMResource"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StaticSiteCustomDomainOverviewARMResource(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _staticSitesRestClient = new StaticSitesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/staticSites/customDomains";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StaticSiteCustomDomainOverviewARMResourceData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// OperationId: StaticSites_GetStaticSiteCustomDomain
        /// <summary> Description for Gets an existing custom domain for a particular static site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<StaticSiteCustomDomainOverviewARMResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResource.Get");
            scope.Start();
            try
            {
                var response = await _staticSitesRestClient.GetStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new StaticSiteCustomDomainOverviewARMResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// OperationId: StaticSites_GetStaticSiteCustomDomain
        /// <summary> Description for Gets an existing custom domain for a particular static site. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StaticSiteCustomDomainOverviewARMResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResource.Get");
            scope.Start();
            try
            {
                var response = _staticSitesRestClient.GetStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteCustomDomainOverviewARMResource(this, response.Value), response.GetRawResponse());
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
            using var scope = _clientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResource.GetAvailableLocations");
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
            using var scope = _clientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResource.GetAvailableLocations");
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// OperationId: StaticSites_DeleteStaticSiteCustomDomain
        /// <summary> Description for Deletes a custom domain. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<StaticSiteDeleteStaticSiteCustomDomainOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResource.Delete");
            scope.Start();
            try
            {
                var response = await _staticSitesRestClient.DeleteStaticSiteCustomDomainAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new StaticSiteDeleteStaticSiteCustomDomainOperation(_clientDiagnostics, Pipeline, _staticSitesRestClient.CreateDeleteStaticSiteCustomDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// OperationId: StaticSites_DeleteStaticSiteCustomDomain
        /// <summary> Description for Deletes a custom domain. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual StaticSiteDeleteStaticSiteCustomDomainOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResource.Delete");
            scope.Start();
            try
            {
                var response = _staticSitesRestClient.DeleteStaticSiteCustomDomain(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new StaticSiteDeleteStaticSiteCustomDomainOperation(_clientDiagnostics, Pipeline, _staticSitesRestClient.CreateDeleteStaticSiteCustomDomainRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}/validate
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// OperationId: StaticSites_ValidateCustomDomainCanBeAddedToStaticSite
        /// <summary> Description for Validates a particular custom domain can be added to a static site. </summary>
        /// <param name="staticSiteCustomDomainRequestPropertiesEnvelope"> A JSON representation of the static site custom domain request properties. See example. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="staticSiteCustomDomainRequestPropertiesEnvelope"/> is null. </exception>
        public async virtual Task<StaticSiteValidateCustomDomainCanBeAddedToStaticSiteOperation> ValidateCustomDomainCanBeAddedToStaticSiteAsync(bool waitForCompletion, StaticSiteCustomDomainRequestPropertiesARMResource staticSiteCustomDomainRequestPropertiesEnvelope, CancellationToken cancellationToken = default)
        {
            if (staticSiteCustomDomainRequestPropertiesEnvelope == null)
            {
                throw new ArgumentNullException(nameof(staticSiteCustomDomainRequestPropertiesEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResource.ValidateCustomDomainCanBeAddedToStaticSite");
            scope.Start();
            try
            {
                var response = await _staticSitesRestClient.ValidateCustomDomainCanBeAddedToStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticSiteCustomDomainRequestPropertiesEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new StaticSiteValidateCustomDomainCanBeAddedToStaticSiteOperation(_clientDiagnostics, Pipeline, _staticSitesRestClient.CreateValidateCustomDomainCanBeAddedToStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticSiteCustomDomainRequestPropertiesEnvelope).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}/validate
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/customDomains/{domainName}
        /// OperationId: StaticSites_ValidateCustomDomainCanBeAddedToStaticSite
        /// <summary> Description for Validates a particular custom domain can be added to a static site. </summary>
        /// <param name="staticSiteCustomDomainRequestPropertiesEnvelope"> A JSON representation of the static site custom domain request properties. See example. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="staticSiteCustomDomainRequestPropertiesEnvelope"/> is null. </exception>
        public virtual StaticSiteValidateCustomDomainCanBeAddedToStaticSiteOperation ValidateCustomDomainCanBeAddedToStaticSite(bool waitForCompletion, StaticSiteCustomDomainRequestPropertiesARMResource staticSiteCustomDomainRequestPropertiesEnvelope, CancellationToken cancellationToken = default)
        {
            if (staticSiteCustomDomainRequestPropertiesEnvelope == null)
            {
                throw new ArgumentNullException(nameof(staticSiteCustomDomainRequestPropertiesEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("StaticSiteCustomDomainOverviewARMResource.ValidateCustomDomainCanBeAddedToStaticSite");
            scope.Start();
            try
            {
                var response = _staticSitesRestClient.ValidateCustomDomainCanBeAddedToStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticSiteCustomDomainRequestPropertiesEnvelope, cancellationToken);
                var operation = new StaticSiteValidateCustomDomainCanBeAddedToStaticSiteOperation(_clientDiagnostics, Pipeline, _staticSitesRestClient.CreateValidateCustomDomainCanBeAddedToStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, staticSiteCustomDomainRequestPropertiesEnvelope).Request, response);
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
    }
}
