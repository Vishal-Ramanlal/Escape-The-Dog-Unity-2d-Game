using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthPotionInteractable : MonoBehaviour
{
    public Score score;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        MainCharacterScript controller = other.GetComponent<MainCharacterScript>();
     
        if (controller != null)
        {
            Debug.Log("Score: " + score.getScore());
            controller.updateScore(1000);
                //controller.changeHealth(1);
            Destroy(gameObject);
            
        }
    }

}
