﻿using UnityEngine;
using System.Collections;

public class Hunter : Ship {
	public Hunter(){
		}

	// Use this for initialization
	void Start(){
	

	}
	public override void init(){
		_TYPE = Enum_ShipType.Hunter;
		_pv = ConstantesManager.HUNTER_PV;
		_degatShot= ConstantesManager.HUNTER_SHOOT_DMG;
		_degatKamikaze = ConstantesManager.HUNTER_KAMIKAZE_DMG;
		_score=ConstantesManager.HUNTER_SCORE;
		_normalSpeed=ConstantesManager.HUNTER_NORME_SPEED;
		_timeBetweenAttack = ConstantesManager.HUNTER_TIME_BETWEEN_ATTACK;
		_variationTimeBetweenAttackPercent = ConstantesManager.VARIATION_TIME_BETWEEN_ATTACK_PERCENT;
		_bulletSpeed=ConstantesManager.BULLET_TURRET_SPEED;
		
		_percentFragByStandard = ConstantesManager.HUNTER_FRAG_STANDARD_PERCENT;
		_percentFragByDisa = ConstantesManager.HUNTER_FRAG_DISINTEGRATOR_PERCENT;
		_percentFragByEMP = ConstantesManager.HUNTER_FRAG_EMP_PERCENT;
		_shootCooldown=Random.Range(0,2);
		_city=GameObject.FindGameObjectWithTag("City");


		}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (this.gameObject.name + " Update");
	}
}
