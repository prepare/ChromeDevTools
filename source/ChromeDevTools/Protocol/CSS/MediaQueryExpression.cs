using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Media query expression descriptor.
	/// </summary>
	public class MediaQueryExpression
	{
		/// <summary>
		/// Gets or sets Media query expression value.
		/// </summary>
		public double Value { get; set; }
		/// <summary>
		/// Gets or sets Media query expression units.
		/// </summary>
		public string Unit { get; set; }
		/// <summary>
		/// Gets or sets Media query expression feature.
		/// </summary>
		public string Feature { get; set; }
		/// <summary>
		/// Gets or sets The associated range of the value text in the enclosing stylesheet (if available).
		/// </summary>
		public SourceRange ValueRange { get; set; }
		/// <summary>
		/// Gets or sets Computed length of media query expression (if applicable).
		/// </summary>
		public double ComputedLength { get; set; }
	}
}
