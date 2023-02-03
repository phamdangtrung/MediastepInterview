/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF NOT EXISTS (SELECT 1 FROM dbo.[Student])
BEGIN
    INSERT INTO dbo.[Student](FullName, DateOfBirth)
    VALUES
        ('1', CAST( DATEADD(month, -51, GETDATE()) AS Date )),
        ('2', CAST( DATEADD(month, -15, GETDATE()) AS Date )),
        ('3', CAST( DATEADD(month, -91, GETDATE()) AS Date )),
        ('4', CAST( DATEADD(month, -90, GETDATE()) AS Date )),
        ('5', CAST( DATEADD(month, -90, GETDATE()) AS Date )),
        ('6', CAST( DATEADD(month, -121, GETDATE()) AS Date )),
        ('7', CAST( DATEADD(month, -75, GETDATE()) AS Date )),
        ('8', CAST( DATEADD(month, -74, GETDATE()) AS Date )),
        ('9', CAST( DATEADD(month, -74, GETDATE()) AS Date )),
        ('10', CAST( DATEADD(month, -51, GETDATE()) AS Date )),
        ('11', CAST( DATEADD(month, -53, GETDATE()) AS Date )),
        ('12', CAST( DATEADD(month, -25, GETDATE()) AS Date )),
        ('13', CAST( DATEADD(month, -34, GETDATE()) AS Date )),
        ('14', CAST( DATEADD(month, -12, GETDATE()) AS Date )),
        ('15', CAST( DATEADD(month, -98, GETDATE()) AS Date )),
        ('16', CAST( DATEADD(month, -67, GETDATE()) AS Date )),
        ('17', CAST( DATEADD(month, -66, GETDATE()) AS Date )),
        ('18', CAST( DATEADD(month, -57, GETDATE()) AS Date )),
        ('19', CAST( DATEADD(month, -52, GETDATE()) AS Date )),
        ('20', CAST( DATEADD(month, -99, GETDATE()) AS Date )),
        ('21', CAST( DATEADD(month, -101, GETDATE()) AS Date )),
        ('22', CAST( DATEADD(month, -102, GETDATE()) AS Date )),
        ('23', CAST( DATEADD(month, -98, GETDATE()) AS Date )),
        ('24', CAST( DATEADD(month, -78, GETDATE()) AS Date )),
        ('25', CAST( DATEADD(month, -77, GETDATE()) AS Date )),
        ('26', CAST( DATEADD(month, -14, GETDATE()) AS Date )),
        ('27', CAST( DATEADD(month, -15, GETDATE()) AS Date )),
        ('28', CAST( DATEADD(month, -24, GETDATE()) AS Date )),
        ('29', CAST( DATEADD(month, -39, GETDATE()) AS Date )),
        ('30', CAST( DATEADD(month, -42, GETDATE()) AS Date ))

END