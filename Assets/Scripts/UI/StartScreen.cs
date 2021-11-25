using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartScreen : Screen
{
    public event UnityAction PlayButtonClick;

    public override void Close()
    {
        Canvas.alpha = 0;
        Button.interactable = false;
    }

    public override void Open()
    {
        Canvas.alpha = 1;
        Button.interactable = true;
    }

    protected override void OnButtonClick()
    {
        PlayButtonClick?.Invoke();
    }
}
