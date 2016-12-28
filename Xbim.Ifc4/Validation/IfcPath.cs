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
namespace Xbim.Ifc4.TopologyResource
{
	public partial class IfcPath : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.TopologyResource.IfcPath");

		/// <summary>
		/// Tests the express where clause IsContinuous
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool IsContinuous() {
			var retVal = false;
			try {
				retVal = IfcPathHeadToTail(this);
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'IsContinuous' for #{EntityLabel}.", ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!IsContinuous())
				yield return new ValidationResult() { Item = this, IssueSource = "IsContinuous", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
