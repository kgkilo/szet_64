﻿ALTER PROCEDURE [dbo].[sp_FillObjMegnev2]
	@pObjTip varchar(2),
	@pAKTIV integer = 1,
	@pMEGNEV VARCHAR(50) = NULL,
	@ELSOOSZLOP varchar(1) = NULL
AS
SET NOCOUNT ON
IF @pObjTip = '01'	--Epulet
	ELSE
RETURN 0