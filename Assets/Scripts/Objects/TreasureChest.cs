using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureChest : Interactable
{
    [Header("Contents")]
    public Item contents;
    public Inventory playerInventory;
    private bool opened;
    public BoolValue storedOpen;
    
    [Header("Siginals and Dialog")]
    public Signal raiseItem;
    public GameObject dialogBox;
    public Text dialogText;
    
    [Header("Animation")]
    private Animator anim;
    public float animationTime;
    
    void Start() {
        anim = GetComponent<Animator>();
        opened = storedOpen.RuntimeValue;
        if(opened){
            anim.SetBool("opened", true);
        }
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.J) && playerInRange ){
            if(!opened){
                OpenChest();
            }else{
                ChestAlredyOpen();
            }
        }
    }

    public void OpenChest(){
        StartCoroutine(OpenChestCo(animationTime)); 
    }

    private IEnumerator OpenChestCo(float animationTime){
        anim.SetBool("opened", true);
        contextOff.Raise();
        yield return new WaitForSeconds(.4f);
        dialogBox.SetActive(true);
        dialogText.text = contents.itemDescription;
        playerInventory.AddItem(contents);
        playerInventory.currentItem = contents;
        raiseItem.Raise();
        contextOff.Raise();
        opened = true;
        storedOpen.RuntimeValue = opened;
    }

    public void ChestAlredyOpen(){
        
        dialogBox.SetActive(false);
        playerInventory.currentItem = null;
        raiseItem.Raise();
        
    }

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Player") && !other.isTrigger && !opened){
            contextOn.Raise();
            playerInRange = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D other){
      if (other.CompareTag("Player") && !other.isTrigger && !opened) {
        contextOff.Raise();
        playerInRange = false;
      } 
    }
}   
