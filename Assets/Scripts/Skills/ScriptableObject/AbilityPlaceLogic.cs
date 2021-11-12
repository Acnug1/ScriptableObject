using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityPlaceLogic : ScriptableObject // логика выбора нашей цели (по точке, цели, диапазону и т.д.)
{
    public abstract List<Unit> TryGetTargets(Vector2 screenPoint); // попытаться получить цели
}
