using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lose : MonoBehaviour
{
    [SerializeField] private GameObject GamePanel;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private Text scoreText;
    [SerializeField] private AudioSource BackGround;
    [SerializeField] private AudioSource loseBackGround;

    private int _score;
    
    //��������� ������ ��, ��� �� ������ ����
    void Start()
    {
        _score = 0;
        scoreText.text = _score.ToString();
        BackGround.Play();
    }

    // ��������� ������������ � ����� �����������
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Obstacle")
        {
            GamePanel.SetActive(false);
            losePanel.SetActive(true);
            Time.timeScale = 0;
            //������������� ������ ���� � �������� ������ ���������
            BackGround.Pause();
            loseBackGround.Play();
        }
        if (other.gameObject.tag == "Coin")
        {
            
            _score++;
            scoreText.text = _score.ToString();
            
        
        }
        
    }
}
