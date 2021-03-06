// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using MigAz.Azure.Arm;
using MigAz.Azure.Core.ArmTemplate;
using MigAz.Azure.Core.Interface;
using System;
using System.Threading.Tasks;
using System.Xml;

namespace MigAz.Azure.Asm
{
    public class Subnet : ISubnet
    {
        #region Variables

        private VirtualNetwork _VirtualNetwork;
        private NetworkSecurityGroup _AsmNetworkSecurityGroup = null;
        private RouteTable _AsmRouteTable = null;
        private XmlNode _XmlNode = null;

        #endregion

        #region Constructors

        private Subnet() { }

        internal Subnet(VirtualNetwork virtualNetwork, XmlNode xmlNode)
        {
            _VirtualNetwork = virtualNetwork;
            _XmlNode = xmlNode;
        }

        #endregion

        #region Properties

        public AzureSubscription AzureSubscription
        {
            get { return _VirtualNetwork.AzureSubscription; }
        }

        public string Name
        {
            get { return _XmlNode.SelectSingleNode("Name").InnerText; }
        }

        public string Id
        {
            get { return this.Name; }
        }

        public string AddressPrefix
        {
            get { return _XmlNode.SelectSingleNode("AddressPrefix").InnerText; }
        }

        private string NetworkSecurityGroupName
        {
            get
            {
                if (_XmlNode.SelectSingleNode("NetworkSecurityGroup") == null)
                    return String.Empty;

                return _XmlNode.SelectSingleNode("NetworkSecurityGroup").InnerText;
            }
        }

        public NetworkSecurityGroup NetworkSecurityGroup
        {
            get
            {
                return _AsmNetworkSecurityGroup;
            }
        }

        private String RouteTableName
        {
            get
            {
                if (_XmlNode.SelectSingleNode("RouteTableName") == null)
                    return String.Empty;

                return _XmlNode.SelectSingleNode("RouteTableName").InnerText;
            }
        }

        public RouteTable RouteTable { get { return _AsmRouteTable; } }

        public VirtualNetwork Parent
        {
            get { return _VirtualNetwork; }
        }

        public bool IsGatewaySubnet
        {
            get { return this.Name == ArmConst.GatewaySubnetName; }
        }

        


        #endregion

        #region Methods

        public override string ToString()
        {
            return this.Name;
        }

        public async Task InitializeChildrenAsync()
        {
            if (this.NetworkSecurityGroupName != String.Empty)
            {
                _AsmNetworkSecurityGroup = await this.AzureSubscription.GetAzureAsmNetworkSecurityGroup(this.NetworkSecurityGroupName);
            }

            if (this.RouteTableName != String.Empty)
            {
                _AsmRouteTable = await this.AzureSubscription.GetAzureAsmRouteTable(this.RouteTableName);
            }
        }

        #endregion

        public static bool operator ==(Subnet lhs, Subnet rhs)
        {
            bool status = false;
            if (((object)lhs == null && (object)rhs == null) ||
                    ((object)lhs != null && (object)rhs != null && lhs.Id == rhs.Id))
            {
                status = true;
            }
            return status;
        }

        public static bool operator !=(Subnet lhs, Subnet rhs)
        {
            return !(lhs == rhs);
        }

    }
}

