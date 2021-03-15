USE [CustomerData]
GO

/****** Object:  StoredProcedure [dbo].[UpdateCustFirstName]    Script Date: 3/14/2021 10:12:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateCustFirstName]
@ID int,
@NewFirstName nvarchar(50)

AS
BEGIN
	update Customers set 
	Firstname = @NewFirstName
	where CustomerID = @ID
END
GO


