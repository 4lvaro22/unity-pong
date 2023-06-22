
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    const float speed = 5f;
    public int player;

    public PlayerMovement(int player)
    {
        this.player = player;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerControl();
    }

    private void PlayerControl(){

        if (player == 1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;

                transform.Translate(0, translation, 0);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;

                transform.Translate(0, translation, 0);
            }

        }else if(player == 2)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;

                transform.Translate(0, translation, 0);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;

                transform.Translate(0, translation, 0);
            }
        }
    }
}
