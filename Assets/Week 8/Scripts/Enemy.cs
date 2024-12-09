using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Update()
    {
        transform.position += new Vector3(4, 0, 0) * Time.deltaTime;
    }
}
