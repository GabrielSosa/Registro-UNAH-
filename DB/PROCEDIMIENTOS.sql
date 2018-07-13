USE [UNAH IA.MDF]
GO
-- ===========================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		GABRIEL
-- Create date: 25.03.2916
-- Description:	ESTE PROCEDIMIENTO HACE LA FUNCION DEL PROGRAMA 
-- =============================================
CREATE PROCEDURE ESTADISTICO_POR_PESO
	-- Add the parameters for the stored procedure here
	@CODIGO_CLASE INTEGER, 
	@PESO INTEGER,
	@RANGO INTEGER,
	@UNIVERSO INTEGER OUTPUT,
	@CANTIDAD_APROBADOS INTEGER OUTPUT,
	@CANTIDAD_REPROBADOS INTEGER OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

/* ==================================================================   
-- Procedimientos para ver los aprobados  
  ==================================================================
*/
 
  SELECT @UNIVERSO = COUNT(*)
		FROM (
		select Z.ID_ESTUDIANTES, Z.FECHA, SUM(Z.PESO) as PESO from 
		( 
			SELECT A.ID_ESTUDIANTES, A.FECHA, SUM(UV) AS PESO FROM 

				TBL_CALIFICACIONES A 
				INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B 
				ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS 
				INNER JOIN TBL_CLASES C 
				ON B.ID_CLASE = C.ID_CLASE 

			WHERE FECHA IN
				(SELECT A.FECHA FROM TBL_CALIFICACIONES A 
					INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B 
					ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS 
						WHERE B.ID_CLASE = @CODIGO_CLASE) AND B.ID_CLASE < > @CODIGO_CLASE AND ID_ESTUDIANTES 
						IN(SELECT ID_ESTUDIANTES FROM TBL_CALIFICACIONES A 
							INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B 
							ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS 
							WHERE B.ID_CLASE = @CODIGO_CLASE)

			GROUP BY ID_ESTUDIANTES, FECHA, B.ID_CLASE 

		)Z where  Z.PESO BETWEEN @PESO-@RANGO AND @PESO+@RANGO --'5 (+- Rango(2))'
		GROUP BY Z.ID_ESTUDIANTES, Z.FECHA ) TABLA_UNIVERSO 


/*============================================================================== 
                         CANTIDAD DE APROBADOS 
==============================================================================*/

SELECT @CANTIDAD_APROBADOS = COUNT(*)
		FROM(select Z.ID_ESTUDIANTES, Z.FECHA, SUM(Z.PESO) as PESO, Z.OBSERVACION from 
		( 
			SELECT A.ID_ESTUDIANTES, A.OBSERVACION, A.FECHA, SUM(UV) AS PESO FROM 

				TBL_CALIFICACIONES A 
				INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B 
				ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS 
				INNER JOIN TBL_CLASES C 
				ON B.ID_CLASE = C.ID_CLASE 

			WHERE FECHA IN
				(SELECT A.FECHA FROM TBL_CALIFICACIONES A 
					INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B 
					ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS 
						WHERE B.ID_CLASE = @CODIGO_CLASE) AND B.ID_CLASE < > @CODIGO_CLASE AND ID_ESTUDIANTES 
						IN(SELECT ID_ESTUDIANTES FROM TBL_CALIFICACIONES A 
							INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B 
							ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS 
							WHERE B.ID_CLASE = @CODIGO_CLASE)

			GROUP BY ID_ESTUDIANTES, FECHA, B.ID_CLASE, A.OBSERVACION 

		)Z where  Z.PESO BETWEEN @PESO-@RANGO AND @PESO+@RANGO --'5 (+- Rango(2))'
		GROUP BY Z.ID_ESTUDIANTES, Z.FECHA, Z.OBSERVACION) TABLA
		WHERE OBSERVACION = 'APR' 

SET @CANTIDAD_REPROBADOS = @UNIVERSO - @CANTIDAD_APROBADOS

RETURN

END
GO
