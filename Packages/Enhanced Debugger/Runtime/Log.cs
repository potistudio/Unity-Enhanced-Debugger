public class Log {
	private object m_Object;
	private LogLevel m_LogLevel;

	public object Object { get { return m_Object; } }
	public LogLevel Level { get { return m_LogLevel; } }
	public string Message { get { return m_Object.ToString(); } }

	public Log (object _obj, LogLevel _logLevel = LogLevel.Info) {
		m_Object = _obj;
		m_LogLevel = _logLevel;
	}
}
