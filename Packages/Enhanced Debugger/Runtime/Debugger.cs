
using System;

public class Debugger {
	public System.Reflection.MemberInfo[] GetMember (Object _obj) {
		Type type = _obj.GetType();
		System.Reflection.MemberInfo[] members = type.GetMembers ();

		return members;
	}
}
