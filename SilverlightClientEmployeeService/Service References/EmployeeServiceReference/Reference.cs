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
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace SilverlightClientEmployeeService.EmployeeServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/EmployeeServiceHost")]
    public partial class Employee : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int IdField;
        
        private string NameField;
        
        private string GenderField;
        
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServiceReference.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        System.IAsyncResult BeginGetEmployee(int Id, System.AsyncCallback callback, object asyncState);
        
        SilverlightClientEmployeeService.EmployeeServiceReference.Employee EndGetEmployee(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IEmployeeService/SaveEmployee", ReplyAction="http://tempuri.org/IEmployeeService/SaveEmployeeResponse")]
        System.IAsyncResult BeginSaveEmployee(SilverlightClientEmployeeService.EmployeeServiceReference.Employee employee, System.AsyncCallback callback, object asyncState);
        
        void EndSaveEmployee(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetEmployeeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetEmployeeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public SilverlightClientEmployeeService.EmployeeServiceReference.Employee Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((SilverlightClientEmployeeService.EmployeeServiceReference.Employee)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService>, SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService {
        
        private BeginOperationDelegate onBeginGetEmployeeDelegate;
        
        private EndOperationDelegate onEndGetEmployeeDelegate;
        
        private System.Threading.SendOrPostCallback onGetEmployeeCompletedDelegate;
        
        private BeginOperationDelegate onBeginSaveEmployeeDelegate;
        
        private EndOperationDelegate onEndSaveEmployeeDelegate;
        
        private System.Threading.SendOrPostCallback onSaveEmployeeCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetEmployeeCompletedEventArgs> GetEmployeeCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SaveEmployeeCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService.BeginGetEmployee(int Id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetEmployee(Id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SilverlightClientEmployeeService.EmployeeServiceReference.Employee SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService.EndGetEmployee(System.IAsyncResult result) {
            return base.Channel.EndGetEmployee(result);
        }
        
        private System.IAsyncResult OnBeginGetEmployee(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int Id = ((int)(inValues[0]));
            return ((SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService)(this)).BeginGetEmployee(Id, callback, asyncState);
        }
        
        private object[] OnEndGetEmployee(System.IAsyncResult result) {
            SilverlightClientEmployeeService.EmployeeServiceReference.Employee retVal = ((SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService)(this)).EndGetEmployee(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetEmployeeCompleted(object state) {
            if ((this.GetEmployeeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetEmployeeCompleted(this, new GetEmployeeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetEmployeeAsync(int Id) {
            this.GetEmployeeAsync(Id, null);
        }
        
        public void GetEmployeeAsync(int Id, object userState) {
            if ((this.onBeginGetEmployeeDelegate == null)) {
                this.onBeginGetEmployeeDelegate = new BeginOperationDelegate(this.OnBeginGetEmployee);
            }
            if ((this.onEndGetEmployeeDelegate == null)) {
                this.onEndGetEmployeeDelegate = new EndOperationDelegate(this.OnEndGetEmployee);
            }
            if ((this.onGetEmployeeCompletedDelegate == null)) {
                this.onGetEmployeeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetEmployeeCompleted);
            }
            base.InvokeAsync(this.onBeginGetEmployeeDelegate, new object[] {
                        Id}, this.onEndGetEmployeeDelegate, this.onGetEmployeeCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService.BeginSaveEmployee(SilverlightClientEmployeeService.EmployeeServiceReference.Employee employee, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSaveEmployee(employee, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService.EndSaveEmployee(System.IAsyncResult result) {
            base.Channel.EndSaveEmployee(result);
        }
        
        private System.IAsyncResult OnBeginSaveEmployee(object[] inValues, System.AsyncCallback callback, object asyncState) {
            SilverlightClientEmployeeService.EmployeeServiceReference.Employee employee = ((SilverlightClientEmployeeService.EmployeeServiceReference.Employee)(inValues[0]));
            return ((SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService)(this)).BeginSaveEmployee(employee, callback, asyncState);
        }
        
        private object[] OnEndSaveEmployee(System.IAsyncResult result) {
            ((SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService)(this)).EndSaveEmployee(result);
            return null;
        }
        
        private void OnSaveEmployeeCompleted(object state) {
            if ((this.SaveEmployeeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SaveEmployeeCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SaveEmployeeAsync(SilverlightClientEmployeeService.EmployeeServiceReference.Employee employee) {
            this.SaveEmployeeAsync(employee, null);
        }
        
        public void SaveEmployeeAsync(SilverlightClientEmployeeService.EmployeeServiceReference.Employee employee, object userState) {
            if ((this.onBeginSaveEmployeeDelegate == null)) {
                this.onBeginSaveEmployeeDelegate = new BeginOperationDelegate(this.OnBeginSaveEmployee);
            }
            if ((this.onEndSaveEmployeeDelegate == null)) {
                this.onEndSaveEmployeeDelegate = new EndOperationDelegate(this.OnEndSaveEmployee);
            }
            if ((this.onSaveEmployeeCompletedDelegate == null)) {
                this.onSaveEmployeeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSaveEmployeeCompleted);
            }
            base.InvokeAsync(this.onBeginSaveEmployeeDelegate, new object[] {
                        employee}, this.onEndSaveEmployeeDelegate, this.onSaveEmployeeCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService CreateChannel() {
            return new EmployeeServiceClientChannel(this);
        }
        
        private class EmployeeServiceClientChannel : ChannelBase<SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService>, SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService {
            
            public EmployeeServiceClientChannel(System.ServiceModel.ClientBase<SilverlightClientEmployeeService.EmployeeServiceReference.IEmployeeService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetEmployee(int Id, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = Id;
                System.IAsyncResult _result = base.BeginInvoke("GetEmployee", _args, callback, asyncState);
                return _result;
            }
            
            public SilverlightClientEmployeeService.EmployeeServiceReference.Employee EndGetEmployee(System.IAsyncResult result) {
                object[] _args = new object[0];
                SilverlightClientEmployeeService.EmployeeServiceReference.Employee _result = ((SilverlightClientEmployeeService.EmployeeServiceReference.Employee)(base.EndInvoke("GetEmployee", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginSaveEmployee(SilverlightClientEmployeeService.EmployeeServiceReference.Employee employee, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = employee;
                System.IAsyncResult _result = base.BeginInvoke("SaveEmployee", _args, callback, asyncState);
                return _result;
            }
            
            public void EndSaveEmployee(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("SaveEmployee", _args, result);
            }
        }
    }
}