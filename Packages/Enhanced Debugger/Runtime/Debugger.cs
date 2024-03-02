
using System;

public static class Debugger {
	public static Type GetType (object _obj) {
		Type type = _obj.GetType();

		return type;
	}

	public static System.Reflection.MemberInfo[] GetMembers (object _obj) {
		Type type = GetType (_obj);
		System.Reflection.MemberInfo[] members = type.GetMembers();

		return members;
	}
}
