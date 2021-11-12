using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Ability _ability;

    public void OnPointerClick(PointerEventData eventData) // при клике на объект
    {
        var units = _ability.SelectTargets(eventData.position); // передаем текущую позицию курсора

        if (units != null) // если количество рейкаст компонентов units не равно 0
            _ability.ApplyAction(units); // применяем способность к юниту
    }
}
