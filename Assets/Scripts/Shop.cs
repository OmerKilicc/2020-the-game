using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprint syringeTurret;
    public TurretBlueprint sanitizerTurret;
    BuildManager buildManager;

    void Start() 
    {
        buildManager = BuildManager.instance;
    }
    public void SyringeTurretSelect()
    {
        Debug.Log("Injector");
        buildManager.SelectTurretToBuild(syringeTurret);
    }

    public void AnotherTurretSelect ()
    {
        Debug.Log("Sanitizer");
        buildManager.SelectTurretToBuild(sanitizerTurret);
    }
}
