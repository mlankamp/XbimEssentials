// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.MeasureResource;

namespace Xbim.IfcRail.DateTimeResource
{
	[ExpressType("IfcDate", 988)]
	[DefinedType(typeof(string))]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcDate : IfcSimpleValue, IExpressValueType, IExpressStringType, System.IEquatable<string>
	{ 
		private string _value;
        
		public object Value
        {
            get { return _value; }
        }

 
		string IExpressStringType.Value { get { return _value; } }

		public override string ToString()
        {
			return _value ?? "";
        }
        public IfcDate(string val)
        {
            _value = val;
        }


        public static implicit operator IfcDate(string value)
        {
            return new IfcDate(value);
        }

        public static implicit operator string(IfcDate obj)
        {
            return obj._value;

        }


        public override bool Equals(object obj)
        {
			if (obj == null && Value == null)
                return true;

            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            return ((IfcDate) obj)._value == _value;
        }

		public bool Equals(string other)
	    {
	        return this == other;
	    }

        public static bool operator ==(IfcDate obj1, IfcDate obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcDate obj1, IfcDate obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return Value != null ? _value.GetHashCode() : base.GetHashCode();
        }

		#region IPersist implementation
		void IPersist.Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			if (propIndex != 0)
				throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
            _value = value.StringVal;
            
		}
		#endregion

		#region IExpressValueType implementation
        System.Type IExpressValueType.UnderlyingSystemType { 
			get 
			{
				return typeof(string);
			}
		}
		#endregion


	}
}
