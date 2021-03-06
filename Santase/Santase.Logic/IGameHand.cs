﻿using Santase.Logic.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Santase.Logic
{
    public interface IGameHand
    {
        void Start();
        PlayerPosition Winner { get; }

        Card FirstPlayerCard { get; }
        Card SecondPlayerCard { get; }
        Announce FirstPlayerAnnounce { get; }
        Announce SecondPlayerAnnounce { get; }

        PlayerPosition GameClosedBy { get; }
    }
}
