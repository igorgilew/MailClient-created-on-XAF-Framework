using System;
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
    public class Request : BaseObject
    { 
        public Request(Session session): base(session){ }
        private DateTime createDate;
        public DateTime CreateDate
        {
            get { return createDate; }
            set { SetPropertyValue("CreateDate", ref createDate, value); }
        }
        private DateTime closeDate;
        public DateTime CloseDate
        {
            get { return closeDate; }
            set { SetPropertyValue("CloseDate", ref closeDate, value); }
        }
        
         
    }
}