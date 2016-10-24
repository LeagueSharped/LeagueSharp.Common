// <copyright file="DamageZedR.cs" company="LeagueSharp">
// Copyright (c) LeagueSharp. All rights reserved.
// </copyright>

namespace LeagueSharp.Common.Spells
{
    using System.ComponentModel.Composition;

    /// <summary>
    ///     Spell Damage, Zed R.
    /// </summary>
    [Export(typeof(IDamageSpell))]
    [ExportDamageMetadata("Zed", SpellSlot.R)]
    public class DamageZedR : DamageSpell
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DamageZedR" /> class.
        /// </summary>
        public DamageZedR()
        {
            this.Slot = SpellSlot.R;
            this.DamageType = Common.Damage.DamageType.Physical;
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        protected override double GetDamage(Obj_AI_Base source, Obj_AI_Base target, int level)
        {
            return 1 * (source.BaseAttackDamage + source.FlatPhysicalDamageMod);
        }

        #endregion
    }
}