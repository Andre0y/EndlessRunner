using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private int score;

    private int _score;
   
    //��������� ������ ��, ��� �� ������ ����
    void Start()
    {
        
        _score = 0;
        scoreText.text = _score.ToString(); 
    
    }

    //��������� ������������ � ����� ������
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            
            _score += score;
            scoreText.text = _score.ToString();
            Destroy(other.gameObject);
        }
    }
}
