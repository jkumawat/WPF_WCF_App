﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_App.WCFArithmaticService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WCF_Arithmath")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Operand", Namespace="http://schemas.datacontract.org/2004/07/WCF_Arithmath")]
    [System.SerializableAttribute()]
    public partial class Operand : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Operand_oneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Operand_twoField;
        
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
        public int Operand_one {
            get {
                return this.Operand_oneField;
            }
            set {
                if ((this.Operand_oneField.Equals(value) != true)) {
                    this.Operand_oneField = value;
                    this.RaisePropertyChanged("Operand_one");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Operand_two {
            get {
                return this.Operand_twoField;
            }
            set {
                if ((this.Operand_twoField.Equals(value) != true)) {
                    this.Operand_twoField = value;
                    this.RaisePropertyChanged("Operand_two");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFArithmaticService.IArithmaticService")]
    public interface IArithmaticService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmaticService/GetData", ReplyAction="http://tempuri.org/IArithmaticService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmaticService/GetData", ReplyAction="http://tempuri.org/IArithmaticService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmaticService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IArithmaticService/GetDataUsingDataContractResponse")]
        WPF_App.WCFArithmaticService.CompositeType GetDataUsingDataContract(WPF_App.WCFArithmaticService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmaticService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IArithmaticService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WPF_App.WCFArithmaticService.CompositeType> GetDataUsingDataContractAsync(WPF_App.WCFArithmaticService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmaticService/GetAddition", ReplyAction="http://tempuri.org/IArithmaticService/GetAdditionResponse")]
        int GetAddition(WPF_App.WCFArithmaticService.Operand operands);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmaticService/GetAddition", ReplyAction="http://tempuri.org/IArithmaticService/GetAdditionResponse")]
        System.Threading.Tasks.Task<int> GetAdditionAsync(WPF_App.WCFArithmaticService.Operand operands);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmaticService/GetSubtraction", ReplyAction="http://tempuri.org/IArithmaticService/GetSubtractionResponse")]
        int GetSubtraction(WPF_App.WCFArithmaticService.Operand operands);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmaticService/GetSubtraction", ReplyAction="http://tempuri.org/IArithmaticService/GetSubtractionResponse")]
        System.Threading.Tasks.Task<int> GetSubtractionAsync(WPF_App.WCFArithmaticService.Operand operands);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmaticService/GetMultiplicaiton", ReplyAction="http://tempuri.org/IArithmaticService/GetMultiplicaitonResponse")]
        int GetMultiplicaiton(WPF_App.WCFArithmaticService.Operand operands);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmaticService/GetMultiplicaiton", ReplyAction="http://tempuri.org/IArithmaticService/GetMultiplicaitonResponse")]
        System.Threading.Tasks.Task<int> GetMultiplicaitonAsync(WPF_App.WCFArithmaticService.Operand operands);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmaticService/GetDivide", ReplyAction="http://tempuri.org/IArithmaticService/GetDivideResponse")]
        int GetDivide(WPF_App.WCFArithmaticService.Operand operands);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmaticService/GetDivide", ReplyAction="http://tempuri.org/IArithmaticService/GetDivideResponse")]
        System.Threading.Tasks.Task<int> GetDivideAsync(WPF_App.WCFArithmaticService.Operand operands);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IArithmaticServiceChannel : WPF_App.WCFArithmaticService.IArithmaticService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ArithmaticServiceClient : System.ServiceModel.ClientBase<WPF_App.WCFArithmaticService.IArithmaticService>, WPF_App.WCFArithmaticService.IArithmaticService {
        
        public ArithmaticServiceClient() {
        }
        
        public ArithmaticServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ArithmaticServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ArithmaticServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ArithmaticServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WPF_App.WCFArithmaticService.CompositeType GetDataUsingDataContract(WPF_App.WCFArithmaticService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WPF_App.WCFArithmaticService.CompositeType> GetDataUsingDataContractAsync(WPF_App.WCFArithmaticService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int GetAddition(WPF_App.WCFArithmaticService.Operand operands) {
            return base.Channel.GetAddition(operands);
        }
        
        public System.Threading.Tasks.Task<int> GetAdditionAsync(WPF_App.WCFArithmaticService.Operand operands) {
            return base.Channel.GetAdditionAsync(operands);
        }
        
        public int GetSubtraction(WPF_App.WCFArithmaticService.Operand operands) {
            return base.Channel.GetSubtraction(operands);
        }
        
        public System.Threading.Tasks.Task<int> GetSubtractionAsync(WPF_App.WCFArithmaticService.Operand operands) {
            return base.Channel.GetSubtractionAsync(operands);
        }
        
        public int GetMultiplicaiton(WPF_App.WCFArithmaticService.Operand operands) {
            return base.Channel.GetMultiplicaiton(operands);
        }
        
        public System.Threading.Tasks.Task<int> GetMultiplicaitonAsync(WPF_App.WCFArithmaticService.Operand operands) {
            return base.Channel.GetMultiplicaitonAsync(operands);
        }
        
        public int GetDivide(WPF_App.WCFArithmaticService.Operand operands) {
            return base.Channel.GetDivide(operands);
        }
        
        public System.Threading.Tasks.Task<int> GetDivideAsync(WPF_App.WCFArithmaticService.Operand operands) {
            return base.Channel.GetDivideAsync(operands);
        }
    }
}
