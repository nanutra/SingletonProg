using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        Debug.LogWarning(ScoreManager.Instance.Score);
        SpellManager.Instance.Atomisation(Vector3.zero);
    }
}
