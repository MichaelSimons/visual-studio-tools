﻿using System;

namespace Salesforce.VisualStudio.Services.ConnectedService.CodeModel
{
    /// <summary>
    /// Represents a storage property on a Salesforce object to generate code for.
    /// </summary>
    [Serializable]
    public sealed class GeneratedStorageProperty
    {
        internal GeneratedStorageProperty()
        {
        }

        public Type ClrType { get; internal set; }

        public bool IsNullableType { get; internal set; }

        public bool IsKey { get; internal set; }

        public bool IsRequired
        {
            get
            {
                return !this.Model.Nillable
                    && this.Model.Createable
                    && this.Model.Updateable
                    && this.Model.DefaultValue == null;
            }
        }

        public SObjectField Model { get; internal set; }
    }
}
