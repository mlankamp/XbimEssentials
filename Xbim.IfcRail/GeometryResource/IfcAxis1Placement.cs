// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

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
	[ExpressType("IfcAxis1Placement", 280)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAxis1Placement : IfcPlacement, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcAxis1Placement>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAxis1Placement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDirection _axis;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcDirection @Axis 
		{ 
			get 
			{
				if(_activated) return _axis;
				Activate();
				return _axis;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _axis = v, _axis, value,  "Axis", 2);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Class, EntityAttributeType.None, null, null, 0)]
		public Common.Geometry.XbimVector3D @Z 
		{
			get 
			{
				//## Getter for Z
                return _axis != null ? _axis.Normalise() : new Common.Geometry.XbimVector3D(0, 0, 1);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_axis = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAxis1Placement other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Location != null)
					yield return @Location;
				if (@Axis != null)
					yield return @Axis;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}