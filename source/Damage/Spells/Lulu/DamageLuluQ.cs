// <copyright file="DamageLuluQ.cs" company="LeagueSharp">
// Copyright (c) LeagueSharp. All rights reserved.
// </copyright>

namespace LeagueSharp.Common.Spells
{
    using System.ComponentModel.Composition;

    /// <summary>
    ///     Spell Damage, Lulu Q.
    /// </summary>
    [Export(typeof(IDamageSpell))]
    [ExportDamageMetadata("Lulu", SpellSlot.Q)]
    public class DamageLuluQ : DamageSpell
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DamageLuluQ" /> class.
        /// </summary>
        public DamageLuluQ()
        {
            this.Slot = SpellSlot.Q;
            this.DamageType = Common.Damage.DamageType.Magical;
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        protected override double GetDamage(Obj_AI_Base source, Obj_AI_Base target, int level)
        {
            return new double[] { 80, 125, 170, 215, 260 }[level] + (0.5 * source.TotalMagicalDamage);
        }

        #endregion
    }
}