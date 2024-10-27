using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbsPathMoving : MonoBehaviour
{    
    [SerializeField] protected List<Point> points = new();
    public List<Point> Points => points;
    protected virtual void Start()
    {
        AddPoint();
    }
    protected virtual void AddPoint()
    {
        Point point;
        if (points.Count > 0) return;
        foreach (Transform child in transform)
        {
            point = child.GetComponent<Point>();
            points.Add(point);
        }
    }
    public virtual Point PointIdx(int idx)
    {
        return Points[idx];
    }
}
