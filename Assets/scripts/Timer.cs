using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timeText;

    [SerializeField] public float _tempsRestant;

    // Update is called once per frame
    void Update()
    {
        CalculTemps();
    }

    private void CalculTemps(){
        _tempsRestant -= Time.deltaTime;
        AfficheTemps(_tempsRestant);
    }

    private void AfficheTemps(float temps){

        temps +=1;

        float minutes = Mathf.FloorToInt(temps/60);

        float secondes = Mathf.FloorToInt(temps % 60);


        _timeText.text = string.Format("{0:00}:{1:00}", minutes, secondes);
    }

}
