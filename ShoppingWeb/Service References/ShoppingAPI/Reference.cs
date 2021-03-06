﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingWeb.ShoppingAPI {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ListUser", Namespace="http://schemas.datacontract.org/2004/07/ShoppingAPI")]
    [System.SerializableAttribute()]
    public partial class ListUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ListIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ListNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ListId {
            get {
                return this.ListIdField;
            }
            set {
                if ((this.ListIdField.Equals(value) != true)) {
                    this.ListIdField = value;
                    this.RaisePropertyChanged("ListId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ListName {
            get {
                return this.ListNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ListNameField, value) != true)) {
                    this.ListNameField = value;
                    this.RaisePropertyChanged("ListName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ListProduct", Namespace="http://schemas.datacontract.org/2004/07/ShoppingAPI")]
    [System.SerializableAttribute()]
    public partial class ListProduct : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> IsBoughtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ListIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsBought {
            get {
                return this.IsBoughtField;
            }
            set {
                if ((this.IsBoughtField.Equals(value) != true)) {
                    this.IsBoughtField = value;
                    this.RaisePropertyChanged("IsBought");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ListId {
            get {
                return this.ListIdField;
            }
            set {
                if ((this.ListIdField.Equals(value) != true)) {
                    this.ListIdField = value;
                    this.RaisePropertyChanged("ListId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShoppingAPI.IShopping")]
    public interface IShopping {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/Register", ReplyAction="http://tempuri.org/IShopping/RegisterResponse")]
        bool Register(string login, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/Register", ReplyAction="http://tempuri.org/IShopping/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(string login, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/Login", ReplyAction="http://tempuri.org/IShopping/LoginResponse")]
        System.Guid Login([System.ServiceModel.MessageParameterAttribute(Name="login")] string login1, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/Login", ReplyAction="http://tempuri.org/IShopping/LoginResponse")]
        System.Threading.Tasks.Task<System.Guid> LoginAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/GetUserList", ReplyAction="http://tempuri.org/IShopping/GetUserListResponse")]
        System.Collections.Generic.List<ShoppingWeb.ShoppingAPI.ListUser> GetUserList(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/GetUserList", ReplyAction="http://tempuri.org/IShopping/GetUserListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ShoppingWeb.ShoppingAPI.ListUser>> GetUserListAsync(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/GetProductsFromList", ReplyAction="http://tempuri.org/IShopping/GetProductsFromListResponse")]
        System.Collections.Generic.List<ShoppingWeb.ShoppingAPI.ListProduct> GetProductsFromList(System.Guid ListId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/GetProductsFromList", ReplyAction="http://tempuri.org/IShopping/GetProductsFromListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ShoppingWeb.ShoppingAPI.ListProduct>> GetProductsFromListAsync(System.Guid ListId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/CreateNewList", ReplyAction="http://tempuri.org/IShopping/CreateNewListResponse")]
        bool CreateNewList(string ListName, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/CreateNewList", ReplyAction="http://tempuri.org/IShopping/CreateNewListResponse")]
        System.Threading.Tasks.Task<bool> CreateNewListAsync(string ListName, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/AddProductToList", ReplyAction="http://tempuri.org/IShopping/AddProductToListResponse")]
        bool AddProductToList(string ProductName, System.Guid ListId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/AddProductToList", ReplyAction="http://tempuri.org/IShopping/AddProductToListResponse")]
        System.Threading.Tasks.Task<bool> AddProductToListAsync(string ProductName, System.Guid ListId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/Sync", ReplyAction="http://tempuri.org/IShopping/SyncResponse")]
        bool Sync(System.Collections.Generic.Dictionary<System.Guid, bool> products, System.Guid listId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/Sync", ReplyAction="http://tempuri.org/IShopping/SyncResponse")]
        System.Threading.Tasks.Task<bool> SyncAsync(System.Collections.Generic.Dictionary<System.Guid, bool> products, System.Guid listId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/Share", ReplyAction="http://tempuri.org/IShopping/ShareResponse")]
        bool Share(System.Guid userId, System.Guid listId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/Share", ReplyAction="http://tempuri.org/IShopping/ShareResponse")]
        System.Threading.Tasks.Task<bool> ShareAsync(System.Guid userId, System.Guid listId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/GetUserId", ReplyAction="http://tempuri.org/IShopping/GetUserIdResponse")]
        System.Guid GetUserId(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/GetUserId", ReplyAction="http://tempuri.org/IShopping/GetUserIdResponse")]
        System.Threading.Tasks.Task<System.Guid> GetUserIdAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/CheckLoginIsExist", ReplyAction="http://tempuri.org/IShopping/CheckLoginIsExistResponse")]
        bool CheckLoginIsExist(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/CheckLoginIsExist", ReplyAction="http://tempuri.org/IShopping/CheckLoginIsExistResponse")]
        System.Threading.Tasks.Task<bool> CheckLoginIsExistAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/CheckEmailIsExist", ReplyAction="http://tempuri.org/IShopping/CheckEmailIsExistResponse")]
        bool CheckEmailIsExist(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/CheckEmailIsExist", ReplyAction="http://tempuri.org/IShopping/CheckEmailIsExistResponse")]
        System.Threading.Tasks.Task<bool> CheckEmailIsExistAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/DeleteList", ReplyAction="http://tempuri.org/IShopping/DeleteListResponse")]
        bool DeleteList(System.Guid listId, System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopping/DeleteList", ReplyAction="http://tempuri.org/IShopping/DeleteListResponse")]
        System.Threading.Tasks.Task<bool> DeleteListAsync(System.Guid listId, System.Guid userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShoppingChannel : ShoppingWeb.ShoppingAPI.IShopping, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShoppingClient : System.ServiceModel.ClientBase<ShoppingWeb.ShoppingAPI.IShopping>, ShoppingWeb.ShoppingAPI.IShopping {
        
        public ShoppingClient() {
        }
        
        public ShoppingClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShoppingClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShoppingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShoppingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Register(string login, string email, string password) {
            return base.Channel.Register(login, email, password);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(string login, string email, string password) {
            return base.Channel.RegisterAsync(login, email, password);
        }
        
        public System.Guid Login(string login1, string password) {
            return base.Channel.Login(login1, password);
        }
        
        public System.Threading.Tasks.Task<System.Guid> LoginAsync(string login, string password) {
            return base.Channel.LoginAsync(login, password);
        }
        
        public System.Collections.Generic.List<ShoppingWeb.ShoppingAPI.ListUser> GetUserList(System.Guid userId) {
            return base.Channel.GetUserList(userId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ShoppingWeb.ShoppingAPI.ListUser>> GetUserListAsync(System.Guid userId) {
            return base.Channel.GetUserListAsync(userId);
        }
        
        public System.Collections.Generic.List<ShoppingWeb.ShoppingAPI.ListProduct> GetProductsFromList(System.Guid ListId) {
            return base.Channel.GetProductsFromList(ListId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ShoppingWeb.ShoppingAPI.ListProduct>> GetProductsFromListAsync(System.Guid ListId) {
            return base.Channel.GetProductsFromListAsync(ListId);
        }
        
        public bool CreateNewList(string ListName, System.Guid userId) {
            return base.Channel.CreateNewList(ListName, userId);
        }
        
        public System.Threading.Tasks.Task<bool> CreateNewListAsync(string ListName, System.Guid userId) {
            return base.Channel.CreateNewListAsync(ListName, userId);
        }
        
        public bool AddProductToList(string ProductName, System.Guid ListId) {
            return base.Channel.AddProductToList(ProductName, ListId);
        }
        
        public System.Threading.Tasks.Task<bool> AddProductToListAsync(string ProductName, System.Guid ListId) {
            return base.Channel.AddProductToListAsync(ProductName, ListId);
        }
        
        public bool Sync(System.Collections.Generic.Dictionary<System.Guid, bool> products, System.Guid listId) {
            return base.Channel.Sync(products, listId);
        }
        
        public System.Threading.Tasks.Task<bool> SyncAsync(System.Collections.Generic.Dictionary<System.Guid, bool> products, System.Guid listId) {
            return base.Channel.SyncAsync(products, listId);
        }
        
        public bool Share(System.Guid userId, System.Guid listId) {
            return base.Channel.Share(userId, listId);
        }
        
        public System.Threading.Tasks.Task<bool> ShareAsync(System.Guid userId, System.Guid listId) {
            return base.Channel.ShareAsync(userId, listId);
        }
        
        public System.Guid GetUserId(string userName) {
            return base.Channel.GetUserId(userName);
        }
        
        public System.Threading.Tasks.Task<System.Guid> GetUserIdAsync(string userName) {
            return base.Channel.GetUserIdAsync(userName);
        }
        
        public bool CheckLoginIsExist(string userName) {
            return base.Channel.CheckLoginIsExist(userName);
        }
        
        public System.Threading.Tasks.Task<bool> CheckLoginIsExistAsync(string userName) {
            return base.Channel.CheckLoginIsExistAsync(userName);
        }
        
        public bool CheckEmailIsExist(string email) {
            return base.Channel.CheckEmailIsExist(email);
        }
        
        public System.Threading.Tasks.Task<bool> CheckEmailIsExistAsync(string email) {
            return base.Channel.CheckEmailIsExistAsync(email);
        }
        
        public bool DeleteList(System.Guid listId, System.Guid userId) {
            return base.Channel.DeleteList(listId, userId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteListAsync(System.Guid listId, System.Guid userId) {
            return base.Channel.DeleteListAsync(listId, userId);
        }
    }
}
