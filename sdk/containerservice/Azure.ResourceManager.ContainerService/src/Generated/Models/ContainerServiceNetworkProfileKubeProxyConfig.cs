// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Holds configuration customizations for kube-proxy. Any values not defined will use the kube-proxy defaulting behavior. See https://v&lt;version&gt;.docs.kubernetes.io/docs/reference/command-line-tools-reference/kube-proxy/ where &lt;version&gt; is represented by a &lt;major version&gt;-&lt;minor version&gt; string. Kubernetes version 1.23 would be '1-23'. </summary>
    public partial class ContainerServiceNetworkProfileKubeProxyConfig
    {
        /// <summary> Initializes a new instance of ContainerServiceNetworkProfileKubeProxyConfig. </summary>
        public ContainerServiceNetworkProfileKubeProxyConfig()
        {
        }

        /// <summary> Initializes a new instance of ContainerServiceNetworkProfileKubeProxyConfig. </summary>
        /// <param name="isEnabled"> Whether to enable on kube-proxy on the cluster (if no 'kubeProxyConfig' exists, kube-proxy is enabled in AKS by default without these customizations). </param>
        /// <param name="mode"> Specify which proxy mode to use ('IPTABLES' or 'IPVS'). </param>
        /// <param name="ipvsConfig"> Holds configuration customizations for IPVS. May only be specified if 'mode' is set to 'IPVS'. </param>
        internal ContainerServiceNetworkProfileKubeProxyConfig(bool? isEnabled, ContainerServiceNetworkProfileKubeProxyMode? mode, ContainerServiceNetworkProfileKubeProxyIPVSConfig ipvsConfig)
        {
            IsEnabled = isEnabled;
            Mode = mode;
            IPVSConfig = ipvsConfig;
        }

        /// <summary> Whether to enable on kube-proxy on the cluster (if no 'kubeProxyConfig' exists, kube-proxy is enabled in AKS by default without these customizations). </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Specify which proxy mode to use ('IPTABLES' or 'IPVS'). </summary>
        public ContainerServiceNetworkProfileKubeProxyMode? Mode { get; set; }
        /// <summary> Holds configuration customizations for IPVS. May only be specified if 'mode' is set to 'IPVS'. </summary>
        public ContainerServiceNetworkProfileKubeProxyIPVSConfig IPVSConfig { get; set; }
    }
}
