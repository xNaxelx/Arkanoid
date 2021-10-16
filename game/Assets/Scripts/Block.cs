using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private int _hp = 1;
    public void Knock()
    {
        if(--_hp == 0)
        {
            Destroy(gameObject);
        }
    }
}
