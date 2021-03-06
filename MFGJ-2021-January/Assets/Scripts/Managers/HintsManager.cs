﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintsManager : MonoBehaviour
{
    private string h0_start = "Break their defences trough the north, then go East. Find the Fence and cross it!";
    private string h1_holdFire = "Hold Fire to Auto-Shoot";
    private string h2_move = "Keep moving to avoid being shot!";
    private string h3_intelSouth = "Intel: you may find rocket ammo supplies south of your location!";
    private string h4_Score = "+1up From score";
    private string h5_rush = "Play smart, rushing only leads to failure";
    private string h6 = "Using rockets against MachineGunners is a great idea!";
    private string h7 = "You will find the enemy base at east. Not far from here.";
    private string h8 = "There! the first fence of the enemy base! clean it from enemies and breach it!";
    private string h9 = "I should throw a rocket on that grey spot on the middle of the fence";
    private string h10 = "They are making rockets here with some jungle plants!";
    private string h11 = "Congratulations, you reached the end of this demo!. Next update 15/2/2021";

    private bool isActive;

    public GameObject hintsPanel;

    private float timer;

    private void Awake()
    {
        timer = 0;
        isActive = false;
    }
    private void Start()
    {
        ShowHintPanel("start", 5);
    }
    private void Update()
    {
        if (timer < 0)
        {
            timer = 0;
            hintsPanel.SetActive(false);
            isActive = false;
        }
        if (isActive)
        {
            timer -= Time.deltaTime;
        }
    }
    public void ChangeHint(string name)
    {
        name.ToLower();
        switch (name)
        {
            case "start":
                hintsPanel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = h0_start;
                break;
            case "holdfire":
                hintsPanel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = h1_holdFire;
                break;
            case "move":
                hintsPanel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = h2_move;
                break;
            case "intelsouth":
                hintsPanel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = h3_intelSouth;
                break;
            case "score":
                hintsPanel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = h4_Score;
                break;
            case "rush":
                hintsPanel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = h5_rush;
                break;
            case "mg":
                hintsPanel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = h6;
                break;
            case "find":
                hintsPanel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = h7;
                break;
            case "fence":
                hintsPanel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = h8;
                break;
            case "breach":
                hintsPanel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = h9;
                break;
            case "making":
                hintsPanel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = h10;
                break;
            case "end":
                hintsPanel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = h11;
                break;
            default:
                Debug.LogWarning("Name mismatch on HintsManager line 38 !!");
                break;
        }
    }
    public void ShowHintPanel(string name, float time)
    {
        ChangeHint(name);
        hintsPanel.SetActive(true);
        isActive = true;
        timer = time;
    }
}
