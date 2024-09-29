
using UnityEngine.UIElements;

public class EnhancedDebuggerWindow : UnityEditor.EditorWindow {
	[UnityEditor.MenuItem("Window/Enhanced Debugger", priority = 4000)]
	private static void OpenWindow() {
		EnhancedDebuggerWindow window = GetWindow<EnhancedDebuggerWindow>();
		window.titleContent = new UnityEngine.GUIContent (
			"Enhanced Debugger",
			UnityEditor.EditorGUIUtility.Load ("Profiler.Memory") as UnityEngine.Texture
		);
	}

	private void CreateGUI() {
		Label label = new ("Label");

		Foldout foldout = new() { text = "Members" };
		foldout.contentContainer.Add (label);

		rootVisualElement.Add (foldout);
	}
}
