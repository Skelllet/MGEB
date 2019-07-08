using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bottons : MonoBehaviour
{
    

    public void OnMouseUpAsBotton()
    {
        Debug.Log("dfdsf");
        switch (gameObject.name)
        {
            case "Play":
            SceneManager.LoadScene("Play");
            
            break;
            
            
        }
    }
}
