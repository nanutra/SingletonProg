using UnityEngine;


public class ScoreManager : Singleton<ScoreManager>
{
    private int m_score = 5;

   // public int Score => m_score;
   public int Score
   {
       get => m_score;
   }
   

   //pas obligatoire
   // protected override string GetSingletonName()
   //{
   //  return "Singleton";
   //{
   
   
}
