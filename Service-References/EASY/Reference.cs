﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISIS.EInvoiceEasy.Test.EASY {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contracts.ResponseType", Namespace="http://isisbilisim.com.tr/data/einvoice")]
    [System.SerializableAttribute()]
    public partial class ContractsResponseType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ByteDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommercialResponseEnvelopeUUIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ETTNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnvelopeUUIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GIBCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GIBMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProfileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ISIS.EInvoiceEasy.Test.EASY.ContractsStatusType StatusField;
        
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
        public byte[] ByteData {
            get {
                return this.ByteDataField;
            }
            set {
                if ((object.ReferenceEquals(this.ByteDataField, value) != true)) {
                    this.ByteDataField = value;
                    this.RaisePropertyChanged("ByteData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CommercialResponseEnvelopeUUID {
            get {
                return this.CommercialResponseEnvelopeUUIDField;
            }
            set {
                if ((object.ReferenceEquals(this.CommercialResponseEnvelopeUUIDField, value) != true)) {
                    this.CommercialResponseEnvelopeUUIDField = value;
                    this.RaisePropertyChanged("CommercialResponseEnvelopeUUID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ETTN {
            get {
                return this.ETTNField;
            }
            set {
                if ((object.ReferenceEquals(this.ETTNField, value) != true)) {
                    this.ETTNField = value;
                    this.RaisePropertyChanged("ETTN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EnvelopeUUID {
            get {
                return this.EnvelopeUUIDField;
            }
            set {
                if ((object.ReferenceEquals(this.EnvelopeUUIDField, value) != true)) {
                    this.EnvelopeUUIDField = value;
                    this.RaisePropertyChanged("EnvelopeUUID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GIBCode {
            get {
                return this.GIBCodeField;
            }
            set {
                if ((this.GIBCodeField.Equals(value) != true)) {
                    this.GIBCodeField = value;
                    this.RaisePropertyChanged("GIBCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GIBMessage {
            get {
                return this.GIBMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.GIBMessageField, value) != true)) {
                    this.GIBMessageField = value;
                    this.RaisePropertyChanged("GIBMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Profile {
            get {
                return this.ProfileField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfileField, value) != true)) {
                    this.ProfileField = value;
                    this.RaisePropertyChanged("Profile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ISIS.EInvoiceEasy.Test.EASY.ContractsStatusType Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contracts.StatusType", Namespace="http://isisbilisim.com.tr/data/einvoice")]
    public enum ContractsStatusType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OK = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ERROR = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PROCCESSING = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ACCEPTED = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        REJECTED = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contracts.CommercialResponseType", Namespace="http://isisbilisim.com.tr/data/einvoice")]
    public enum ContractsCommercialResponseType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ACCEPTED = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        REJECTED = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contracts.DirectionType", Namespace="http://isisbilisim.com.tr/data/einvoice")]
    public enum ContractsDirectionType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INBOUND = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OUTBOUND = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Enums.PDFType", Namespace="http://isisbilisim.com.tr/core/enums")]
    public enum EnumsPDFType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NORMAL = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ATTACHMENT = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DETAIL = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PREPRINTED = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://isisbilisim.com.tr/services/einvoice", ConfigurationName="EASY.IEasy")]
    public interface IEasy {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/SendInvoice", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/SendInvoiceResponse")]
        ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType SendInvoice(string VKN, string SenderAlias, string ReceiverAlias, byte[] ByteData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/SendEnvelope", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/SendEnvelopeResponse")]
        ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType SendEnvelope(string VKN, byte[] ByteData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/SendResponse", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/SendResponseResponse")]
        ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType SendResponse(string VKN, string ETTN, ISIS.EInvoiceEasy.Test.EASY.ContractsCommercialResponseType Response, string Reason);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/GetInvoice", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/GetInvoiceResponse")]
        ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType GetInvoice(string VKN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/GetSingleInvoice", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/GetSingleInvoiceResponse")]
        ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType GetSingleInvoice(string VKN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/GetStatus", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/GetStatusResponse")]
        ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType GetStatus(string VKN, ISIS.EInvoiceEasy.Test.EASY.ContractsDirectionType Direction, string ETTN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/GetSingleEnvelope", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/GetSingleEnvelopeResponse")]
        ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType GetSingleEnvelope(string VKN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/GetEnvelope", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/GetEnvelopeResponse")]
        ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType GetEnvelope(string VKN, ISIS.EInvoiceEasy.Test.EASY.ContractsDirectionType Direction, string ETTN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/GetPostboxList", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/GetPostboxListResponse")]
        string[] GetPostboxList(string ReceiverVKN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/GetPdfInvoice", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/GetPdfInvoiceResponse")]
        ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType GetPdfInvoice(string VKN, ISIS.EInvoiceEasy.Test.EASY.ContractsDirectionType Direction, string ETTN, ISIS.EInvoiceEasy.Test.EASY.EnumsPDFType[] PDFType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/ReceiveDone", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/ReceiveDoneResponse")]
        ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType ReceiveDone(string VKN, string ETTN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/ReceiveEnvelopeDone", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/ReceiveEnvelopeDoneResponse")]
        ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType ReceiveEnvelopeDone(string VKN, string ETTN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://isisbilisim.com.tr/services/einvoice/IEasy/ReceiveInvoiceDone", ReplyAction="http://isisbilisim.com.tr/services/einvoice/IEasy/ReceiveInvoiceDoneResponse")]
        ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType ReceiveInvoiceDone(string VKN, string ETTN);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEasyChannel : ISIS.EInvoiceEasy.Test.EASY.IEasy, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EasyClient : System.ServiceModel.ClientBase<ISIS.EInvoiceEasy.Test.EASY.IEasy>, ISIS.EInvoiceEasy.Test.EASY.IEasy {
        
        public EasyClient() {
        }
        
        public EasyClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EasyClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EasyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EasyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType SendInvoice(string VKN, string SenderAlias, string ReceiverAlias, byte[] ByteData) {
            return base.Channel.SendInvoice(VKN, SenderAlias, ReceiverAlias, ByteData);
        }
        
        public ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType SendEnvelope(string VKN, byte[] ByteData) {
            return base.Channel.SendEnvelope(VKN, ByteData);
        }
        
        public ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType SendResponse(string VKN, string ETTN, ISIS.EInvoiceEasy.Test.EASY.ContractsCommercialResponseType Response, string Reason) {
            return base.Channel.SendResponse(VKN, ETTN, Response, Reason);
        }
        
        public ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType GetInvoice(string VKN) {
            return base.Channel.GetInvoice(VKN);
        }
        
        public ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType GetSingleInvoice(string VKN) {
            return base.Channel.GetSingleInvoice(VKN);
        }
        
        public ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType GetStatus(string VKN, ISIS.EInvoiceEasy.Test.EASY.ContractsDirectionType Direction, string ETTN) {
            return base.Channel.GetStatus(VKN, Direction, ETTN);
        }
        
        public ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType GetSingleEnvelope(string VKN) {
            return base.Channel.GetSingleEnvelope(VKN);
        }
        
        public ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType GetEnvelope(string VKN, ISIS.EInvoiceEasy.Test.EASY.ContractsDirectionType Direction, string ETTN) {
            return base.Channel.GetEnvelope(VKN, Direction, ETTN);
        }
        
        public string[] GetPostboxList(string ReceiverVKN) {
            return base.Channel.GetPostboxList(ReceiverVKN);
        }
        
        public ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType GetPdfInvoice(string VKN, ISIS.EInvoiceEasy.Test.EASY.ContractsDirectionType Direction, string ETTN, ISIS.EInvoiceEasy.Test.EASY.EnumsPDFType[] PDFType) {
            return base.Channel.GetPdfInvoice(VKN, Direction, ETTN, PDFType);
        }
        
        public ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType ReceiveDone(string VKN, string ETTN) {
            return base.Channel.ReceiveDone(VKN, ETTN);
        }
        
        public ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType ReceiveEnvelopeDone(string VKN, string ETTN) {
            return base.Channel.ReceiveEnvelopeDone(VKN, ETTN);
        }
        
        public ISIS.EInvoiceEasy.Test.EASY.ContractsResponseType ReceiveInvoiceDone(string VKN, string ETTN) {
            return base.Channel.ReceiveInvoiceDone(VKN, ETTN);
        }
    }
}