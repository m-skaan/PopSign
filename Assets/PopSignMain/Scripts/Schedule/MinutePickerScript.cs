﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinutePickerScript : TimePickerScript
{

    void Start()
    {
        for (int i = 58; i <= 121; i++)
        {
            Text text = Text.Instantiate(textPrefab);
            text.text = (i % 60 < 10? "0": "") + (i % 60);
            text.transform.parent = content.transform;
            choices.Add(text);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}