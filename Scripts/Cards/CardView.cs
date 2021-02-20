using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardView : MonoBehaviour
{
    [SerializeField] private Card _card; // принимаем карту ScriptableObject для отображения

    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _price;

    private void Start() // подтягиваем все параметры карты ссылаясь на ScriptableObject (лучше всего хранить неизменяемые параметры)
    {
        _image.sprite = _card.Icon;
        _name.text = _card.Name;
        _price.text = _card.Price.ToString();
    }
}
