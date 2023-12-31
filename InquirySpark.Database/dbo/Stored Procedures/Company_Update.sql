﻿

-- ==========================================================================================
-- Entity Name:	Company_Update
-- Create date:	10/9/2015 2:14:07 PM
-- Description:	This stored procedure is intended for updating Company table
-- ==========================================================================================
CREATE Procedure [dbo].[Company_Update]
	@CompanyID int,
	@CompanyNM nvarchar(50),
	@CompanyCD nvarchar(10),
	@CompanyDS nvarchar(255),
	@Title nvarchar(255),
	@Theme nvarchar(10),
	@DefaultTheme nvarchar(10),
	@GalleryFolder nvarchar(50),
	@SiteURL nvarchar(255),
	@Address1 nvarchar(100),
	@Address2 nvarchar(100),
	@City nvarchar(50),
	@State nvarchar(20),
	@Country nvarchar(50),
	@PostalCode nvarchar(20),
	@FaxNumber nvarchar(30),
	@PhoneNumber nvarchar(30),
	@DefaultPaymentTerms nvarchar(255),
	@DefaultInvoiceDescription nvarchar(MAX),
	@ActiveFL bit,
	@Component nvarchar(50),
	@FromEmail nvarchar(50),
	@SMTP nvarchar(50),
	@ModifiedDT datetime,
	@ModifiedID int
As
Begin
	Update Company
	Set
		[CompanyNM] = @CompanyNM,
		[CompanyCD] = @CompanyCD,
		[CompanyDS] = @CompanyDS,
		[Title] = @Title,
		[Theme] = @Theme,
		[DefaultTheme] = @DefaultTheme,
		[GalleryFolder] = @GalleryFolder,
		[SiteURL] = @SiteURL,
		[Address1] = @Address1,
		[Address2] = @Address2,
		[City] = @City,
		[State] = @State,
		[Country] = @Country,
		[PostalCode] = @PostalCode,
		[FaxNumber] = @FaxNumber,
		[PhoneNumber] = @PhoneNumber,
		[DefaultPaymentTerms] = @DefaultPaymentTerms,
		[DefaultInvoiceDescription] = @DefaultInvoiceDescription,
		[ActiveFL] = @ActiveFL,
		[Component] = @Component,
		[FromEmail] = @FromEmail,
		[SMTP] = @SMTP,
		[ModifiedDT] = @ModifiedDT,
		[ModifiedID] = @ModifiedID
	Where		
		[CompanyID] = @CompanyID
	Select 
		[CompanyID],
		[CompanyNM],
		[CompanyCD],
		[CompanyDS],
		[Title],
		[Theme],
		[DefaultTheme],
		[GalleryFolder],
		[SiteURL],
		[Address1],
		[Address2],
		[City],
		[State],
		[Country],
		[PostalCode],
		[FaxNumber],
		[PhoneNumber],
		[DefaultPaymentTerms],
		[DefaultInvoiceDescription],
		[ActiveFL],
		[Component],
		[FromEmail],
		[SMTP],
		[ModifiedDT],
		[ModifiedID]
	From Company
	Where
		[CompanyID] = @CompanyID
End