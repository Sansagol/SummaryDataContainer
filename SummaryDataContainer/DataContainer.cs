﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryDataContainer
{
    class DataContainer
    {
        public AttributeType AttrType { get { return _AttrType; } }
        protected AttributeType _AttrType;

        private string StrData = null;
        private int? IntData = null;

        protected DataContainer()
        {
            _AttrType = AttributeType.None;
        }

        public DataContainer(string value)
        {
            StrData = value ?? throw new ArgumentNullException(nameof(value));
            _AttrType = AttributeType.Name;
        }

        public DataContainer(int value)
        {
            IntData = value;
            _AttrType = AttributeType.Age;
        }

        public static implicit operator int(DataContainer dt)
        {
            if (dt.IntData.HasValue)
            {
                return dt.IntData.Value;
            }
            return 0;
        }

        public static implicit operator string(DataContainer dt)
        {
            return dt.StrData;
        }
    }
}
