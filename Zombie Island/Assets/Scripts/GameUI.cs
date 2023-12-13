using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI humansKilled;
    // instance
    public static GameUI instance;

    void Awake()
    {
        instance = this;
    }

    public void UpdateGoldText(int gold)
    {
        goldText.text = "<b>Current Damage:</b> " + gold;
    }
    public void UpdateKillCount(int killed)
    {
        humansKilled.text = "<b>Humans Killed:</b> " + killed;
    }
}
