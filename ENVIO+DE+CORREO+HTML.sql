DECLARE @Encabezado VARCHAR(MAX),
        @Cuerpo NVARCHAR(MAX),
        @Pie VARCHAR(MAX);

--select * from tblproductos

SET @Encabezado
    = '<html><head>' + '<style>'
      + 'td {border: solid black;border-width: 1px;padding-left:5px;padding-right:5px;padding-top:1px;padding-bottom:1px;font: 11px arial} '
      + '</style>' + '<meta charset="UTF-16">' + '</head>' + '<body>' + 'Listado de Productos Generados en HTML '
      + CONVERT(VARCHAR(50), GETDATE(), 106) + ' <br> <table cellpadding=0 cellspacing=0 border=0>'
      + '<tr> <td bgcolor=#E6E6FA><b>Id</b></td>' + '<td bgcolor=#E6E6FA><b>Producto </b></td>'
      + '<td bgcolor=#E6E6FA><b>Descripcion </b></td>' + '<td bgcolor=#E6E6FA><b>Marca </b></td>'
     
	  + '<td bgcolor=#E6E6FA><b>Stock </b></td></tr>' ;


SET @Cuerpo =
(
    SELECT p.Id AS TD,p.Producto AS TD,p.Descripcion AS TD,p.Marca AS td,p.Stock AS TD FROM dbo.Productos AS p
				  FOR XML RAW('tr'),ELEMENTS
);

--PRINT @Cuerpo

SET @Pie = '</table></body></html>';

SELECT @Cuerpo = @Encabezado + ISNULL(@Cuerpo, '') + @Pie;

--

EXEC msdb.dbo.sp_send_dbmail @profile_name = 'PerfilDBA',
                             @recipients = 'kevinjuliangaitano@gmail.com',
                             @subject = 'Listado de Productos en HTML',
                             @body = @Cuerpo,
                             @body_format = 'HTML';

