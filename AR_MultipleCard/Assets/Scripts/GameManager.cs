using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header ("史萊姆")]
   public Transform Slime;
    [Header("蝙蝠")]
   public Transform Bat;
    [Header("虛擬搖桿")]
   public FixedJoystick Joystick;
    [Header("旋轉速度") , Range(0.1f, 20f)]
    public float turn = 1.5f;
    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.3f;
    [Header("史萊姆動畫元件")]
    public Animator aniSlime;
    [Header("蝙蝠動畫元件")]
    public Animator aniBat;

    private void Start()
    {
        print("開始事件");
    }

    private void Update()
    {
        print("更新事件");
        print(Joystick.Vertical);

        Slime.Rotate(0, Joystick.Horizontal * turn, 0);
        Bat.Rotate(0, Joystick.Horizontal * turn, 0);

        Slime.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * size;
        Slime.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(Slime.localScale.x, 5f, 35f);
        Bat.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * size;
        Bat.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(Slime.localScale.x, 5f, 35f);
    }

    public void Attack()
    {
        print("攻擊");
        aniSlime.SetTrigger("攻擊觸發");
        aniBat.SetTrigger("攻擊觸發");
    }

    public void PlayAnimation(string aniName)
    {
        print(aniName);
        aniSlime.SetTrigger(aniName);
        aniBat.SetTrigger(aniName);
    }

}