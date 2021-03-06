﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleButton : MonoBehaviour
{

    public GameObject player,enemy,yuka;
    Rigidbody playerRb,enemyRb,yukaRb;
    public Text text;
    public GameObject btn;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = player.transform.GetComponent<Rigidbody>();
        enemyRb = enemy.transform.GetComponent<Rigidbody>();
        yukaRb = yuka.transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        playerRb.isKinematic = false;
        enemyRb.isKinematic = false;
        yukaRb.isKinematic = false;
        btn.SetActive(false);
    }
}
