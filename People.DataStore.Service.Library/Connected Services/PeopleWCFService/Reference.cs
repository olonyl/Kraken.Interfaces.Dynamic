﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace People.DataStore.Service.Library.PeopleWCFService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PeopleWCFService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPeople", ReplyAction="http://tempuri.org/IService/GetPeopleResponse")]
        System.Collections.Generic.List<Kraken.Interfaces.Dynamic.Library.Models.PersonModel> GetPeople();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetPeople", ReplyAction="http://tempuri.org/IService/GetPeopleResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Kraken.Interfaces.Dynamic.Library.Models.PersonModel>> GetPeopleAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : People.DataStore.Service.Library.PeopleWCFService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<People.DataStore.Service.Library.PeopleWCFService.IService>, People.DataStore.Service.Library.PeopleWCFService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Kraken.Interfaces.Dynamic.Library.Models.PersonModel> GetPeople() {
            return base.Channel.GetPeople();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Kraken.Interfaces.Dynamic.Library.Models.PersonModel>> GetPeopleAsync() {
            return base.Channel.GetPeopleAsync();
        }
    }
}