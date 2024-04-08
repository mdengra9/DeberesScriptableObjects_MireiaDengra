using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslationUI : MonoBehaviour
{
    public Text[] texts; // Asigna tus 4 textos aquí en el inspector
    public Button[] buttons; // Asigna tus 3 botones aquí en el inspector
    public TranslationObject[] translations; // Asigna tus 3 ScriptableObjects de traducción aquí en el inspector

    void Start()
    {
        // Asigna las funciones a los botones
        buttons[0].onClick.AddListener(() => TranslateTexts(translations[0]));
        buttons[1].onClick.AddListener(() => TranslateTexts(translations[1]));
        buttons[2].onClick.AddListener(() => TranslateTexts(translations[2]));
    }

    void TranslateTexts(TranslationObject translation)
    {
        texts[0].text = translation.prof;
        texts[1].text = translation.deProgramacion;
        texts[2].text = translation.apruebame;
        texts[3].text = translation.porFavor;
        texts[4].text = translation.botton1;
        texts[5].text = translation.botton2;
        texts[6].text = translation.botton3;
    }
}
