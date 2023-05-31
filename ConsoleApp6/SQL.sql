SELECT 
    P.Name AS ProductName,
    COALESCE(C.Name, 'No Category') AS CategoryName
FROM 
    Products AS P
LEFT JOIN 
    ProductCategories AS PC ON P.ProductId = PC.ProductId
LEFT JOIN 
    Categories AS C ON PC.CategoryId = C.CategoryId;