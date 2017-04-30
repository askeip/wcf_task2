﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/TaskOne")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LibraryClient.ServiceReference1.BookType BookTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PublishingYearField;
        
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
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LibraryClient.ServiceReference1.BookType BookType {
            get {
                return this.BookTypeField;
            }
            set {
                if ((this.BookTypeField.Equals(value) != true)) {
                    this.BookTypeField = value;
                    this.RaisePropertyChanged("BookType");
                }
            }
        }
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PublishingYear {
            get {
                return this.PublishingYearField;
            }
            set {
                if ((this.PublishingYearField.Equals(value) != true)) {
                    this.PublishingYearField = value;
                    this.RaisePropertyChanged("PublishingYear");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookType", Namespace="http://schemas.datacontract.org/2004/07/TaskOne")]
    public enum BookType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FictionBook = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Magazine = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Other = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ILibraryService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ILibraryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/LogIn", ReplyAction="http://tempuri.org/ILibraryService/LogInResponse")]
        void LogIn(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/LogIn", ReplyAction="http://tempuri.org/ILibraryService/LogInResponse")]
        System.Threading.Tasks.Task LogInAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILibraryService/AddBook", ReplyAction="http://tempuri.org/ILibraryService/AddBookResponse")]
        void AddBook(LibraryClient.ServiceReference1.Book value);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILibraryService/AddBook", ReplyAction="http://tempuri.org/ILibraryService/AddBookResponse")]
        System.Threading.Tasks.Task AddBookAsync(LibraryClient.ServiceReference1.Book value);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILibraryService/GetBook", ReplyAction="http://tempuri.org/ILibraryService/GetBookResponse")]
        LibraryClient.ServiceReference1.Book GetBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILibraryService/GetBook", ReplyAction="http://tempuri.org/ILibraryService/GetBookResponse")]
        System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Book> GetBookAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILibraryService/GetAllBooks", ReplyAction="http://tempuri.org/ILibraryService/GetAllBooksResponse")]
        LibraryClient.ServiceReference1.Book[] GetAllBooks(string author);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILibraryService/GetAllBooks", ReplyAction="http://tempuri.org/ILibraryService/GetAllBooksResponse")]
        System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Book[]> GetAllBooksAsync(string author);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILibraryService/TakeBook", ReplyAction="http://tempuri.org/ILibraryService/TakeBookResponse")]
        LibraryClient.ServiceReference1.Book TakeBook(LibraryClient.ServiceReference1.Book book);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILibraryService/TakeBook", ReplyAction="http://tempuri.org/ILibraryService/TakeBookResponse")]
        System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Book> TakeBookAsync(LibraryClient.ServiceReference1.Book book);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILibraryService/ReturnBook", ReplyAction="http://tempuri.org/ILibraryService/ReturnBookResponse")]
        void ReturnBook(LibraryClient.ServiceReference1.Book book);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILibraryService/ReturnBook", ReplyAction="http://tempuri.org/ILibraryService/ReturnBookResponse")]
        System.Threading.Tasks.Task ReturnBookAsync(LibraryClient.ServiceReference1.Book book);
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILibraryService/ConfirmChoice", ReplyAction="http://tempuri.org/ILibraryService/ConfirmChoiceResponse")]
        string ConfirmChoice();
        
        [System.ServiceModel.OperationContractAttribute(IsInitiating=false, Action="http://tempuri.org/ILibraryService/ConfirmChoice", ReplyAction="http://tempuri.org/ILibraryService/ConfirmChoiceResponse")]
        System.Threading.Tasks.Task<string> ConfirmChoiceAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/ILibraryService/LeaveLibrary", ReplyAction="http://tempuri.org/ILibraryService/LeaveLibraryResponse")]
        void LeaveLibrary();
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/ILibraryService/LeaveLibrary", ReplyAction="http://tempuri.org/ILibraryService/LeaveLibraryResponse")]
        System.Threading.Tasks.Task LeaveLibraryAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILibraryServiceChannel : LibraryClient.ServiceReference1.ILibraryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibraryServiceClient : System.ServiceModel.ClientBase<LibraryClient.ServiceReference1.ILibraryService>, LibraryClient.ServiceReference1.ILibraryService {
        
        public LibraryServiceClient() {
        }
        
        public LibraryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void LogIn(string userName) {
            base.Channel.LogIn(userName);
        }
        
        public System.Threading.Tasks.Task LogInAsync(string userName) {
            return base.Channel.LogInAsync(userName);
        }
        
        public void AddBook(LibraryClient.ServiceReference1.Book value) {
            base.Channel.AddBook(value);
        }
        
        public System.Threading.Tasks.Task AddBookAsync(LibraryClient.ServiceReference1.Book value) {
            return base.Channel.AddBookAsync(value);
        }
        
        public LibraryClient.ServiceReference1.Book GetBook(int id) {
            return base.Channel.GetBook(id);
        }
        
        public System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Book> GetBookAsync(int id) {
            return base.Channel.GetBookAsync(id);
        }
        
        public LibraryClient.ServiceReference1.Book[] GetAllBooks(string author) {
            return base.Channel.GetAllBooks(author);
        }
        
        public System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Book[]> GetAllBooksAsync(string author) {
            return base.Channel.GetAllBooksAsync(author);
        }
        
        public LibraryClient.ServiceReference1.Book TakeBook(LibraryClient.ServiceReference1.Book book) {
            return base.Channel.TakeBook(book);
        }
        
        public System.Threading.Tasks.Task<LibraryClient.ServiceReference1.Book> TakeBookAsync(LibraryClient.ServiceReference1.Book book) {
            return base.Channel.TakeBookAsync(book);
        }
        
        public void ReturnBook(LibraryClient.ServiceReference1.Book book) {
            base.Channel.ReturnBook(book);
        }
        
        public System.Threading.Tasks.Task ReturnBookAsync(LibraryClient.ServiceReference1.Book book) {
            return base.Channel.ReturnBookAsync(book);
        }
        
        public string ConfirmChoice() {
            return base.Channel.ConfirmChoice();
        }
        
        public System.Threading.Tasks.Task<string> ConfirmChoiceAsync() {
            return base.Channel.ConfirmChoiceAsync();
        }
        
        public void LeaveLibrary() {
            base.Channel.LeaveLibrary();
        }
        
        public System.Threading.Tasks.Task LeaveLibraryAsync() {
            return base.Channel.LeaveLibraryAsync();
        }
    }
}
