﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZucchettiCensimentoAttivita
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://htht_fwsztsanag.ws.localhost/", ConfigurationName="ZucchettiCensimentoAttivita.htht_fwsztsanagWS")]
    public interface htht_fwsztsanagWS
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ZucchettiCensimentoAttivita.htht_fwsztsanag_RunResponse> htht_fwsztsanag_RunAsync(ZucchettiCensimentoAttivita.htht_fwsztsanag_Run request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class htht_fwsztsanag_Run
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="htht_fwsztsanag_Run", Namespace="http://htht_fwsztsanag.ws.localhost/", Order=0)]
        public ZucchettiCensimentoAttivita.htht_fwsztsanag_RunBody Body;
        
        public htht_fwsztsanag_Run()
        {
        }
        
        public htht_fwsztsanag_Run(ZucchettiCensimentoAttivita.htht_fwsztsanag_RunBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://htht_fwsztsanag.ws.localhost/")]
    public partial class htht_fwsztsanag_RunBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string m_UserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string m_Password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string m_Company;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string p_info;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string p_upd_mode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string p_flcompress;
        
        public htht_fwsztsanag_RunBody()
        {
        }
        
        public htht_fwsztsanag_RunBody(string m_UserName, string m_Password, string m_Company, string p_info, string p_upd_mode, string p_flcompress)
        {
            this.m_UserName = m_UserName;
            this.m_Password = m_Password;
            this.m_Company = m_Company;
            this.p_info = p_info;
            this.p_upd_mode = p_upd_mode;
            this.p_flcompress = p_flcompress;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class htht_fwsztsanag_RunResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="htht_fwsztsanag_RunResponse", Namespace="http://htht_fwsztsanag.ws.localhost/", Order=0)]
        public ZucchettiCensimentoAttivita.htht_fwsztsanag_RunResponseBody Body;
        
        public htht_fwsztsanag_RunResponse()
        {
        }
        
        public htht_fwsztsanag_RunResponse(ZucchettiCensimentoAttivita.htht_fwsztsanag_RunResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://htht_fwsztsanag.ws.localhost/")]
    public partial class htht_fwsztsanag_RunResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public htht_fwsztsanag_RunResponseBody()
        {
        }
        
        public htht_fwsztsanag_RunResponseBody(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface htht_fwsztsanagWSChannel : ZucchettiCensimentoAttivita.htht_fwsztsanagWS, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class htht_fwsztsanagWSClient : System.ServiceModel.ClientBase<ZucchettiCensimentoAttivita.htht_fwsztsanagWS>, ZucchettiCensimentoAttivita.htht_fwsztsanagWS
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public htht_fwsztsanagWSClient() : 
                base(htht_fwsztsanagWSClient.GetDefaultBinding(), htht_fwsztsanagWSClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.htht_fwsztsanagWSPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public htht_fwsztsanagWSClient(EndpointConfiguration endpointConfiguration) : 
                base(htht_fwsztsanagWSClient.GetBindingForEndpoint(endpointConfiguration), htht_fwsztsanagWSClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public htht_fwsztsanagWSClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(htht_fwsztsanagWSClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public htht_fwsztsanagWSClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(htht_fwsztsanagWSClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public htht_fwsztsanagWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ZucchettiCensimentoAttivita.htht_fwsztsanag_RunResponse> ZucchettiCensimentoAttivita.htht_fwsztsanagWS.htht_fwsztsanag_RunAsync(ZucchettiCensimentoAttivita.htht_fwsztsanag_Run request)
        {
            return base.Channel.htht_fwsztsanag_RunAsync(request);
        }
        
        public System.Threading.Tasks.Task<ZucchettiCensimentoAttivita.htht_fwsztsanag_RunResponse> htht_fwsztsanag_RunAsync(string m_UserName, string m_Password, string m_Company, string p_info, string p_upd_mode, string p_flcompress)
        {
            ZucchettiCensimentoAttivita.htht_fwsztsanag_Run inValue = new ZucchettiCensimentoAttivita.htht_fwsztsanag_Run();
            inValue.Body = new ZucchettiCensimentoAttivita.htht_fwsztsanag_RunBody();
            inValue.Body.m_UserName = m_UserName;
            inValue.Body.m_Password = m_Password;
            inValue.Body.m_Company = m_Company;
            inValue.Body.p_info = p_info;
            inValue.Body.p_upd_mode = p_upd_mode;
            inValue.Body.p_flcompress = p_flcompress;
            return ((ZucchettiCensimentoAttivita.htht_fwsztsanagWS)(this)).htht_fwsztsanag_RunAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.htht_fwsztsanagWSPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.htht_fwsztsanagWSPort))
            {
                return new System.ServiceModel.EndpointAddress("http://10.16.187.59/ZTimesheet/servlet/htht_fwsztsanag");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return htht_fwsztsanagWSClient.GetBindingForEndpoint(EndpointConfiguration.htht_fwsztsanagWSPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return htht_fwsztsanagWSClient.GetEndpointAddress(EndpointConfiguration.htht_fwsztsanagWSPort);
        }
        
        public enum EndpointConfiguration
        {
            
            htht_fwsztsanagWSPort,
        }
    }
}
