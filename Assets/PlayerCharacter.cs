using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int health;

    private void Start()
    {
        health = 5;
    }

    public void Hurt(int damage)
    {
        health -= damage;
    }

    public void OnGUI()
    {
        int size = 18;
        GUI.Label(new Rect(size / 2, size / 2, size * 4, size), $"Health: {health}");
    }
}
