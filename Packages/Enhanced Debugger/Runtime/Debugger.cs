
using System;

public static class Debugger {
	public static System.Reflection.MemberInfo[] GetMember (object _obj) {
		Type type = _obj.GetType();
		System.Reflection.MemberInfo[] members = type.GetMembers ();

		return members;
	}
}
