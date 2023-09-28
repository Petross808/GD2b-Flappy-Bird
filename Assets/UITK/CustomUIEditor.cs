using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class CustomUIEditor : EditorWindow
{
    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset = default;

    [MenuItem("Window/UI Toolkit/CustomUIEditor")]
    public static void ShowExample()
    {
        CustomUIEditor wnd = GetWindow<CustomUIEditor>();
        wnd.titleContent = new GUIContent("CustomUIEditor");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        VisualElement label = new Label("Hello World! From C#");
        root.Add(label);

        // Instantiate UXML
        VisualElement labelFromUXML = m_VisualTreeAsset.Instantiate();
        root.Add(labelFromUXML);

        SetupButtonHandlers();
    }

    private void SetupButtonHandlers()
    {
        var button = rootVisualElement.Query<Button>();
        button.ForEach(RegisterHandler);
    }

    private void RegisterHandler(Button button)
    {
        button.RegisterCallback<ClickEvent>(Foo);
    }
    private void Foo(ClickEvent evt)
    {
        Debug.Log("Click");
    }
}
