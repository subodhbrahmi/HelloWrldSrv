﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HWrldClientTcp.HWrldSrvcRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HWrldSrvcRef.IHWrldSrvc")]
    public interface IHWrldSrvc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHWrldSrvc/GetMsg", ReplyAction="http://tempuri.org/IHWrldSrvc/GetMsgResponse")]
        string GetMsg(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHWrldSrvc/GetMsg", ReplyAction="http://tempuri.org/IHWrldSrvc/GetMsgResponse")]
        System.Threading.Tasks.Task<string> GetMsgAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHWrldSrvcChannel : HWrldClientTcp.HWrldSrvcRef.IHWrldSrvc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HWrldSrvcClient : System.ServiceModel.ClientBase<HWrldClientTcp.HWrldSrvcRef.IHWrldSrvc>, HWrldClientTcp.HWrldSrvcRef.IHWrldSrvc {
        
        public HWrldSrvcClient() {
        }
        
        public HWrldSrvcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HWrldSrvcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HWrldSrvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HWrldSrvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMsg(string name) {
            return base.Channel.GetMsg(name);
        }
        
        public System.Threading.Tasks.Task<string> GetMsgAsync(string name) {
            return base.Channel.GetMsgAsync(name);
        }
    }
}
