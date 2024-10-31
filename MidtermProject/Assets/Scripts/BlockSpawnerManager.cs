using UnityEngine;

public class BlockSpawnerManager : MonoBehaviour
{
    public GameObject BlockSpawnerCirPink;
    public GameObject BlockSpawnerTriPur;
    public GameObject BlockSpawnerYellow;
    public GameObject BlockSpawnerBlue;
    public GameObject BlockSpawnerTriWhite;

    void Start()
    {
        // 确保所有生成器初始时处于不激活状态
        SetSpawnerActive(BlockSpawnerCirPink, false);
        SetSpawnerActive(BlockSpawnerTriPur, false);
        SetSpawnerActive(BlockSpawnerYellow, false);
        SetSpawnerActive(BlockSpawnerBlue, false);
        SetSpawnerActive(BlockSpawnerTriWhite, false);
    }

    // 控制激活每个生成器的公共方法
    public void ActivateSpawnerCirPink()
    {
        SetSpawnerActive(BlockSpawnerCirPink, true);
    }

    public void ActivateSpawnerTriPur()
    {
        SetSpawnerActive(BlockSpawnerTriPur, true);
    }

    public void ActivateSpawnerYellow()
    {
        SetSpawnerActive(BlockSpawnerYellow, true);
    }

    public void ActivateSpawnerBlue()
    {
        SetSpawnerActive(BlockSpawnerBlue, true);
    }

    public void ActivateSpawnerTriWhite()
    {
        SetSpawnerActive(BlockSpawnerTriWhite, true);
    }

    // 设置生成器激活状态的方法
    private void SetSpawnerActive(GameObject spawner, bool isActive)
    {
        if (spawner != null)
        {
            spawner.SetActive(isActive);
        }
    }
}