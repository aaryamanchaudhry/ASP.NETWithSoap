﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTAaryamanChaudhry.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        FTAaryamanChaudhry.ServiceReference1.HelloWorldResponse HelloWorld(FTAaryamanChaudhry.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<FTAaryamanChaudhry.ServiceReference1.HelloWorldResponse> HelloWorldAsync(FTAaryamanChaudhry.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name pub_id from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/returnData", ReplyAction="*")]
        FTAaryamanChaudhry.ServiceReference1.returnDataResponse returnData(FTAaryamanChaudhry.ServiceReference1.returnDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/returnData", ReplyAction="*")]
        System.Threading.Tasks.Task<FTAaryamanChaudhry.ServiceReference1.returnDataResponse> returnDataAsync(FTAaryamanChaudhry.ServiceReference1.returnDataRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public FTAaryamanChaudhry.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(FTAaryamanChaudhry.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public FTAaryamanChaudhry.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(FTAaryamanChaudhry.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class returnDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="returnData", Namespace="http://tempuri.org/", Order=0)]
        public FTAaryamanChaudhry.ServiceReference1.returnDataRequestBody Body;
        
        public returnDataRequest() {
        }
        
        public returnDataRequest(FTAaryamanChaudhry.ServiceReference1.returnDataRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class returnDataRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string pub_id;
        
        public returnDataRequestBody() {
        }
        
        public returnDataRequestBody(string pub_id) {
            this.pub_id = pub_id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class returnDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="returnDataResponse", Namespace="http://tempuri.org/", Order=0)]
        public FTAaryamanChaudhry.ServiceReference1.returnDataResponseBody Body;
        
        public returnDataResponse() {
        }
        
        public returnDataResponse(FTAaryamanChaudhry.ServiceReference1.returnDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class returnDataResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public FTAaryamanChaudhry.ServiceReference1.ArrayOfString returnDataResult;
        
        public returnDataResponseBody() {
        }
        
        public returnDataResponseBody(FTAaryamanChaudhry.ServiceReference1.ArrayOfString returnDataResult) {
            this.returnDataResult = returnDataResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : FTAaryamanChaudhry.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<FTAaryamanChaudhry.ServiceReference1.WebService1Soap>, FTAaryamanChaudhry.ServiceReference1.WebService1Soap {
        
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
        FTAaryamanChaudhry.ServiceReference1.HelloWorldResponse FTAaryamanChaudhry.ServiceReference1.WebService1Soap.HelloWorld(FTAaryamanChaudhry.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            FTAaryamanChaudhry.ServiceReference1.HelloWorldRequest inValue = new FTAaryamanChaudhry.ServiceReference1.HelloWorldRequest();
            inValue.Body = new FTAaryamanChaudhry.ServiceReference1.HelloWorldRequestBody();
            FTAaryamanChaudhry.ServiceReference1.HelloWorldResponse retVal = ((FTAaryamanChaudhry.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FTAaryamanChaudhry.ServiceReference1.HelloWorldResponse> FTAaryamanChaudhry.ServiceReference1.WebService1Soap.HelloWorldAsync(FTAaryamanChaudhry.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<FTAaryamanChaudhry.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            FTAaryamanChaudhry.ServiceReference1.HelloWorldRequest inValue = new FTAaryamanChaudhry.ServiceReference1.HelloWorldRequest();
            inValue.Body = new FTAaryamanChaudhry.ServiceReference1.HelloWorldRequestBody();
            return ((FTAaryamanChaudhry.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FTAaryamanChaudhry.ServiceReference1.returnDataResponse FTAaryamanChaudhry.ServiceReference1.WebService1Soap.returnData(FTAaryamanChaudhry.ServiceReference1.returnDataRequest request) {
            return base.Channel.returnData(request);
        }
        
        public FTAaryamanChaudhry.ServiceReference1.ArrayOfString returnData(string pub_id) {
            FTAaryamanChaudhry.ServiceReference1.returnDataRequest inValue = new FTAaryamanChaudhry.ServiceReference1.returnDataRequest();
            inValue.Body = new FTAaryamanChaudhry.ServiceReference1.returnDataRequestBody();
            inValue.Body.pub_id = pub_id;
            FTAaryamanChaudhry.ServiceReference1.returnDataResponse retVal = ((FTAaryamanChaudhry.ServiceReference1.WebService1Soap)(this)).returnData(inValue);
            return retVal.Body.returnDataResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FTAaryamanChaudhry.ServiceReference1.returnDataResponse> FTAaryamanChaudhry.ServiceReference1.WebService1Soap.returnDataAsync(FTAaryamanChaudhry.ServiceReference1.returnDataRequest request) {
            return base.Channel.returnDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<FTAaryamanChaudhry.ServiceReference1.returnDataResponse> returnDataAsync(string pub_id) {
            FTAaryamanChaudhry.ServiceReference1.returnDataRequest inValue = new FTAaryamanChaudhry.ServiceReference1.returnDataRequest();
            inValue.Body = new FTAaryamanChaudhry.ServiceReference1.returnDataRequestBody();
            inValue.Body.pub_id = pub_id;
            return ((FTAaryamanChaudhry.ServiceReference1.WebService1Soap)(this)).returnDataAsync(inValue);
        }
    }
}
