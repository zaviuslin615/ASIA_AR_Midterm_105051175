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

    private void Start()
    {
        print("開始事件執行中");
    }

    private void Update()
    {
        print("更新事件");
        print(Joystick.Vertical);

        Slime.Rotate(0, Joystick.Horizontal * turn, 0);
        Bat.Rotate(0, Joystick.Horizontal * turn, 0);

        Slime.localScale += new Vector3(1, 1, 1) * Joystick.Vertical * size;
    }
}
