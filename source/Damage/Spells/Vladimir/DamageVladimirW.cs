// <copyright file="DamageVladimirW.cs" company="LeagueSharp">
// Copyright (c) LeagueSharp. All rights reserved.
// </copyright>

namespace LeagueSharp.Common.Spells
{
    using System.ComponentModel.Composition;

    /// <summary>
    ///     Spell Damage, Vladimir W.
    /// </summary>
    [Export(typeof(IDamageSpell))]
    [ExportDamageMetadata("Vladimir", SpellSlot.W)]
    public class DamageVladimirW : DamageSpell
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DamageVladimirW" /> class.
        /// </summary>
        public DamageVladimirW()
        {
            this.Slot = SpellSlot.W;
            this.DamageType = Common.Damage.DamageType.Magical;
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        protected override double GetDamage(Obj_AI_Base source, Obj_AI_Base target, int level)
        {
            return new double[] { 80, 135, 190, 245, 300 }[level];
        }

        #endregion
    }
}