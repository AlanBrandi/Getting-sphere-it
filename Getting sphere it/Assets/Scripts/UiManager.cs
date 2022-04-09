using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    TMP_Text txtScore;
    TMP_Text txtLives;

    public GameObject FX;
    int score = 0;
    int live = 3;
    public Slider slide;
    public GameObject player;

    public GameObject GameOver;
    public GameObject NextLevel;
    public GameObject HUD;

    public GameObject PegouChave;
    public GameObject PegouDash;
    public GameObject PegouJump;

    //================================================================
    private void Start()
    {
        //txtScore.text = "0";
        HUD.SetActive(true);
        NextLevel.SetActive(false);
        gameObject.SetActive(false);

        PegouChave.SetActive(false);
        PegouDash.SetActive(false);
        PegouJump.SetActive(false);

        slide.value = live;
        live = 3;
    }


    //================================================================
    //helpers
    public void SetScore(int value)
    {
        score += value;
        txtScore.text = score.ToString();
    }
    public void SetLife(int val)
    {
        live -= val;
        slide.value = live;
    }
    //================================================================
    //Handler

    public void MyLoadScene(string sceneName)
    {

    }

    public void PassouFase()
    {
        NextLevel.SetActive(true);
        Invoke("DesligarPassouFase", 2);
    }
    public void DesligarPassouFase()
    {
        NextLevel.SetActive(false);
    }

    //================================= Poderes ===============================

    public void PegouChaveTrue()
    {
        PegouChave.SetActive(true);
    }
    public void PegouDashTrue()
    {
        PegouDash.SetActive(true);
    }
    public void PegouJumpTrue()
    {
        PegouJump.SetActive(true);
    }
    private void Update()
    {

        if (live <= 0)
        {
            Destroy(player.gameObject);
            Instantiate(FX, player.transform.position, Quaternion.identity);
            HUD.SetActive(true);
            GameOver.SetActive(true);
        }
    }
}

