using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Singleton : MonoBehaviour
{

    //initialisation de l'instance
    private Singleton() { }
    private static Singleton m_instance = null;
    //[SerializeField][Tooltip("text qui va afficher le score")] public Text score;

    //variables de la class
    public int m_score = 3;
    public static Singleton Instance
    {
        get
        {
            // sauveguarde this dans m_instance si la place est libre sinon selfdestruct
            if (m_instance == null)
            {
                m_instance = new Singleton();
            }

            return m_instance;
        }
    }

    public void ChangeScore()
    {
        m_score += 1 ;
        //score.text = $"score : {m_score.ToString()}";
    }

}
