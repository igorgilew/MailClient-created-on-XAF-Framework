﻿using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace MailService.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Client : BaseObject
    { 
        public Client(Session session) : base(session)          
        { }
        private string surname;
        public string Surname
        {
            get { return surname; }
            set { SetPropertyValue("Surname", ref surname, value); }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { SetPropertyValue("Name", ref name, value); }
        }       
        private string patronymic;
        public string Patronymic
        {
            get { return patronymic; }
            set { SetPropertyValue("Patronymic", ref patronymic, value); }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { SetPropertyValue("Email", ref email, value); }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { SetPropertyValue("PhoneNumber", ref phoneNumber, value); }
        }
    }
}