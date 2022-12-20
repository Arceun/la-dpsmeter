/*
 * This file has been Auto Generated, Please do not edit.
 * If you need changes, follow the instructions written in the readme.md
 *
 * Generated by Herysia.
 */

using System;
using System.Collections.Generic;
using LostArkLogger.Types;

namespace LostArkLogger
{
    public class PKTPartyStatusEffectAddNotify
    {
        public PKTPartyStatusEffectAddNotify(BitReader reader)
        {
            PlayerIdOnRefresh = reader.ReadUInt64();
            Unk1 = reader.ReadByte();
            statusEffectDatas = new StatusEffectDatas(reader);
            Unk3 = reader.ReadInt64();
            CharacterId = reader.ReadUInt64();
        }

        public ulong PlayerIdOnRefresh { get; }
        public byte Unk1 { get; }
        public StatusEffectDatas statusEffectDatas { get; } = new StatusEffectDatas();
        public long Unk3 { get; }
        public ulong CharacterId { get; }
    }
}