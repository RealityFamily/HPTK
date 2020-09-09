﻿using HPTK.Controllers.Interaction;
using HPTK.Helpers;
using HPTK.Models.Avatar;
using HPTK.Settings;
using HPTK.Views.Handlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HPTK.Controllers.Avatar
{
    public class AvatarController : HPTKElement
    {
        public AvatarModel model;

        private void Start()
        {
            core.model.avatars.Add(model);
        }

        private void Update()
        {
            if (model.followsCamera && core.model.trackedCamera)
            {
                model.headSight.position = core.model.trackedCamera.position;
                model.headSight.rotation = core.model.trackedCamera.rotation;
            }
        }
    }
}
 