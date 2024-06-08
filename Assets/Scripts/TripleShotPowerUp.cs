using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShotPowerUp : MonoBehaviour
{
    [SerializeField]
    private float _powerUpSpeed = 3;
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _powerUpSpeed * Time.deltaTime);
      
        if (this.gameObject.transform.position.y <-5)
        {
            Destroy(this.gameObject);
        }
      
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();
            if (player != null)
            {
                player.TripleShotActive();
               
            }
            Destroy(this.gameObject);

        }

    }
}
