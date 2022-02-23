using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayer: MonoBehaviour
{

    public Text textHP;
    public GameObject UIEndGamePanel;

    public void UpdateHP(int hp)
    {
        textHP.text = hp.ToString();
    }

    public void SwowEndGamePanel()
    {
        UIEndGamePanel.SetActive(true);
        Time.timeScale = 0;
    }
}
