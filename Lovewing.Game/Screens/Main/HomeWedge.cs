﻿// Copyright (c) 2017 Clara.
// Licensed under the EPL-1.0 License

using Lovewing.Game.Graphics;
using OpenTK.Graphics;
using osu.Framework.Allocation;

namespace Lovewing.Game.Screens.Main
{
    public class HomeWedge : Wedge
    {
        private Color4 wedgeColor;
        private Color4 buttonColor;
        protected override Color4 WedgeColor => wedgeColor;
        protected override Color4 ButtonColor => buttonColor;
        protected override FontAwesome ButtonIcon => FontAwesome.fa_home;

        [BackgroundDependencyLoader]
        private void load(LovewingColors colors)
        {
            wedgeColor = colors.Magenta;
            buttonColor = colors.LightMagenta;
        }
    }
}
