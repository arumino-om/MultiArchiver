using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArchiveLibrary.Types
{
    public class ConfigItem
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public Type ValueType { get; init; }

        private object _value;
        public object Value
        {
            get => _value;
            set
            {
                if (value.GetType() != ValueType)
                {
                    throw new ArgumentException("Value type does not match the expected type.");
                }
                _value = value;
            }
        }
    }
}
