using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinWindowScript : BaseWindow
{
    [SerializeField] private TextMeshProUGUI MovesText;

    protected override void Awake()
    {
        base.Awake();
        MovesText.text = "Moves: " + GameManager.Instance.PlayerData.turn.ToString();
    }

    public override void ButtonCloseOnClick()
    {
        GameManager.Instance.PlaySound("ButtonClick");
        Application.Quit();
    }
}