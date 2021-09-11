 
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
	public class ExampleControlAlert : IControlAlert
	{
		private IControlCenter controlCenterHost;

		// This property is used to display a name for the custom alert, in the alert type selection list, within the Control Center. 
		public string AlertName
		{
			get
			{
				return "CrankCall Voice";
			}
		}

		// This number is set to one of the Alert Action Types and is used to control how the LabTech system creates the alert.
		public int AlertNumber
		{
			get
			{
				return 8;
			}
		}

		// Decommision is called when the Control Center is closing and is used to clean up objects created by the plugin.
		public void Decommision()
		{
			controlCenterHost = null;
		}

		// Initialize is called when the Control Center is opened and is used to load properties, set variables and perform any other required operations for your plugin to integrate properly.
		// After initialization your new alert type will be found in the alert templates section
		// These are found in Dashboard -> Management -> Alert Templates 
		// From here you can either modify an existing Template or create a new one.  Either way right clicking on the listview will allow you 
		// to add a "New Alert" and select the alert you have created.
		// Be sure that the timeframe of your template is within the hours of your testing.
		public void Initialize(LabTech.Interfaces.IControlCenter host)
		{
			controlCenterHost = host;
		}

		public string Name
		{
			get
			{
				return "CrankCall Voice";
			}
		}
	}

}