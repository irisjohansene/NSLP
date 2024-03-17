using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;
using System.Linq;

namespace NSLPWebApi.Services.MenuToIngredientService
{
    public class MenuToIngredientOrRecipeService : IMenuToIngredientOrRecipeService
    {
        private readonly MenuToIngredientOrRecipeRepository _mtirepo;
        private readonly MenuRepository _menurepo;
        private readonly AppDbContext _db;
        public MenuToIngredientOrRecipeService(MenuToIngredientOrRecipeRepository mtirepo, MenuRepository menurepo, AppDbContext db)
        {
            _db = db;
            _mtirepo = mtirepo;
            _menurepo = menurepo;
        }

        public async Task<List<MenuToIngredientOrRecipe>> GetAllMenuToIngredientOrRecipeAsync()
        {
            var mtis = await _mtirepo.GetAllAsListAsync();
            return mtis;
        }

        public async Task AddMenuToIngredientOrRecipeAsync(IEnumerable<MenuToIngredientOrRecipe> mti)
        {
            foreach (var mi in mti)
            {
                await _mtirepo.AddAsync(mi);
            }

            await _mtirepo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task AddOneMenuToIngredientOrRecipeAsync(MenuToIngredientOrRecipe mti)
        {
            await _mtirepo.AddAsync(mti);
            await _mtirepo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateMenuToIngredientOrRecipeAsync(MenuToIngredientOrRecipe mti)
        {
            _db.MenuToIngredientOrRecipes.Update(mti);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveMenuToIngredientOrRecipeAsync(MenuToIngredientOrRecipe mti)
        {
            _db.MenuToIngredientOrRecipes.Remove(mti);
            await _db.SaveChangesAsync();
        }

        public async Task<List<MenuToIngredientOrRecipe>> GetAllDataByDateAndIdAsync(DateTime dateTime, int menuTypeId)
        {
            // Retrieve menu information based on date and menu type
            var menuInfo = await _db.Menus
                .Where(x => x.MenuDate == dateTime && x.MenuTypeId == menuTypeId)
                .ToListAsync();

            // Extract menu IDs from the retrieved menu information
            var menuIds = menuInfo.Select(x => x.MenuId).ToList();

            // Retrieve menu-to-ingredient or recipe associations for the extracted menu IDs
            var menuToIngredientsOrRecipes = await _db.MenuToIngredientOrRecipes
                .Where(x => menuIds.Contains(x.MenuId))
                .ToListAsync();

            return menuToIngredientsOrRecipes;
        }
    }
}
