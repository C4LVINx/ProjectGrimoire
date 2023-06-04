using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemIntoBackPack : MonoBehaviour
{
    [SerializeField] private Transform backPack;
    private float speed = 40f;

    private void FixedUpdate()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, backPack.position, step);
    }
}
