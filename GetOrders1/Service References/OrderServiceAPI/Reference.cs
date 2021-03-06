﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetOrders1.OrderServiceAPI {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class OrderDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderServiceAPI.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name ListOrdersResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListOrders", ReplyAction="*")]
        GetOrders1.OrderServiceAPI.ListOrdersResponse ListOrders(GetOrders1.OrderServiceAPI.ListOrdersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListOrders", ReplyAction="*")]
        System.Threading.Tasks.Task<GetOrders1.OrderServiceAPI.ListOrdersResponse> ListOrdersAsync(GetOrders1.OrderServiceAPI.ListOrdersRequest request);
        
        // CODEGEN: Generating message contract since element name GetOrderResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOrder", ReplyAction="*")]
        GetOrders1.OrderServiceAPI.GetOrderResponse GetOrder(GetOrders1.OrderServiceAPI.GetOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<GetOrders1.OrderServiceAPI.GetOrderResponse> GetOrderAsync(GetOrders1.OrderServiceAPI.GetOrderRequest request);
        
        // CODEGEN: Generating message contract since element name CreateOneOrderResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateOneOrder", ReplyAction="*")]
        GetOrders1.OrderServiceAPI.CreateOneOrderResponse CreateOneOrder(GetOrders1.OrderServiceAPI.CreateOneOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateOneOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<GetOrders1.OrderServiceAPI.CreateOneOrderResponse> CreateOneOrderAsync(GetOrders1.OrderServiceAPI.CreateOneOrderRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOrdersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOrders", Namespace="http://tempuri.org/", Order=0)]
        public GetOrders1.OrderServiceAPI.ListOrdersRequestBody Body;
        
        public ListOrdersRequest() {
        }
        
        public ListOrdersRequest(GetOrders1.OrderServiceAPI.ListOrdersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOrdersRequestBody {
        
        public ListOrdersRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOrdersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOrdersResponse", Namespace="http://tempuri.org/", Order=0)]
        public GetOrders1.OrderServiceAPI.ListOrdersResponseBody Body;
        
        public ListOrdersResponse() {
        }
        
        public ListOrdersResponse(GetOrders1.OrderServiceAPI.ListOrdersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ListOrdersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public GetOrders1.OrderServiceAPI.OrderDTO[] ListOrdersResult;
        
        public ListOrdersResponseBody() {
        }
        
        public ListOrdersResponseBody(GetOrders1.OrderServiceAPI.OrderDTO[] ListOrdersResult) {
            this.ListOrdersResult = ListOrdersResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetOrderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetOrder", Namespace="http://tempuri.org/", Order=0)]
        public GetOrders1.OrderServiceAPI.GetOrderRequestBody Body;
        
        public GetOrderRequest() {
        }
        
        public GetOrderRequest(GetOrders1.OrderServiceAPI.GetOrderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetOrderRequestBody {
        
        public GetOrderRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetOrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public GetOrders1.OrderServiceAPI.GetOrderResponseBody Body;
        
        public GetOrderResponse() {
        }
        
        public GetOrderResponse(GetOrders1.OrderServiceAPI.GetOrderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetOrderResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public GetOrders1.OrderServiceAPI.OrderDTO GetOrderResult;
        
        public GetOrderResponseBody() {
        }
        
        public GetOrderResponseBody(GetOrders1.OrderServiceAPI.OrderDTO GetOrderResult) {
            this.GetOrderResult = GetOrderResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateOneOrderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateOneOrder", Namespace="http://tempuri.org/", Order=0)]
        public GetOrders1.OrderServiceAPI.CreateOneOrderRequestBody Body;
        
        public CreateOneOrderRequest() {
        }
        
        public CreateOneOrderRequest(GetOrders1.OrderServiceAPI.CreateOneOrderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CreateOneOrderRequestBody {
        
        public CreateOneOrderRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateOneOrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateOneOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public GetOrders1.OrderServiceAPI.CreateOneOrderResponseBody Body;
        
        public CreateOneOrderResponse() {
        }
        
        public CreateOneOrderResponse(GetOrders1.OrderServiceAPI.CreateOneOrderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateOneOrderResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public GetOrders1.OrderServiceAPI.OrderDTO CreateOneOrderResult;
        
        public CreateOneOrderResponseBody() {
        }
        
        public CreateOneOrderResponseBody(GetOrders1.OrderServiceAPI.OrderDTO CreateOneOrderResult) {
            this.CreateOneOrderResult = CreateOneOrderResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : GetOrders1.OrderServiceAPI.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<GetOrders1.OrderServiceAPI.WebService1Soap>, GetOrders1.OrderServiceAPI.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetOrders1.OrderServiceAPI.ListOrdersResponse GetOrders1.OrderServiceAPI.WebService1Soap.ListOrders(GetOrders1.OrderServiceAPI.ListOrdersRequest request) {
            return base.Channel.ListOrders(request);
        }
        
        public GetOrders1.OrderServiceAPI.OrderDTO[] ListOrders() {
            GetOrders1.OrderServiceAPI.ListOrdersRequest inValue = new GetOrders1.OrderServiceAPI.ListOrdersRequest();
            inValue.Body = new GetOrders1.OrderServiceAPI.ListOrdersRequestBody();
            GetOrders1.OrderServiceAPI.ListOrdersResponse retVal = ((GetOrders1.OrderServiceAPI.WebService1Soap)(this)).ListOrders(inValue);
            return retVal.Body.ListOrdersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetOrders1.OrderServiceAPI.ListOrdersResponse> GetOrders1.OrderServiceAPI.WebService1Soap.ListOrdersAsync(GetOrders1.OrderServiceAPI.ListOrdersRequest request) {
            return base.Channel.ListOrdersAsync(request);
        }
        
        public System.Threading.Tasks.Task<GetOrders1.OrderServiceAPI.ListOrdersResponse> ListOrdersAsync() {
            GetOrders1.OrderServiceAPI.ListOrdersRequest inValue = new GetOrders1.OrderServiceAPI.ListOrdersRequest();
            inValue.Body = new GetOrders1.OrderServiceAPI.ListOrdersRequestBody();
            return ((GetOrders1.OrderServiceAPI.WebService1Soap)(this)).ListOrdersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetOrders1.OrderServiceAPI.GetOrderResponse GetOrders1.OrderServiceAPI.WebService1Soap.GetOrder(GetOrders1.OrderServiceAPI.GetOrderRequest request) {
            return base.Channel.GetOrder(request);
        }
        
        public GetOrders1.OrderServiceAPI.OrderDTO GetOrder() {
            GetOrders1.OrderServiceAPI.GetOrderRequest inValue = new GetOrders1.OrderServiceAPI.GetOrderRequest();
            inValue.Body = new GetOrders1.OrderServiceAPI.GetOrderRequestBody();
            GetOrders1.OrderServiceAPI.GetOrderResponse retVal = ((GetOrders1.OrderServiceAPI.WebService1Soap)(this)).GetOrder(inValue);
            return retVal.Body.GetOrderResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetOrders1.OrderServiceAPI.GetOrderResponse> GetOrders1.OrderServiceAPI.WebService1Soap.GetOrderAsync(GetOrders1.OrderServiceAPI.GetOrderRequest request) {
            return base.Channel.GetOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<GetOrders1.OrderServiceAPI.GetOrderResponse> GetOrderAsync() {
            GetOrders1.OrderServiceAPI.GetOrderRequest inValue = new GetOrders1.OrderServiceAPI.GetOrderRequest();
            inValue.Body = new GetOrders1.OrderServiceAPI.GetOrderRequestBody();
            return ((GetOrders1.OrderServiceAPI.WebService1Soap)(this)).GetOrderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetOrders1.OrderServiceAPI.CreateOneOrderResponse GetOrders1.OrderServiceAPI.WebService1Soap.CreateOneOrder(GetOrders1.OrderServiceAPI.CreateOneOrderRequest request) {
            return base.Channel.CreateOneOrder(request);
        }
        
        public GetOrders1.OrderServiceAPI.OrderDTO CreateOneOrder() {
            GetOrders1.OrderServiceAPI.CreateOneOrderRequest inValue = new GetOrders1.OrderServiceAPI.CreateOneOrderRequest();
            inValue.Body = new GetOrders1.OrderServiceAPI.CreateOneOrderRequestBody();
            GetOrders1.OrderServiceAPI.CreateOneOrderResponse retVal = ((GetOrders1.OrderServiceAPI.WebService1Soap)(this)).CreateOneOrder(inValue);
            return retVal.Body.CreateOneOrderResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetOrders1.OrderServiceAPI.CreateOneOrderResponse> GetOrders1.OrderServiceAPI.WebService1Soap.CreateOneOrderAsync(GetOrders1.OrderServiceAPI.CreateOneOrderRequest request) {
            return base.Channel.CreateOneOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<GetOrders1.OrderServiceAPI.CreateOneOrderResponse> CreateOneOrderAsync() {
            GetOrders1.OrderServiceAPI.CreateOneOrderRequest inValue = new GetOrders1.OrderServiceAPI.CreateOneOrderRequest();
            inValue.Body = new GetOrders1.OrderServiceAPI.CreateOneOrderRequestBody();
            return ((GetOrders1.OrderServiceAPI.WebService1Soap)(this)).CreateOneOrderAsync(inValue);
        }
    }
}
