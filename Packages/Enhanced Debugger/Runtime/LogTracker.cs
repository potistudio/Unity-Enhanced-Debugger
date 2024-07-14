public static class LogTracker {
	private static System.Collections.Generic.List<Log> logs = new();

	public static void AddTracking (Log log) {
		logs.Add (log);
	}
}
