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
using System.Data;

namespace EnterERP.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Tasas : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Tasas(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string fCodigo;
        [Size(20)]
        public string Codigo
        {
            get { return fCodigo; }
            set { SetPropertyValue<string>("Codigo", ref fCodigo, value); }
        }
        Monedas fMoneda;
        [Association(@"TasasReferencesMonedas")]
        public Monedas Moneda
        {
            get { return fMoneda; }
            set { SetPropertyValue<Monedas>("Moneda", ref fMoneda, value); }
        }
        DateTime fFecha;
        public DateTime Fecha
        {
            get { return fFecha; }
            set { SetPropertyValue<DateTime>("Fecha", ref fFecha, value); }
        }
        decimal fTasa;
        public decimal Tasa
        {
            get { return fTasa; }
            set { SetPropertyValue<decimal>("Tasa", ref fTasa, value); }
        }
        string fObservaciones;
        [Size(4000)]
        public string Observaciones
        {
            get { return fObservaciones; }
            set { SetPropertyValue<string>("Observaciones", ref fObservaciones, value); }
        }

        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue("PersistentProperty", ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}


        [Action(Caption = "Obtener Tasas desde Pagina Web", ConfirmationMessage = "Esta Seguro?", ImageName = "Attention", AutoCommit = true, TargetObjectsCriteria = "Moneda.Codigo='USD'")]
        public void ActionMethod()
        {
            // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
            //this.Name = "Paid";
            string buyrate = "";
            string salerate = "";


            System.Data.DataSet xmlDataSet = new System.Data.DataSet("XML DataSet");
            // Load the XML document to the DataSet
            xmlDataSet.ReadXml(@"https://www.bac.net/exchangerate/showXmlExchangeRate.do?company=BCO");
            // This line of code is generated by Data Source Configuration Wizard
            DataTable countries = xmlDataSet.Tables["country"];
            DataRow[] results = countries.Select("name = 'Honduras'");
            int contador = 0;
            if (results.Length > 0)
            {
                foreach (DataRow dr in results)
                {
                    foreach (object item in dr.ItemArray)
                    {
                        contador++;

                        if (contador == 2)
                            buyrate = item.ToString();
                        if (contador == 3)
                            salerate = item.ToString();
                    }
                }
            }

            //this.buyRateUSD = buyrate;
            this.Tasa = Decimal.Parse(salerate);
            Fecha = DateTime.Now;
            Moneda = Session.FindObject<Monedas>(CriteriaOperator.Parse("Contains(Descripcion,'Dolares')"));
            Codigo = Moneda.Codigo + Fecha.ToString("yyyyMMdd");
            //Name = "Dolares";
        }
    }
}