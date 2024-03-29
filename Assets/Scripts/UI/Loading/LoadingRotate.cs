﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingRotate : MonoBehaviour {

    private RectTransform rectComponent;
    public float rotateSpeed = 200f;
    private float currentvalue;

    // Use this for initialization
    void Start()
    {
        rectComponent = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        currentvalue = currentvalue + (Time.deltaTime * rotateSpeed);

        //Debug.Log("currnet Value is " + currentvalue);

        rectComponent.transform.rotation = Quaternion.Euler(0f, 0f, -72f * currentvalue);
    }
}