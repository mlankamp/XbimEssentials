using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.ProcessExtension
{
	public partial class IfcEventType : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.ProcessExtension.IfcEventType");

		/// <summary>
		/// Tests the express where clause CorrectPredefinedType
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool CorrectPredefinedType() {
			var retVal = false;
			try {
				retVal = (PredefinedType != IfcEventTypeEnum.USERDEFINED) || ((PredefinedType == IfcEventTypeEnum.USERDEFINED) && EXISTS(this/* as IfcTypeProcess*/.ProcessType));
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'CorrectPredefinedType' for #{EntityLabel}.", ex);
			}
			return retVal;
		}

		/// <summary>
		/// Tests the express where clause CorrectEventTriggerType
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool CorrectEventTriggerType() {
			var retVal = false;
			try {
				retVal = (EventTriggerType != IfcEventTriggerTypeEnum.USERDEFINED) || ((EventTriggerType == IfcEventTriggerTypeEnum.USERDEFINED) && EXISTS(UserDefinedEventTriggerType));
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'CorrectEventTriggerType' for #{EntityLabel}.", ex);
			}
			return retVal;
		}

		public new IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!CorrectPredefinedType())
				yield return new ValidationResult() { Item = this, IssueSource = "CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
			if (!CorrectEventTriggerType())
				yield return new ValidationResult() { Item = this, IssueSource = "CorrectEventTriggerType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
