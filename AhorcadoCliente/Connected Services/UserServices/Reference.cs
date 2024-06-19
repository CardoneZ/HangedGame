﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AhorcadoCliente.UserServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/AhorcadoServicios.Model.POCO")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstSurnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NickNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PlayerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PointsEarnedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecondSurnameField;
        
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
        public string BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((object.ReferenceEquals(this.BirthDateField, value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstSurname {
            get {
                return this.FirstSurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstSurnameField, value) != true)) {
                    this.FirstSurnameField = value;
                    this.RaisePropertyChanged("FirstSurname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Names {
            get {
                return this.NamesField;
            }
            set {
                if ((object.ReferenceEquals(this.NamesField, value) != true)) {
                    this.NamesField = value;
                    this.RaisePropertyChanged("Names");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NickName {
            get {
                return this.NickNameField;
            }
            set {
                if ((object.ReferenceEquals(this.NickNameField, value) != true)) {
                    this.NickNameField = value;
                    this.RaisePropertyChanged("NickName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PlayerID {
            get {
                return this.PlayerIDField;
            }
            set {
                if ((this.PlayerIDField.Equals(value) != true)) {
                    this.PlayerIDField = value;
                    this.RaisePropertyChanged("PlayerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PointsEarned {
            get {
                return this.PointsEarnedField;
            }
            set {
                if ((this.PointsEarnedField.Equals(value) != true)) {
                    this.PointsEarnedField = value;
                    this.RaisePropertyChanged("PointsEarned");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondSurname {
            get {
                return this.SecondSurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SecondSurnameField, value) != true)) {
                    this.SecondSurnameField = value;
                    this.RaisePropertyChanged("SecondSurname");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServices.IUserServices")]
    public interface IUserServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/logIn", ReplyAction="http://tempuri.org/IUserServices/logInResponse")]
        AhorcadoCliente.UserServices.Player logIn(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/logIn", ReplyAction="http://tempuri.org/IUserServices/logInResponse")]
        System.Threading.Tasks.Task<AhorcadoCliente.UserServices.Player> logInAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/registerUser", ReplyAction="http://tempuri.org/IUserServices/registerUserResponse")]
        bool registerUser(AhorcadoCliente.UserServices.Player newPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/registerUser", ReplyAction="http://tempuri.org/IUserServices/registerUserResponse")]
        System.Threading.Tasks.Task<bool> registerUserAsync(AhorcadoCliente.UserServices.Player newPlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/emailAlreadyRegistered", ReplyAction="http://tempuri.org/IUserServices/emailAlreadyRegisteredResponse")]
        bool emailAlreadyRegistered(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/emailAlreadyRegistered", ReplyAction="http://tempuri.org/IUserServices/emailAlreadyRegisteredResponse")]
        System.Threading.Tasks.Task<bool> emailAlreadyRegisteredAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/nicknameAlreadyRegistered", ReplyAction="http://tempuri.org/IUserServices/nicknameAlreadyRegisteredResponse")]
        bool nicknameAlreadyRegistered(string nickname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/nicknameAlreadyRegistered", ReplyAction="http://tempuri.org/IUserServices/nicknameAlreadyRegisteredResponse")]
        System.Threading.Tasks.Task<bool> nicknameAlreadyRegisteredAsync(string nickname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/telephoneAlreadyExist", ReplyAction="http://tempuri.org/IUserServices/telephoneAlreadyExistResponse")]
        bool telephoneAlreadyExist(string telephone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/telephoneAlreadyExist", ReplyAction="http://tempuri.org/IUserServices/telephoneAlreadyExistResponse")]
        System.Threading.Tasks.Task<bool> telephoneAlreadyExistAsync(string telephone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/updatePlayerProfile", ReplyAction="http://tempuri.org/IUserServices/updatePlayerProfileResponse")]
        bool updatePlayerProfile(AhorcadoCliente.UserServices.Player updatePlayer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/updatePlayerProfile", ReplyAction="http://tempuri.org/IUserServices/updatePlayerProfileResponse")]
        System.Threading.Tasks.Task<bool> updatePlayerProfileAsync(AhorcadoCliente.UserServices.Player updatePlayer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServicesChannel : AhorcadoCliente.UserServices.IUserServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServicesClient : System.ServiceModel.ClientBase<AhorcadoCliente.UserServices.IUserServices>, AhorcadoCliente.UserServices.IUserServices {
        
        public UserServicesClient() {
        }
        
        public UserServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AhorcadoCliente.UserServices.Player logIn(string email, string password) {
            return base.Channel.logIn(email, password);
        }
        
        public System.Threading.Tasks.Task<AhorcadoCliente.UserServices.Player> logInAsync(string email, string password) {
            return base.Channel.logInAsync(email, password);
        }
        
        public bool registerUser(AhorcadoCliente.UserServices.Player newPlayer) {
            return base.Channel.registerUser(newPlayer);
        }
        
        public System.Threading.Tasks.Task<bool> registerUserAsync(AhorcadoCliente.UserServices.Player newPlayer) {
            return base.Channel.registerUserAsync(newPlayer);
        }
        
        public bool emailAlreadyRegistered(string email) {
            return base.Channel.emailAlreadyRegistered(email);
        }
        
        public System.Threading.Tasks.Task<bool> emailAlreadyRegisteredAsync(string email) {
            return base.Channel.emailAlreadyRegisteredAsync(email);
        }
        
        public bool nicknameAlreadyRegistered(string nickname) {
            return base.Channel.nicknameAlreadyRegistered(nickname);
        }
        
        public System.Threading.Tasks.Task<bool> nicknameAlreadyRegisteredAsync(string nickname) {
            return base.Channel.nicknameAlreadyRegisteredAsync(nickname);
        }
        
        public bool telephoneAlreadyExist(string telephone) {
            return base.Channel.telephoneAlreadyExist(telephone);
        }
        
        public System.Threading.Tasks.Task<bool> telephoneAlreadyExistAsync(string telephone) {
            return base.Channel.telephoneAlreadyExistAsync(telephone);
        }
        
        public bool updatePlayerProfile(AhorcadoCliente.UserServices.Player updatePlayer) {
            return base.Channel.updatePlayerProfile(updatePlayer);
        }
        
        public System.Threading.Tasks.Task<bool> updatePlayerProfileAsync(AhorcadoCliente.UserServices.Player updatePlayer) {
            return base.Channel.updatePlayerProfileAsync(updatePlayer);
        }
    }
}
