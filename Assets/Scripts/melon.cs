using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class melon : MonoBehaviour
{
    private int melons = 0;

    [SerializeField] private Text melonsText;

    [SerializeField] private AudioSource collectionSoundEffect;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("Melon"))
        {
            collectionSoundEffect.Play();
            
            Destroy(collision.gameObject);
            melons++;

            Debug.Log("Melons: " + melons);
             
            melonsText.text = "Melons : " +melons;
        }
    }
}
