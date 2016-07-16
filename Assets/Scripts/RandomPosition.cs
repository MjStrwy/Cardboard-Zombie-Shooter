﻿using UnityEngine;
using System.Collections;

public class RandomPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(RePositionWithDelay());
	}

    IEnumerator RePositionWithDelay()
    {
        while (true)
        {
            SetRandomPosition();
            yield return new WaitForSeconds(5);
        }
    }
	
	void SetRandomPosition()
    {
        float x = Random.Range(-4.0f, 4.0f);
        float z = Random.Range(-4.0f, 4.0f);
        Debug.Log("XY of WalkTarget: " + x.ToString("F2") + ", " + z.ToString("F2"));
        transform.position = new Vector3(x, 0.0f, z);
    }
}
