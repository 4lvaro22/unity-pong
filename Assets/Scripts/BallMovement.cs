using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public int startingPlayer;
    float yAxis;

    // Start is called before the first frame update
    void Start()
    {
        this.startingPlayer = Random.Range(1, 3);
        this.yAxis = Random.Range(5, -5);

    }

    // Update is called once per frame
    void Update()
    {
        if (startingPlayer == 1)
        {
            transform.Translate(new Vector2(-speed * Time.deltaTime, yAxis * Time.deltaTime));
        } 
        else if(startingPlayer == 2)
        {
            transform.Translate(new Vector2(speed * Time.deltaTime, yAxis * Time.deltaTime));
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.tag);
        yAxis += Random.Range(1, -1);

        if (startingPlayer == 1 && col.gameObject.tag == "Player")
        {
            startingPlayer = 2;
        }
        else if (startingPlayer == 2 && col.gameObject.tag == "Player")
        {
            startingPlayer = 1;
        }
        else
        {
            yAxis = -yAxis;
        }



    }
}
