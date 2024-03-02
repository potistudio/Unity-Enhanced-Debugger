
public class Window : UnityEditor.EditorWindow {
	[UnityEditor.MenuItem("Window/Enhanced Debugger", priority = 4000)]
	private static void OpenWindow() {
		Window window = GetWindow<Window>();
		window.titleContent = new UnityEngine.GUIContent (
			"Enhanced Debugger",
			UnityEditor.EditorGUIUtility.Load ("Profiler.Memory") as UnityEngine.Texture
		);
	}
}
