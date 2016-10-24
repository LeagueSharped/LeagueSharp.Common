// <copyright file="DamageMordekaiserQ.cs" company="LeagueSharp">
// Copyright (c) LeagueSharp. All rights reserved.
// </copyright>

namespace LeagueSharp.Common.Spells
{
    using System.ComponentModel.Composition;

    /// <summary>
    ///     Spell Damage, Mordekaiser Q.
    /// </summary>
    [Export(typeof(IDamageSpell))]
    [ExportDamageMetadata("Mordekaiser", SpellSlot.Q)]
    public class DamageMordekaiserQ : DamageSpell
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DamageMordekaiserQ" /> class.
        /// </summary>
        public DamageMordekaiserQ()
        {
            this.Slot = SpellSlot.Q;
            this.DamageType = Common.Damage.DamageType.Magical;
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        protected override double GetDamage(Obj_AI_Base source, Obj_AI_Base target, int level)
        {
            return new double[] { 80, 110, 140, 170, 200 }[level] + (1 * source.FlatPhysicalDamageMod) + (0.4 * source.TotalMagicalDamage);
        }

        #endregion
    }
}