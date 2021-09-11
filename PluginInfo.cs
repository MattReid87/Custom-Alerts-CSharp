 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

using LabTech.Interfaces;

namespace Example.CustomAlerts
{
	public class PluginInfo : IPlugin
	{
		public string About
		{
			get
			{
				return "Custom Alerts - Example by LabTech Software, LLC.";
			}
		}

		public string Author
		{
			get
			{
				return "LabTech Software, LLC";
			}
		}

		public string Filename
		{
			get
			{
				return "Example-CustomAlerts.dll";
			}
			set
			{
				//do nothing
			}
		}

		public string hMD5 {get; set;}

		public bool Install(IControlCenter host)
		{
			return true;
		}

		public bool IsCompatible(IControlCenter host)
		{
			return true;
		}

		public bool IsLicensed()
		{
			return true;
		}

		public bool IsLicensed(IControlCenter host)
		{
			return true;
		}

		public string Name
		{
			get
			{
				return "Example - Custom Alerts";
			}
		}

		public bool Remove(IControlCenter host)
		{
			return true;
		}

		public int Version
		{
			get
			{
				return 1;
			}
		}

	}

}