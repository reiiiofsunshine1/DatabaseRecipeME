SELECT * FROM Recipe

select * from Ingredient

select a.ingName from Ingredient a
INNER JOIN RecipexIngredient b ON a.Id = b.IngredientID
WHERE b.RecipeID = 2;

UPDATE Recipe
SET recipeName = 'Rendang'
WHERE Id = 1;


