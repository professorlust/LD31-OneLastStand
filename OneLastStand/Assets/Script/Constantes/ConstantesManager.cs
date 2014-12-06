﻿using UnityEngine;
using System.Collections;

//Contient toutes les constantes liées au GameDesign
public class ConstantesManager {


	// -------------------------------------------------ENNEMY VAR--------------------------------------------------------
	public static float VARIATION_TIME_BETWEEN_ATTACK_PERCENT = 10 / 100;

	public static int FREQUENCE_POP=1500;
	public static int VARIANCE_FREQUENCE_POP_PERCENT=20/100;
	public static Vector2 POP_POINT_1 = new Vector2(45,5);
	public static Vector2 POP_POINT_2 = new Vector2(5,45);
	public static Vector2 POP_POINT_3 = new Vector2(25,25);

	



	//Hunter Var

	public static int HUNTER_PV = 100;
	public static int HUNTER_SCORE = 100;
	public static int HUNTER_SHOOT_DMG = 10;
	public static int HUNTER_KAMIKAZE_DMG = 100;
	public static float HUNTER_NORME_SPEED = 10;
	public static float HUNTER_TIME_BETWEEN_ATTACK = 2000; // time in ms


	//Frigate Var
	
	public static int FRIGATE_PV = 100;
	public static int FRIGATE_SCORE = 100;
	public static int FRIGATE_SHOOT_DMG = 10;
	public static int FRIGATE_KAMIKAZE_DMG = 100;
	public static float FRIGATE_NORME_SPEED = 10;
	public static float FRIGATE_TIME_BETWEEN_ATTACK = 2000; // time in ms

	//Cruiser Var

	public static int CRUISER_PV = 100;
	public static int CRUISER_SCORE = 100;
	public static int CRUISER_SHOOT_DMG = 10;
	public static int CRUISER_KAMIKAZE_DMG = 100;
	public static float CRUISER_NORME_SPEED = 10;
	public static float CRUISER_TIME_BETWEEN_ATTACK = 2000; // time in ms


	//City var
	public static int CITY_PV = 10000;
}
