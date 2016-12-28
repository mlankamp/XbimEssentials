using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
using static Xbim.Ifc2x3.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.MeasureResource
{
	public partial class IfcUnitAssignment : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc2x3.MeasureResource.IfcUnitAssignment");

		/// <summary>
		/// Tests the express where clause WR01
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool WR01() {
			var retVal = false;
			try {
				retVal = IfcCorrectUnitAssignment(Units);
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'WR01' for #{EntityLabel}.", ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!WR01())
				yield return new ValidationResult() { Item = this, IssueSource = "WR01", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
