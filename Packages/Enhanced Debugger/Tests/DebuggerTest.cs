
using NUnit.Framework;

public class DebuggerTest {
	object m_TargetInstance = null;

	[SetUp]
	public void Setup() {
		m_TargetInstance = new System.Collections.Generic.List<float>();
	}

	[Test]
	public void DebugType() {
		UnityEngine.Debug.Log (Debugger.GetType(m_TargetInstance));
		UnityEngine.Debug.Log (Debugger.GetType(m_TargetInstance).Namespace);
		Logger.Verbose ("DebugType");
	}

	[Test]
	public void DebugMembers() {
		System.Reflection.MemberInfo[] members = Debugger.GetMembers (m_TargetInstance);

		foreach (System.Reflection.MemberInfo member in members) {
			UnityEngine.Debug.Log (member);
		}
	}
}
