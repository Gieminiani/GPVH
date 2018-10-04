﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LB_GPVH.ServiceWSFuncionarios {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceWSFuncionarios.IWSFuncionarios")]
    public interface IWSFuncionarios {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/getListadoFuncionarios", ReplyAction="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosResponse")]
        WS_GPVH.WebServices.Funcionarios.Funcionario[] getListadoFuncionarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/getListadoFuncionarios", ReplyAction="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosResponse")]
        System.Threading.Tasks.Task<WS_GPVH.WebServices.Funcionarios.Funcionario[]> getListadoFuncionariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosClaveValor", ReplyAction="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosClaveValorResponse")]
        System.Collections.Generic.Dictionary<int, string> getListadoFuncionariosClaveValor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosClaveValor", ReplyAction="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosClaveValorResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> getListadoFuncionariosClaveValorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosNoJefesClaveValor", ReplyAction="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosNoJefesClaveValorRespons" +
            "e")]
        System.Collections.Generic.Dictionary<int, string> getListadoFuncionariosNoJefesClaveValor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosNoJefesClaveValor", ReplyAction="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosNoJefesClaveValorRespons" +
            "e")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> getListadoFuncionariosNoJefesClaveValorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosNoJefesNoClaveValorModif" +
            "icar", ReplyAction="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosNoJefesNoClaveValorModif" +
            "icarResponse")]
        System.Collections.Generic.Dictionary<int, string> getListadoFuncionariosNoJefesNoClaveValorModificar(int id_unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosNoJefesNoClaveValorModif" +
            "icar", ReplyAction="http://tempuri.org/IWSFuncionarios/getListadoFuncionariosNoJefesNoClaveValorModif" +
            "icarResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> getListadoFuncionariosNoJefesNoClaveValorModificarAsync(int id_unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/getFuncionarioByRun", ReplyAction="http://tempuri.org/IWSFuncionarios/getFuncionarioByRunResponse")]
        WS_GPVH.WebServices.Funcionarios.Funcionario getFuncionarioByRun(int run);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/getFuncionarioByRun", ReplyAction="http://tempuri.org/IWSFuncionarios/getFuncionarioByRunResponse")]
        System.Threading.Tasks.Task<WS_GPVH.WebServices.Funcionarios.Funcionario> getFuncionarioByRunAsync(int run);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/addFuncionario", ReplyAction="http://tempuri.org/IWSFuncionarios/addFuncionarioResponse")]
        int addFuncionario(int run, int dv, string nombre, string ap_pat, string ap_mat, System.DateTime nacimiento, string correo, string direccion, string tipo_funcionario, int id_unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/addFuncionario", ReplyAction="http://tempuri.org/IWSFuncionarios/addFuncionarioResponse")]
        System.Threading.Tasks.Task<int> addFuncionarioAsync(int run, int dv, string nombre, string ap_pat, string ap_mat, System.DateTime nacimiento, string correo, string direccion, string tipo_funcionario, int id_unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/modifyFuncionario", ReplyAction="http://tempuri.org/IWSFuncionarios/modifyFuncionarioResponse")]
        int modifyFuncionario(int run, string nombre, string ap_pat, string ap_mat, System.DateTime nacimiento, string correo, string direccion, string tipo_funcionario, bool habilitado_bool, int id_unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/modifyFuncionario", ReplyAction="http://tempuri.org/IWSFuncionarios/modifyFuncionarioResponse")]
        System.Threading.Tasks.Task<int> modifyFuncionarioAsync(int run, string nombre, string ap_pat, string ap_mat, System.DateTime nacimiento, string correo, string direccion, string tipo_funcionario, bool habilitado_bool, int id_unidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/deleteFuncionario", ReplyAction="http://tempuri.org/IWSFuncionarios/deleteFuncionarioResponse")]
        int deleteFuncionario(int run);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSFuncionarios/deleteFuncionario", ReplyAction="http://tempuri.org/IWSFuncionarios/deleteFuncionarioResponse")]
        System.Threading.Tasks.Task<int> deleteFuncionarioAsync(int run);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSFuncionariosChannel : LB_GPVH.ServiceWSFuncionarios.IWSFuncionarios, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSFuncionariosClient : System.ServiceModel.ClientBase<LB_GPVH.ServiceWSFuncionarios.IWSFuncionarios>, LB_GPVH.ServiceWSFuncionarios.IWSFuncionarios {
        
        public WSFuncionariosClient() {
        }
        
        public WSFuncionariosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSFuncionariosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSFuncionariosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSFuncionariosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WS_GPVH.WebServices.Funcionarios.Funcionario[] getListadoFuncionarios() {
            return base.Channel.getListadoFuncionarios();
        }
        
        public System.Threading.Tasks.Task<WS_GPVH.WebServices.Funcionarios.Funcionario[]> getListadoFuncionariosAsync() {
            return base.Channel.getListadoFuncionariosAsync();
        }
        
        public System.Collections.Generic.Dictionary<int, string> getListadoFuncionariosClaveValor() {
            return base.Channel.getListadoFuncionariosClaveValor();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> getListadoFuncionariosClaveValorAsync() {
            return base.Channel.getListadoFuncionariosClaveValorAsync();
        }
        
        public System.Collections.Generic.Dictionary<int, string> getListadoFuncionariosNoJefesClaveValor() {
            return base.Channel.getListadoFuncionariosNoJefesClaveValor();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> getListadoFuncionariosNoJefesClaveValorAsync() {
            return base.Channel.getListadoFuncionariosNoJefesClaveValorAsync();
        }
        
        public System.Collections.Generic.Dictionary<int, string> getListadoFuncionariosNoJefesNoClaveValorModificar(int id_unidad) {
            return base.Channel.getListadoFuncionariosNoJefesNoClaveValorModificar(id_unidad);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string>> getListadoFuncionariosNoJefesNoClaveValorModificarAsync(int id_unidad) {
            return base.Channel.getListadoFuncionariosNoJefesNoClaveValorModificarAsync(id_unidad);
        }
        
        public WS_GPVH.WebServices.Funcionarios.Funcionario getFuncionarioByRun(int run) {
            return base.Channel.getFuncionarioByRun(run);
        }
        
        public System.Threading.Tasks.Task<WS_GPVH.WebServices.Funcionarios.Funcionario> getFuncionarioByRunAsync(int run) {
            return base.Channel.getFuncionarioByRunAsync(run);
        }
        
        public int addFuncionario(int run, int dv, string nombre, string ap_pat, string ap_mat, System.DateTime nacimiento, string correo, string direccion, string tipo_funcionario, int id_unidad) {
            return base.Channel.addFuncionario(run, dv, nombre, ap_pat, ap_mat, nacimiento, correo, direccion, tipo_funcionario, id_unidad);
        }
        
        public System.Threading.Tasks.Task<int> addFuncionarioAsync(int run, int dv, string nombre, string ap_pat, string ap_mat, System.DateTime nacimiento, string correo, string direccion, string tipo_funcionario, int id_unidad) {
            return base.Channel.addFuncionarioAsync(run, dv, nombre, ap_pat, ap_mat, nacimiento, correo, direccion, tipo_funcionario, id_unidad);
        }
        
        public int modifyFuncionario(int run, string nombre, string ap_pat, string ap_mat, System.DateTime nacimiento, string correo, string direccion, string tipo_funcionario, bool habilitado_bool, int id_unidad) {
            return base.Channel.modifyFuncionario(run, nombre, ap_pat, ap_mat, nacimiento, correo, direccion, tipo_funcionario, habilitado_bool, id_unidad);
        }
        
        public System.Threading.Tasks.Task<int> modifyFuncionarioAsync(int run, string nombre, string ap_pat, string ap_mat, System.DateTime nacimiento, string correo, string direccion, string tipo_funcionario, bool habilitado_bool, int id_unidad) {
            return base.Channel.modifyFuncionarioAsync(run, nombre, ap_pat, ap_mat, nacimiento, correo, direccion, tipo_funcionario, habilitado_bool, id_unidad);
        }
        
        public int deleteFuncionario(int run) {
            return base.Channel.deleteFuncionario(run);
        }
        
        public System.Threading.Tasks.Task<int> deleteFuncionarioAsync(int run) {
            return base.Channel.deleteFuncionarioAsync(run);
        }
    }
}