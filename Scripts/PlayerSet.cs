using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSet : Player
{
    public Material[] mat;

    private MeshRenderer mr;

    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        StartCoroutine(ChangeColor());
    }

    private IEnumerator ChangeColor()
    {
        while (true)
        {
            for(int i  = 0; i < mat.Length; i++)
            {
                mr.material = mat[i];
                yield return new WaitForSeconds(1f);
            }
        }
    }
}
