using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    // variable for speed = 8

    [SerializeField]
    private int _speed = 8 ;
    

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //translate laser up

        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        // if laser position is greater tham 8 on the y
        // destroy game object

        if(transform.position.y >= 8 )
        {
            Destroy(this.gameObject);
        }

        
    }
}
