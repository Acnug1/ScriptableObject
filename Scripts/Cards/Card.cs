using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card/Create new card", order = 51)] // делаем возможность для создания скриптованного объекта 
                                                                                        // (fileName - это имя файла у ScriptableObject, когда мы его создаем
                                                                                        // menuName - имя меню, в котором будет создаваться наш ScriptableObject
                                                                                        // order = 51 - размещение нашего меню после Folder
public class Card : ScriptableObject // Наследуем наш класс от ScriptableObject (контейнер для хранения параметров объектов)
{
    // делаем отображение для наших данных
    [SerializeField] private string _name;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _icon;

    public string Name => _name;
    public int Price => _price;
    public Sprite Icon => _icon;
}
