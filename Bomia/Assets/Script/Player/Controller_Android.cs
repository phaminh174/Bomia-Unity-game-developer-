using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Android: Controller_PC
{ 
    public void OnclickedUpButton()
    {
        if (transform.position.y < maxHeight)
        transform.position = new Vector2(transform.position.x, transform.position.y + distance);
        
    }

    public void OnClickedDownButton()
    {
        if (transform.position.y > minHeight)
        transform.position= new Vector2(transform.position.x, transform.position.y - distance);
         
    }
}
