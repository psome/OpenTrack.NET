﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenTrack.Definitions {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.starstandards.org/webservices/2005/10/transport/bindings", ConfigurationName="Definitions.starTransport")]
    public interface starTransport {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.starstandards.org/webservices/2005/10/transport/operations/ProcessMess" +
            "age", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        OpenTrack.Definitions.ProcessMessageResponse ProcessMessage(OpenTrack.Definitions.ProcessMessageRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.starstandards.org/webservices/2005/10/transport/operations/ProcessMess" +
            "age", ReplyAction="*")]
        System.Threading.Tasks.Task<OpenTrack.Definitions.ProcessMessageResponse> ProcessMessageAsync(OpenTrack.Definitions.ProcessMessageRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.starstandards.org/webservices/2005/10/transport")]
    public partial class PayloadManifest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Manifest[] manifestField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manifest", Order=0)]
        public Manifest[] manifest {
            get {
                return this.manifestField;
            }
            set {
                this.manifestField = value;
                this.RaisePropertyChanged("manifest");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.starstandards.org/webservices/2005/10/transport")]
    public partial class Manifest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string contentIDField;
        
        private string namespaceURIField;
        
        private string elementField;
        
        private string relatedIDField;
        
        private string versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string contentID {
            get {
                return this.contentIDField;
            }
            set {
                this.contentIDField = value;
                this.RaisePropertyChanged("contentID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string namespaceURI {
            get {
                return this.namespaceURIField;
            }
            set {
                this.namespaceURIField = value;
                this.RaisePropertyChanged("namespaceURI");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string element {
            get {
                return this.elementField;
            }
            set {
                this.elementField = value;
                this.RaisePropertyChanged("element");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string relatedID {
            get {
                return this.relatedIDField;
            }
            set {
                this.relatedIDField = value;
                this.RaisePropertyChanged("relatedID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
                this.RaisePropertyChanged("version");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.starstandards.org/webservices/2005/10/transport")]
    public partial class Content : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Xml.XmlElement anyField;
        
        private string idField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.XmlElement Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.starstandards.org/webservices/2005/10/transport")]
    public partial class Payload : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Content[] contentField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("content", Order=0)]
        public Content[] content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessMessage", WrapperNamespace="http://www.starstandards.org/webservices/2005/10/transport", IsWrapped=true)]
    public partial class ProcessMessageRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.starstandards.org/webservices/2005/10/transport")]
        public OpenTrack.Definitions.PayloadManifest PayloadManifest;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.starstandards.org/webservices/2005/10/transport", Order=0)]
        public OpenTrack.Definitions.Payload payload;
        
        public ProcessMessageRequest() {
        }
        
        public ProcessMessageRequest(OpenTrack.Definitions.PayloadManifest PayloadManifest, OpenTrack.Definitions.Payload payload) {
            this.PayloadManifest = PayloadManifest;
            this.payload = payload;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessMessageResponse", WrapperNamespace="http://www.starstandards.org/webservices/2005/10/transport", IsWrapped=true)]
    public partial class ProcessMessageResponse {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.starstandards.org/webservices/2005/10/transport")]
        public OpenTrack.Definitions.PayloadManifest PayloadManifest;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.starstandards.org/webservices/2005/10/transport", Order=0)]
        public OpenTrack.Definitions.Payload payload;
        
        public ProcessMessageResponse() {
        }
        
        public ProcessMessageResponse(OpenTrack.Definitions.PayloadManifest PayloadManifest, OpenTrack.Definitions.Payload payload) {
            this.PayloadManifest = PayloadManifest;
            this.payload = payload;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface starTransportChannel : OpenTrack.Definitions.starTransport, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class starTransportClient : System.ServiceModel.ClientBase<OpenTrack.Definitions.starTransport>, OpenTrack.Definitions.starTransport {
        
        public starTransportClient() {
        }
        
        public starTransportClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public starTransportClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public starTransportClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public starTransportClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenTrack.Definitions.ProcessMessageResponse OpenTrack.Definitions.starTransport.ProcessMessage(OpenTrack.Definitions.ProcessMessageRequest request) {
            return base.Channel.ProcessMessage(request);
        }
        
        public void ProcessMessage(ref OpenTrack.Definitions.PayloadManifest PayloadManifest, ref OpenTrack.Definitions.Payload payload) {
            OpenTrack.Definitions.ProcessMessageRequest inValue = new OpenTrack.Definitions.ProcessMessageRequest();
            inValue.PayloadManifest = PayloadManifest;
            inValue.payload = payload;
            OpenTrack.Definitions.ProcessMessageResponse retVal = ((OpenTrack.Definitions.starTransport)(this)).ProcessMessage(inValue);
            PayloadManifest = retVal.PayloadManifest;
            payload = retVal.payload;
        }
        
        public System.Threading.Tasks.Task<OpenTrack.Definitions.ProcessMessageResponse> ProcessMessageAsync(OpenTrack.Definitions.ProcessMessageRequest request) {
            return base.Channel.ProcessMessageAsync(request);
        }
    }
}
