
using NUnit.Framework;

public class DebuggerTest {
	[Test]
	public void DebugMembers() {
		System.Reflection.MemberInfo[] members = Debugger.GetMembers (new UnityEngine.Color());

		foreach (System.Reflection.MemberInfo member in members) {
			UnityEngine.Debug.Log (member);
		}
	}
}
