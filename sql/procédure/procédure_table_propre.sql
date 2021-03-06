-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Maxime,,Hollebecq>
-- Create date: <07/12/18,,>
-- Description:	<Proc�dure permettant d'update la table place en rendant la table � l'�tat propre ,,>
-- =============================================
CREATE PROCEDURE Table_sale @place int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Place
	SET Etat_sale = 0
	WHERE ID_Table = @place
END
GO