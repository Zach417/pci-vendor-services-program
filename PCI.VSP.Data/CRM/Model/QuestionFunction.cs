﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Crm.Sdk;

namespace PCI.VSP.Data.CRM.Model
{
    public class QuestionFunction : EntityBase
    {
        public QuestionFunction() : base("questionfunction") { }
        public QuestionFunction(DynamicEntity e)
            : base(e)
        {
        }
        private static String[] _columnSet = new String[] { "vsp_name", "vsp_questionfunctionid", "vsp_sortorder" };

        public new String Name
        {
            get { return base.GetPropertyValue<String>("vsp_name", PropertyType.String, ""); }
            set { base.SetPropertyValue<String>("vsp_name", PropertyType.String, value); }
        }

        public Guid Id
        {
            get { return base.GetPropertyValue<Guid>("vsp_questionfunctionid", PropertyType.Key, Guid.Empty); }
            set { base.SetPropertyValue<Guid>("vsp_questionfunctionid", PropertyType.Key, value); }
        }

        public Int32 SortOrder
        {
            get { return base.GetPropertyValue<Int32>("vsp_sortorder", PropertyType.Number, 0); }
            set { base.SetPropertyValue<Int32>("vsp_sortorder", PropertyType.Number, value); }
        }
    }
}
