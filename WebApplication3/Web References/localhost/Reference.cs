﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebApplication3.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetOperationCompleted;
        
        private System.Threading.SendOrPostCallback Get1OperationCompleted;
        
        private System.Threading.SendOrPostCallback Get2OperationCompleted;
        
        private System.Threading.SendOrPostCallback Get3OperationCompleted;
        
        private System.Threading.SendOrPostCallback Get4OperationCompleted;
        
        private System.Threading.SendOrPostCallback Get5OperationCompleted;
        
        private System.Threading.SendOrPostCallback Get6OperationCompleted;
        
        private System.Threading.SendOrPostCallback Get7OperationCompleted;
        
        private System.Threading.SendOrPostCallback Get8OperationCompleted;
        
        private System.Threading.SendOrPostCallback findupdateemployeeOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteEmployeOperationCompleted;
        
        private System.Threading.SendOrPostCallback addemployeeOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateemployeeOperationCompleted;
        
        private System.Threading.SendOrPostCallback FindEmployeeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::WebApplication3.Properties.Settings.Default.WebApplication3_localhost_WebService1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetCompletedEventHandler GetCompleted;
        
        /// <remarks/>
        public event Get1CompletedEventHandler Get1Completed;
        
        /// <remarks/>
        public event Get2CompletedEventHandler Get2Completed;
        
        /// <remarks/>
        public event Get3CompletedEventHandler Get3Completed;
        
        /// <remarks/>
        public event Get4CompletedEventHandler Get4Completed;
        
        /// <remarks/>
        public event Get5CompletedEventHandler Get5Completed;
        
        /// <remarks/>
        public event Get6CompletedEventHandler Get6Completed;
        
        /// <remarks/>
        public event Get7CompletedEventHandler Get7Completed;
        
        /// <remarks/>
        public event Get8CompletedEventHandler Get8Completed;
        
        /// <remarks/>
        public event findupdateemployeeCompletedEventHandler findupdateemployeeCompleted;
        
        /// <remarks/>
        public event DeleteEmployeCompletedEventHandler DeleteEmployeCompleted;
        
        /// <remarks/>
        public event addemployeeCompletedEventHandler addemployeeCompleted;
        
        /// <remarks/>
        public event updateemployeeCompletedEventHandler updateemployeeCompleted;
        
        /// <remarks/>
        public event FindEmployeeCompletedEventHandler FindEmployeeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Get", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Get() {
            object[] results = this.Invoke("Get", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void GetAsync() {
            this.GetAsync(null);
        }
        
        /// <remarks/>
        public void GetAsync(object userState) {
            if ((this.GetOperationCompleted == null)) {
                this.GetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOperationCompleted);
            }
            this.InvokeAsync("Get", new object[0], this.GetOperationCompleted, userState);
        }
        
        private void OnGetOperationCompleted(object arg) {
            if ((this.GetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCompleted(this, new GetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Get1", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Get1() {
            object[] results = this.Invoke("Get1", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void Get1Async() {
            this.Get1Async(null);
        }
        
        /// <remarks/>
        public void Get1Async(object userState) {
            if ((this.Get1OperationCompleted == null)) {
                this.Get1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGet1OperationCompleted);
            }
            this.InvokeAsync("Get1", new object[0], this.Get1OperationCompleted, userState);
        }
        
        private void OnGet1OperationCompleted(object arg) {
            if ((this.Get1Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Get1Completed(this, new Get1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Get2", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Get2() {
            object[] results = this.Invoke("Get2", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void Get2Async() {
            this.Get2Async(null);
        }
        
        /// <remarks/>
        public void Get2Async(object userState) {
            if ((this.Get2OperationCompleted == null)) {
                this.Get2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGet2OperationCompleted);
            }
            this.InvokeAsync("Get2", new object[0], this.Get2OperationCompleted, userState);
        }
        
        private void OnGet2OperationCompleted(object arg) {
            if ((this.Get2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Get2Completed(this, new Get2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Get3", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Get3() {
            object[] results = this.Invoke("Get3", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void Get3Async() {
            this.Get3Async(null);
        }
        
        /// <remarks/>
        public void Get3Async(object userState) {
            if ((this.Get3OperationCompleted == null)) {
                this.Get3OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGet3OperationCompleted);
            }
            this.InvokeAsync("Get3", new object[0], this.Get3OperationCompleted, userState);
        }
        
        private void OnGet3OperationCompleted(object arg) {
            if ((this.Get3Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Get3Completed(this, new Get3CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Get4", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Get4() {
            object[] results = this.Invoke("Get4", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void Get4Async() {
            this.Get4Async(null);
        }
        
        /// <remarks/>
        public void Get4Async(object userState) {
            if ((this.Get4OperationCompleted == null)) {
                this.Get4OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGet4OperationCompleted);
            }
            this.InvokeAsync("Get4", new object[0], this.Get4OperationCompleted, userState);
        }
        
        private void OnGet4OperationCompleted(object arg) {
            if ((this.Get4Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Get4Completed(this, new Get4CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Get5", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Get5() {
            object[] results = this.Invoke("Get5", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void Get5Async() {
            this.Get5Async(null);
        }
        
        /// <remarks/>
        public void Get5Async(object userState) {
            if ((this.Get5OperationCompleted == null)) {
                this.Get5OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGet5OperationCompleted);
            }
            this.InvokeAsync("Get5", new object[0], this.Get5OperationCompleted, userState);
        }
        
        private void OnGet5OperationCompleted(object arg) {
            if ((this.Get5Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Get5Completed(this, new Get5CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Get6", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Get6() {
            object[] results = this.Invoke("Get6", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void Get6Async() {
            this.Get6Async(null);
        }
        
        /// <remarks/>
        public void Get6Async(object userState) {
            if ((this.Get6OperationCompleted == null)) {
                this.Get6OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGet6OperationCompleted);
            }
            this.InvokeAsync("Get6", new object[0], this.Get6OperationCompleted, userState);
        }
        
        private void OnGet6OperationCompleted(object arg) {
            if ((this.Get6Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Get6Completed(this, new Get6CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Get7", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Get7() {
            object[] results = this.Invoke("Get7", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void Get7Async() {
            this.Get7Async(null);
        }
        
        /// <remarks/>
        public void Get7Async(object userState) {
            if ((this.Get7OperationCompleted == null)) {
                this.Get7OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGet7OperationCompleted);
            }
            this.InvokeAsync("Get7", new object[0], this.Get7OperationCompleted, userState);
        }
        
        private void OnGet7OperationCompleted(object arg) {
            if ((this.Get7Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Get7Completed(this, new Get7CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Get8", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable Get8() {
            object[] results = this.Invoke("Get8", new object[0]);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void Get8Async() {
            this.Get8Async(null);
        }
        
        /// <remarks/>
        public void Get8Async(object userState) {
            if ((this.Get8OperationCompleted == null)) {
                this.Get8OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGet8OperationCompleted);
            }
            this.InvokeAsync("Get8", new object[0], this.Get8OperationCompleted, userState);
        }
        
        private void OnGet8OperationCompleted(object arg) {
            if ((this.Get8Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Get8Completed(this, new Get8CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/findupdateemployee", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable findupdateemployee(string upnr) {
            object[] results = this.Invoke("findupdateemployee", new object[] {
                        upnr});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void findupdateemployeeAsync(string upnr) {
            this.findupdateemployeeAsync(upnr, null);
        }
        
        /// <remarks/>
        public void findupdateemployeeAsync(string upnr, object userState) {
            if ((this.findupdateemployeeOperationCompleted == null)) {
                this.findupdateemployeeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindupdateemployeeOperationCompleted);
            }
            this.InvokeAsync("findupdateemployee", new object[] {
                        upnr}, this.findupdateemployeeOperationCompleted, userState);
        }
        
        private void OnfindupdateemployeeOperationCompleted(object arg) {
            if ((this.findupdateemployeeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findupdateemployeeCompleted(this, new findupdateemployeeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteEmploye", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteEmploye(string delnr) {
            this.Invoke("DeleteEmploye", new object[] {
                        delnr});
        }
        
        /// <remarks/>
        public void DeleteEmployeAsync(string delnr) {
            this.DeleteEmployeAsync(delnr, null);
        }
        
        /// <remarks/>
        public void DeleteEmployeAsync(string delnr, object userState) {
            if ((this.DeleteEmployeOperationCompleted == null)) {
                this.DeleteEmployeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteEmployeOperationCompleted);
            }
            this.InvokeAsync("DeleteEmploye", new object[] {
                        delnr}, this.DeleteEmployeOperationCompleted, userState);
        }
        
        private void OnDeleteEmployeOperationCompleted(object arg) {
            if ((this.DeleteEmployeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteEmployeCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addemployee", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void addemployee(string sosnr, string name, string adress, string lastname, string worktitle) {
            this.Invoke("addemployee", new object[] {
                        sosnr,
                        name,
                        adress,
                        lastname,
                        worktitle});
        }
        
        /// <remarks/>
        public void addemployeeAsync(string sosnr, string name, string adress, string lastname, string worktitle) {
            this.addemployeeAsync(sosnr, name, adress, lastname, worktitle, null);
        }
        
        /// <remarks/>
        public void addemployeeAsync(string sosnr, string name, string adress, string lastname, string worktitle, object userState) {
            if ((this.addemployeeOperationCompleted == null)) {
                this.addemployeeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddemployeeOperationCompleted);
            }
            this.InvokeAsync("addemployee", new object[] {
                        sosnr,
                        name,
                        adress,
                        lastname,
                        worktitle}, this.addemployeeOperationCompleted, userState);
        }
        
        private void OnaddemployeeOperationCompleted(object arg) {
            if ((this.addemployeeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addemployeeCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateemployee", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateemployee(string sosnr, string name, string adress, string lastname, string worktitle) {
            this.Invoke("updateemployee", new object[] {
                        sosnr,
                        name,
                        adress,
                        lastname,
                        worktitle});
        }
        
        /// <remarks/>
        public void updateemployeeAsync(string sosnr, string name, string adress, string lastname, string worktitle) {
            this.updateemployeeAsync(sosnr, name, adress, lastname, worktitle, null);
        }
        
        /// <remarks/>
        public void updateemployeeAsync(string sosnr, string name, string adress, string lastname, string worktitle, object userState) {
            if ((this.updateemployeeOperationCompleted == null)) {
                this.updateemployeeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateemployeeOperationCompleted);
            }
            this.InvokeAsync("updateemployee", new object[] {
                        sosnr,
                        name,
                        adress,
                        lastname,
                        worktitle}, this.updateemployeeOperationCompleted, userState);
        }
        
        private void OnupdateemployeeOperationCompleted(object arg) {
            if ((this.updateemployeeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateemployeeCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindEmployee", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void FindEmployee(string sosnr) {
            this.Invoke("FindEmployee", new object[] {
                        sosnr});
        }
        
        /// <remarks/>
        public void FindEmployeeAsync(string sosnr) {
            this.FindEmployeeAsync(sosnr, null);
        }
        
        /// <remarks/>
        public void FindEmployeeAsync(string sosnr, object userState) {
            if ((this.FindEmployeeOperationCompleted == null)) {
                this.FindEmployeeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFindEmployeeOperationCompleted);
            }
            this.InvokeAsync("FindEmployee", new object[] {
                        sosnr}, this.FindEmployeeOperationCompleted, userState);
        }
        
        private void OnFindEmployeeOperationCompleted(object arg) {
            if ((this.FindEmployeeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FindEmployeeCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void GetCompletedEventHandler(object sender, GetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void Get1CompletedEventHandler(object sender, Get1CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Get1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Get1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void Get2CompletedEventHandler(object sender, Get2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Get2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Get2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void Get3CompletedEventHandler(object sender, Get3CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Get3CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Get3CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void Get4CompletedEventHandler(object sender, Get4CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Get4CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Get4CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void Get5CompletedEventHandler(object sender, Get5CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Get5CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Get5CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void Get6CompletedEventHandler(object sender, Get6CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Get6CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Get6CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void Get7CompletedEventHandler(object sender, Get7CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Get7CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Get7CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void Get8CompletedEventHandler(object sender, Get8CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Get8CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Get8CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void findupdateemployeeCompletedEventHandler(object sender, findupdateemployeeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findupdateemployeeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findupdateemployeeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void DeleteEmployeCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void addemployeeCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void updateemployeeCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void FindEmployeeCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591