using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private int numCoins = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(50, 500, 50));
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().AddForce(new Vector3(horizontalMove*speed,0,verticalMove*speed));
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Coin")
        {
            numCoins = numCoins + 1;
            Debug.Log("Coin Collected! You have " + numCoins+"!");
            Destroy(col.gameObject);
        }
    }




}
