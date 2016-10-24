// <copyright file="DamageLeonaE.cs" company="LeagueSharp">
// Copyright (c) LeagueSharp. All rights reserved.
// </copyright>

namespace LeagueSharp.Common.Spells
{
    using System.ComponentModel.Composition;

    /// <summary>
    ///     Spell Damage, Leona E.
    /// </summary>
    [Export(typeof(IDamageSpell))]
    [ExportDamageMetadata("Leona", SpellSlot.E)]
    public class DamageLeonaE : DamageSpell
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DamageLeonaE" /> class.
        /// </summary>
        public DamageLeonaE()
        {
            this.Slot = SpellSlot.E;
            this.DamageType = Common.Damage.DamageType.Magical;
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        protected override double GetDamage(Obj_AI_Base source, Obj_AI_Base target, int level)
        {
            return new double[] { 60, 100, 140, 180, 220 }[level] + (0.4 * source.TotalMagicalDamage);
        }

        #endregion
    }
}