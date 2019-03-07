// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.GeometryResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.GeometryResource
{
	[ExpressType("IfcCartesianTransformationOperator2DnonUniform", 147)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcCartesianTransformationOperator2DnonUniform>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator2DnonUniform(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcReal? _scale2;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcReal? @Scale2 
		{ 
			get 
			{
				if(_activated) return _scale2;
				Activate();
				return _scale2;
			} 
			set
			{
				SetValue( v =>  _scale2 = v, _scale2, value,  "Scale2", 5);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcReal @Scl2 
		{
			get 
			{
				//## Getter for Scl2
                return Scale2 ?? Scl;
				//##
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_scale2 = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianTransformationOperator2DnonUniform other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Axis1 != null)
					yield return @Axis1;
				if (@Axis2 != null)
					yield return @Axis2;
				if (@LocalOrigin != null)
					yield return @LocalOrigin;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}