using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Doortype{
    key,
    enemy,
    button
}
public class Door : Interactable {

    [Header("Door variables")]
    public Doortype thisDoorType;
    private bool opened;
    public Inventory playerInventory;
    public SpriteRenderer doorSprite;
    public BoxCollider2D physicsCollider;
    public  BoolValue storedOpen;
    

    void Start() {
        // anim = GetComponent<Animator>();
        opened = storedOpen.RuntimeValue;
        if(opened){
            //  anim.SetBool("opened", true);
            physicsCollider.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Space)){
            if(playerInRange && thisDoorType == Doortype.key){
                if( playerInventory.numberOfKeys > 0){
                    playerInventory.numberOfKeys--;
                    Open();
                }
            }
        }
    }

    public void Open(){
        opened = true;
        physicsCollider.enabled = false;
        storedOpen.RuntimeValue = opened;
    }
}
