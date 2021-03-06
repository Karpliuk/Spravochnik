﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Spravochnik_Api.DictionaryServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DictionaryServiceReference.IDictionaryService")]
    public interface IDictionaryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetLocations", ReplyAction="http://tempuri.org/IDictionaryService/GetLocationsResponse")]
        System.IO.Stream GetLocations(string languageCd, bool showAll);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetLocations", ReplyAction="http://tempuri.org/IDictionaryService/GetLocationsResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetLocationsAsync(string languageCd, bool showAll);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetSubstances", ReplyAction="http://tempuri.org/IDictionaryService/GetSubstancesResponse")]
        System.IO.Stream GetSubstances();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetSubstances", ReplyAction="http://tempuri.org/IDictionaryService/GetSubstancesResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetSubstancesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetServices", ReplyAction="http://tempuri.org/IDictionaryService/GetServicesResponse")]
        System.IO.Stream GetServices(string languageCd, string laboratoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetServices", ReplyAction="http://tempuri.org/IDictionaryService/GetServicesResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetServicesAsync(string languageCd, string laboratoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetMedicalServiceGroups", ReplyAction="http://tempuri.org/IDictionaryService/GetMedicalServiceGroupsResponse")]
        System.IO.Stream GetMedicalServiceGroups();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetMedicalServiceGroups", ReplyAction="http://tempuri.org/IDictionaryService/GetMedicalServiceGroupsResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetMedicalServiceGroupsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetPriceList", ReplyAction="http://tempuri.org/IDictionaryService/GetPriceListResponse")]
        System.IO.Stream GetPriceList(string locationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetPriceList", ReplyAction="http://tempuri.org/IDictionaryService/GetPriceListResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetPriceListAsync(string locationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetPatientQuestions", ReplyAction="http://tempuri.org/IDictionaryService/GetPatientQuestionsResponse")]
        System.IO.Stream GetPatientQuestions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetPatientQuestions", ReplyAction="http://tempuri.org/IDictionaryService/GetPatientQuestionsResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetPatientQuestionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetTubes", ReplyAction="http://tempuri.org/IDictionaryService/GetTubesResponse")]
        System.IO.Stream GetTubes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetTubes", ReplyAction="http://tempuri.org/IDictionaryService/GetTubesResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetTubesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetDiscounts", ReplyAction="http://tempuri.org/IDictionaryService/GetDiscountsResponse")]
        System.IO.Stream GetDiscounts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDictionaryService/GetDiscounts", ReplyAction="http://tempuri.org/IDictionaryService/GetDiscountsResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetDiscountsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDictionaryServiceChannel : Spravochnik_Api.DictionaryServiceReference.IDictionaryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DictionaryServiceClient : System.ServiceModel.ClientBase<Spravochnik_Api.DictionaryServiceReference.IDictionaryService>, Spravochnik_Api.DictionaryServiceReference.IDictionaryService {
        
        public DictionaryServiceClient() {
        }
        
        public DictionaryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DictionaryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DictionaryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DictionaryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.IO.Stream GetLocations(string languageCd, bool showAll) {
            return base.Channel.GetLocations(languageCd, showAll);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetLocationsAsync(string languageCd, bool showAll) {
            return base.Channel.GetLocationsAsync(languageCd, showAll);
        }
        
        public System.IO.Stream GetSubstances() {
            return base.Channel.GetSubstances();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetSubstancesAsync() {
            return base.Channel.GetSubstancesAsync();
        }
        
        public System.IO.Stream GetServices(string languageCd, string laboratoryId) {
            return base.Channel.GetServices(languageCd, laboratoryId);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetServicesAsync(string languageCd, string laboratoryId) {
            return base.Channel.GetServicesAsync(languageCd, laboratoryId);
        }
        
        public System.IO.Stream GetMedicalServiceGroups() {
            return base.Channel.GetMedicalServiceGroups();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetMedicalServiceGroupsAsync() {
            return base.Channel.GetMedicalServiceGroupsAsync();
        }
        
        public System.IO.Stream GetPriceList(string locationId) {
            return base.Channel.GetPriceList(locationId);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetPriceListAsync(string locationId) {
            return base.Channel.GetPriceListAsync(locationId);
        }
        
        public System.IO.Stream GetPatientQuestions() {
            return base.Channel.GetPatientQuestions();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetPatientQuestionsAsync() {
            return base.Channel.GetPatientQuestionsAsync();
        }
        
        public System.IO.Stream GetTubes() {
            return base.Channel.GetTubes();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetTubesAsync() {
            return base.Channel.GetTubesAsync();
        }
        
        public System.IO.Stream GetDiscounts() {
            return base.Channel.GetDiscounts();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetDiscountsAsync() {
            return base.Channel.GetDiscountsAsync();
        }
    }
}
