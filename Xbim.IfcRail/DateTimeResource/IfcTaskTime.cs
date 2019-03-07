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
using Xbim.IfcRail.DateTimeResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.DateTimeResource
{
	[ExpressType("IfcTaskTime", 1294)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTaskTime : IfcSchedulingTime, IInstantiableEntity, IEquatable<@IfcTaskTime>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTaskTime(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcTaskDurationEnum? _durationType;
		private IfcDuration? _scheduleDuration;
		private IfcDateTime? _scheduleStart;
		private IfcDateTime? _scheduleFinish;
		private IfcDateTime? _earlyStart;
		private IfcDateTime? _earlyFinish;
		private IfcDateTime? _lateStart;
		private IfcDateTime? _lateFinish;
		private IfcDuration? _freeFloat;
		private IfcDuration? _totalFloat;
		private IfcBoolean? _isCritical;
		private IfcDateTime? _statusTime;
		private IfcDuration? _actualDuration;
		private IfcDateTime? _actualStart;
		private IfcDateTime? _actualFinish;
		private IfcDuration? _remainingTime;
		private IfcPositiveRatioMeasure? _completion;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 4)]
		public IfcTaskDurationEnum? @DurationType 
		{ 
			get 
			{
				if(_activated) return _durationType;
				Activate();
				return _durationType;
			} 
			set
			{
				SetValue( v =>  _durationType = v, _durationType, value,  "DurationType", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcDuration? @ScheduleDuration 
		{ 
			get 
			{
				if(_activated) return _scheduleDuration;
				Activate();
				return _scheduleDuration;
			} 
			set
			{
				SetValue( v =>  _scheduleDuration = v, _scheduleDuration, value,  "ScheduleDuration", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcDateTime? @ScheduleStart 
		{ 
			get 
			{
				if(_activated) return _scheduleStart;
				Activate();
				return _scheduleStart;
			} 
			set
			{
				SetValue( v =>  _scheduleStart = v, _scheduleStart, value,  "ScheduleStart", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcDateTime? @ScheduleFinish 
		{ 
			get 
			{
				if(_activated) return _scheduleFinish;
				Activate();
				return _scheduleFinish;
			} 
			set
			{
				SetValue( v =>  _scheduleFinish = v, _scheduleFinish, value,  "ScheduleFinish", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcDateTime? @EarlyStart 
		{ 
			get 
			{
				if(_activated) return _earlyStart;
				Activate();
				return _earlyStart;
			} 
			set
			{
				SetValue( v =>  _earlyStart = v, _earlyStart, value,  "EarlyStart", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcDateTime? @EarlyFinish 
		{ 
			get 
			{
				if(_activated) return _earlyFinish;
				Activate();
				return _earlyFinish;
			} 
			set
			{
				SetValue( v =>  _earlyFinish = v, _earlyFinish, value,  "EarlyFinish", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcDateTime? @LateStart 
		{ 
			get 
			{
				if(_activated) return _lateStart;
				Activate();
				return _lateStart;
			} 
			set
			{
				SetValue( v =>  _lateStart = v, _lateStart, value,  "LateStart", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcDateTime? @LateFinish 
		{ 
			get 
			{
				if(_activated) return _lateFinish;
				Activate();
				return _lateFinish;
			} 
			set
			{
				SetValue( v =>  _lateFinish = v, _lateFinish, value,  "LateFinish", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public IfcDuration? @FreeFloat 
		{ 
			get 
			{
				if(_activated) return _freeFloat;
				Activate();
				return _freeFloat;
			} 
			set
			{
				SetValue( v =>  _freeFloat = v, _freeFloat, value,  "FreeFloat", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 13)]
		public IfcDuration? @TotalFloat 
		{ 
			get 
			{
				if(_activated) return _totalFloat;
				Activate();
				return _totalFloat;
			} 
			set
			{
				SetValue( v =>  _totalFloat = v, _totalFloat, value,  "TotalFloat", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 14)]
		public IfcBoolean? @IsCritical 
		{ 
			get 
			{
				if(_activated) return _isCritical;
				Activate();
				return _isCritical;
			} 
			set
			{
				SetValue( v =>  _isCritical = v, _isCritical, value,  "IsCritical", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 15)]
		public IfcDateTime? @StatusTime 
		{ 
			get 
			{
				if(_activated) return _statusTime;
				Activate();
				return _statusTime;
			} 
			set
			{
				SetValue( v =>  _statusTime = v, _statusTime, value,  "StatusTime", 15);
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 16)]
		public IfcDuration? @ActualDuration 
		{ 
			get 
			{
				if(_activated) return _actualDuration;
				Activate();
				return _actualDuration;
			} 
			set
			{
				SetValue( v =>  _actualDuration = v, _actualDuration, value,  "ActualDuration", 16);
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 17)]
		public IfcDateTime? @ActualStart 
		{ 
			get 
			{
				if(_activated) return _actualStart;
				Activate();
				return _actualStart;
			} 
			set
			{
				SetValue( v =>  _actualStart = v, _actualStart, value,  "ActualStart", 17);
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 18)]
		public IfcDateTime? @ActualFinish 
		{ 
			get 
			{
				if(_activated) return _actualFinish;
				Activate();
				return _actualFinish;
			} 
			set
			{
				SetValue( v =>  _actualFinish = v, _actualFinish, value,  "ActualFinish", 18);
			} 
		}	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 19)]
		public IfcDuration? @RemainingTime 
		{ 
			get 
			{
				if(_activated) return _remainingTime;
				Activate();
				return _remainingTime;
			} 
			set
			{
				SetValue( v =>  _remainingTime = v, _remainingTime, value,  "RemainingTime", 19);
			} 
		}	
		[EntityAttribute(20, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 20)]
		public IfcPositiveRatioMeasure? @Completion 
		{ 
			get 
			{
				if(_activated) return _completion;
				Activate();
				return _completion;
			} 
			set
			{
				SetValue( v =>  _completion = v, _completion, value,  "Completion", 20);
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
                    _durationType = (IfcTaskDurationEnum) System.Enum.Parse(typeof (IfcTaskDurationEnum), value.EnumVal, true);
					return;
				case 4: 
					_scheduleDuration = value.StringVal;
					return;
				case 5: 
					_scheduleStart = value.StringVal;
					return;
				case 6: 
					_scheduleFinish = value.StringVal;
					return;
				case 7: 
					_earlyStart = value.StringVal;
					return;
				case 8: 
					_earlyFinish = value.StringVal;
					return;
				case 9: 
					_lateStart = value.StringVal;
					return;
				case 10: 
					_lateFinish = value.StringVal;
					return;
				case 11: 
					_freeFloat = value.StringVal;
					return;
				case 12: 
					_totalFloat = value.StringVal;
					return;
				case 13: 
					_isCritical = value.BooleanVal;
					return;
				case 14: 
					_statusTime = value.StringVal;
					return;
				case 15: 
					_actualDuration = value.StringVal;
					return;
				case 16: 
					_actualStart = value.StringVal;
					return;
				case 17: 
					_actualFinish = value.StringVal;
					return;
				case 18: 
					_remainingTime = value.StringVal;
					return;
				case 19: 
					_completion = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTaskTime other)
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