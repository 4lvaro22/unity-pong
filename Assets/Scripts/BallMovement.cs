using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    GameObject instance;
    public float speed;
    public int startingPlayer;
    float yAxis;



    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this.gameObject;
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

    void setSpeed(float speed)
    {
        this.speed = speed;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
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

        if (col.gameObject.tag == "LeftLimit")
        {
            ScoreManager.scoreManager.AddPointRight();
            instance.gameObject.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);
            //clone.transform.parent = transform;
        }
        else if (col.gameObject.tag == "RightLimit")
        {
            ScoreManager.scoreManager.AddPointLeft();
            instance.gameObject.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);
            //clone.transform.parent = transform;
        }


    }

}
