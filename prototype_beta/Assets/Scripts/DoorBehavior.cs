using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DoorBehavior : MonoBehaviour
{
   private UnityEngine.U2D.Animation.SpriteResolver spriteResolver;
   private UnityEngine.U2D.Animation.SpriteLibrary spriteLibrary;
   public string categoryName, labelClosedName, labelOpenName;
 //  public Image dialogImage;
 //  DialogueTrigger dialogueTrigger;   
  
    void Start()
    {
       // dialogueTrigger = GetComponent<DialogueTrigger>();
        spriteResolver = GetComponent<UnityEngine.U2D.Animation.SpriteResolver>();
        spriteLibrary = GetComponent<UnityEngine.U2D.Animation.SpriteLibrary>();
      
        //dialogImage.gameObject.SetActive(false);


    }
    
    public void OpenDoor()
    {
       // spriteLibrary.GetSprite("BoxDoor", "BoxClose");
        spriteResolver.SetCategoryAndLabel(categoryName, labelOpenName);
    }
    public void CloseDoor()
    {
        // spriteLibrary.GetSprite("BoxDoor", "BoxClose");
        spriteResolver.SetCategoryAndLabel(categoryName, labelClosedName);
    }
    public void OnTriggerEnter2D (Collider2D collision)
    {
        //dialogImage.gameObject.SetActive(true);
        //dialogueTrigger.TriggerDialogue();
        PlayerController playerController = collision.GetComponent<PlayerController>();
      

        if (playerController != null || collision.CompareTag("Player"))
        {
           // Debug.Log("Player passou por aqui");
            OpenDoor();
                 
        }
      

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerController playerController = collision.GetComponent<PlayerController>();
        //dialogImage.gameObject.SetActive(false);

        if (playerController != null || collision.CompareTag("Player"))
        {

            CloseDoor();
           

        }
    }
}
