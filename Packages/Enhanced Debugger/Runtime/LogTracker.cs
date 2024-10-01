public static class LogTracker {
	private static System.Collections.Generic.List<Log> m_CalledLogs = new();
	public static System.Collections.Generic.List<Log> CalledLogs => m_CalledLogs;

	public static void AddLog (Log log) {
		m_CalledLogs.Add (log);
	}
}
