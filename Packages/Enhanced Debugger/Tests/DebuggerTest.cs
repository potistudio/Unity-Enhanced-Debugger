
using NUnit.Framework;

public class DebuggerTest {
	[Test]
	public void Debug() {
		Debugger debugger = new();
		System.Reflection.MemberInfo[] members = debugger.GetMember (new UnityEngine.GameObject("Test Object"));

		foreach (System.Reflection.MemberInfo member in members) {
			UnityEngine.Debug.Log (member);
		}
	}
}
