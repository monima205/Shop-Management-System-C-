SET IDENTITY_INSERT [dbo].[Products] ON
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [Category], [Price], [Stock], [Quantity]) VALUES (4, N' Mouse', N'Electronics', CAST(25.00 AS Decimal(10, 2)), 12, 100)
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [Category], [Price], [Stock], [Quantity]) VALUES (5, N' Shoes', N'Footwear', CAST(55.00 AS Decimal(10, 2)), 6, 100)
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [Category], [Price], [Stock], [Quantity]) VALUES (6, N' Maker', N'Appliance', CAST(40.00 AS Decimal(10, 2)), 5, 100)
SET IDENTITY_INSERT [dbo].[Products] OFF
