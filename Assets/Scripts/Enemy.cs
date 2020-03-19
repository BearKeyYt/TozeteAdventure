using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy: MonoBehaviour{
    public Transformplayer;
    private Rigidbody2Drb;
    private Vector2movement;
    public float moveSpeed = 5f;
    public int currentHealth;
    
    // Start is called before the first frame update
    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame 
    void Update(){
        Vector3direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }
    
    internal static bool FindObjectWithTag(string v){
        throw new NotImplementedException();
    }
    private void FixedUpdate(){
        moveCharacter(movement);
    }
    void moveCharacter(Vector2direction){
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}