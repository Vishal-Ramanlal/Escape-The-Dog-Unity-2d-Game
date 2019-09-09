using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    public Sprite openChest;
    public GameObject item;
    public int counter = 0;
        
    void OnTriggerEnter2D(Collider2D other)
    {
        
        MainCharacterScript controller = other.GetComponent<MainCharacterScript>();
        if (controller != null)
        {
            if (counter == 0)
            {
               this.gameObject.GetComponent<SpriteRenderer>().sprite = openChest;
                
                Instantiate(item, new Vector3(this.transform.position.x, this.transform.position.y - 1, this.transform.position.z), this.transform.rotation);
                counter++;
            }
         // Destroy(gameObject);
            
        }
    }
}
