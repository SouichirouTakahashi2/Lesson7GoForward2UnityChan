﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    private bool BlockSound;


    void OnCollisionEnter2D(Collision2D collision)
    {
        //衝突判定
       // if (collision.gameObject.tag == "CubeA")

            if (collision.gameObject.name == "CubePrefab(Clone)"|| collision.gameObject.name=="ground")


            {   //block音を出す
            GetComponent<AudioSource>().Play();
        }
    }


    // Use this for initialization
    void Start()
    {
        AudioSource BlockSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外にでたら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    }






