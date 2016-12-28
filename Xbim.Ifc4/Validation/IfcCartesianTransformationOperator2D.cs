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
namespace Xbim.Ifc4.GeometryResource
{
	public partial class IfcCartesianTransformationOperator2D : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.GeometryResource.IfcCartesianTransformationOperator2D");

		/// <summary>
		/// Tests the express where clause DimEqual2
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool DimEqual2() {
			var retVal = false;
			try {
				retVal = this/* as IfcCartesianTransformationOperator*/.Dim == 2;
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'DimEqual2' for #{EntityLabel}.", ex);
			}
			return retVal;
		}

		/// <summary>
		/// Tests the express where clause Axis1Is2D
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool Axis1Is2D() {
			var retVal = false;
			try {
				retVal = !(EXISTS(this/* as IfcCartesianTransformationOperator*/.Axis1)) || (this/* as IfcCartesianTransformationOperator*/.Axis1.Dim == 2);
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'Axis1Is2D' for #{EntityLabel}.", ex);
			}
			return retVal;
		}

		/// <summary>
		/// Tests the express where clause Axis2Is2D
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool Axis2Is2D() {
			var retVal = false;
			try {
				retVal = !(EXISTS(this/* as IfcCartesianTransformationOperator*/.Axis2)) || (this/* as IfcCartesianTransformationOperator*/.Axis2.Dim == 2);
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'Axis2Is2D' for #{EntityLabel}.", ex);
			}
			return retVal;
		}

		public new IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!DimEqual2())
				yield return new ValidationResult() { Item = this, IssueSource = "DimEqual2", IssueType = ValidationFlags.EntityWhereClauses };
			if (!Axis1Is2D())
				yield return new ValidationResult() { Item = this, IssueSource = "Axis1Is2D", IssueType = ValidationFlags.EntityWhereClauses };
			if (!Axis2Is2D())
				yield return new ValidationResult() { Item = this, IssueSource = "Axis2Is2D", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
