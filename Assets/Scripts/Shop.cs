using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLauncher;
	public TurretBlueprint laserBeamer;
	public TurretBlueprint freezeTurret;

	public Outline[] turretOutlines;

	BuildManager buildManager;

	void Start ()
	{
		buildManager = BuildManager.instance;
	}

	public void SelectStandardTurret ()
	{
		Debug.Log("Standard Turret Selected");
		buildManager.SelectTurretToBuild(standardTurret);
		turretOutlines[0].enabled = true;
		turretOutlines[1].enabled = false;
		turretOutlines[2].enabled = false;
		turretOutlines[3].enabled = false;
	}

	public void SelectMissileLauncher()
	{
		Debug.Log("Missile Launcher Selected");
		buildManager.SelectTurretToBuild(missileLauncher);
		turretOutlines[1].enabled = true;
		turretOutlines[0].enabled = false;
		turretOutlines[2].enabled = false;
		turretOutlines[3].enabled = false;
	}

	public void SelectLaserBeamer()
	{
		Debug.Log("Laser Beamer Selected");
		buildManager.SelectTurretToBuild(laserBeamer);
		turretOutlines[2].enabled = true;
		turretOutlines[0].enabled = false;
		turretOutlines[1].enabled = false;
		turretOutlines[3].enabled = false;
	}
	public void SelectFreezeTurret()
	{
		Debug.Log("Freeze Turret Selected");
		buildManager.SelectTurretToBuild(freezeTurret);
		turretOutlines[3].enabled = true;
		turretOutlines[0].enabled = false;
		turretOutlines[1].enabled = false;
		turretOutlines[2].enabled = false;
	}

}
