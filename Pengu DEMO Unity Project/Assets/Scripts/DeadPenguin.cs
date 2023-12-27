using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPenguin : MonoBehaviour
{
    public bool isdead;
    public GameObject DeathScene;
    public GameObject music;
    public PenguinMovement penguinMovementsrc;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isdead = true;
            Time.timeScale = 0;

            DeathScene.SetActive(true);
            music.SetActive(false);
            
            
            
        }

        
    }
    private void Update()
    {
        if (isdead==true)
        {
            penguinMovementsrc.walkingSFX.Stop();
            penguinMovementsrc.slidingSFX.Stop();
            penguinMovementsrc.jumpingSFX.Stop();
        }
        
    }
}
