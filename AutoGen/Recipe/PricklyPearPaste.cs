
namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Controller;

    [Serialized]
    [LocDisplayName("Prickly Pear Paste")]
    [MaxStackSize(250)]
    [Weight(100)]
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    public partial class PricklyPearPasteItem : FoodItem
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A sweet additive."); } }
        public override float Calories => 60;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 3, Fat = 10, Protein = 2, Vitamins = 0 };
        protected override int BaseShelfLife => (int)TimeUtil.HoursToSeconds(72);
    }


    [RequiresSkill(typeof(MixologySkill), 3)]
    [ForceCreateView]
    public partial class PricklyPearPasteRecipe : RecipeFamily
    {
        public PricklyPearPasteRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Prickly Pear Paste",  //noloc
                Localizer.DoStr("Prickly Pear Paste"),
                new List<IngredientElement>
                {
                    new IngredientElement(typeof(PricklyPearFruitItem), 2, typeof(MixologySkill), typeof(MixologyLavishResourcesTalent)),
                },
                new List<CraftingElement>
                {
                    new CraftingElement<PricklyPearPasteItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(80, typeof(MixologySkill));
            this.CraftMinutes = CreateCraftTimeValue(typeof(PricklyPearPasteRecipe), 1, typeof(MixologySkill), typeof(MixologyFocusedSpeedTalent), typeof(MixologyParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Prickly Pear Paste"), typeof(PricklyPearPasteRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(BlenderTableObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}