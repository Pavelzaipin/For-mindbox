SELECT p1.Name, c1.Name FROM Product p1
LEFT JOIN Category c1 ON p1.Category = c1.Id
