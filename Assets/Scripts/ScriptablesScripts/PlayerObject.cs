using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerObject", menuName = "Player/PlayerObject", order = 0)]
public class PlayerObject : ScriptableObject
{
    public string id;
    public Sprite portrait;

    [Header("ANIMATIONS ")]
    [Header("Idle: ")]
    public List<Sprite> frontIdle;
    public List<Sprite> backIdle, leftIdle, rightIdle;
    [Header("Walk: ")]
    public List<Sprite> frontWalk;
    public List<Sprite> backWalk, leftWalk, rightWalk;


}
