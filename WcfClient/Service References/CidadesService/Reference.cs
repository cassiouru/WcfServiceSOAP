﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClient.CidadesService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CidadesService.IObtemCidadePorEstado")]
    public interface IObtemCidadePorEstado {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObtemCidadePorEstado/Obter", ReplyAction="http://tempuri.org/IObtemCidadePorEstado/ObterResponse")]
        string[] Obter(string uf);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IObtemCidadePorEstado/Obter", ReplyAction="http://tempuri.org/IObtemCidadePorEstado/ObterResponse")]
        System.Threading.Tasks.Task<string[]> ObterAsync(string uf);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IObtemCidadePorEstadoChannel : WcfClient.CidadesService.IObtemCidadePorEstado, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ObtemCidadePorEstadoClient : System.ServiceModel.ClientBase<WcfClient.CidadesService.IObtemCidadePorEstado>, WcfClient.CidadesService.IObtemCidadePorEstado {
        
        public ObtemCidadePorEstadoClient() {
        }
        
        public ObtemCidadePorEstadoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ObtemCidadePorEstadoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ObtemCidadePorEstadoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ObtemCidadePorEstadoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] Obter(string uf) {
            return base.Channel.Obter(uf);
        }
        
        public System.Threading.Tasks.Task<string[]> ObterAsync(string uf) {
            return base.Channel.ObterAsync(uf);
        }
    }
}
