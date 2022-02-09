using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void NextLevel1()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void NextLevel2()
    {
        SceneManager.LoadScene("Level_2");
    }
    
    public void NextLevel3()
    {
        SceneManager.LoadScene("Level_3");
    }
    
}
