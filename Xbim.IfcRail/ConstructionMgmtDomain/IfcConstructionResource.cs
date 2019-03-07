// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.Kernel;
using Xbim.IfcRail.DateTimeResource;
using Xbim.IfcRail.QuantityResource;
using Xbim.IfcRail.CostResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.ConstructionMgmtDomain;
//## Custom using statements
//##


namespace Xbim.IfcRail.ConstructionMgmtDomain
{
	[ExpressType("IfcConstructionResource", 157)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcConstructionResource : IfcResource, IEquatable<@IfcConstructionResource>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConstructionResource(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_baseCosts = new OptionalItemSet<IfcAppliedValue>( this, 0,  9);
		}

		#region Explicit attribute fields
		private IfcResourceTime _usage;
		private readonly OptionalItemSet<IfcAppliedValue> _baseCosts;
		private IfcPhysicalQuantity _baseQuantity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 20)]
		public IfcResourceTime @Usage 
		{ 
			get 
			{
				if(_activated) return _usage;
				Activate();
				return _usage;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _usage = v, _usage, value,  "Usage", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 21)]
		public IOptionalItemSet<IfcAppliedValue> @BaseCosts 
		{ 
			get 
			{
				if(_activated) return _baseCosts;
				Activate();
				return _baseCosts;
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 22)]
		public IfcPhysicalQuantity @BaseQuantity 
		{ 
			get 
			{
				if(_activated) return _baseQuantity;
				Activate();
				return _baseQuantity;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _baseQuantity = v, _baseQuantity, value,  "BaseQuantity", 10);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_usage = (IfcResourceTime)(value.EntityVal);
					return;
				case 8: 
					_baseCosts.InternalAdd((IfcAppliedValue)value.EntityVal);
					return;
				case 9: 
					_baseQuantity = (IfcPhysicalQuantity)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConstructionResource other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}