﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;

namespace EnterERP.Module.BusinessObjects.maptooni_CFSCustomers
{
    [DefaultClassOptions]
    [NavigationItem("CFSPOS")]
    public partial class Settings : XPLiteObject
    {
        string fPrincipalStore;
        [Size(500)]
        public string PrincipalStore
        {
            get { return fPrincipalStore; }
            set { SetPropertyValue<string>("PrincipalStore", ref fPrincipalStore, value); }
        }
        string fyy_store_id;
        [Size(500)]
        public string yy_store_id
        {
            get { return fyy_store_id; }
            set { SetPropertyValue<string>("yy_store_id", ref fyy_store_id, value); }
        }
        string fcompany_name_tx;
        [Size(500)]
        public string company_name_tx
        {
            get { return fcompany_name_tx; }
            set { SetPropertyValue<string>("company_name_tx", ref fcompany_name_tx, value); }
        }
        string fDID;
        [Key]
        [Size(500)]
        public string DID
        {
            get { return fDID; }
            set { SetPropertyValue<string>("DID", ref fDID, value); }
        }
        string fxx_user_name_tx;
        [Size(500)]
        public string xx_user_name_tx
        {
            get { return fxx_user_name_tx; }
            set { SetPropertyValue<string>("xx_user_name_tx", ref fxx_user_name_tx, value); }
        }
        string fxx_password_tx;
        [Size(500)]
        public string xx_password_tx
        {
            get { return fxx_password_tx; }
            set { SetPropertyValue<string>("xx_password_tx", ref fxx_password_tx, value); }
        }
        string fxx_name_tx;
        [Size(500)]
        public string xx_name_tx
        {
            get { return fxx_name_tx; }
            set { SetPropertyValue<string>("xx_name_tx", ref fxx_name_tx, value); }
        }
        string fxx_d_id_tx;
        [Size(500)]
        public string xx_d_id_tx
        {
            get { return fxx_d_id_tx; }
            set { SetPropertyValue<string>("xx_d_id_tx", ref fxx_d_id_tx, value); }
        }
        string fyy_my_sql_db_name_tx;
        [Size(500)]
        public string yy_my_sql_db_name_tx
        {
            get { return fyy_my_sql_db_name_tx; }
            set { SetPropertyValue<string>("yy_my_sql_db_name_tx", ref fyy_my_sql_db_name_tx, value); }
        }
        string fyy_my_sql_password_tx;
        [Size(500)]
        public string yy_my_sql_password_tx
        {
            get { return fyy_my_sql_password_tx; }
            set { SetPropertyValue<string>("yy_my_sql_password_tx", ref fyy_my_sql_password_tx, value); }
        }
        string fyy_created_by_tx;
        [Size(500)]
        public string yy_created_by_tx
        {
            get { return fyy_created_by_tx; }
            set { SetPropertyValue<string>("yy_created_by_tx", ref fyy_created_by_tx, value); }
        }
        string fyy_modified_by_tx;
        [Size(500)]
        public string yy_modified_by_tx
        {
            get { return fyy_modified_by_tx; }
            set { SetPropertyValue<string>("yy_modified_by_tx", ref fyy_modified_by_tx, value); }
        }
        int fLayawayPeriods_num;
        public int LayawayPeriods_num
        {
            get { return fLayawayPeriods_num; }
            set { SetPropertyValue<int>("LayawayPeriods_num", ref fLayawayPeriods_num, value); }
        }
        decimal fTaxRate_Num;
        public decimal TaxRate_Num
        {
            get { return fTaxRate_Num; }
            set { SetPropertyValue<decimal>("TaxRate_Num", ref fTaxRate_Num, value); }
        }
        string fdefaultState;
        [Size(500)]
        public string defaultState
        {
            get { return fdefaultState; }
            set { SetPropertyValue<string>("defaultState", ref fdefaultState, value); }
        }
        string fstorelogoexp;
        [Size(SizeAttribute.Unlimited)]
        public string storelogoexp
        {
            get { return fstorelogoexp; }
            set { SetPropertyValue<string>("storelogoexp", ref fstorelogoexp, value); }
        }
        string fdis1exp;
        [Size(SizeAttribute.Unlimited)]
        public string dis1exp
        {
            get { return fdis1exp; }
            set { SetPropertyValue<string>("dis1exp", ref fdis1exp, value); }
        }
        string fdis2exp;
        [Size(SizeAttribute.Unlimited)]
        public string dis2exp
        {
            get { return fdis2exp; }
            set { SetPropertyValue<string>("dis2exp", ref fdis2exp, value); }
        }
        string fdis33exp;
        [Size(SizeAttribute.Unlimited)]
        public string dis33exp
        {
            get { return fdis33exp; }
            set { SetPropertyValue<string>("dis33exp", ref fdis33exp, value); }
        }
        string fdis4exp;
        [Size(SizeAttribute.Unlimited)]
        public string dis4exp
        {
            get { return fdis4exp; }
            set { SetPropertyValue<string>("dis4exp", ref fdis4exp, value); }
        }
        string fmarkup;
        [Size(500)]
        public string markup
        {
            get { return fmarkup; }
            set { SetPropertyValue<string>("markup", ref fmarkup, value); }
        }
        string fContactInfo;
        [Size(1000)]
        public string ContactInfo
        {
            get { return fContactInfo; }
            set { SetPropertyValue<string>("ContactInfo", ref fContactInfo, value); }
        }
        string fCSystemID;
        [Size(500)]
        public string CSystemID
        {
            get { return fCSystemID; }
            set { SetPropertyValue<string>("CSystemID", ref fCSystemID, value); }
        }
        string fSONumber;
        [Size(50)]
        public string SONumber
        {
            get { return fSONumber; }
            set { SetPropertyValue<string>("SONumber", ref fSONumber, value); }
        }
        string fPONumber;
        [Size(50)]
        public string PONumber
        {
            get { return fPONumber; }
            set { SetPropertyValue<string>("PONumber", ref fPONumber, value); }
        }
        string fPrimaryCSysID;
        [Size(500)]
        public string PrimaryCSysID
        {
            get { return fPrimaryCSysID; }
            set { SetPropertyValue<string>("PrimaryCSysID", ref fPrimaryCSysID, value); }
        }
        public Settings(Session session) : base(session) { }
    }

}
