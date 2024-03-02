
using NUnit.Framework;

public class DebuggerTest {
	[Test]
	public void Debug() {
		System.Reflection.MemberInfo[] members = Debugger.GetMember (new UnityEngine.GameObject("Test Object"));

		foreach (System.Reflection.MemberInfo member in members) {
			UnityEngine.Debug.Log (member);
		}
	}
}
