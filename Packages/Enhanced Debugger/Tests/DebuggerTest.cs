
using NUnit.Framework;

public class DebuggerTest {
	[Test]
	public void DebugType() {
		object targetInstance = new System.Collections.Generic.List<float>();
		UnityEngine.Debug.Log (Debugger.GetType(targetInstance));
		UnityEngine.Debug.Log (Debugger.GetType(targetInstance).Namespace);
	}

	[Test]
	public void DebugMembers() {
		System.Reflection.MemberInfo[] members = Debugger.GetMembers (new UnityEngine.Color());

		foreach (System.Reflection.MemberInfo member in members) {
			UnityEngine.Debug.Log (member);
		}
	}
}
