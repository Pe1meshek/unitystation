﻿using PlayGroup;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InputControl {
    public class DoorTrigger: InputTrigger {

        private DoorController doorController;

        void Start() {
            doorController = GetComponent<DoorController>();
        }

        public override void Interact() {
            if(doorController.IsOpened) {
				doorController.CmdTryClose();
            } else {
				doorController.CmdTryOpen();
            }
        }
    }
}
