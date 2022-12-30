﻿using KittensLibrary;
using Protocol.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protocol.Packets
{
    public class PacketPlayerState
    {
        [Field(0)] public List<Card> Cards;
        [Field(1)] public int OtherPlayerCardsCount;
        [Field(2)] public Card LastResetCard;
        [Field(3)] public State PlayerState;
    }
}