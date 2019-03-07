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
	[ExpressType("IfcToroidalSurface", 1328)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcToroidalSurface : IfcElementarySurface, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcToroidalSurface>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcToroidalSurface(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _majorRadius;
		private IfcPositiveLengthMeasure _minorRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcPositiveLengthMeasure @MajorRadius 
		{ 
			get 
			{
				if(_activated) return _majorRadius;
				Activate();
				return _majorRadius;
			} 
			set
			{
				SetValue( v =>  _majorRadius = v, _majorRadius, value,  "MajorRadius", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcPositiveLengthMeasure @MinorRadius 
		{ 
			get 
			{
				if(_activated) return _minorRadius;
				Activate();
				return _minorRadius;
			} 
			set
			{
				SetValue( v =>  _minorRadius = v, _minorRadius, value,  "MinorRadius", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_majorRadius = value.RealVal;
					return;
				case 2: 
					_minorRadius = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcToroidalSurface other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}