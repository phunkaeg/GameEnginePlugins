using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ACPlugin.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (resourceMan == null)
				{
					ResourceManager resourceManager = resourceMan = new ResourceManager("ACPlugin.Properties.Resources", typeof(Resources).Assembly);
				}
				return resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return resourceCulture;
			}
			set
			{
				resourceCulture = value;
			}
		}

		internal static Bitmap background
		{
			get
			{
				object @object = ResourceManager.GetObject("background", resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static string defProfile => ResourceManager.GetString("defProfile", resourceCulture);

		internal static Bitmap logo
		{
			get
			{
				object @object = ResourceManager.GetObject("logo", resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap small
		{
			get
			{
				object @object = ResourceManager.GetObject("small", resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal Resources()
		{
		}
	}
}
