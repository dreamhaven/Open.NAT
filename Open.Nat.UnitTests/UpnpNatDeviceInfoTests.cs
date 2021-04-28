using System;
using System.Net;
#if UNITY_INCLUDE_TESTS
using NUnit.Framework;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

namespace Open.Nat.UnitTests
{
#if UNITY_INCLUDE_TESTS
	[TestFixture]
#else
	[TestClass]
#endif
	public class UpnpNatDeviceInfoTests
	{
#if UNITY_INCLUDE_TESTS
		[Test]
#else
		[TestMethod]
#endif
		public void x()
		{
			var info = new UpnpNatDeviceInfo(IPAddress.Loopback, new Uri("http://127.0.0.1:3221"), "/control?WANIPConnection", null);
			Assert.AreEqual("http://127.0.0.1:3221/control?WANIPConnection", info.ServiceControlUri.ToString());
		}
	}
}
