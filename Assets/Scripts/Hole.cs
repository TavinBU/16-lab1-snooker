using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Ball b = other.GetComponent<Ball>();

        if (b != null)
        {
            GameManager.instance.PlayrScore += b.Point;
            GameManager.instance.UpdatrScoreText();
            Destroy(b.gameObject);
        }
    }
}
