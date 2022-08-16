using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;
    void Update()
    {
        if(transform.position.y < bottomY){
            Destroy(gameObject);
            ApplePicker applePicker = Camera.main.gameObject.GetComponent<ApplePicker>();
            applePicker.decreaseBasket();
        }
    }
}
