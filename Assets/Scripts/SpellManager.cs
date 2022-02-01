using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class SpellManager : Singleton<SpellManager>
{
    [SerializeField,Tooltip("prefab d'explosion")]
    private GameObject m_explosionPrefab;
    
    /// <summary>
    /// ça sert a app une particule je suppose 
    /// </summary>
    /// <param name="p_position">la position de la particule</param>
    public void Atomisation(Vector3 p_position)
    {
        //instance du prefab
        GameObject go = Instantiate(m_explosionPrefab ,p_position , Quaternion.identity);
        Debug.Log(go);
        ParticleSystem particleSystem = go.GetComponent<ParticleSystem>();
        particleSystem.Play();
        Debug.Log("Boom");
    }

    protected override string GetSingletonName()
    {
        return "SpellManager";
    }

}
