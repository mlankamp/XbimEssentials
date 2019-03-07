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
	[ExpressType("IfcTrimmedCurve", 143)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTrimmedCurve : IfcBoundedCurve, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcTrimmedCurve>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTrimmedCurve(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_trim1 = new ItemSet<IfcTrimmingSelect>( this, 2,  2);
			_trim2 = new ItemSet<IfcTrimmingSelect>( this, 2,  3);
		}

		#region Explicit attribute fields
		private IfcCurve _basisCurve;
		private readonly ItemSet<IfcTrimmingSelect> _trim1;
		private readonly ItemSet<IfcTrimmingSelect> _trim2;
		private IfcBoolean _senseAgreement;
		private IfcTrimmingPreference _masterRepresentation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcCurve @BasisCurve 
		{ 
			get 
			{
				if(_activated) return _basisCurve;
				Activate();
				return _basisCurve;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _basisCurve = v, _basisCurve, value,  "BasisCurve", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { 2 }, 5)]
		public IItemSet<IfcTrimmingSelect> @Trim1 
		{ 
			get 
			{
				if(_activated) return _trim1;
				Activate();
				return _trim1;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { 2 }, 6)]
		public IItemSet<IfcTrimmingSelect> @Trim2 
		{ 
			get 
			{
				if(_activated) return _trim2;
				Activate();
				return _trim2;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcBoolean @SenseAgreement 
		{ 
			get 
			{
				if(_activated) return _senseAgreement;
				Activate();
				return _senseAgreement;
			} 
			set
			{
				SetValue( v =>  _senseAgreement = v, _senseAgreement, value,  "SenseAgreement", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 8)]
		public IfcTrimmingPreference @MasterRepresentation 
		{ 
			get 
			{
				if(_activated) return _masterRepresentation;
				Activate();
				return _masterRepresentation;
			} 
			set
			{
				SetValue( v =>  _masterRepresentation = v, _masterRepresentation, value,  "MasterRepresentation", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_basisCurve = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					_trim1.InternalAdd((IfcTrimmingSelect)value.EntityVal);
					return;
				case 2: 
					_trim2.InternalAdd((IfcTrimmingSelect)value.EntityVal);
					return;
				case 3: 
					_senseAgreement = value.BooleanVal;
					return;
				case 4: 
                    _masterRepresentation = (IfcTrimmingPreference) System.Enum.Parse(typeof (IfcTrimmingPreference), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTrimmedCurve other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@BasisCurve != null)
					yield return @BasisCurve;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}