﻿



-- ==========================================================================================
-- Entity Name:	ApplicationUserRole_SelectByApplicationID
-- Author:	Mark Hazleton
-- Create date:	9/21/2015 8:43:41 AM
-- Description:	This stored procedure is intended for selecting a rows from ApplicationUserRole table
-- ==========================================================================================
CREATE Procedure [dbo].[ApplicationUserRole_SelectByApplicationUserID]
	@ApplicationUserID int
As
Begin
SELECT        ApplicationUserRole.ApplicationUserRoleID, ApplicationUserRole.ApplicationID, ApplicationUserRole.ApplicationUserID, ApplicationUserRole.RoleID, ApplicationUserRole.ModifiedID, 
                         ApplicationUserRole.ModifiedDT, ApplicationUserRole.IsDemo, ApplicationUserRole.StartUpDate, ApplicationUserRole.IsMonthlyPrice, ApplicationUserRole.Price, ApplicationUserRole.UserInRolled, 
                         ApplicationUserRole.IsUserAdmin, ApplicationUser.AccountNM, ApplicationUser.LastNM, ApplicationUser.FirstNM, ApplicationUser.eMailAddress, Application.ApplicationNM, Application.ApplicationCD, 
                         Application.ApplicationShortNM, Application.ApplicationDS, Application.ApplicationTypeID, ApplicationUser.LastLoginDT, ApplicationUser.LastLoginLocation, ApplicationUser.VerifyCode, 
                         ApplicationUser.EmailVerified, ApplicationUser.UserLogin, ApplicationUser.UserKey, ApplicationUser.CommentDS, Role.RoleNM, Role.RoleCD, Role.RoleDS, Role.ReviewLevel, Role.ReadFL, Role.UpdateFL, 
                         SiteRole.RoleName, ApplicationUser.SupervisorAccountNM, ApplicationUser.DisplayName, ApplicationUser.RoleID AS Expr1
FROM            SiteRole RIGHT OUTER JOIN
                         ApplicationUser ON SiteRole.Id = ApplicationUser.RoleID RIGHT OUTER JOIN
                         ApplicationUserRole LEFT OUTER JOIN
                         Application ON ApplicationUserRole.ApplicationID = Application.ApplicationID ON ApplicationUser.ApplicationUserID = ApplicationUserRole.ApplicationUserID LEFT OUTER JOIN
                         Role ON ApplicationUserRole.RoleID = Role.RoleID
where ApplicationUserRole.ApplicationUserID = @ApplicationUserID
End