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

    [SerializeField]
    private TMP_Text LocationText;

    [SerializeField]
    private TMP_Text MovesText;

    private Game Game { get; set; }

    void Awake()
    {
        TextAsset gameFileAsset = Resources.Load<TextAsset>(GameFileAssetname);
        Game = Game.Load(gameFileAsset.text, OutputService, InputService);
    }

    void Start()
    {
        Game.Output.WriteLine("Welcome to Zork!");
        Game.CommandManager.PerformCommand(Game, "LOOK");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            if (string.IsNullOrWhiteSpace(InputService.InputField.text) == false)
            {
                Game.Output.WriteLine($"> {InputService.InputField.text}");
                InputService.ProcessInput();
                ScoreText.text = $"Score: {Game.Player.Score}";
                MovesText.text = $"Moves: {Game.Player.amtMoved}";
                LocationText.text = $"Location: {Game.Player.Location}";
            }

            InputService.InputField.text = string.Empty;
            InputService.InputField.Select();
            InputService.InputField.ActivateInputField();
        }

        if ((Game.IsRunning == false))
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
    }
}
