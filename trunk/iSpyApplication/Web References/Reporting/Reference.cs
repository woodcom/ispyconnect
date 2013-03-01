﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18010.
// 
#pragma warning disable 1591

namespace iSpyApplication.Reporting {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ReportingSoap", Namespace="http://tempuri.org/")]
    public partial class Reporting : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback LogApplicationExceptionOperationCompleted;
        
        private System.Threading.SendOrPostCallback LogUsageOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddCameraOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddCamera2OperationCompleted;
        
        private System.Threading.SendOrPostCallback SendFeedbackOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Reporting() {
            this.Url = "http://www.ispyconnect.com/Webservices/reporting.asmx";
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
        public event LogApplicationExceptionCompletedEventHandler LogApplicationExceptionCompleted;
        
        /// <remarks/>
        public event LogUsageCompletedEventHandler LogUsageCompleted;
        
        /// <remarks/>
        public event AddCameraCompletedEventHandler AddCameraCompleted;
        
        /// <remarks/>
        public event AddCamera2CompletedEventHandler AddCamera2Completed;
        
        /// <remarks/>
        public event SendFeedbackCompletedEventHandler SendFeedbackCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LogApplicationException", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void LogApplicationException(int ProductID, string Message, string Source, string HelpLink, string StackTrace, string ExceptionIdent) {
            this.Invoke("LogApplicationException", new object[] {
                        ProductID,
                        Message,
                        Source,
                        HelpLink,
                        StackTrace,
                        ExceptionIdent});
        }
        
        /// <remarks/>
        public void LogApplicationExceptionAsync(int ProductID, string Message, string Source, string HelpLink, string StackTrace, string ExceptionIdent) {
            this.LogApplicationExceptionAsync(ProductID, Message, Source, HelpLink, StackTrace, ExceptionIdent, null);
        }
        
        /// <remarks/>
        public void LogApplicationExceptionAsync(int ProductID, string Message, string Source, string HelpLink, string StackTrace, string ExceptionIdent, object userState) {
            if ((this.LogApplicationExceptionOperationCompleted == null)) {
                this.LogApplicationExceptionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLogApplicationExceptionOperationCompleted);
            }
            this.InvokeAsync("LogApplicationException", new object[] {
                        ProductID,
                        Message,
                        Source,
                        HelpLink,
                        StackTrace,
                        ExceptionIdent}, this.LogApplicationExceptionOperationCompleted, userState);
        }
        
        private void OnLogApplicationExceptionOperationCompleted(object arg) {
            if ((this.LogApplicationExceptionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LogApplicationExceptionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LogUsage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void LogUsage(int ProductID, string UsageReport) {
            this.Invoke("LogUsage", new object[] {
                        ProductID,
                        UsageReport});
        }
        
        /// <remarks/>
        public void LogUsageAsync(int ProductID, string UsageReport) {
            this.LogUsageAsync(ProductID, UsageReport, null);
        }
        
        /// <remarks/>
        public void LogUsageAsync(int ProductID, string UsageReport, object userState) {
            if ((this.LogUsageOperationCompleted == null)) {
                this.LogUsageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLogUsageOperationCompleted);
            }
            this.InvokeAsync("LogUsage", new object[] {
                        ProductID,
                        UsageReport}, this.LogUsageOperationCompleted, userState);
        }
        
        private void OnLogUsageOperationCompleted(object arg) {
            if ((this.LogUsageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LogUsageCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddCamera", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddCamera(string make, string model, string prefix, string source, string url, string cookies, string flags, int port) {
            this.Invoke("AddCamera", new object[] {
                        make,
                        model,
                        prefix,
                        source,
                        url,
                        cookies,
                        flags,
                        port});
        }
        
        /// <remarks/>
        public void AddCameraAsync(string make, string model, string prefix, string source, string url, string cookies, string flags, int port) {
            this.AddCameraAsync(make, model, prefix, source, url, cookies, flags, port, null);
        }
        
        /// <remarks/>
        public void AddCameraAsync(string make, string model, string prefix, string source, string url, string cookies, string flags, int port, object userState) {
            if ((this.AddCameraOperationCompleted == null)) {
                this.AddCameraOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddCameraOperationCompleted);
            }
            this.InvokeAsync("AddCamera", new object[] {
                        make,
                        model,
                        prefix,
                        source,
                        url,
                        cookies,
                        flags,
                        port}, this.AddCameraOperationCompleted, userState);
        }
        
        private void OnAddCameraOperationCompleted(object arg) {
            if ((this.AddCameraCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddCameraCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddCamera2", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddCamera2(string make, string model, string prefix, string source, string url, string cookies, string flags, int port) {
            this.Invoke("AddCamera2", new object[] {
                        make,
                        model,
                        prefix,
                        source,
                        url,
                        cookies,
                        flags,
                        port});
        }
        
        /// <remarks/>
        public void AddCamera2Async(string make, string model, string prefix, string source, string url, string cookies, string flags, int port) {
            this.AddCamera2Async(make, model, prefix, source, url, cookies, flags, port, null);
        }
        
        /// <remarks/>
        public void AddCamera2Async(string make, string model, string prefix, string source, string url, string cookies, string flags, int port, object userState) {
            if ((this.AddCamera2OperationCompleted == null)) {
                this.AddCamera2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddCamera2OperationCompleted);
            }
            this.InvokeAsync("AddCamera2", new object[] {
                        make,
                        model,
                        prefix,
                        source,
                        url,
                        cookies,
                        flags,
                        port}, this.AddCamera2OperationCompleted, userState);
        }
        
        private void OnAddCamera2OperationCompleted(object arg) {
            if ((this.AddCamera2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddCamera2Completed(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendFeedback", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SendFeedback(string Feedback, string FromEmail) {
            this.Invoke("SendFeedback", new object[] {
                        Feedback,
                        FromEmail});
        }
        
        /// <remarks/>
        public void SendFeedbackAsync(string Feedback, string FromEmail) {
            this.SendFeedbackAsync(Feedback, FromEmail, null);
        }
        
        /// <remarks/>
        public void SendFeedbackAsync(string Feedback, string FromEmail, object userState) {
            if ((this.SendFeedbackOperationCompleted == null)) {
                this.SendFeedbackOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendFeedbackOperationCompleted);
            }
            this.InvokeAsync("SendFeedback", new object[] {
                        Feedback,
                        FromEmail}, this.SendFeedbackOperationCompleted, userState);
        }
        
        private void OnSendFeedbackOperationCompleted(object arg) {
            if ((this.SendFeedbackCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendFeedbackCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void LogApplicationExceptionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void LogUsageCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void AddCameraCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void AddCamera2CompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void SendFeedbackCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591