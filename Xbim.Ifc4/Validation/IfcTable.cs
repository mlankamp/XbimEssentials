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
namespace Xbim.Ifc4.UtilityResource
{
	public partial class IfcTable : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.UtilityResource.IfcTable");

		/// <summary>
		/// Tests the express where clause WR1
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool WR1() {
			var retVal = false;
			try {
				retVal = SIZEOF(Rows.Where(Temp => HIINDEX(Temp.RowCells) != HIINDEX(Rows.ToArray()[0].RowCells))) == 0;
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'WR1' for #{EntityLabel}.", ex);
			}
			return retVal;
		}

		/// <summary>
		/// Tests the express where clause WR2
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool WR2() {
			var retVal = false;
			try {
				retVal = ((0 <= NumberOfHeadings) && (NumberOfHeadings <= 1) );
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'WR2' for #{EntityLabel}.", ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!WR1())
				yield return new ValidationResult() { Item = this, IssueSource = "WR1", IssueType = ValidationFlags.EntityWhereClauses };
			if (!WR2())
				yield return new ValidationResult() { Item = this, IssueSource = "WR2", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
