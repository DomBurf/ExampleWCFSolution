﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BailiffClient.DebtorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DebtorEntity", Namespace="http://schemas.datacontract.org/2004/07/Common.Entities")]
    [System.SerializableAttribute()]
    public partial class DebtorEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CRefField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LiabilityOrderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RefnoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CRef {
            get {
                return this.CRefField;
            }
            set {
                if ((object.ReferenceEquals(this.CRefField, value) != true)) {
                    this.CRefField = value;
                    this.RaisePropertyChanged("CRef");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Client {
            get {
                return this.ClientField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientField, value) != true)) {
                    this.ClientField = value;
                    this.RaisePropertyChanged("Client");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Company {
            get {
                return this.CompanyField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyField, value) != true)) {
                    this.CompanyField = value;
                    this.RaisePropertyChanged("Company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LiabilityOrderId {
            get {
                return this.LiabilityOrderIdField;
            }
            set {
                if ((object.ReferenceEquals(this.LiabilityOrderIdField, value) != true)) {
                    this.LiabilityOrderIdField = value;
                    this.RaisePropertyChanged("LiabilityOrderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Refno {
            get {
                return this.RefnoField;
            }
            set {
                if ((object.ReferenceEquals(this.RefnoField, value) != true)) {
                    this.RefnoField = value;
                    this.RaisePropertyChanged("Refno");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UnexpectedServiceFault", Namespace="http://schemas.datacontract.org/2004/07/Common")]
    [System.SerializableAttribute()]
    public partial class UnexpectedServiceFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DebtorService.IDebtor")]
    public interface IDebtor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDebtor/GetDebtorInfo", ReplyAction="http://tempuri.org/IDebtor/GetDebtorInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BailiffClient.DebtorService.UnexpectedServiceFault), Action="http://tempuri.org/IDebtor/GetDebtorInfoUnexpectedServiceFaultFault", Name="UnexpectedServiceFault", Namespace="http://schemas.datacontract.org/2004/07/Common")]
        BailiffClient.DebtorService.DebtorEntity GetDebtorInfo(int debtorId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDebtorChannel : BailiffClient.DebtorService.IDebtor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DebtorClient : System.ServiceModel.ClientBase<BailiffClient.DebtorService.IDebtor>, BailiffClient.DebtorService.IDebtor {
        
        public DebtorClient() {
        }
        
        public DebtorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DebtorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DebtorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DebtorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BailiffClient.DebtorService.DebtorEntity GetDebtorInfo(int debtorId) {
            return base.Channel.GetDebtorInfo(debtorId);
        }
    }
}
