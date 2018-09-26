using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Launch projectile
/// </summary>
public class SpawnScript : MonoBehaviour
{
  //--------------------------------
  // 1 - Designer variables
  //--------------------------------

  /// <summary>
  /// Projectile prefab for shooting
  /// </summary>
  public Transform Unit;
  public Transform BoxUnit;
  private PlayerScript playerStats;
  private UnitScript UnitStats;
  private Vector3 aim;
  private const float aimspeed = 10;

  public bool player1;

  /// <summary>
  /// Cooldown in seconds between two shots
  /// </summary>
  public float shootingRate = 0.25f;
  private float boxShootingRate = 3f;
  private float shootCooldown;

  void Start() {
    shootCooldown = 0f;
    aim = transform.position;
  }

  void Update() {
    if (shootCooldown > 0) {
      shootCooldown -= Time.deltaTime;
    }

    if (CanAttack) {
      //Player 1 presses 'S' to shoot normal units
      if (Input.GetKeyDown(KeyCode.S) && player1) {
        spawnUnit();

      //Player 2 presses 'K' to shoot normal units
      } else if (Input.GetKeyDown(KeyCode.K) && !player1) {
        spawnUnit();
      }
      //PLayer 1 presses 'W' to shoot Box units
      else if (Input.GetKeyDown(KeyCode.W) && player1) {
        spawnBoxUnit();
      }
      else if (Input.GetKeyDown(KeyCode.I) && !player1) {
        spawnBoxUnit();
      }

      


    }
    if (Input.GetKey(KeyCode.A) && player1) {
      aimUp();
    } else if (Input.GetKey(KeyCode.D) && player1) {
      aimDown();

      //Note PLayer2 is weird because the aim wsa rotated, so aimUp is going down lol
    } else if (Input.GetKey(KeyCode.J) && !player1) {
      aimDown();
    } else if (Input.GetKey(KeyCode.L) && !player1) {
      aimUp();
    }

  }

  //--------------------------------
  // 2 - Cooldown
  //--------------------------------

  /// Is the weapon ready to create a new projectile?
  /// </summary>
  public bool CanAttack
  {
    get
    {
      playerStats = gameObject.GetComponent<PlayerScript>();
      UnitStats = Unit.gameObject.GetComponent<UnitScript>();

      return shootCooldown <= 0f && UnitStats.cost <= playerStats.cash;
    }
  }

  void aimUp() {
    Vector3 movement = new Vector3(0, aimspeed, 0) * Time.deltaTime;
    aim += movement;
  }

  void aimDown() {
    Vector3 movement = new Vector3(0, -aimspeed, 0) * Time.deltaTime;
    aim += movement;
  }

  void spawnUnit() {
      shootCooldown = shootingRate;

      var createdUnit = Instantiate(Unit) as Transform;
      Vector3 displace;
      if (player1) {
        displace = new Vector3(1, 0, 0);
      } else {
        displace = new Vector3(-1,0,0);
      }

      createdUnit.position = aim + displace;
      playerStats = gameObject.GetComponent<PlayerScript>();
      UnitStats = createdUnit.gameObject.GetComponent<UnitScript>();
      playerStats.cash -= UnitStats.cost;
      SoundEffectsHelper.Instance.MakePlayerShotSound();

  }

  void spawnBoxUnit() {
    shootCooldown = boxShootingRate;


      var createdUnit = Instantiate(BoxUnit) as Transform;
      Vector3 displace;
      if (player1) {
        displace = new Vector3(1, 0, 0);
      } else {
        displace = new Vector3(-1,0,0);
      }

      createdUnit.position = aim + displace;
      playerStats = gameObject.GetComponent<PlayerScript>();
      UnitStats = createdUnit.gameObject.GetComponent<UnitScript>();
      playerStats.cash -= UnitStats.cost;
      SoundEffectsHelper.Instance.MakePlayerShotSound();
  }
}
