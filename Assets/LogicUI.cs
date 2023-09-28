using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LogicUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetupButtonHandlers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetupButtonHandlers()
    {
        UIDocument document = GetComponent<UIDocument>();
        var button = document.rootVisualElement.Query<Button>();
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
