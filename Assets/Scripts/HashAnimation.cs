using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashAnimation : MonoBehaviour
{
    private int _isMoveRightHash = Animator.StringToHash("isMoveRight");
    private int _isMoveLeftHash = Animator.StringToHash("isMoveLeft");
    public int IsMoveRightHash => _isMoveRightHash;
    public int IsMoveLeftHash => _isMoveLeftHash;
}
