using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrangeParentPosition : MonoBehaviour
{
    private void ArrangeParentPos()
    {
        Vector3 centerPos = Vector3.zero;
        List<Transform> children = new List<Transform>();
        for (int i = 0; i < transform.childCount; i++)
        {
            centerPos += transform.GetChild(i).position;
            children.Add(transform.GetChild(i));
        }
        centerPos /= transform.childCount;
        transform.DetachChildren();
        transform.position = centerPos;
        for (int i = 0; i < children.Count; i++)
        {
            children[i].SetParent(transform);
        }
    }
}
