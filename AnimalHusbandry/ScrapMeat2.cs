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
    [RequiresSkill(typeof(ButcherySkill), 6)] 
    public partial class AdvancedScrapMeatRecipe :
        RecipeFamily
    {
        public AdvancedScrapMeatRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "AdvancedScrapMeat",
                    Localizer.DoStr("Scrap Meat"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(RawMeatItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<ScrapMeatItem>(6),
    
                    })
            };
            this.ExperienceOnCraft = 5;  
            this.LaborInCalories = CreateLaborInCaloriesValue(120, typeof(ButcherySkill)); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(AdvancedScrapMeatRecipe), 1, typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));     
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Scrap Meat"), typeof(AdvancedScrapMeatRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(ElectricButcheryTableObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
