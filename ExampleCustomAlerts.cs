 
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
	public class ExampleCustomAlerts : IAlert2
	{
		private IControlCenter controlCenterHost;

		public string AlertName
		{
			get
			{
				return "CrankCall Voice";
			}
		}

		public int AlertNumber
		{
			get
			{
				return 8;
			}
		}

		public void Decommision()
		{
			controlCenterHost = null;
		}

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

		// This is the IAlert2 function, this is the one we will be using.
		public string ExecuteAlert(LabTech.Interfaces.ContactInfo contact, int clientId, int computerId, string message, string agentName, int agentId, int groupId, string fieldName, string result, string what, string @where)
		{
			// For a simple example we will just send a command to open a browser on the computer where the alert was triggered
			try
			{
				//controlCenterHost.SendCommand(computerId, 65, "http://www.labtechsoftware.com|0");
				controlCenterHost.LogMessage(string.Format("[CrankCall] Voice Alarm for Client [{0}] Computer [{1}] with message [{2}] ", clientId, computerId, message));
			}
			catch (Exception ex)
			{
				controlCenterHost.LogMessage(string.Format("[CrankCall] Executing PBX Call failed with -> {0}", ex.Message));
			}

			return "Alert finished";
		}

		// This is the IAlert function, we will not be using this one.
		public string ExecuteAlert(LabTech.Interfaces.ContactInfo contact, int clientId, int computerId, string message, string agentName)
		{
			return "";
		}
	}

}