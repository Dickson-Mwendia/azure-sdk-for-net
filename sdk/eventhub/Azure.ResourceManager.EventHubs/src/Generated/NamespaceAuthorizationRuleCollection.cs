// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing collection of AuthorizationRule and their operations over its parent. </summary>
    public partial class NamespaceAuthorizationRuleCollection : ArmCollection, IEnumerable<NamespaceAuthorizationRule>, IAsyncEnumerable<NamespaceAuthorizationRule>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly NamespacesRestOperations _namespacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NamespaceAuthorizationRuleCollection"/> class for mocking. </summary>
        protected NamespaceAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NamespaceAuthorizationRuleCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal NamespaceAuthorizationRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _namespacesRestClient = new NamespacesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventHubNamespace.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventHubNamespace.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates an AuthorizationRule for a Namespace. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="parameters"> The shared access AuthorizationRule. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual NamespaceCreateOrUpdateAuthorizationRuleOperation CreateOrUpdate(bool waitForCompletion, string authorizationRuleName, AuthorizationRuleData parameters, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _namespacesRestClient.CreateOrUpdateAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, parameters, cancellationToken);
                var operation = new NamespaceCreateOrUpdateAuthorizationRuleOperation(Parent, response);
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

        /// <summary> Creates or updates an AuthorizationRule for a Namespace. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="parameters"> The shared access AuthorizationRule. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<NamespaceCreateOrUpdateAuthorizationRuleOperation> CreateOrUpdateAsync(bool waitForCompletion, string authorizationRuleName, AuthorizationRuleData parameters, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _namespacesRestClient.CreateOrUpdateAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NamespaceCreateOrUpdateAuthorizationRuleOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an AuthorizationRule for a Namespace by rule name. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<NamespaceAuthorizationRule> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _namespacesRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceAuthorizationRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an AuthorizationRule for a Namespace by rule name. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<NamespaceAuthorizationRule>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _namespacesRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NamespaceAuthorizationRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<NamespaceAuthorizationRule> GetIfExists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _namespacesRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NamespaceAuthorizationRule>(null, response.GetRawResponse());
                return Response.FromValue(new NamespaceAuthorizationRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<NamespaceAuthorizationRule>> GetIfExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _namespacesRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NamespaceAuthorizationRule>(null, response.GetRawResponse());
                return Response.FromValue(new NamespaceAuthorizationRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(authorizationRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of authorization rules for a Namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NamespaceAuthorizationRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NamespaceAuthorizationRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NamespaceAuthorizationRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _namespacesRestClient.ListAuthorizationRules(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceAuthorizationRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NamespaceAuthorizationRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _namespacesRestClient.ListAuthorizationRulesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceAuthorizationRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of authorization rules for a Namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NamespaceAuthorizationRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NamespaceAuthorizationRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NamespaceAuthorizationRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _namespacesRestClient.ListAuthorizationRulesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceAuthorizationRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NamespaceAuthorizationRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NamespaceAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _namespacesRestClient.ListAuthorizationRulesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceAuthorizationRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<NamespaceAuthorizationRule> IEnumerable<NamespaceAuthorizationRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NamespaceAuthorizationRule> IAsyncEnumerable<NamespaceAuthorizationRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, NamespaceAuthorizationRule, AuthorizationRuleData> Construct() { }
    }
}
