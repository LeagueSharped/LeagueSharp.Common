// <copyright file="DamageGragasPassive.cs" company="LeagueSharp">
// Copyright (c) LeagueSharp. All rights reserved.
// </copyright>

namespace LeagueSharp.Common.Passives
{
    using System.ComponentModel.Composition;

    /// <summary>
    ///     Gragas's Damage Passive.
    /// </summary>
    [Export(typeof(IPassiveDamage))]
    [ExportMetadata("ChampionName", "Gragas")]
    public class DamageGragasPassive : IPassiveDamage
    {
        #region Public Methods and Operators

        /// <inheritdoc />
        public double GetDamage(Obj_AI_Hero source, Obj_AI_Base target)
        {
            return source.GetSpellDamage(target, SpellSlot.W);
        }

        /// <inheritdoc />
        public bool IsActive(Obj_AI_Hero source, Obj_AI_Base target)
        {
            return source.HasBuff("gragaswattackbuff");
        }

        #endregion
    }
}