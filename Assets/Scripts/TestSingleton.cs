using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TestSingleton : MonoBehaviour
{

    public static TestSingleton m_instance = null;
    [SerializeField][Tooltip("text qui va afficher le score")] private Text score;

    private int m_score = -1;
    
    private void Awake()
    {
        // sauveguarde this dans m_instance si la place est libre sinon selfdestruct
        if (m_instance == null)
        {
            m_instance = this;
        }
        else
        {
          Destroy(this);  
        }
    }

    private void Update()
    {
        
    }

    public void ChangeScore()
    {
        m_score += 1 ;
        score.text = $"score : {m_score.ToString()}" ;
    }

    // Update is called once per frame
}
