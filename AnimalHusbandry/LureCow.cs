﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>
    [RequiresSkill(typeof(AnimalHusbandrySkill), 1)] 
    public partial class LureCowRecipe :
        RecipeFamily
    {
        public LureCowRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Lure Cow",
                    Localizer.DoStr("LureCow"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(HerbivoreLureItem), 5, typeof(AnimalHusbandrySkill), typeof(AnimalHusbandryLavishResourcesTalent)),     
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<CowItem>(1)
    
                    })
            };
            this.ExperienceOnCraft = 7;  
            this.LaborInCalories = CreateLaborInCaloriesValue(120, typeof(AnimalHusbandrySkill)); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(LureCowRecipe), 20, typeof(AnimalHusbandrySkill), typeof(AnimalHusbandryFocusedSpeedTalent), typeof(AnimalHusbandryParallelSpeedTalent));     
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Lure Cow"), typeof(LureCowRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(AnimalFeederObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
