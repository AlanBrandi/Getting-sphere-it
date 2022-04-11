using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Jump jump;
    public DoubleJump doublejump;
    public Dash dash;

    GameObject Player;

    private void Start()
    {
        Player = this.GetComponent<GameObject>();
        jump = this.GetComponent<Jump>();
        doublejump = this.GetComponent<DoubleJump>();
        dash = this.GetComponent<Dash>();
    }
    private void Update()
    {
      
    }

   public void LigarJump()
    {
        jump.enabled = true;
    }
    public void LigarDoubleJump()
    {
        doublejump.enabled = true;
    }
    public void LigarDash()
    {
        dash.enabled = true;
    }

    public void DesligarDoubleJump()
    {
        doublejump.enabled = false;
    }
    public void DesligarDash()
    {
        dash.enabled = false;
    }
}
