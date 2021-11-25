using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOverScreen : Screen
{
    public event UnityAction RestartButtonClick;

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
        RestartButtonClick?.Invoke();
    }
}
