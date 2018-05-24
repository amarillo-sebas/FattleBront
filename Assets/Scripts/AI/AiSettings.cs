﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;

public class AiSettings : MonoBehaviour {
	public BehaviorTree behaviorTree;
	public SoldierStats statsInfo;

	public Shared_LayerMask targetLayers;

	void Start () {
		behaviorTree.SetVariableValue("movementSpeed", statsInfo.movementSpeed);
		behaviorTree.SetVariableValue("rotationSpeed", statsInfo.rotationSpeed);
		behaviorTree.SetVariableValue("angularSpeed", statsInfo.rotationSpeed * 100f);
		behaviorTree.SetVariableValue("minWanderDistance", statsInfo.minWanderDistance);
		behaviorTree.SetVariableValue("maxWanderDistance", statsInfo.maxWanderDistance);
		behaviorTree.SetVariableValue("minWanderPause", statsInfo.minWanderPause);
		behaviorTree.SetVariableValue("maxWanderPause", statsInfo.maxWanderPause);
		behaviorTree.SetVariableValue("wanderRate", statsInfo.wanderRate);
		behaviorTree.SetVariableValue("targetLayers", targetLayers);
		behaviorTree.SetVariableValue("targetTooCloseReactionTime", statsInfo.targetTooCloseReactionTime);
	}
	
	public bool GetTarget (out Transform t) {
		SharedGameObject sgo = behaviorTree.GetVariable("target") as SharedGameObject;

		if (sgo.Value != null) {
			t = sgo.Value.transform;
			return true;
		} else {
			t = null;
			return false;
		}
	}
}