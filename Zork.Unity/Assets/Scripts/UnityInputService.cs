using System;
using UnityEngine;
using Zork.Common;
using TMPro;

public class UnityInputService : MonoBehaviour, IInputService
{
    public event EventHandler<string> InputReceived;

    public TMP_InputField InputField;

    void Start()
    {
        InputField.Select();
        InputField.ActivateInputField();
    }

    public void ProcessInput()
    {
        InputReceived?.Invoke(this, InputField.text);
    }
}
