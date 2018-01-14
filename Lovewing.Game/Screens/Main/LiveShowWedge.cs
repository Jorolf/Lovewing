﻿// Copyright (c) 2017 Clara.
// Licensed under the EPL-1.0 License

using Lovewing.Game.Graphics;
using OpenTK.Graphics;
using osu.Framework.Allocation;

namespace Lovewing.Game.Screens.Main
{
    public class LiveShowWedge : Wedge
    {
        private Color4 wedgeColour;
        private Color4 buttonColour;
        protected override Color4 WedgeColour => wedgeColour;
        protected override Color4 ButtonColour => buttonColour;
        protected override FontAwesome ButtonIcon => FontAwesome.fa_music;
        protected override string ButtonText => @"Live";

        [BackgroundDependencyLoader]
        private void load(LovewingColours colours)
        {
            wedgeColour = colours.DarkBlue;
            buttonColour = colours.Blue;
        }
    }
}
