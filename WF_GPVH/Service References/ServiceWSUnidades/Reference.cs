﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WF_GPVH.ServiceWSUnidades {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceWSUnidades.IWSUnidades")]
    public interface IWSUnidades {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/getListadoUnidades", ReplyAction="http://tempuri.org/IWSUnidades/getListadoUnidadesResponse")]
        WS_GPVH.WebServices.Unidades.Unidad[] getListadoUnidades();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/getListadoUnidades", ReplyAction="http://tempuri.org/IWSUnidades/getListadoUnidadesResponse")]
        System.Threading.Tasks.Task<WS_GPVH.WebServices.Unidades.Unidad[]> getListadoUnidadesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/unidadExiste", ReplyAction="http://tempuri.org/IWSUnidades/unidadExisteResponse")]
        bool unidadExiste(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/unidadExiste", ReplyAction="http://tempuri.org/IWSUnidades/unidadExisteResponse")]
        System.Threading.Tasks.Task<bool> unidadExisteAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/getListadoUnidadesNoHijas", ReplyAction="http://tempuri.org/IWSUnidades/getListadoUnidadesNoHijasResponse")]
        WS_GPVH.WebServices.Unidades.Unidad[] getListadoUnidadesNoHijas(int id_unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/getListadoUnidadesNoHijas", ReplyAction="http://tempuri.org/IWSUnidades/getListadoUnidadesNoHijasResponse")]
        System.Threading.Tasks.Task<WS_GPVH.WebServices.Unidades.Unidad[]> getListadoUnidadesNoHijasAsync(int id_unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/getListadoUnidadesNoHijasClaveValor", ReplyAction="http://tempuri.org/IWSUnidades/getListadoUnidadesNoHijasClaveValorResponse")]
        System.Collections.Generic.Dictionary<int, string> getListadoUnidadesNoHijasClaveValor(int id_unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/getListadoUnidadesNoHijasClaveValor", ReplyAction="http://tempuri.org/IWSUnidades/getListadoUnidadesNoHijasClaveValorResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> getListadoUnidadesNoHijasClaveValorAsync(int id_unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/getListadoUnidadesClaveValor", ReplyAction="http://tempuri.org/IWSUnidades/getListadoUnidadesClaveValorResponse")]
        System.Collections.Generic.Dictionary<int, string> getListadoUnidadesClaveValor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/getListadoUnidadesClaveValor", ReplyAction="http://tempuri.org/IWSUnidades/getListadoUnidadesClaveValorResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> getListadoUnidadesClaveValorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/getUnidadById", ReplyAction="http://tempuri.org/IWSUnidades/getUnidadByIdResponse")]
        WS_GPVH.WebServices.Unidades.Unidad getUnidadById(int id_unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/getUnidadById", ReplyAction="http://tempuri.org/IWSUnidades/getUnidadByIdResponse")]
        System.Threading.Tasks.Task<WS_GPVH.WebServices.Unidades.Unidad> getUnidadByIdAsync(int id_unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/addUnidad", ReplyAction="http://tempuri.org/IWSUnidades/addUnidadResponse")]
        int addUnidad(string nombre, string descripcion, string direccion, System.Nullable<int> unidad_padre, System.Nullable<int> jefe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/addUnidad", ReplyAction="http://tempuri.org/IWSUnidades/addUnidadResponse")]
        System.Threading.Tasks.Task<int> addUnidadAsync(string nombre, string descripcion, string direccion, System.Nullable<int> unidad_padre, System.Nullable<int> jefe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/modifyUnidad", ReplyAction="http://tempuri.org/IWSUnidades/modifyUnidadResponse")]
        int modifyUnidad(int id_unidad, string nombre, string descripcion, string direccion, bool habilitado_bool, System.Nullable<int> unidad_padre, System.Nullable<int> jefe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/modifyUnidad", ReplyAction="http://tempuri.org/IWSUnidades/modifyUnidadResponse")]
        System.Threading.Tasks.Task<int> modifyUnidadAsync(int id_unidad, string nombre, string descripcion, string direccion, bool habilitado_bool, System.Nullable<int> unidad_padre, System.Nullable<int> jefe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/deleteUnidad", ReplyAction="http://tempuri.org/IWSUnidades/deleteUnidadResponse")]
        int deleteUnidad(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/deleteUnidad", ReplyAction="http://tempuri.org/IWSUnidades/deleteUnidadResponse")]
        System.Threading.Tasks.Task<int> deleteUnidadAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/filterListadoUnidades", ReplyAction="http://tempuri.org/IWSUnidades/filterListadoUnidadesResponse")]
        System.Collections.Generic.Dictionary<int, string> filterListadoUnidades(WS_GPVH.WebServices.Unidades.Unidad[] listado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSUnidades/filterListadoUnidades", ReplyAction="http://tempuri.org/IWSUnidades/filterListadoUnidadesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> filterListadoUnidadesAsync(WS_GPVH.WebServices.Unidades.Unidad[] listado);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSUnidadesChannel : WF_GPVH.ServiceWSUnidades.IWSUnidades, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSUnidadesClient : System.ServiceModel.ClientBase<WF_GPVH.ServiceWSUnidades.IWSUnidades>, WF_GPVH.ServiceWSUnidades.IWSUnidades {
        
        public WSUnidadesClient() {
        }
        
        public WSUnidadesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSUnidadesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSUnidadesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSUnidadesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WS_GPVH.WebServices.Unidades.Unidad[] getListadoUnidades() {
            return base.Channel.getListadoUnidades();
        }
        
        public System.Threading.Tasks.Task<WS_GPVH.WebServices.Unidades.Unidad[]> getListadoUnidadesAsync() {
            return base.Channel.getListadoUnidadesAsync();
        }
        
        public bool unidadExiste(string nombre) {
            return base.Channel.unidadExiste(nombre);
        }
        
        public System.Threading.Tasks.Task<bool> unidadExisteAsync(string nombre) {
            return base.Channel.unidadExisteAsync(nombre);
        }
        
        public WS_GPVH.WebServices.Unidades.Unidad[] getListadoUnidadesNoHijas(int id_unidad) {
            return base.Channel.getListadoUnidadesNoHijas(id_unidad);
        }
        
        public System.Threading.Tasks.Task<WS_GPVH.WebServices.Unidades.Unidad[]> getListadoUnidadesNoHijasAsync(int id_unidad) {
            return base.Channel.getListadoUnidadesNoHijasAsync(id_unidad);
        }
        
        public System.Collections.Generic.Dictionary<int, string> getListadoUnidadesNoHijasClaveValor(int id_unidad) {
            return base.Channel.getListadoUnidadesNoHijasClaveValor(id_unidad);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> getListadoUnidadesNoHijasClaveValorAsync(int id_unidad) {
            return base.Channel.getListadoUnidadesNoHijasClaveValorAsync(id_unidad);
        }
        
        public System.Collections.Generic.Dictionary<int, string> getListadoUnidadesClaveValor() {
            return base.Channel.getListadoUnidadesClaveValor();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> getListadoUnidadesClaveValorAsync() {
            return base.Channel.getListadoUnidadesClaveValorAsync();
        }
        
        public WS_GPVH.WebServices.Unidades.Unidad getUnidadById(int id_unidad) {
            return base.Channel.getUnidadById(id_unidad);
        }
        
        public System.Threading.Tasks.Task<WS_GPVH.WebServices.Unidades.Unidad> getUnidadByIdAsync(int id_unidad) {
            return base.Channel.getUnidadByIdAsync(id_unidad);
        }
        
        public int addUnidad(string nombre, string descripcion, string direccion, System.Nullable<int> unidad_padre, System.Nullable<int> jefe) {
            return base.Channel.addUnidad(nombre, descripcion, direccion, unidad_padre, jefe);
        }
        
        public System.Threading.Tasks.Task<int> addUnidadAsync(string nombre, string descripcion, string direccion, System.Nullable<int> unidad_padre, System.Nullable<int> jefe) {
            return base.Channel.addUnidadAsync(nombre, descripcion, direccion, unidad_padre, jefe);
        }
        
        public int modifyUnidad(int id_unidad, string nombre, string descripcion, string direccion, bool habilitado_bool, System.Nullable<int> unidad_padre, System.Nullable<int> jefe) {
            return base.Channel.modifyUnidad(id_unidad, nombre, descripcion, direccion, habilitado_bool, unidad_padre, jefe);
        }
        
        public System.Threading.Tasks.Task<int> modifyUnidadAsync(int id_unidad, string nombre, string descripcion, string direccion, bool habilitado_bool, System.Nullable<int> unidad_padre, System.Nullable<int> jefe) {
            return base.Channel.modifyUnidadAsync(id_unidad, nombre, descripcion, direccion, habilitado_bool, unidad_padre, jefe);
        }
        
        public int deleteUnidad(int id) {
            return base.Channel.deleteUnidad(id);
        }
        
        public System.Threading.Tasks.Task<int> deleteUnidadAsync(int id) {
            return base.Channel.deleteUnidadAsync(id);
        }
        
        public System.Collections.Generic.Dictionary<int, string> filterListadoUnidades(WS_GPVH.WebServices.Unidades.Unidad[] listado) {
            return base.Channel.filterListadoUnidades(listado);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> filterListadoUnidadesAsync(WS_GPVH.WebServices.Unidades.Unidad[] listado) {
            return base.Channel.filterListadoUnidadesAsync(listado);
        }
    }
}
