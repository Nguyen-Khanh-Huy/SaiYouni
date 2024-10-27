using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private NavMeshAgent agent;

    private StraightLine _straightLine;
    private ZicZac _zicZac;
    private Elip _elip;
    private Spiral _spiral;
    private Rd _rd;

    public Vector3 TargetPoint;
    public bool IsFinish = false;
    public int count = 0;
    public int randomIdx = 0;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        _straightLine = FindObjectOfType<StraightLine>();
        _zicZac = FindObjectOfType<ZicZac>();
        _elip = FindObjectOfType<Elip>();
        _spiral = FindObjectOfType<Spiral>();
        _rd = FindObjectOfType<Rd>();
    }
    private void FixedUpdate()
    {
        Moving();
    }
    private void Moving()
    {
        if(IsFinish == true)
        {
            agent.isStopped = true;
            return;
        }
        //TargetStraightLine();             // Di Chuyen Duong Thang
        //TargetZicZac();                   // Di Chuyen ZicZac
        //TargetElip();                     // Di Chuyen Elip
        //TargetSpital();                   // Di Chuyen Xoan Oc
        //TargetRd();                       // Di Chuyen Ngau Nhien
        agent.SetDestination(TargetPoint);
    }
    private void TargetStraightLine()
    {
        Point point = _straightLine.PointIdx(count);
        if (Vector3.Distance(transform.position, point.transform.position) <= 1f)
        {
            count++;
        }
        if (count > _straightLine.Points.Count - 1)
        {
            IsFinish = true;
        }
        TargetPoint = point.transform.position;
    }
    private void TargetZicZac()
    {
        Point point = _zicZac.PointIdx(count);
        if (Vector3.Distance(transform.position, point.transform.position) <= 1f)
        {
            count++;
        }
        if(count > _zicZac.Points.Count - 1)
        {
            IsFinish = true;
        }
        TargetPoint = point.transform.position;
    }
    private void TargetElip()
    {
        Point point = _elip.PointIdx(count);
        if (Vector3.Distance(transform.position, point.transform.position) <= 1f)
        {
            count++;
        }
        if (count > _elip.Points.Count - 1)
        {
            IsFinish = true;
        }
        TargetPoint = point.transform.position;
    }
    private void TargetSpital()
    {
        Point point = _spiral.PointIdx(count);
        if (Vector3.Distance(transform.position, point.transform.position) <= 1f)
        {
            count++;
        }
        if (count > _spiral.Points.Count - 1)
        {
            IsFinish = true;
        }
        TargetPoint = point.transform.position;
    }
    private void TargetRd()
    {
        Point point = _rd.PointIdx(randomIdx);
        if (Vector3.Distance(transform.position, point.transform.position) <= 1f)
        {
            randomIdx = Random.Range(0, _rd.Points.Count - 1);
            count++;
            if (count == _rd.Points.Count - 1)
            {
                randomIdx = count;
            }
        }
        if (count > _rd.Points.Count - 1)
        {
            IsFinish = true;
        }
        TargetPoint = point.transform.position;
        
    }
}
