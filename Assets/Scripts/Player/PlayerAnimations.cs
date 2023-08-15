using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] List<Animator> playerAnimators;

    public void SetFloatForAllAnimators(string id, float value)
    {
        for (int i = 0; i < playerAnimators.Count; i++)
        {
            playerAnimators[i].SetFloat(id, value);
        }
    }
}
