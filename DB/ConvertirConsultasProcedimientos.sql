--Primer Procedimiento 
/*OBtiene como Parametos el Codigo de La Clase(int) ([dbo].[TBL_CLASES].[ID_CLASE]), Peso(int), Y 
rango(int) que puese Variar el Peso

A) Obtener los estudiantes que llevaron Clase '110' con peso acompañado de '5 (+- Rango(2))' */
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
				WHERE B.ID_CLASE = 110) AND B.ID_CLASE < > 110 AND ID_ESTUDIANTES 
				IN(SELECT ID_ESTUDIANTES FROM TBL_CALIFICACIONES A 
					INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B 
					ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS 
					WHERE B.ID_CLASE = 110)

	GROUP BY ID_ESTUDIANTES, FECHA, B.ID_CLASE 

)Z where  Z.PESO BETWEEN 3 AND 7 --'5 (+- Rango(2))'
GROUP BY Z.ID_ESTUDIANTES, Z.FECHA 

/*B) Del Resultado Anterior Obtener el numero de registro que representa el Universo o Total en este caso 207307
Ahora consultar en la tabla Calificaciones si por cada registro de la tabla anterior 110 esta APR e ir acumulando cada APR
con la siguiente consulta*/
select  A.OBSERVACION from TBL_CALIFICACIONES A where  A.ID_ESTUDIANTES=1118 AND A.FECHA='1937-09-19'AND A.ID_CLASE_PLAN_ESTUDIOS=1
-- Al final el Procedimiento tendra que devolver una tabla de esta manera
select 100 as UNIVERSO, 40 as APR, (100-40) as RPB 






/*--Segundo Procedimiento ESTE PROCEDIMIENTO ESTA EN VEREMOS POR QUE HAY COSAS QUE ESTUDIAR 
--QUE ME PARECIERON EXTRAÑAS

--SELECT COUNT(*) CANTIDAD FROM TBL_CALIFICACIONES A 
--	INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B 
--	ON A.ID_CLASE_PLAN_ESTUDIOS = B.ID_CLASE_PLAN_ESTUDIOS 
--	INNER JOIN TBL_CLASES C 
--	ON B.ID_CLASE = C.ID_CLASE 
--	WHERE A.OBSERVACION = 'APR' AND C.ID_CLASE=110;

--SELECT COUNT(*) CANTIDAD from 
--	TBL_CALIFICACIONES A
--	INNER JOIN TBL_CLASES_PLAN_ESTUDIOS B
--	ON A.ID_CLASE_PLAN_ESTUDIOS=B.ID_CLASE_PLAN_ESTUDIOS
--	INNER JOIN TBL_PLAN_ESTUDIOS C
--	ON B.ID_PLAN_ESTUDIOS=C.ID_PLAN_ESTUDIOS
--	INNER JOIN TBL_CLASES D
--	ON B.ID_CLASE = D.ID_CLASE 

--WHERE OBSERVACION = 'APR' AND C.ID_PLAN_ESTUDIOS=1 AND D.ID_CLASE=110;
--*

--TERCER Procedimiento 
/*En este Procedimiento es lo mismo que en primero solo que hay un filtro que es que las 
calificaciones esten entre un Rango de Fechas BETWEEN 2010 AND 2016
ENTONCES AQUI SON 5 PARAMETRO QUE RECIBE : id_clase, peso, rango peso, fechaInicio, fechaFin 
*/

--CUARTO Procedimiento 
/*En este Procedimiento es lo mismo que en primero solo que hay un filtro que es que los
estudiantes a los cuales pertencen las Calificaciones lleven estudianto X cantidad de años en la
U {Para saber cuales son los años validos de estudio recordar que hay tabla promedio en la cual
se registan los promdios de los estudiantes por periodos y 3 = 1 año de estudian}. OBS para este 
se procedimiento se recomienda hacer un consulta sacando los estudiantes que cumplan con X cantidad
de años estudiando y Luego hacer un INNER JOIN CON la primera tabla del primer procedimiento
ENTONCES AQUI SON 4 PARAMETRO QUE RECIBE : id_clase, peso, rango peso, Cantidad de Años 
*/

--QUINTO Procedimiento 
/*En este Procedimiento es lo mismo que en primero solo que hay un filtro que es que los
estudiantes con cierto indice global igual a X +- una deviacion Y
ENTONCES AQUI SON 4 PARAMETRO QUE RECIBE : id_clase, peso, rango peso, IndiceGlobal, rango Indice
{WHERE INDICE_GLOBAL BETWEEN X-Y AND X+}
*/
