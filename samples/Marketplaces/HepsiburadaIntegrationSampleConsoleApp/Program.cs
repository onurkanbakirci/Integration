var hepsiburadaProductIntegration = new HepsiburadaProductIntegration(
        username: "username",
        password: "password",
        isInProduction: false);

//Get All Categories
var categories = await hepsiburadaProductIntegration.GetCategoriesAsync();

//Get Category Attributes
var categoryAttributes = await hepsiburadaProductIntegration.GetCategoryAttributesAsync(categoryId: 80844002);

// Get Category Attribute Values
var categoryAttributeValues = await hepsiburadaProductIntegration.GetCategoryAttributeValuesAsync(categoryId: 80844002, attributeId: "gram");

