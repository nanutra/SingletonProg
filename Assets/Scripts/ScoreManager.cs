using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int m_score = 0;
    [SerializeField] [NotNull] private Text m_this;
    private Singleton s1 = Singleton.Instance;
    private void Update()
    {
        if (s1.m_score >= m_score)
        {
            m_score = s1.m_score;
            ChangeText();
        }
    }

    private void ChangeText()
    {
        m_this.text = $"score : {m_score.ToString()}";
    }
}
