using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/New Ability")]
public class Ability : ScriptableObject
{
    [SerializeField] private AbilityPlaceLogic _placeLogic;
    [SerializeField] private List<AbilityAction> _abilityAction;

    public void ApplyAction(List<Unit> targets) // применить действие к определенным целям
    {
        foreach (var action in _abilityAction) // перебираем все абилки, которые мы хотим применить к цели
        {
            foreach (var target in targets)  // перебираем весь наш список целей, с которыми пересёкся raycast
            {
                action.Action(target); // применяем действие заклинания к цели
            }
        }
    }

    public List<Unit> SelectTargets(Vector2 screenPoint) // выбираем цели, к кому мы будем применять заклинание (screenPoint - координаты, куда кликнул игрок)
    {
        return _placeLogic.TryGetTargets(screenPoint); // возвращает цель, к которой мы применим заклинание
    }
}
