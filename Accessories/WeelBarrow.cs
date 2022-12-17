using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using ZooAbyss.Edits;

namespace ZooAbyss.Accessories
{
    public class WeelBarrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("5% increased Flora damage\n"                   
                             + "Increases Flora firing speed by 5%");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 44;
            Item.height = 48;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            // GetDamage returns a reference to the specified damage class' damage StatModifier.
            // Since it doesn't return a value, but a reference to it, you can freely modify it with mathematics operators (+, -, *, /, etc.).
            // StatModifier is a structure that separately holds float additive and multiplicative modifiers, as well as base damage and flat damage.
            // When StatModifier is applied to a value, its additive modifiers are applied before multiplicative ones.
            // Base damage is added directly to the weapon's base damage and is affected by damage bonuses, while flat damage is applied after all other calculations.
            // In this case, we're doing a number of things:
            // - Adding 25% damage, additively. This is the typical "X% damage increase" that accessories use, use this one.
            // - Adding 12% damage, multiplicatively. This effect is almost never useds in Terraria, typically you want to use the additive multiplier above. It is extremely hard to correctly balance the game with multiplicative bonuses.
            // - Adding 4 base damage.
            // - Adding 5 flat damage.
            // Since we're using DamageClass.Generic, these bonuses apply to ALL damage the player deals.
            player.GetDamage (ModContent.GetInstance<Flora>()) += 0.5f; 
            // GetCrit, similarly to GetDamage, returns a reference to the specified damage class' crit chance.
            // In this case, we're adding 10% crit chance, but only for the melee DamageClass (as such, only melee weapons will receive this bonus).
            // NOTE: Once all crit calculations are complete, a weapon or class' total crit chance is typically cast to an int. Plan accordingly.

            // GetAttackSpeed is functionally identical to GetDamage and GetKnockback; it's for attack speed.
            // In this case, we'll make ranged weapons 15% faster to use overall.
            // NOTE: Zero or a negative value as the result of these calculations will throw an exception. Plan accordingly.
            player.GetAttackSpeed(ModContent.GetInstance<Flora>()) += 0.5f;

            // GetArmorPenetration is functionally identical to GetCritChance, but for the armor penetration stat instead.
            // In this case, we'll add 5 armor penetration to magic weapons.
            // NOTE: Once all armor pen calculations are complete, the final armor pen amount is cast to an int. Plan accordingly.

            // GetKnockback is functionally identical to GetDamage, but for the knockback stat instead.
            // In this case, we're adding 100% knockback additively, but only for our custom example DamageClass (as such, only our example class weapons will receive this bonus).
        }
    }
}