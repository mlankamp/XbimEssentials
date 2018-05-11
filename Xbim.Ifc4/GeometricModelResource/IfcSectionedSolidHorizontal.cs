// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSectionedSolidHorizontal
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSectionedSolidHorizontal : IIfcSectionedSolid
	{
		IItemSet<IIfcDistanceExpression> @CrossSectionPositions { get; }
		IfcBoolean @FixedAxisVertical { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcSectionedSolidHorizontal", 1355)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionedSolidHorizontal : IfcSectionedSolid, IInstantiableEntity, IIfcSectionedSolidHorizontal, IContainsEntityReferences, IEquatable<@IfcSectionedSolidHorizontal>
	{
		#region IIfcSectionedSolidHorizontal explicit implementation
		IItemSet<IIfcDistanceExpression> IIfcSectionedSolidHorizontal.CrossSectionPositions { 
			get { return new Common.Collections.ProxyItemSet<IfcDistanceExpression, IIfcDistanceExpression>( @CrossSectionPositions); } 
		}	
		IfcBoolean IIfcSectionedSolidHorizontal.FixedAxisVertical { 
 
			get { return @FixedAxisVertical; } 
			set { FixedAxisVertical = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionedSolidHorizontal(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_crossSectionPositions = new ItemSet<IfcDistanceExpression>( this, 0,  3);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcDistanceExpression> _crossSectionPositions;
		private IfcBoolean _fixedAxisVertical;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 2, -1, 5)]
		public IItemSet<IfcDistanceExpression> @CrossSectionPositions 
		{ 
			get 
			{
				if(_activated) return _crossSectionPositions;
				Activate();
				return _crossSectionPositions;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcBoolean @FixedAxisVertical 
		{ 
			get 
			{
				if(_activated) return _fixedAxisVertical;
				Activate();
				return _fixedAxisVertical;
			} 
			set
			{
				SetValue( v =>  _fixedAxisVertical = v, _fixedAxisVertical, value,  "FixedAxisVertical", 4);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_crossSectionPositions.InternalAdd((IfcDistanceExpression)value.EntityVal);
					return;
				case 3: 
					_fixedAxisVertical = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSectionedSolidHorizontal other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Directrix != null)
					yield return @Directrix;
				foreach(var entity in @CrossSections)
					yield return entity;
				foreach(var entity in @CrossSectionPositions)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}