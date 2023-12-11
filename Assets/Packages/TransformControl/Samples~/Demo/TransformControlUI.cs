using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace mattatz.TransformControl.Demo {

	public class TransformControlUI : MonoBehaviour {

		[SerializeField] TransformController controller;

        void Update() {
            controller.Control();
        }

		public void OnModeChanged(int index) {
			switch(index) {
			case 0:
				controller.mode = TransformController.TransformMode.Translate;
				break;
			case 1:
				controller.mode = TransformController.TransformMode.Rotate;
				break;
			case 2:
				controller.mode = TransformController.TransformMode.Scale;
				break;
			}
		}

		public void OnCoordinateChanged(int index) {
			switch(index) {
			case 0:
				controller.global = false;
				break;
			case 1:
				controller.global = true;
				break;
			}
		}

	}

}
