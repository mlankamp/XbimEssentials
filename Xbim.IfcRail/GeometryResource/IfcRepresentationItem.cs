// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.PresentationOrganizationResource;
using Xbim.IfcRail.PresentationAppearanceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.GeometryResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.GeometryResource
{
	[ExpressType("IfcRepresentationItem", 31)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcRepresentationItem : PersistEntity, IfcLayeredItem, IEquatable<@IfcRepresentationItem>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRepresentationItem(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}




		#region Inverse attributes
		[InverseProperty("AssignedItems")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 1)]
		public IEnumerable<IfcPresentationLayerAssignment> @LayerAssignment 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPresentationLayerAssignment>(e => e.AssignedItems != null &&  e.AssignedItems.Contains(this), "AssignedItems", this);
			} 
		}
		[InverseProperty("Item")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 2)]
		public IEnumerable<IfcStyledItem> @StyledByItem 
		{ 
			get 
			{
				return Model.Instances.Where<IfcStyledItem>(e => Equals(e.Item), "Item", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRepresentationItem other)
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