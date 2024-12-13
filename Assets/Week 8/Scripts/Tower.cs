using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public float SpeedFire;
    [SerializeField] private float timeFire = 0f;
    [SerializeField] private Transform _rotate;
    [SerializeField] private Transform _firePoint;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Enemy _target;
    [SerializeField] private List<Enemy> _enemyList;

    public Enemy Target { get => _target; }

    private void Update()
    {
        FireBullet();
        LookAtTarget();
    }

    private void FireBullet()
    {
        if (_target != null)
        {
            timeFire += Time.deltaTime;
            if (timeFire >= SpeedFire)
            {
                timeFire = 0;
                var newBullet = Instantiate(_bullet, _firePoint.position, Quaternion.identity);
                newBullet.transform.rotation = _firePoint.rotation;
            }
        }
        else timeFire = 0;
    }

    private void LookAtTarget()
    {
        if (_target != null)
        {
            _rotate.LookAt(_target.transform.position);
        }
    }

    public void RemoveEnemyFromList(Enemy enemy)
    {
        if (_enemyList.Contains(enemy))
        {
            _enemyList.Remove(enemy);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            _enemyList.Add(enemy);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            float minDistance = Mathf.Infinity;
            foreach (Enemy enemyIdx in _enemyList)
            {
                float distance = Vector3.Distance(transform.position, enemyIdx.transform.position);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    _target = enemyIdx;
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            _enemyList.Remove(enemy);
        }

        if (_enemyList.Count == 0)
        {
            _target = null;
        }
    }
}
