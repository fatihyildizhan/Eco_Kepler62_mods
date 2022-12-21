// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree

{ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Eco.Gameplay.Blocks;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Economy;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Property;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Gameplay.Systems;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Gameplay.Systems.Tooltip;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Core.Items;
using Eco.World;
using Eco.World.Blocks;
using Eco.Gameplay.Pipes;

    [RequiresSkill(typeof(PaperMillingSkill), 6)]
    public class PropertyClaimRecipe : RecipeFamily
    {
        public PropertyClaimRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Land Claim Paper",
                    Localizer.DoStr("Land Claim Paper"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(PaperItem), 30, typeof(PaperMillingSkill), typeof(PaperMillingLavishResourcesTalent)),  
					new IngredientElement(typeof(GoldBarItem), 2, typeof(PaperMillingSkill), typeof(PaperMillingLavishResourcesTalent)),
					new IngredientElement(typeof(InkItem), 5, typeof(PaperMillingSkill), typeof(PaperMillingLavishResourcesTalent)),
					new IngredientElement(typeof(QuillPenItem), 1, true),
					new IngredientElement(typeof(WaxSealItem), 1, true),
                    },
                    new CraftingElement [] { new CraftingElement<PropertyClaimItem>() }
                    )
            };

            this.ExperienceOnCraft = 0;
            this.LaborInCalories = CreateLaborInCaloriesValue(100);
            this.CraftMinutes = CreateCraftTimeValue(typeof(PropertyClaimRecipe), 30, typeof(PaperMillingSkill), typeof(PaperMillingFocusedSpeedTalent), typeof(PaperMillingParallelSpeedTalent)); 
            this.Initialize(Localizer.DoStr("Land Claim Paper"), typeof(PropertyClaimRecipe));

            CraftingComponent.AddRecipe(typeof(CapitolObject), this);
        }
    }
}
