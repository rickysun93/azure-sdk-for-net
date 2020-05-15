// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Compute.Models;

namespace Azure.Management.Compute
{
    /// <summary> The VirtualMachineScaleSetRollingUpgrades service client. </summary>
    public partial class VirtualMachineScaleSetRollingUpgradesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VirtualMachineScaleSetRollingUpgradesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of VirtualMachineScaleSetRollingUpgradesClient for mocking. </summary>
        protected VirtualMachineScaleSetRollingUpgradesClient()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetRollingUpgradesClient. </summary>
        public VirtualMachineScaleSetRollingUpgradesClient(string subscriptionId, TokenCredential tokenCredential, ComputeManagementClientOptions options = null) : this(subscriptionId, "https://management.azure.com", tokenCredential, options)
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetRollingUpgradesClient. </summary>
        public VirtualMachineScaleSetRollingUpgradesClient(string subscriptionId, string host, TokenCredential tokenCredential, ComputeManagementClientOptions options = null)
        {
            options ??= new ComputeManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, host, options);
            RestClient = new VirtualMachineScaleSetRollingUpgradesRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId, host: host);
        }

        /// <summary> Gets the status of the latest virtual machine scale set rolling upgrade. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RollingUpgradeStatusInfo>> GetLatestAsync(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesClient.GetLatest");
            scope.Start();
            try
            {
                return await RestClient.GetLatestAsync(resourceGroupName, vmScaleSetName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the status of the latest virtual machine scale set rolling upgrade. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RollingUpgradeStatusInfo> GetLatest(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesClient.GetLatest");
            scope.Start();
            try
            {
                return RestClient.GetLatest(resourceGroupName, vmScaleSetName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancels the current virtual machine scale set rolling upgrade. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<VirtualMachineScaleSetRollingUpgradesCancelOperation> StartCancelAsync(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesClient.StartCancel");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CancelAsync(resourceGroupName, vmScaleSetName, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineScaleSetRollingUpgradesCancelOperation(_clientDiagnostics, _pipeline, RestClient.CreateCancelRequest(resourceGroupName, vmScaleSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancels the current virtual machine scale set rolling upgrade. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualMachineScaleSetRollingUpgradesCancelOperation StartCancel(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesClient.StartCancel");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Cancel(resourceGroupName, vmScaleSetName, cancellationToken);
                return new VirtualMachineScaleSetRollingUpgradesCancelOperation(_clientDiagnostics, _pipeline, RestClient.CreateCancelRequest(resourceGroupName, vmScaleSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts a rolling upgrade to move all virtual machine scale set instances to the latest available Platform Image OS version. Instances which are already running the latest available OS version are not affected. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<VirtualMachineScaleSetRollingUpgradesStartOSUpgradeOperation> StartStartOSUpgradeAsync(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesClient.StartStartOSUpgrade");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.StartOSUpgradeAsync(resourceGroupName, vmScaleSetName, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineScaleSetRollingUpgradesStartOSUpgradeOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartOSUpgradeRequest(resourceGroupName, vmScaleSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts a rolling upgrade to move all virtual machine scale set instances to the latest available Platform Image OS version. Instances which are already running the latest available OS version are not affected. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualMachineScaleSetRollingUpgradesStartOSUpgradeOperation StartStartOSUpgrade(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesClient.StartStartOSUpgrade");
            scope.Start();
            try
            {
                var originalResponse = RestClient.StartOSUpgrade(resourceGroupName, vmScaleSetName, cancellationToken);
                return new VirtualMachineScaleSetRollingUpgradesStartOSUpgradeOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartOSUpgradeRequest(resourceGroupName, vmScaleSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts a rolling upgrade to move all extensions for all virtual machine scale set instances to the latest available extension version. Instances which are already running the latest extension versions are not affected. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<VirtualMachineScaleSetRollingUpgradesStartExtensionUpgradeOperation> StartStartExtensionUpgradeAsync(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesClient.StartStartExtensionUpgrade");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.StartExtensionUpgradeAsync(resourceGroupName, vmScaleSetName, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineScaleSetRollingUpgradesStartExtensionUpgradeOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartExtensionUpgradeRequest(resourceGroupName, vmScaleSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts a rolling upgrade to move all extensions for all virtual machine scale set instances to the latest available extension version. Instances which are already running the latest extension versions are not affected. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualMachineScaleSetRollingUpgradesStartExtensionUpgradeOperation StartStartExtensionUpgrade(string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetRollingUpgradesClient.StartStartExtensionUpgrade");
            scope.Start();
            try
            {
                var originalResponse = RestClient.StartExtensionUpgrade(resourceGroupName, vmScaleSetName, cancellationToken);
                return new VirtualMachineScaleSetRollingUpgradesStartExtensionUpgradeOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartExtensionUpgradeRequest(resourceGroupName, vmScaleSetName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
