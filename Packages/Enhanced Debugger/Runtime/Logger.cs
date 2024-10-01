public static class Logger {
	public static void Verbose (object obj) {
		Log log = new Log (obj, LogLevel.Verbose);
		LogTracker.AddLog (log);
		UnityEngine.Debug.Log (obj);
	}

	public static void Debug (object obj) {

	}

	public static void Info (object obj) {

	}

	public static void Warning (object obj) {

	}

	public static void Error (object obj) {

	}

	public static void Fatal (object obj) {

	}
}
