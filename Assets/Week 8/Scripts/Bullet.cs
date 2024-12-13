using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speedBullet;
    private void Update()
    {
        transform.Translate(this._speedBullet * Time.deltaTime * Vector3.forward);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null )
        {
            Destroy(gameObject);
        }
    }
}
