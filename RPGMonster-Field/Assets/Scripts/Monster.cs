using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float speed = 3.5f;

    [Range(0, 500)]
    public int attack = 100;

    [Range(0, 5000)]
    public int blood = 350;

    [Header("追蹤範圍"), Range(0, 50)]
    public int traceRange = 30;

    [Header("追蹤位移")]
    public Vector3 traceMoving;

    [Header("掉落道具")]
    public GameObject dropItem;

    [Range(0, 1)]
    public int dropPercent;

    [Header("掉落道具音效")]
    public AudioClip itemSound;

    public AudioClip hurtSound;

    public AudioClip attackSound;

    private AudioSource sound;

    private Rigidbody2D rig;

    private Animator ani;
}
