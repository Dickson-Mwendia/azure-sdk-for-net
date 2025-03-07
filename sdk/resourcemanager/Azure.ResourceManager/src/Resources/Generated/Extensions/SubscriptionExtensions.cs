// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        #region SubscriptionPolicyDefinition
        /// <summary> Gets an object representing a SubscriptionPolicyDefinitionCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="SubscriptionPolicyDefinitionCollection" /> object. </returns>
        public static SubscriptionPolicyDefinitionCollection GetSubscriptionPolicyDefinitions(this Subscription subscription)
        {
            return new SubscriptionPolicyDefinitionCollection(subscription);
        }
        #endregion

        #region SubscriptionPolicySetDefinition
        /// <summary> Gets an object representing a SubscriptionPolicySetDefinitionCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="SubscriptionPolicySetDefinitionCollection" /> object. </returns>
        public static SubscriptionPolicySetDefinitionCollection GetSubscriptionPolicySetDefinitions(this Subscription subscription)
        {
            return new SubscriptionPolicySetDefinitionCollection(subscription);
        }
        #endregion

        private static ResourceLinksRestOperations GetResourceLinksRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, Uri endpoint = null)
        {
            return new ResourceLinksRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Resources/links
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ResourceLinks_ListAtSubscription
        /// <summary> Lists the ResourceLinks for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply on the list resource links operation. The supported filter for list resource links is targetId. For example, $filter=targetId eq {value}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceLink> GetAtSubscriptionResourceLinksAsync(this Subscription subscription, string filter = null, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetResourceLinksRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                async Task<Page<ResourceLink>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetAtSubscriptionResourceLinks");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAtSubscriptionAsync(subscription.Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<ResourceLink>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetAtSubscriptionResourceLinks");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAtSubscriptionNextPageAsync(nextLink, subscription.Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Resources/links
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: ResourceLinks_ListAtSubscription
        /// <summary> Lists the ResourceLinks for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply on the list resource links operation. The supported filter for list resource links is targetId. For example, $filter=targetId eq {value}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceLink> GetAtSubscriptionResourceLinks(this Subscription subscription, string filter = null, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetResourceLinksRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                Page<ResourceLink> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetAtSubscriptionResourceLinks");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListAtSubscription(subscription.Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<ResourceLink> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetAtSubscriptionResourceLinks");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListAtSubscriptionNextPage(nextLink, subscription.Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Filters the list of ResourceLinks for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetResourceLinksAsGenericResourcesAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(ResourceLink.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of ResourceLinks for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetResourceLinksAsGenericResources(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(ResourceLink.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(subscription, filters, expand, top, cancellationToken);
        }
    }
}
