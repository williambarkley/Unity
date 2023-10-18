using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    // Start is called before the first frame update
   public void playgame()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
   }
   public void exit()
   {
       Application.Quit();
   }

   public void playagain()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
   }
}
