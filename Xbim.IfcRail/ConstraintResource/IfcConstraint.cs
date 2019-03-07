// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.ExternalReferenceResource;
using Xbim.IfcRail.MeasureResource;
using Xbim.IfcRail.ActorResource;
using Xbim.IfcRail.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.ConstraintResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.ConstraintResource
{
	[ExpressType("IfcConstraint", 81)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcConstraint : PersistEntity, IfcResourceObjectSelect, IEquatable<@IfcConstraint>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConstraint(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcText? _description;
		private IfcConstraintEnum _constraintGrade;
		private IfcLabel? _constraintSource;
		private IfcActorSelect _creatingActor;
		private IfcDateTime? _creationTime;
		private IfcLabel? _userDefinedGrade;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 3)]
		public IfcConstraintEnum @ConstraintGrade 
		{ 
			get 
			{
				if(_activated) return _constraintGrade;
				Activate();
				return _constraintGrade;
			} 
			set
			{
				SetValue( v =>  _constraintGrade = v, _constraintGrade, value,  "ConstraintGrade", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLabel? @ConstraintSource 
		{ 
			get 
			{
				if(_activated) return _constraintSource;
				Activate();
				return _constraintSource;
			} 
			set
			{
				SetValue( v =>  _constraintSource = v, _constraintSource, value,  "ConstraintSource", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcActorSelect @CreatingActor 
		{ 
			get 
			{
				if(_activated) return _creatingActor;
				Activate();
				return _creatingActor;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _creatingActor = v, _creatingActor, value,  "CreatingActor", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcDateTime? @CreationTime 
		{ 
			get 
			{
				if(_activated) return _creationTime;
				Activate();
				return _creationTime;
			} 
			set
			{
				SetValue( v =>  _creationTime = v, _creationTime, value,  "CreationTime", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcLabel? @UserDefinedGrade 
		{ 
			get 
			{
				if(_activated) return _userDefinedGrade;
				Activate();
				return _userDefinedGrade;
			} 
			set
			{
				SetValue( v =>  _userDefinedGrade = v, _userDefinedGrade, value,  "UserDefinedGrade", 7);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedResourceObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 8)]
		public IEnumerable<IfcExternalReferenceRelationship> @HasExternalReferences 
		{ 
			get 
			{
				return Model.Instances.Where<IfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
		[InverseProperty("RelatingConstraint")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 9)]
		public IEnumerable<IfcResourceConstraintRelationship> @PropertiesForConstraint 
		{ 
			get 
			{
				return Model.Instances.Where<IfcResourceConstraintRelationship>(e => Equals(e.RelatingConstraint), "RelatingConstraint", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
                    _constraintGrade = (IfcConstraintEnum) System.Enum.Parse(typeof (IfcConstraintEnum), value.EnumVal, true);
					return;
				case 3: 
					_constraintSource = value.StringVal;
					return;
				case 4: 
					_creatingActor = (IfcActorSelect)(value.EntityVal);
					return;
				case 5: 
					_creationTime = value.StringVal;
					return;
				case 6: 
					_userDefinedGrade = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConstraint other)
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