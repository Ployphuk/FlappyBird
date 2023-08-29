using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] public float gravity = -9.8f;
    [SerializeField] float strength = 5f;
     // Added variable to track game start
    private void OnEnable(){
        Vector3 position = transform.position;
        position.y= 0f;
        transform.position = position;
        direction = Vector3.zero;
    }
    private void Update(){
        if(Input.GetKeyDown(KeyCode.Space) ||  Input.GetMouseButtonDown(0)){
            direction = Vector3.up * strength;
        }

        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began){
                direction = Vector3.up * strength;
            }
        }
        
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
}
