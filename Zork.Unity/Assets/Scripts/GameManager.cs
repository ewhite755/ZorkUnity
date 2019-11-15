using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork.Common;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string GameFileAssetname = "Zork";

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private TMP_Text ScoreText;

    private Game Game { get; set; }

    void Awake()
    {
        TextAsset gameFileAsset = Resources.Load<TextAsset>(GameFileAssetname);
        Game = Game.Load(gameFileAsset.text, OutputService, InputService);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            if (string.IsNullOrWhiteSpace(InputService.InputField.text) == false)
            {
                Game.Output.WriteLine($"> {InputService.InputField.text}");
                InputService.ProcessInput();
            }

            InputService.InputField.text = string.Empty;
            InputService.InputField.Select();
            InputService.InputField.ActivateInputField();
        }
    }
}
