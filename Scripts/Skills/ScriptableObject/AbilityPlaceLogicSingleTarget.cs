using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/Place Logic/Single Target")]
public class AbilityPlaceLogicSingleTarget : AbilityPlaceLogic
{
    public override List<Unit> TryGetTargets(Vector2 screenPoint)
    {
        var ray = Camera.main.ScreenPointToRay(new Vector3(screenPoint.x, screenPoint.y, 1)); // кидаем рейкаст туда, куда кликает игрок по камере

        RaycastHit hit; // записываем информацию о том, попали ли мы куда-то
        if (Physics.Raycast(ray, out hit, 15)) // если наш рейкаст в кого-то попал (если использовать Physics2D для рейкаста, можно записать множество целей для попадания луча)
        {
            if (hit.transform.GetComponent<Unit>()) // если мы попали в юнита (если позиция луча пересекается с объектом, содержащим компонент Unit)
            {
                return new List<Unit>() { hit.transform.GetComponent<Unit>() }; // то в этом случае мы хотим вернуть этого юнита (из списка юнитов)
            }    
        }

        return null;
    }
}
