SELECT Products.name as 'Продукт', Categories.name as 'Категория'
	FROM Products LEFT JOIN (ProductToCategories LEFT JOIN Categories ON ProductToCategories.category_id = Categories.id) on product_id = Products.id
	ORDER BY Products.id asc, Categories.id asc