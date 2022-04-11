using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public TMP_Text txtScore;

    Transform playertranform;
    public GameObject FX;
    int score = 0;
    int live = 10;
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
        playertranform = player.GetComponent<Transform>();
        gameObject.SetActive(true);
        txtScore.text = "0";

        HUD.SetActive(true);
        NextLevel.SetActive(false);
        PegouChave.SetActive(false);
        PegouDash.SetActive(false);
        PegouJump.SetActive(false);

        slide.value = live;
        live = 10;
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
        Debug.Log(val);
        live -= val;
        slide.value = live;
    }
    //================================================================
    //Handler

    public void MyLoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
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
    public void PegouJumpfalse()
    {
        PegouJump.SetActive(false);
    }

    public void PegouChavefalse()
    {
        PegouChave.SetActive(false);
    }
    public void PegouDashfalse()
    {
        PegouDash.SetActive(false);
    }
    public void QuitGame()
    {
     Application.Quit();
    }

    public void Renascer()
    {
        GameOver.SetActive(false);
        SceneManager.LoadScene("Level");
        //player.transform.position = playertranform.position;
        //HUD.SetActive(true);
    }

    private void Update()
    {
        if (live <= 0)
        {
            Destroy(player.gameObject);
            Instantiate(FX, player.transform.position, Quaternion.identity);
            HUD.SetActive(false);
            GameOver.SetActive(true);
        }
    }
}

