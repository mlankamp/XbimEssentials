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
using Xbim.IfcRail.GeometricConstraintResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.GeometricConstraintResource
{
	[ExpressType("IfcAlignment2DVerSegCircularArc", 1335)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAlignment2DVerSegCircularArc : IfcAlignment2DVerticalSegment, IInstantiableEntity, IEquatable<@IfcAlignment2DVerSegCircularArc>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAlignment2DVerSegCircularArc(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _radius;
		private IfcBoolean _isConvex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcPositiveLengthMeasure @Radius 
		{ 
			get 
			{
				if(_activated) return _radius;
				Activate();
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public IfcBoolean @IsConvex 
		{ 
			get 
			{
				if(_activated) return _isConvex;
				Activate();
				return _isConvex;
			} 
			set
			{
				SetValue( v =>  _isConvex = v, _isConvex, value,  "IsConvex", 9);
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
					_radius = value.RealVal;
					return;
				case 8: 
					_isConvex = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAlignment2DVerSegCircularArc other)
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