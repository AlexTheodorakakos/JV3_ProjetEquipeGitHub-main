using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    [SerializeField] private int _nbPoints;

//Référence à l'audioClip
    [SerializeField] private AudioClip _sonWin;
    private AudioSource audioSource;



    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

     private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Interact"){
            _nbPoints = _nbPoints+1;

                audioSource.clip = _sonWin;
                audioSource.Play();

                //Enlève l'objet de la scène
            Destroy(gameObject);
            }
            _scoreText.SetText(_nbPoints.ToString());
            
        }
    }

