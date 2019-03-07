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
	[ExpressType("IfcAlignment2DVerticalSegment", 1339)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcAlignment2DVerticalSegment : IfcAlignment2DSegment, IEquatable<@IfcAlignment2DVerticalSegment>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAlignment2DVerticalSegment(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _startDistAlong;
		private IfcPositiveLengthMeasure _horizontalLength;
		private IfcLengthMeasure _startHeight;
		private IfcRatioMeasure _startGradient;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcLengthMeasure @StartDistAlong 
		{ 
			get 
			{
				if(_activated) return _startDistAlong;
				Activate();
				return _startDistAlong;
			} 
			set
			{
				SetValue( v =>  _startDistAlong = v, _startDistAlong, value,  "StartDistAlong", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcPositiveLengthMeasure @HorizontalLength 
		{ 
			get 
			{
				if(_activated) return _horizontalLength;
				Activate();
				return _horizontalLength;
			} 
			set
			{
				SetValue( v =>  _horizontalLength = v, _horizontalLength, value,  "HorizontalLength", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcLengthMeasure @StartHeight 
		{ 
			get 
			{
				if(_activated) return _startHeight;
				Activate();
				return _startHeight;
			} 
			set
			{
				SetValue( v =>  _startHeight = v, _startHeight, value,  "StartHeight", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcRatioMeasure @StartGradient 
		{ 
			get 
			{
				if(_activated) return _startGradient;
				Activate();
				return _startGradient;
			} 
			set
			{
				SetValue( v =>  _startGradient = v, _startGradient, value,  "StartGradient", 7);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("Segments")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { 1 }, 10)]
		public IEnumerable<IfcAlignment2DVertical> @ToVertical 
		{ 
			get 
			{
				return Model.Instances.Where<IfcAlignment2DVertical>(e => e.Segments != null &&  e.Segments.Contains(this), "Segments", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_startDistAlong = value.RealVal;
					return;
				case 4: 
					_horizontalLength = value.RealVal;
					return;
				case 5: 
					_startHeight = value.RealVal;
					return;
				case 6: 
					_startGradient = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAlignment2DVerticalSegment other)
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