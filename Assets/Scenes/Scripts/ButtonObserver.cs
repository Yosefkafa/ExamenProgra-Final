using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonObserver : MonoBehaviour
{
    public Button [] buttons;

    void Start()
    {
            buttons[0].onClick.AddListener(() => InputController.Instance.UpdateButtonValue(0));
            buttons[1].onClick.AddListener(() => InputController.Instance.UpdateButtonValue(1));
            buttons[2].onClick.AddListener(() => InputController.Instance.UpdateButtonValue(2));
    }
}
