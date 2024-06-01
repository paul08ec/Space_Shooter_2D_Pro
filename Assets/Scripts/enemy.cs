using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField]
    private float _enemySpeed = 4;


    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector3.down * _enemySpeed * Time.deltaTime);
         if (transform.position.y<=-5)
        {
            float ramdonX = Random.Range(-12f, 12f);

            transform.position = new Vector3(ramdonX, 7, 0);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
       
        if(other.tag == "Player" )
        {
            Player player = GetComponent<Player>();
            if(player != null)
            {
                player.Damage();
            }
            Destroy(this.gameObject);
        }



        if (other.tag == "laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }

    }
}
