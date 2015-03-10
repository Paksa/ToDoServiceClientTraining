﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace ToDoManager.ToDoRemoteService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IToDoManager", Namespace="http://tempuri.org/")]
    public partial class ToDoManager : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetTodoListOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateToDoItemOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateToDoItemOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteToDoItemOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateUserOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ToDoManager() {
            this.Url = global::ToDoManager.Properties.Settings.Default.ToDoManager_ToDoRemoteService_ToDoManager;
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
        public event GetTodoListCompletedEventHandler GetTodoListCompleted;
        
        /// <remarks/>
        public event UpdateToDoItemCompletedEventHandler UpdateToDoItemCompleted;
        
        /// <remarks/>
        public event CreateToDoItemCompletedEventHandler CreateToDoItemCompleted;
        
        /// <remarks/>
        public event DeleteToDoItemCompletedEventHandler DeleteToDoItemCompleted;
        
        /// <remarks/>
        public event CreateUserCompletedEventHandler CreateUserCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IToDoManager/GetTodoList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/ToDoManagerService.Entities")]
        public ToDoItem[] GetTodoList(int userId, [System.Xml.Serialization.XmlIgnoreAttribute()] bool userIdSpecified) {
            object[] results = this.Invoke("GetTodoList", new object[] {
                        userId,
                        userIdSpecified});
            return ((ToDoItem[])(results[0]));
        }
        
        /// <remarks/>
        public void GetTodoListAsync(int userId, bool userIdSpecified) {
            this.GetTodoListAsync(userId, userIdSpecified, null);
        }
        
        /// <remarks/>
        public void GetTodoListAsync(int userId, bool userIdSpecified, object userState) {
            if ((this.GetTodoListOperationCompleted == null)) {
                this.GetTodoListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTodoListOperationCompleted);
            }
            this.InvokeAsync("GetTodoList", new object[] {
                        userId,
                        userIdSpecified}, this.GetTodoListOperationCompleted, userState);
        }
        
        private void OnGetTodoListOperationCompleted(object arg) {
            if ((this.GetTodoListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTodoListCompleted(this, new GetTodoListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IToDoManager/UpdateToDoItem", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateToDoItem([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ToDoItem todo) {
            this.Invoke("UpdateToDoItem", new object[] {
                        todo});
        }
        
        /// <remarks/>
        public void UpdateToDoItemAsync(ToDoItem todo) {
            this.UpdateToDoItemAsync(todo, null);
        }
        
        /// <remarks/>
        public void UpdateToDoItemAsync(ToDoItem todo, object userState) {
            if ((this.UpdateToDoItemOperationCompleted == null)) {
                this.UpdateToDoItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateToDoItemOperationCompleted);
            }
            this.InvokeAsync("UpdateToDoItem", new object[] {
                        todo}, this.UpdateToDoItemOperationCompleted, userState);
        }
        
        private void OnUpdateToDoItemOperationCompleted(object arg) {
            if ((this.UpdateToDoItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateToDoItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IToDoManager/CreateToDoItem", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateToDoItem([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] ToDoItem todo) {
            this.Invoke("CreateToDoItem", new object[] {
                        todo});
        }
        
        /// <remarks/>
        public void CreateToDoItemAsync(ToDoItem todo) {
            this.CreateToDoItemAsync(todo, null);
        }
        
        /// <remarks/>
        public void CreateToDoItemAsync(ToDoItem todo, object userState) {
            if ((this.CreateToDoItemOperationCompleted == null)) {
                this.CreateToDoItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateToDoItemOperationCompleted);
            }
            this.InvokeAsync("CreateToDoItem", new object[] {
                        todo}, this.CreateToDoItemOperationCompleted, userState);
        }
        
        private void OnCreateToDoItemOperationCompleted(object arg) {
            if ((this.CreateToDoItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateToDoItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IToDoManager/DeleteToDoItem", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteToDoItem(int todoItemId, [System.Xml.Serialization.XmlIgnoreAttribute()] bool todoItemIdSpecified) {
            this.Invoke("DeleteToDoItem", new object[] {
                        todoItemId,
                        todoItemIdSpecified});
        }
        
        /// <remarks/>
        public void DeleteToDoItemAsync(int todoItemId, bool todoItemIdSpecified) {
            this.DeleteToDoItemAsync(todoItemId, todoItemIdSpecified, null);
        }
        
        /// <remarks/>
        public void DeleteToDoItemAsync(int todoItemId, bool todoItemIdSpecified, object userState) {
            if ((this.DeleteToDoItemOperationCompleted == null)) {
                this.DeleteToDoItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteToDoItemOperationCompleted);
            }
            this.InvokeAsync("DeleteToDoItem", new object[] {
                        todoItemId,
                        todoItemIdSpecified}, this.DeleteToDoItemOperationCompleted, userState);
        }
        
        private void OnDeleteToDoItemOperationCompleted(object arg) {
            if ((this.DeleteToDoItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteToDoItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IToDoManager/CreateUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateUser([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string name, out int CreateUserResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool CreateUserResultSpecified) {
            object[] results = this.Invoke("CreateUser", new object[] {
                        name});
            CreateUserResult = ((int)(results[0]));
            CreateUserResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void CreateUserAsync(string name) {
            this.CreateUserAsync(name, null);
        }
        
        /// <remarks/>
        public void CreateUserAsync(string name, object userState) {
            if ((this.CreateUserOperationCompleted == null)) {
                this.CreateUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateUserOperationCompleted);
            }
            this.InvokeAsync("CreateUser", new object[] {
                        name}, this.CreateUserOperationCompleted, userState);
        }
        
        private void OnCreateUserOperationCompleted(object arg) {
            if ((this.CreateUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateUserCompleted(this, new CreateUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/ToDoManagerService.Entities")]
    public partial class ToDoItem {
        
        private bool isCompletedField;
        
        private bool isCompletedFieldSpecified;
        
        private string nameField;
        
        private int toDoIdField;
        
        private bool toDoIdFieldSpecified;
        
        private int userIdField;
        
        private bool userIdFieldSpecified;
        
        /// <remarks/>
        public bool IsCompleted {
            get {
                return this.isCompletedField;
            }
            set {
                this.isCompletedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsCompletedSpecified {
            get {
                return this.isCompletedFieldSpecified;
            }
            set {
                this.isCompletedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int ToDoId {
            get {
                return this.toDoIdField;
            }
            set {
                this.toDoIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ToDoIdSpecified {
            get {
                return this.toDoIdFieldSpecified;
            }
            set {
                this.toDoIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int UserId {
            get {
                return this.userIdField;
            }
            set {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserIdSpecified {
            get {
                return this.userIdFieldSpecified;
            }
            set {
                this.userIdFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetTodoListCompletedEventHandler(object sender, GetTodoListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTodoListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTodoListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ToDoItem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ToDoItem[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void UpdateToDoItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void CreateToDoItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void DeleteToDoItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void CreateUserCompletedEventHandler(object sender, CreateUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int CreateUserResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool CreateUserResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591