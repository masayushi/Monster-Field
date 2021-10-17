using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("���ʳt��"), Range(0, 10)]
    public float speed = 3.5f;

    [Range(0, 500)]
    public int attack = 100;

    [Range(0, 5000)]
    public int blood = 350;

    [Header("�l�ܽd��"), Range(0, 50)]
    public int traceRange = 30;

    [Header("�l�ܦ첾")]
    public Vector3 traceMoving;

    [Header("�����D��")]
    public GameObject dropItem;

    [Range(0, 1)]
    public int dropPercent;

    [Header("�����D�㭵��")]
    public AudioClip itemSound;

    public AudioClip hurtSound;

    public AudioClip attackSound;

    private AudioSource sound;

    private Rigidbody2D rig;

    private Animator ani;
}
